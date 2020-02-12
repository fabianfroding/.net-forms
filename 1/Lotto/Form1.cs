using System;
using System.Windows.Forms;

/* Tolkning av uppgiften:
 * Användaren matar in 7 unika nummer i "Lottorad"-rutorna.
 * Användaren definierar antalet dragningar.
 * För varje dragning genereras 7 slumpmässiga nummer
 * (som enligt ert svar på Canvas inte behövde vara unika) mellan (och inklusive) 1-35.
 * För varje dragning jämförs användarens inmatade nummer med de genererade slumptalen.
 * Om 5 nummer stämmer överens, ökas antalet 5 rätt.
 * Om 6 nummer stämmer överens, ökas antalet 6 rätt.
 * Om 7 (alla) nummer stämmer överens, ökas antalet 7 rätt.
 */

namespace Lotto
{
    public partial class MainForm : Form
    {
        private TextBox[] LottoRad; // Förvaring av LottoRad text-värden i en array.
        private readonly int MIN_VALUE = 1;
        private readonly int MAX_VALUE = 35;
        
        public MainForm()
        {
            InitializeComponent();
            InitializeLottoRader();
        }

        private void InitializeLottoRader()
        {
            // Initialisering av LottoRad-array.
            // Loop hade självklart fungerat här men vet ej hur man hittar TextBoxes på det sättet.
            LottoRad = new TextBox[7];
            LottoRad[0] = Rad01;
            LottoRad[1] = Rad02;
            LottoRad[2] = Rad03;
            LottoRad[3] = Rad04;
            LottoRad[4] = Rad05;
            LottoRad[5] = Rad06;
            LottoRad[6] = Rad07;
        }

        // Återger true om någon av Rad-rutorna har dubletter.
        private bool ContainsDuplicates()
        {
            // Loop genom de 7 inmatade Lottoraderna.
            for (int i = 0; i < LottoRad.Length - 1; i++)
            {
                // För varje lottorad-ruta, jämförs den med resterande rutor för att hitta dubletter.
                for (int j = i + 1; j < LottoRad.Length; j++)
                {
                    if (!string.IsNullOrEmpty(LottoRad[i].Text) && !string.IsNullOrEmpty(LottoRad[j].Text))
                    {
                        // Eftersom metoden AdjustRowInputs inte accepterar
                        // icke-numeriska värden behöver vi inte försöka
                        // fånga denna del i en try-catch.
                        int temp1 = int.Parse(LottoRad[i].Text);
                        int temp2 = int.Parse(LottoRad[j].Text);
                        if (temp1 == temp2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // Återgår true om någon input är tom.
        // Loopar igenom lottorad-rutorna för att säkerställa att ingen ruta är tom.
        private bool IsAnyInputEmpty()
        {
            for (int i = 0; i < LottoRad.Length; i++)
            {
                if (string.IsNullOrEmpty(LottoRad[i].Text))
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(AntalDrag.Text))
            {
                return true;
            }
            return false;
        }

        // Denna metod justerar felaktig inmatning.
        // Om inmatat värde inte är numeriskt så rensas rutan.
        // Detta för att förhindra inmating av invalida symboler.
        private void AdjustInput()
        {
            int temp;
            for (int i = 0; i < LottoRad.Length; i++)
            {
                if (int.TryParse(LottoRad[i].Text, out temp))
                {
                    if (temp < MIN_VALUE)
                    {
                        LottoRad[i].Text = MIN_VALUE.ToString();
                    }
                    else if (temp > MAX_VALUE)
                    {
                        LottoRad[i].Text = MAX_VALUE.ToString();
                    }
                }
                else
                {
                    LottoRad[i].Clear();
                }
            }

            if (!int.TryParse(AntalDrag.Text, out temp))
            {
                AntalDrag.Text = "";
            }
        }

        // Om texten i någon av Rad-textrutorna ändras, kallas denna metod.
        private void Input_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;
            AdjustInput();

            if (ContainsDuplicates())
            {
                FelmeddelandeLabel.Text = "Innehåller dubletter!";
                valid = false;
            }
            else
            {
                FelmeddelandeLabel.Text = "";
            }

            if (IsAnyInputEmpty())
            {
                valid = false;
            }

            if (!valid)
            {
                StartBTN.Enabled = false;
            }
            else
            {
                StartBTN.Enabled = true;
            }
        }

        // Denna metod anropas när användaren trycker på startknappen.
        private void StartBTN_Click(object sender, EventArgs e)
        {
            // Ifall beräkningen tar lång tid, inaktivaveras start-knappen
            // för säkerhets skull så att användaren inte "köar" fler beräkningar.
            StartBTN.Enabled = false;
            
            // Eftersom AntalDrag redan blivit "verifierad" i AdjustInput-metoden
            // behöver vi inget try-ctach här.
            int antalDrag;
            int.TryParse(AntalDrag.Text, out antalDrag);
            int[] slumptal = new int[7];
            Random rnd = new Random();
            int antalRatt = 0;
            int antal5Ratt = 0;
            int antal6Ratt = 0;
            int antal7Ratt = 0;

            // Kör TryParse innan dragningsloopen för att 
            // undvika onödigt många calls till TryParse-funktionen.
            int[] LottoRadNum = new int[7];
            for (int i = 0; i < LottoRadNum.Length; i++)
            {
                int.TryParse(LottoRad[i].Text, out LottoRadNum[i]);
            }

            // Algoritmen för att hitta antalet 5, 6 och 7 rätt.
            for (int i = 0; i < antalDrag; i++)
            {
                antalRatt = 0;
                for (int j = 0; j < 7; j++)
                {
                    int temp = rnd.Next(MIN_VALUE, MAX_VALUE + 1);
                    for (int k = 0; k < LottoRadNum.Length; k++)
                    {
                        if (LottoRadNum[k] == temp)
                        {
                            antalRatt++;
                        }
                    }
                }
                if (antalRatt == 5)
                {
                    antal5Ratt++;
                }
                else if (antalRatt == 6)
                {
                    antal6Ratt++;
                }
                else if (antalRatt == 7)
                {
                    antal7Ratt++;
                }
            }

            FemRatt.Text = antal5Ratt.ToString();
            SexRatt.Text = antal6Ratt.ToString();
            SjuRatt.Text = antal7Ratt.ToString();
            StartBTN.Enabled = true;
        }
    }
}
