using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Operation : Form
    {
        private List<Plotter> plotsLeft = new List<Plotter>();
        private List<Plotter> plotsRight = new List<Plotter>();
        private OperationType operationType;
        public Plotter result;

        public Operation(OperationType operationType, List<Plotter> plots)
        {
            InitializeComponent();
            foreach (Plotter p in plots)
            {
                plotsLeft.Add(p);
                plotsRight.Add(p);
            }
            this.operationType = operationType;
            comboBoxLeft.DataSource = plotsLeft;
            comboBoxLeft.DisplayMember = "Title";
            comboBoxRight.DataSource = plotsRight;
            comboBoxRight.DisplayMember = "Title";

            switch (operationType)
            {
                case OperationType.Adding:
                    label1.Text = "Składnik";
                    label2.Text = "Składnik";
                    button1.Text = "Dodaj";
                    break;
                case OperationType.Substracting:
                    label1.Text = "Odjemna";
                    label2.Text = "Odjemnik";
                    button1.Text = "Odejmij";
                    break;
                case OperationType.Multiplying:
                    label1.Text = "Czynnik";
                    label2.Text = "Czynnik";
                    button1.Text = "Pomnóż";
                    break;
                case OperationType.Dividing:
                    label1.Text = "Dzielna";
                    label2.Text = "Dzielnik";
                    button1.Text = "Podziel";
                    break;
            }
        }

        private void Add()
        {
            Plotter leftPlot = (Plotter)comboBoxLeft.SelectedItem, rightPlot = (Plotter)comboBoxRight.SelectedItem;
            if(Math.Abs(leftPlot.samplingFrequency - rightPlot.samplingFrequency) > 1e-6)
            {
                MessageBox.Show("Wykresy mają różną częstotliwość próbkowania");
                return;
            }

            double initialTime = Math.Min(leftPlot.initialTime, rightPlot.initialTime);
            double finalTime = Math.Max(leftPlot.finalTime, rightPlot.finalTime);
            double samplingFrequency = leftPlot.samplingFrequency;

            if(rightPlot.initialTime < leftPlot.initialTime)
            {
                Plotter temp = leftPlot;
                leftPlot = rightPlot;
                rightPlot = temp;
            }

            int leftLenght = Convert.ToInt32(finalTime - leftPlot.finalTime);
            int rightLenght = Convert.ToInt32(rightPlot.initialTime - initialTime);

            List<double> list = new List<double>();

            for(int i = 0; i< leftLenght*samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> leftAmplitudes = leftPlot.dataPoints.Select(x => x.Y).Concat(list).ToList();

            list.Clear();

            for (int i = 0; i < rightLenght * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> rightAmplitudes = rightPlot.dataPoints.Select(y => y.Y).Concat(list).ToList();

            List<double> resultAmplitudes = rightAmplitudes.Select((y, i) => leftAmplitudes[i] + y).ToList();


            List<double> resultTime = new List<double>();
            for(double i = initialTime; i < finalTime; i+= 1.0/samplingFrequency)
            {
                resultTime.Add(i);
            }

            List<DataPoint> resultPoints = new List<DataPoint>();
            for(int i = 0; i<resultAmplitudes.Count; i++)
            {
                resultPoints.Add(new DataPoint(resultTime[i], resultAmplitudes[i]));
            }

            result = new Plotter() { Title = textBoxTitle.Text };
            result.dataPoints = resultPoints;
            result.initialTime = initialTime;
            result.finalTime = finalTime;
            result.samplingFrequency = samplingFrequency;
        }

        private void Substract() {

            Plotter leftPlot = (Plotter)comboBoxLeft.SelectedItem, rightPlot = (Plotter)comboBoxRight.SelectedItem;

            bool subtrahend;
            result = null;
            if (Math.Abs(leftPlot.samplingFrequency - rightPlot.samplingFrequency) > 1e-6)
            {
                MessageBox.Show("Wykresy mają różną częstotliwość próbkowania");
                return;
            }

            double initialTime = Math.Min(leftPlot.initialTime, rightPlot.initialTime);
            double finalTime = Math.Max(leftPlot.finalTime, rightPlot.finalTime);
            double samplingFrequency = leftPlot.samplingFrequency;

            Plotter leftSignal;
            Plotter rightSignal;

            if (leftPlot.initialTime < rightPlot.initialTime)
            {
                subtrahend = true;
                leftSignal = leftPlot;
                rightSignal = rightPlot;
            }
            else
            {
                subtrahend = false;
                leftSignal = rightPlot;
                rightSignal = leftPlot;
            }

            int length1 = Convert.ToInt32(finalTime - leftSignal.finalTime);
            int length2 = Convert.ToInt32(rightSignal.initialTime - initialTime);

            var list = new List<double>();

            for (var i = 0; i < length1 * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> leftAmplitudes = leftPlot.dataPoints.Select(x => x.Y).Concat(list).ToList();

            list.Clear();

            for (var i = 0; i < length2 * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> rightAmplitudes = rightPlot.dataPoints.Select(y => y.Y).Concat(list).ToList();

            List<double> resultAmplitudes = subtrahend ? rightAmplitudes.Select((t, i) => leftAmplitudes[i] - t).ToList() : leftAmplitudes.Select((t, i) => rightAmplitudes[i] - t).ToList();

            List<double> resultTime = new List<double>();
            for (double i = initialTime; i < finalTime; i += 1.0 / samplingFrequency)
            {
                resultTime.Add(i);
            }

            List<DataPoint> resultPoints = new List<DataPoint>();
            for (int i = 0; i < resultAmplitudes.Count; i++)
            {
                resultPoints.Add(new DataPoint(resultTime[i], resultAmplitudes[i]));
            }

            result = new Plotter() { Title = textBoxTitle.Text };
            result.dataPoints = resultPoints;
            result.initialTime = initialTime;
            result.finalTime = finalTime;
            result.samplingFrequency = samplingFrequency;
        }

        private void Multiply() {
            Plotter leftPlot = (Plotter)comboBoxLeft.SelectedItem, rightPlot = (Plotter)comboBoxRight.SelectedItem;
            if (Math.Abs(leftPlot.samplingFrequency - rightPlot.samplingFrequency) > 1e-6)
            {
                MessageBox.Show("Wykresy mają różną częstotliwość próbkowania");
                return;
            }

            double initialTime = Math.Min(leftPlot.initialTime, rightPlot.initialTime);
            double finalTime = Math.Max(leftPlot.finalTime, rightPlot.finalTime);
            double samplingFrequency = leftPlot.samplingFrequency;

            if (rightPlot.initialTime < leftPlot.initialTime)
            {
                Plotter temp = leftPlot;
                leftPlot = rightPlot;
                rightPlot = temp;
            }

            int leftLenght = Convert.ToInt32(finalTime - leftPlot.finalTime);
            int rightLenght = Convert.ToInt32(rightPlot.initialTime - initialTime);

            List<double> list = new List<double>();

            for (int i = 0; i < leftLenght * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> leftAmplitudes = leftPlot.dataPoints.Select(x => x.Y).Concat(list).ToList();

            list.Clear();

            for (int i = 0; i < rightLenght * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> rightAmplitudes = rightPlot.dataPoints.Select(y => y.Y).Concat(list).ToList();

            List<double> resultAmplitudes = rightAmplitudes.Select((y, i) => leftAmplitudes[i] * y).ToList();

            List<double> resultTime = new List<double>();
            for (double i = initialTime; i < finalTime; i += 1.0 / samplingFrequency)
            {
                resultTime.Add(i);
            }

            List<DataPoint> resultPoints = new List<DataPoint>();
            for (int i = 0; i < resultAmplitudes.Count; i++)
            {
                resultPoints.Add(new DataPoint(resultTime[i], resultAmplitudes[i]));
            }

            result = new Plotter() { Title = textBoxTitle.Text };
            result.dataPoints = resultPoints;
            result.initialTime = initialTime;
            result.finalTime = finalTime;
            result.samplingFrequency = samplingFrequency;

        }

        private void Divide() {
            bool dividend;

            Plotter leftPlot = (Plotter)comboBoxLeft.SelectedItem, rightPlot = (Plotter)comboBoxRight.SelectedItem;
            if (Math.Abs(leftPlot.samplingFrequency - rightPlot.samplingFrequency) > 1e-6)
            {
                MessageBox.Show("Wykresy mają różną częstotliwość próbkowania");
                return;
            }

            double initialTime = Math.Min(leftPlot.initialTime, rightPlot.initialTime);
            double finalTime = Math.Max(leftPlot.finalTime, rightPlot.finalTime);
            double samplingFrequency = leftPlot.samplingFrequency;

            Plotter leftSignal;
            Plotter rightSignal;

            if (leftPlot.initialTime < rightPlot.initialTime)
            {
                dividend = true;
                leftSignal = leftPlot;
                rightSignal = rightPlot;
            }
            else
            {
                dividend = false;
                leftSignal = rightPlot;
                rightSignal = leftPlot;
            }

            var length1 = Convert.ToInt32(finalTime - leftSignal.finalTime);
            var length2 = Convert.ToInt32(rightSignal.initialTime - initialTime);

            var list = new List<double>();

            for (var i = 0; i < length1 * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> leftAmplitudes = leftPlot.dataPoints.Select(x => x.Y).Concat(list).ToList();

            list = new List<double>();

            for (var i = 0; i < length2 * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> rightAmplitudes = rightPlot.dataPoints.Select(y => y.Y).Concat(list).ToList();
            List<double> resultAmplitudes = dividend ? rightAmplitudes.Select((t, i) => (Math.Abs(leftAmplitudes[i]) < 1e-10 || Math.Abs(t) < 1e-10) ? 0 : leftAmplitudes[i] / t).ToList() : leftAmplitudes.Select((t, i) => (Math.Abs(rightAmplitudes[i]) < 1e-10 || Math.Abs(t) < 1e-10) ? 0 : rightAmplitudes[i] / t).ToList();

            List<double> resultTime = new List<double>();
            for (double i = initialTime; i < finalTime; i += 1.0 / samplingFrequency)
            {
                resultTime.Add(i);
            }

            List<DataPoint> resultPoints = new List<DataPoint>();
            for (int i = 0; i < resultAmplitudes.Count; i++)
            {
                resultPoints.Add(new DataPoint(resultTime[i], resultAmplitudes[i]));
            }

            result = new Plotter() { Title = textBoxTitle.Text };
            result.dataPoints = resultPoints;
            result.initialTime = initialTime;
            result.finalTime = finalTime;
            result.samplingFrequency = samplingFrequency;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (comboBoxLeft.SelectedItem != null && comboBoxRight.SelectedItem != null)
            {
                switch (operationType)
                {
                    case OperationType.Adding:
                        Add();
                        break;
                    case OperationType.Substracting:
                        Substract();
                        break;
                    case OperationType.Multiplying:
                        Multiply();
                        break;
                    case OperationType.Dividing:
                        Divide();
                        break;
                }
            }
            Close();
        }
    }
}
