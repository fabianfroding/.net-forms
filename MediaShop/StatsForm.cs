using MediaShop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class StatsForm : Form
    {
        private readonly Product selectedProduct;
        private readonly List<Receipt> receipts;

        public StatsForm(Product product, List<Receipt> receipts)
        {
            InitializeComponent();
            this.selectedProduct = product;
            this.receipts = receipts;
            StatsChart.Series[0].Name = product.name;
            StatsChart.ChartAreas[0].AxisX.Title = "YYYYMM";
            StatsChart.ChartAreas[0].AxisY.Title = "Units Sold";
            StatsChart.ChartAreas[0].AxisY.Interval = 1;
            StatsChart.ChartAreas[0].AxisY.IntervalOffset = 1;
            StatsChart.ChartAreas[0].AxisY.ScaleView.Size = 10;
            DrawGraph(this.receipts);
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void DrawGraph(List<Receipt> receipts)
        {
            Receipt[] receiptsCopy = receipts.ToArray();
            for (int i = 0; i < receiptsCopy.Length; i++)
            {
                if (receiptsCopy[i] != null)
                {
                    for (int j = i + 1; j < receiptsCopy.Length; j++)
                    {
                        if (receiptsCopy[i].date.Substring(0, 6) == receiptsCopy[j].date.Substring(0, 6))
                        {
                            receiptsCopy[i].products.AddRange(receiptsCopy[j].products);
                            receiptsCopy[j] = null;
                        }
                    }
                    int numSales = 0;
                    foreach (Product p in receiptsCopy[i].products)
                    {
                        if (p.id == selectedProduct.id)
                        {
                            numSales++;
                        }
                    }
                    StatsChart.Series[0].Points.AddXY(receiptsCopy[i].date.Substring(0, 6), numSales);
                }
            }
        }

    }
}
