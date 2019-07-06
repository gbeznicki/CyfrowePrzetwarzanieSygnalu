using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class MeanSquaredErrorCalculator : Form
    {
        private readonly List<PlotController> plotsLeft = new List<PlotController>();
        private readonly List<PlotController> plotsRight = new List<PlotController>();

        public MeanSquaredErrorCalculator(List<PlotController> plots)
        {
            InitializeComponent();
            foreach (PlotController p in plots)
            {
                plotsLeft.Add(p);
                plotsRight.Add(p);
            }
            comboBoxLeft.DataSource = plotsLeft;
            comboBoxLeft.DisplayMember = "Title";
            comboBoxRight.DataSource = plotsRight;
            comboBoxRight.DisplayMember = "Title";
            button1.Text = "Oblicz błąd średniokwadratowy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Błąd średniokwadratowy wynosi: " + 
                calulateMeanSquaredError(((PlotController)comboBoxLeft.SelectedItem).DataPoints, 
                    ((PlotController)comboBoxRight.SelectedItem).DataPoints)
                , "Wynik"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private double calulateMeanSquaredError(List<DataPoint> initialPoints, List<DataPoint> afterReverseTransformPoints)
        {
            double mse = 0;
            for (int i = 0; i < initialPoints.Count; i++)
            {
                double diff = initialPoints[i].Y - afterReverseTransformPoints[i].Y;
                mse += Math.Pow(diff, 2);
            }
            return mse / initialPoints.Count;
        }
    }
}
