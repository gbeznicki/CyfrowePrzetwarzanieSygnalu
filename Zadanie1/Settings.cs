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
            textBoxSamplingFrequency.Text = SharedSettings.SamplingFrequencyAc.ToString();

            textBoxFilterM.Text = SharedSettings.FilterM.ToString();
            textBoxFilterF0.Text = SharedSettings.FilterF0.ToString();
            textBoxFilterFp.Text = SharedSettings.FilterFp.ToString();
            windowComboBox.Text = SharedSettings.ChosenWindow.ToString();
            
            textBox1.Text = SharedSettings.NumberOfMeasurement.ToString();
            textBox2.Text = SharedSettings.TimeUnit.ToString();
            textBox3.Text = SharedSettings.RealSpeed.ToString();
            textBox4.Text = SharedSettings.AbstractSpeed.ToString();
            textBox5.Text = SharedSettings.SignalPeriod.ToString();
            textBox6.Text = SharedSettings.BasicSignals.ToString();
            textBox7.Text = SharedSettings.ReportingPeriod.ToString();
            textBox8.Text = SharedSettings.BuffersLength.ToString();
            textBox9.Text = SharedSettings.SamplingFrequency.ToString();
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
            if (int.TryParse(textBoxSamplingFrequency.Text, out int samplingFrequencyAc))
                SharedSettings.SamplingFrequencyAc = samplingFrequencyAc;
            else MessageBox.Show("Liczba musi być liczbą całkowitą");
            if (int.TryParse(textBoxFilterM.Text, out int filterM))
                SharedSettings.FilterM = filterM;
            else MessageBox.Show("Wartość M musi być liczbą całkowitą");
            if (double.TryParse(textBoxFilterF0.Text, out double filterF0))
                SharedSettings.FilterF0 = filterF0;
            else MessageBox.Show("Wartość f0 musi być liczbą");
            if (double.TryParse(textBoxFilterFp.Text, out double filterFp))
                SharedSettings.FilterFp = filterFp;
            else MessageBox.Show("Wartość fp musi być liczbą");
            if (int.TryParse(textBox1.Text, out int NumberOfMeasurement))
                SharedSettings.NumberOfMeasurement = NumberOfMeasurement;
            else MessageBox.Show("Wartość musi być liczbą całkowitą");
            if (double.TryParse(textBox2.Text, out double TimeUnit))
                SharedSettings.TimeUnit = TimeUnit;
            else MessageBox.Show("Wartość musi być liczbą");
            if (double.TryParse(textBox3.Text, out double RealSpeed))
                SharedSettings.RealSpeed = RealSpeed;
            else MessageBox.Show("Wartość musi być liczbą");
            if (double.TryParse(textBox4.Text, out double AbstractSpeed))
                SharedSettings.AbstractSpeed = AbstractSpeed;
            else MessageBox.Show("Wartość musi być liczbą");
            if (double.TryParse(textBox5.Text, out double SignalPeriod))
                SharedSettings.SignalPeriod = SignalPeriod;
            else MessageBox.Show("Wartość musi być liczbą");
            if (int.TryParse(textBox6.Text, out int BasicSignals))
                SharedSettings.BasicSignals = BasicSignals;
            else MessageBox.Show("Wartość musi być liczbą całkowitą");
            if (double.TryParse(textBox7.Text, out double BuffersLength))
                SharedSettings.BuffersLength = BuffersLength;
            else MessageBox.Show("Wartość musi być liczbą");
            if (double.TryParse(textBox8.Text, out double ReportingPeriod))
                SharedSettings.ReportingPeriod = ReportingPeriod;
            else MessageBox.Show("Wartość musi być liczbą");
            if (double.TryParse(textBox9.Text, out double SamplingFrequency))
                SharedSettings.SamplingFrequency = SamplingFrequency;
            else MessageBox.Show("Wartość musi być liczbą");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void windowComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedSettings.ChosenWindow = windowComboBox.Text;
        }
    }
}
