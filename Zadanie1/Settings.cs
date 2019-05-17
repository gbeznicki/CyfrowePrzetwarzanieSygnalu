using System;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            SetSettings();
        }

        private void SetSettings()
        {
            textBoxAmplitude.Text = SharedSettings.Amplitude.ToString();
            textBoxImpletionRate.Text = SharedSettings.ImpletionRate.ToString();
            textBoxInitialTime.Text = SharedSettings.InitialTime.ToString();
            textBoxJumpTime.Text = SharedSettings.JumpTime.ToString();
            textBoxPeriod.Text = SharedSettings.Period.ToString();
            textBoxProbability.Text = SharedSettings.Period.ToString();
            textBoxSampling.Text = SharedSettings.Frequency.ToString();
            textBoxTotalTime.Text = SharedSettings.TotalTime.ToString();
            textBoxRangesAmount.Text = SharedSettings.RangesAmount.ToString();

            textBoxReconstructionFrequency.Text = SharedSettings.ReconstructionFrequency.ToString();
            textBoxConsideredSamplesAmount.Text = SharedSettings.ConsideredSamplesNumber.ToString();
            textBoxQuantizationLevel.Text = SharedSettings.QuantizationLevel.ToString();
            textBoxSamplingFrequency.Text = SharedSettings.SamplingFrequency.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxAmplitude.Text, out double amplitude))
                SharedSettings.Amplitude = amplitude;
            else MessageBox.Show("Amplituda musi być liczbą");
            if (double.TryParse(textBoxPeriod.Text, out double period))
                SharedSettings.Period = period;
            else MessageBox.Show("Okres musi być liczbą");
            if (double.TryParse(textBoxInitialTime.Text, out double initialTime))
                SharedSettings.InitialTime = initialTime;
            else MessageBox.Show("Czas początkowy musi być liczbą");
            if (double.TryParse(textBoxImpletionRate.Text, out double impletionRate))
                SharedSettings.ImpletionRate = impletionRate;
            else MessageBox.Show("Współczynnik wypełnienia musi być liczbą");
            if (double.TryParse(textBoxJumpTime.Text, out double jumpTime))
                SharedSettings.JumpTime = jumpTime;
            else MessageBox.Show("Czas skoku musi być liczbą");
            if (double.TryParse(textBoxProbability.Text, out double probability))
                SharedSettings.Probability = probability;
            else MessageBox.Show("Prawdopodobieństwo musi być liczbą");
            if (double.TryParse(textBoxSampling.Text, out double frequency))
                SharedSettings.Frequency = frequency;
            else MessageBox.Show("Częstowliwość próbkowania musi być liczbą");
            if (double.TryParse(textBoxTotalTime.Text, out double totalTime))
                SharedSettings.TotalTime = totalTime;
            else MessageBox.Show("Czas całkowity musi być liczbą");
            if (int.TryParse(textBoxRangesAmount.Text, out int rangesAmount))
                SharedSettings.RangesAmount = rangesAmount;
            else MessageBox.Show("Liczba przedziałów musi być liczbą całkowitą");
            if (int.TryParse(textBoxReconstructionFrequency.Text, out int reconstructionFreq))
                SharedSettings.ReconstructionFrequency = reconstructionFreq;
            else MessageBox.Show("Liczba musi być liczbą całkowitą");
            if (int.TryParse(textBoxQuantizationLevel.Text, out int quantizationLevel))
                SharedSettings.QuantizationLevel = quantizationLevel;
            else MessageBox.Show("Liczba musi być liczbą całkowitą");
            if (int.TryParse(textBoxConsideredSamplesAmount.Text, out int consideredSamplesAmount))
                SharedSettings.ConsideredSamplesNumber = consideredSamplesAmount;
            else MessageBox.Show("Liczba musi być liczbą całkowitą");
            if (int.TryParse(textBoxSamplingFrequency.Text, out int samplingFrequency))
                SharedSettings.SamplingFrequency = samplingFrequency;
            else MessageBox.Show("Liczba musi być liczbą całkowitą");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
