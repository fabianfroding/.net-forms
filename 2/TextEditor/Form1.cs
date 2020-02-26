using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class MainForm : Form
    {

        // modified sätts till true när text ändras och till false när en fil inte har
        // några ändringar.
        private bool modified;
        
        public MainForm()
        {
            InitializeComponent();
            this.Text = "New File";
            modified = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileBeforeClosing() == "yes")
            {
                // Om användaren valt att spara en modifierad* fil innan en ny skapas
                // så rensar vi textrutan och sätter titeln till new file.
                clearText();
                this.Text = "New File";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Om användaren väljer något annat än "cancel" hoppar vi helt över
            // att öppna dialogen för att öppna existerande fil.
            string option = saveFileBeforeClosing();
            if (option != "cancel" || option == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (.txt)|*.txt";
                ofd.Title = "Open File";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    this.Text = Path.GetFileName(ofd.FileName);
                    modified = false;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileBeforeClosing();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (.txt)|*.txt";
            sfd.Title = "Save File";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
                this.Text = Path.GetFileName(sfd.FileName);
                modified = false;
            }
            
        }

        // Denna funktion anropas när användaren försöker öppna, stänga eller
        // skapa en ny fil och frågar om potentiella ändringar önskas sparas.
        // Detta sker endast om den nuvarande filen är ändrad*.
        // Återger true om användaren svarar Ja, och false om användaren svarar
        // Nej eller Cancel.
        private string saveFileBeforeClosing()
        {
            if (modified)
            {
                DialogResult dR = MessageBox.Show("Save your changes to current file?", "Save changes?", MessageBoxButtons.YesNoCancel);
                if (dR == DialogResult.Yes)
                {
                    saveToolStripMenuItem.PerformClick();
                    return "yes";
                }
                else if (dR == DialogResult.No)
                {
                    // Om användaren valt att skapa ny eller stänga en fil så sätter vi
                    // titeln till "New File".
                    // Om användaren valt att öppna en existerande fil så gör det inget
                    // att titeln sätts till "New File" eftersom den kommer överskridas
                    // av den nya filmens namn i funktionen som anropat denna funktion.
                    this.Text = "New File";
                    clearText();
                    return "no";
                }
                else
                {
                    return "cancel";
                }
            }
            else
            {
                this.Text = "New File";
                clearText();
                return null;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.PerformClick();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!modified)
            {
                this.Text = this.Text + "*";
                modified = true;
            }
            updateStatsRTB();
        }

        private void updateStatsRTB()
        {
            StatsRTB.Text = $"Bokstäver {countLetters(true)}" +
                $"\nBokstäver (utan mellanslag): {countLetters(false)}";
        }

        private int countLetters(bool includeSpaces)
        {
            int count = 0;
            if (includeSpaces)
            {
                count = richTextBox1.Text.Length;
            }
            else
            {
                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if (richTextBox1.Text[i] != ' ')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        

        private void clearText()
        {
            // I vissa fall vill vi rensa texten, t.ex. när vi stänger eller skapar
            // ny fil. För att förhindra att texten tolkas som att den ändras så 
            // sätter vi modified temporärt till true.
            modified = true;
            richTextBox1.Clear();
            modified = false;
        }
    }
}
