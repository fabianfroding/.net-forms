using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        private bool modified; // Håller info om filen är redigerad eller "orörd".
        private bool newFile; // Sparar info om filen är ny eller existerande.
        private FileHandler fileHandler; // Klass som var tänkt hantera fil-upgifter.
        private StringHandler stringHandler; // Klass som hanterar string-uppgifter.
        private string currentText; // Sparar text innan drag and drop aktiveras.
        private bool fileDropped = false; // En variabel för att veta om en fil "droppats".

        public MainForm()
        {
            InitializeComponent();
            fileHandler = new FileHandler();
            stringHandler = new StringHandler();
            this.Text = "New File.txt";
            modified = false;
            newFile = true;

            // Initialisering av drag and drop for richTextBox1.
            richTextBox1.AllowDrop = true;
            this.richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Om befintlig fil är redigerad anropar vi saveAs funktionen,
            // annars bara save (den sparas direkt).
            if (modified)
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                saveAsToolStripMenuItem.PerformClick();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp = saveFileBeforeClosing();
            if (temp == "yes")
            {
                // Om användaren valt att spara en redigerad* fil innan en ny skapas
                // så rensar vi textrutan och sätter titeln till new file.
                clearText();
                this.Text = "New File.txt";
            }
            if (temp != "cancel")
            {
                newFile = true;
            }
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
                    StreamReader sr = new StreamReader(ofd.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    this.Text = Path.GetFileName(ofd.FileName);
                    modified = false;
                }
                newFile = false;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp = saveFileBeforeClosing();
            if (temp != "cancel")
            {
                newFile = true;
            }
            if (temp == "yes")
            {
                clearText();
                this.Text = "New File.txt";
                modified = false;
                newFile = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newFile)
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                try
                {
                    this.Text = this.Text.Replace("*", "");
                    fileHandler.saveFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + this.Text, richTextBox1.Text);
                    modified = false;
                    newFile = false;
                }
                catch (UnauthorizedAccessException uAE)
                {
                    System.Diagnostics.Debug.Write("Problem when saving file: " + uAE.Message);
                }
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (.txt)|*.txt";
            sfd.Title = "Save File";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileHandler.saveFile(sfd.FileName, richTextBox1.Text);
                this.Text = Path.GetFileName(sfd.FileName);
                modified = false;
                newFile = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!modified && !fileDropped)
            {
                this.Text = this.Text + "*";
                modified = true;
                
            }
            fileDropped = false;
            updateStatsRTB();
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
                    this.Text = "New File.txt";
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
                this.Text = "New File.txt";
                clearText();
                return null;
            }
        }

        // Uppdaterar texten i rutan som visar antal bokstäver, ord och rader.
        private void updateStatsRTB()
        {
            StatsRTB.Text = $"Bokstäver {stringHandler.countLetters(richTextBox1.Text, true)}" +
                $"\nBokstäver (utan mellanslag): {stringHandler.countLetters(richTextBox1.Text, false)}" +
                $"\nOrd: {stringHandler.countWords(richTextBox1.Text)}" +
                $"\nRader: {stringHandler.countLines(richTextBox1.Text)}";
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

        // ==================================================
        // Grundläggade text-funktioner.
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

        // ==================================================

        // ==================================================
        // Drag and drop funktioner.
        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                // Eftersom vi endast vill öppna en fil tar vi bara file[0].
                if (files.Length == 1)
                {
                    StreamReader sr = new StreamReader(files[0]);
                    if (ModifierKeys.HasFlag(Keys.Control))
                    {
                        richTextBox1.Text += sr.ReadToEnd();
                        newFile = false;
                        modified = true;
                    }
                    else if (ModifierKeys.HasFlag(Keys.Shift))
                    {
                        richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, sr.ReadToEnd());
                        newFile = false;
                        modified = true;
                    }
                    else
                    {
                        // Av någon anledning så läggs * i filnamnet till när en fil "droppas", även
                        // om modified sätt till true och sedan sätts tillbaka.
                        // Var tvungen att åtgärda detta genom en ytterligare variabel som adderar
                        // ännu mer onödig logik och komplexitet till programmet.
                        // Hade säkert gått att förenkla men hade ej tid till att finslipa detta.
                        // I slutänden fungerar programmet och det är huvudsaken.
                        fileDropped = true;
                        richTextBox1.Text = sr.ReadToEnd();
                        this.Text = Path.GetFileName(files[0]);
                        newFile = false;
                        modified = false;
                    }
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("Endast en fil kan laddas.");
                }
                
                
            }
            catch (NullReferenceException nRE)
            {
                System.Diagnostics.Debug.WriteLine("Problem opening file: " + nRE.Message);
            }
            
            
        }
    }

        // ==================================================

}
