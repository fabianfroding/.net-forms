using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        double value = 0; // Värdet som matas in av användaren.
        string operation = ""; // Variabel för att lagra vilket räknesätt som klickades.
        bool operationPressed = false; // Variabel för att avgöra om räknesätt-knappen har använts.

        public MainForm()
        {
            InitializeComponent();
        }

        // Eventhanterare för klick på alla nummer-knapper och decimal knappen.
        private void BTNNumber_Click(object sender, EventArgs e)
        {
            // Om inmatningsrutan innehåller bara 0 eller om räknesättsknappen har tryckts
            // efter att man matar in ett nummer så clearar vi inmatningsrutan.
            if (ResultTextBox.Text == "0" || operationPressed)
            {
                ResultTextBox.Clear();
            }

            // Återställ att räknesätts.knappen har tryks så vi kan tillåta fler inmatningar.
            operationPressed = false;

            // Logik för att hantera försök av inmatning av flera decimaler.
            if ((sender as Button).Text == ",")
            {
                if (!ResultTextBox.Text.Contains(","))
                {
                    ResultTextBox.Text += (sender as Button).Text;
                }
            }
            else
            {
                ResultTextBox.Text += (sender as Button).Text;
            }
            
        }

        // Event-hanterare för klick på alla räknesätt-knappar.
        private void BTNOperator_Click(object sender, EventArgs e)
        {
            operation = (sender as Button).Text; // Lagra räknesättet i variabel.

            value = double.Parse(ResultTextBox.Text);
            // Sätt operationPressed till true för att förhindra att den tidigare inmatade numret
            // ligger kvar och ett nytt nummer kan matas in
            operationPressed = true;
            // Sätt ekvations-textrutan till ekvationen som vi har hitills.
            EquationLabel.Text = value + " " + operation;
            // Återställ nästa värde till 0.
            ResultTextBox.Text = "0";
        }

        // Eventhanterare för klick på C-knappen som återställer all värden etc.
        private void BTNC_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            value = 0;
            EquationLabel.Text = "";
        }

        // Eventhanterare för klick på lika-med-knappen.
        private void BTNEqual_Click(object sender, EventArgs e)
        {
            // Töm ekvations-textrutan då vi utför beräkningen.
            EquationLabel.Text = "";
            // Switch-case statement för att hantera de olika räknesätten.
           switch (operation)
            {
                case "+":
                    ResultTextBox.Text = (value + Double.Parse(ResultTextBox.Text)).ToString();
                    break;
                case "-":
                    ResultTextBox.Text = (value - Double.Parse(ResultTextBox.Text)).ToString();
                    break;
                case "*":
                    ResultTextBox.Text = (value * Double.Parse(ResultTextBox.Text)).ToString();
                    break;
                case "/":
                    // Hantering av division med 0.
                    if (ResultTextBox.Text == "0")
                    {
                        MessageBox.Show("Division by 0 is illegal!");
                        break;
                    }
                    ResultTextBox.Text = (value / Double.Parse(ResultTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
                
        }
    }
}
