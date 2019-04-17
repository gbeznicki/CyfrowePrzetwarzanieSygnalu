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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            double amplitude;
            double period;
            double initialTime;
            double impletionRate;
            double jumpTime;
            double probability;
            double samplingFrequency;
            double totalTime;

            if (double.TryParse(textBoxAmplitude.Text, out amplitude))
                SharedSettings.Amplitude = amplitude;
            else MessageBox.Show("Amplituda musi być liczbą");
            if (double.TryParse(textBoxPeriod.Text, out period))
                SharedSettings.Period = period;
            else MessageBox.Show("Okres musi być liczbą");
            if (double.TryParse(textBoxInitialTime.Text, out initialTime))
                SharedSettings.InitialTime = initialTime;
            else MessageBox.Show("Czas początkowy musi być liczbą");
            if (double.TryParse(textBoxImpletionRate.Text, out impletionRate))
                SharedSettings.ImpletionRate = impletionRate;
            else MessageBox.Show("Współczynnik wypełnienia musi być liczbą");
            if (double.TryParse(textBoxJumpTime.Text, out jumpTime))
                SharedSettings.JumpTime = jumpTime;
            else MessageBox.Show("Czas skoku musi być liczbą");
            if (double.TryParse(textBoxProbability.Text, out probability))
                SharedSettings.Probability = probability;
            else MessageBox.Show("Prawdopodobieństwo musi być liczbą");
            if (double.TryParse(textBoxSamplingFrequency.Text, out samplingFrequency))
                SharedSettings.SamplingFrequency = samplingFrequency;
            else MessageBox.Show("Częstowliwość próbkowania musi być liczbą");
            if (double.TryParse(textBoxTotalTime.Text, out totalTime))
                SharedSettings.TotalTime = totalTime;
            else MessageBox.Show("Czas całkowity musi być liczbą");
        }


    }
}
