using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Operation : Form
    {
        private readonly List<PlotController> plotsLeft = new List<PlotController>();
        private readonly List<PlotController> plotsRight = new List<PlotController>();
        private readonly OperationType operationType;

        public PlotController Result { get; private set; }

        public Operation(OperationType operationType, List<PlotController> plots)
        {
            InitializeComponent();
            foreach (PlotController p in plots)
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
                case OperationType.Filtering:
                    label1.Text = "Wykres";
                    label2.Text = "Filtr";
                    button1.Text = "Filtruj";
                    break;
                case OperationType.Convolution:
                    label1.Text = "Wykres";
                    label2.Text = "Wykres 2";
                    button1.Text = "Splot";
                    break;
                case OperationType.Correlation:
                    label1.Text = "Wykres";
                    label2.Text = "Wykres 2";
                    button1.Text = "Korelacja";
                    break;
                case OperationType.CorrelationWithConvolution:
                    label1.Text = "Wykres";
                    label2.Text = "Wykres 2";
                    button1.Text = "Korelacja ze splotem";
                    break;
            }
        }

        private void Add()
        {
            PlotController leftPlot = (PlotController)comboBoxLeft.SelectedItem, rightPlot = (PlotController)comboBoxRight.SelectedItem;
            if(Math.Abs(leftPlot.Frequency - rightPlot.Frequency) > 1e-6)
            {
                MessageBox.Show("Wykresy mają różną częstotliwość próbkowania");
                return;
            }

            double initialTime = Math.Min(leftPlot.InitialTime, rightPlot.InitialTime);
            double finalTime = Math.Max(leftPlot.FinalTime, rightPlot.FinalTime);
            double samplingFrequency = leftPlot.Frequency;

            if(rightPlot.InitialTime < leftPlot.InitialTime)
            {
                PlotController temp = leftPlot;
                leftPlot = rightPlot;
                rightPlot = temp;
            }

            int leftLenght = Convert.ToInt32(finalTime - leftPlot.FinalTime);
            int rightLenght = Convert.ToInt32(rightPlot.InitialTime - initialTime);

            List<double> list = new List<double>();

            for(int i = 0; i< leftLenght*samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> leftAmplitudes = leftPlot.DataPoints.Select(x => x.Y).Concat(list).ToList();

            list.Clear();

            for (int i = 0; i < rightLenght * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> rightAmplitudes = rightPlot.DataPoints.Select(y => y.Y).Concat(list).ToList();

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

            Result = new PlotController
            {
                Title = textBoxTitle.Text,
                DataPoints = resultPoints,
                InitialTime = initialTime,
                FinalTime = finalTime,
                Frequency = samplingFrequency
            };
        }

        private void Substract() {

            PlotController leftPlot = (PlotController)comboBoxLeft.SelectedItem, rightPlot = (PlotController)comboBoxRight.SelectedItem;

            bool subtrahend;
            Result = null;
            if (Math.Abs(leftPlot.Frequency - rightPlot.Frequency) > 1e-6)
            {
                MessageBox.Show("Wykresy mają różną częstotliwość próbkowania");
                return;
            }

            double initialTime = Math.Min(leftPlot.InitialTime, rightPlot.InitialTime);
            double finalTime = Math.Max(leftPlot.FinalTime, rightPlot.FinalTime);
            double samplingFrequency = leftPlot.Frequency;

            PlotController leftSignal;
            PlotController rightSignal;

            if (leftPlot.InitialTime < rightPlot.InitialTime)
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

            int length1 = Convert.ToInt32(finalTime - leftSignal.FinalTime);
            int length2 = Convert.ToInt32(rightSignal.InitialTime - initialTime);

            var list = new List<double>();

            for (var i = 0; i < length1 * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> leftAmplitudes = leftPlot.DataPoints.Select(x => x.Y).Concat(list).ToList();

            list.Clear();

            for (var i = 0; i < length2 * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> rightAmplitudes = rightPlot.DataPoints.Select(y => y.Y).Concat(list).ToList();

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

            Result = new PlotController() { Title = textBoxTitle.Text };
            Result.DataPoints = resultPoints;
            Result.InitialTime = initialTime;
            Result.FinalTime = finalTime;
            Result.Frequency = samplingFrequency;
        }

        private void Multiply() {
            PlotController leftPlot = (PlotController)comboBoxLeft.SelectedItem, rightPlot = (PlotController)comboBoxRight.SelectedItem;
            if (Math.Abs(leftPlot.Frequency - rightPlot.Frequency) > 1e-6)
            {
                MessageBox.Show("Wykresy mają różną częstotliwość próbkowania");
                return;
            }

            var initialTime = Math.Min(leftPlot.InitialTime, rightPlot.InitialTime);
            var finalTime = Math.Max(leftPlot.FinalTime, rightPlot.FinalTime);
            var samplingFrequency = leftPlot.Frequency;

            if (rightPlot.InitialTime < leftPlot.InitialTime)
            {
                PlotController temp = leftPlot;
                leftPlot = rightPlot;
                rightPlot = temp;
            }

            int leftLenght = Convert.ToInt32(finalTime - leftPlot.FinalTime);
            int rightLenght = Convert.ToInt32(rightPlot.InitialTime - initialTime);

            List<double> list = new List<double>();

            for (int i = 0; i < leftLenght * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> leftAmplitudes = leftPlot.DataPoints.Select(x => x.Y).Concat(list).ToList();

            list.Clear();

            for (int i = 0; i < rightLenght * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> rightAmplitudes = rightPlot.DataPoints.Select(y => y.Y).Concat(list).ToList();

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

            Result = new PlotController() { Title = textBoxTitle.Text };
            Result.DataPoints = resultPoints;
            Result.InitialTime = initialTime;
            Result.FinalTime = finalTime;
            Result.Frequency = samplingFrequency;

        }

        private void Divide() {
            bool dividend;

            PlotController leftPlot = (PlotController)comboBoxLeft.SelectedItem, rightPlot = (PlotController)comboBoxRight.SelectedItem;
            if (Math.Abs(leftPlot.Frequency - rightPlot.Frequency) > 1e-6)
            {
                MessageBox.Show("Wykresy mają różną częstotliwość próbkowania");
                return;
            }

            double initialTime = Math.Min(leftPlot.InitialTime, rightPlot.InitialTime);
            double finalTime = Math.Max(leftPlot.FinalTime, rightPlot.FinalTime);
            double samplingFrequency = leftPlot.Frequency;

            PlotController leftSignal;
            PlotController rightSignal;

            if (leftPlot.InitialTime < rightPlot.InitialTime)
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

            var length1 = Convert.ToInt32(finalTime - leftSignal.FinalTime);
            var length2 = Convert.ToInt32(rightSignal.InitialTime - initialTime);

            var list = new List<double>();

            for (var i = 0; i < length1 * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> leftAmplitudes = leftPlot.DataPoints.Select(x => x.Y).Concat(list).ToList();

            list = new List<double>();

            for (var i = 0; i < length2 * samplingFrequency; i++)
            {
                list.Add(0.0);
            }

            List<double> rightAmplitudes = rightPlot.DataPoints.Select(y => y.Y).Concat(list).ToList();
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

            Result = new PlotController() { Title = textBoxTitle.Text };
            Result.DataPoints = resultPoints;
            Result.InitialTime = initialTime;
            Result.FinalTime = finalTime;
            Result.Frequency = samplingFrequency;
        }

        #region zadanie3
        private void Convolution()
        {
            PlotController leftPlot = (PlotController)comboBoxLeft.SelectedItem, rightPlot = (PlotController)comboBoxRight.SelectedItem;
            double initialTime = Math.Min(leftPlot.InitialTime, rightPlot.InitialTime);
            double finalTime = Math.Max(leftPlot.FinalTime, rightPlot.FinalTime);
            double samplingFrequency = leftPlot.Frequency;

            List<DataPoint> resultPoints = new List<DataPoint>();
            List<DataPoint> signalPoints = leftPlot.DataPoints;
            List<DataPoint> filterPoints = rightPlot.DataPoints;
            for (int i = 0; i < signalPoints.Count + filterPoints.Count - 1; i++)
            {
                double sum = 0;
                for (int j = 0; j < signalPoints.Count; j++)
                {
                    if (i - j < 0 || i - j >= filterPoints.Count)
                        continue;

                    sum += signalPoints[j].Y * filterPoints[i - j].Y;
                }
                resultPoints.Add(new DataPoint(i, sum));
            }

            Result = new PlotController
            {
                Title = textBoxTitle.Text,
                DataPoints = resultPoints,
                InitialTime = initialTime,
                FinalTime = finalTime,
                Frequency = samplingFrequency
            };
        }

        private void Correlation()
        {
            PlotController leftPlot = (PlotController)comboBoxLeft.SelectedItem, rightPlot = (PlotController)comboBoxRight.SelectedItem;
            double initialTime = Math.Min(leftPlot.InitialTime, rightPlot.InitialTime);
            double finalTime = Math.Max(leftPlot.FinalTime, rightPlot.FinalTime);
            double samplingFrequency = leftPlot.Frequency;

            List<DataPoint> resultPoints = new List<DataPoint>();
            List<DataPoint> signalPoints = leftPlot.DataPoints;
            List<DataPoint> signal2Points = rightPlot.DataPoints;
            for (int i = signal2Points.Count - 1; i >= (-1) * signalPoints.Count; i--)
            {
                double sum = 0;
                for (int j = 0; j < signalPoints.Count; j++)
                {
                    if (i - j < 0 || i - j >= signal2Points.Count)
                        continue;

                    sum += signalPoints[j].Y * signal2Points[i - j].Y;
                }
                resultPoints.Add(new DataPoint(i, sum));
            }

            Result = new PlotController
            {
                Title = textBoxTitle.Text,
                DataPoints = resultPoints,
                InitialTime = initialTime,
                FinalTime = finalTime,
                Frequency = samplingFrequency
            };
        }

        private void CorrelationWithConvolution()
        {
            PlotController leftPlot = (PlotController)comboBoxLeft.SelectedItem, rightPlot = (PlotController)comboBoxRight.SelectedItem;
            double initialTime = Math.Min(leftPlot.InitialTime, rightPlot.InitialTime);
            double finalTime = Math.Max(leftPlot.FinalTime, rightPlot.FinalTime);
            double samplingFrequency = leftPlot.Frequency;

            List<DataPoint> resultPoints = new List<DataPoint>();
            List<DataPoint> signalPoints = leftPlot.DataPoints;
            List<DataPoint> signal2Points = rightPlot.DataPoints;
            signalPoints.Reverse();
            for (int i = 0; i < signalPoints.Count + signal2Points.Count - 1; i++)
            {
                double sum = 0;
                for (int j = 0; j < signalPoints.Count; j++)
                {
                    if (i - j < 0 || i - j >= signal2Points.Count)
                        continue;

                    sum += signalPoints[j].Y * signal2Points[i - j].Y;
                }
                resultPoints.Add(new DataPoint(i, sum));
            }

            Result = new PlotController
            {
                Title = textBoxTitle.Text,
                DataPoints = resultPoints,
                InitialTime = initialTime,
                FinalTime = finalTime,
                Frequency = samplingFrequency
            };
        }
        #endregion

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
                    case OperationType.Filtering:
                        Convolution();
                        break;
                    case OperationType.Convolution:
                        Convolution();
                        break;
                    case OperationType.Correlation:
                        Correlation();
                        break;
                    case OperationType.CorrelationWithConvolution:
                        CorrelationWithConvolution();
                        break;
                }
            }
            Close();
        }
    }
}
