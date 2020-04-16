using MediaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        public void DrawTop10Graph(List<Product> products, List<Receipt> receipts)
        {
            foreach (Product p in products)
            {
                foreach (Receipt r in receipts)
                {
                    foreach (Product rP in r.products)
                    {
                        if (p.id == rP.id)
                        {
                            p.unitsSold++;
                        }
                    }
                }
            }
            products = products.OrderByDescending(p => p.unitsSold).ToList<Product>();

            StatsChart.Series[0].Name = "";
            StatsChart.ChartAreas[0].AxisX.Title = "Products";
            StatsChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            StatsChart.ChartAreas[0].AxisX.Interval = 1;
            StatsChart.ChartAreas[0].AxisY.Title = "Units Sold";
            StatsChart.ChartAreas[0].AxisY.Interval = 1;
            StatsChart.ChartAreas[0].AxisY.IntervalOffset = 1;
            StatsChart.ChartAreas[0].AxisY.ScaleView.Size = 10;

            int count = 0;
            foreach(Product p in products)
            {
                StatsChart.Series[0].Points.AddXY(p.name, p.unitsSold);
                count++;
                if (count > 9)
                {
                    break;
                }
            }
        }

        public void DrawSalesGraph(Product product, List<Receipt> receipts)
        {
            StatsChart.Series[0].Name = product.name;
            StatsChart.ChartAreas[0].AxisX.Title = "YYYYMM";
            StatsChart.ChartAreas[0].AxisY.Title = "Units Sold";
            StatsChart.ChartAreas[0].AxisY.Interval = 1;
            StatsChart.ChartAreas[0].AxisY.IntervalOffset = 1;
            StatsChart.ChartAreas[0].AxisY.ScaleView.Size = 10;

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
                        if (p.id == product.id)
                        {
                            numSales++;
                        }
                    }
                    if (numSales > StatsChart.ChartAreas[0].AxisY.ScaleView.Size)
                    {
                        StatsChart.ChartAreas[0].AxisY.Interval = 1 + (int)(numSales * 0.1);
                        StatsChart.ChartAreas[0].AxisY.IntervalOffset = 1 + (int)(numSales * 0.1);
                        StatsChart.ChartAreas[0].AxisY.ScaleView.Size = numSales + (int)(numSales * 0.1);
                    }
                    if (numSales > 0)
                    {
                        StatsChart.Series[0].Points.AddXY(receiptsCopy[i].date.Substring(0, 6), numSales);
                    }
                }
            }
        }

    }
}
