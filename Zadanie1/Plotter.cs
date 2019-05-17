using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Plotter : Form
    {
        /// <summary>
        /// Tytuł wykresu
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Czas skoku jednostkowego
        /// </summary>
        /// <summary>
        /// Typ wykresu
        /// </summary>
        public PlotType PlotType { get; set; }

        public List<DataPoint> DataPoints;
        public double Frequency;
        public double InitialTime;
        public double FinalTime;
        public double Period;

        public int SamplingFrequency;
        public int ReconstructionFrequency;
        public int QuantizationLevel;
        public int ConsideredSamplesNumber;

        private readonly Equation equation;

        // results and measures
        private double averageValue;
        private double absoluteAverageValue;
        private double averagePower;
        private double variance;
        private double rootAveragePower;

        public Plotter()
        {
            InitializeComponent();
            equation = new Equation();
            Frequency = SharedSettings.Frequency;
            InitialTime = SharedSettings.InitialTime;
            FinalTime = SharedSettings.InitialTime + SharedSettings.TotalTime;
            Period = SharedSettings.Period;

            SamplingFrequency = SharedSettings.SamplingFrequency;
            ReconstructionFrequency = SharedSettings.ReconstructionFrequency;
            QuantizationLevel = SharedSettings.QuantizationLevel;
            ConsideredSamplesNumber = SharedSettings.ConsideredSamplesNumber;
        }

        public void Plot()
        {
            switch (PlotType)
            {
                case PlotType.SzumJednostajny:
                    RysujSzumJednostajny();
                    CalculateResults();
                    break;
                case PlotType.SzumGaussowski:
                    RysujSzumGaussowski();
                    CalculateResults();
                    break;
                case PlotType.Sinusoidalny:
                    RysujSinusoidalny();
                    CalculateResults();
                    break;
                case PlotType.SinusoidalnyWyprostowanyJednopolowkowo:
                    RysujSinusoidalnyWyprostowanyJednopolowkowo();
                    CalculateResults();
                    break;
                case PlotType.SinusoidalnyWyprostowanyDwupolowkowo:
                    RysujSinusoidalnyWyprostowanyDwupolowkowo();
                    CalculateResults();
                    break;
                case PlotType.Prostokatny:
                    RysujProstokatny();
                    CalculateResults();
                    break;
                case PlotType.ProstokatnySymetryczny:
                    RysujProstokatnySymetryczny();
                    CalculateResults();
                    break;
                case PlotType.Trojkatny:
                    RysujTrojkatny();
                    CalculateResults();
                    break;
                case PlotType.SkokJednostkowy:
                    RysujSkokJednostkowy();
                    CalculateResults();
                    break;
                case PlotType.ImpulsJednostkowy:
                    RysujImpulsJednostkowy();
                    CalculateResults();
                    break;
                case PlotType.SzumImpulsowy:
                    RysujSzumImpulsowy();
                    CalculateResults();
                    break;
                case PlotType.WynikDzialania:
                    DrawChart(DataPoints);
                    CalculateResults();
                    break;
            }
        }

        private void CalculateResults()
        {
            //int howManyPeriods = (int)(SharedSettings.TotalTime / SharedSettings.Period);
            //int length = (int)(howManyPeriods * SharedSettings.Period * Frequency);

            //var pointsRange = DataPoints.GetRange(0, length);

            //averageValue = pointsRange.Select(y => y.Y).Sum() / pointsRange.Count;
            //absoluteAverageValue = pointsRange.Select(y => y.Y).Sum(x => Math.Abs(x)) / pointsRange.Count;
            //variance = pointsRange.Select(y => y.Y).Sum(x => Math.Pow(x - averageValue, 2)) / pointsRange.Count;
            //averagePower = pointsRange.Select(y => y.Y).Sum(x => x * x) / pointsRange.Count;
            //rootAveragePower = Math.Sqrt(averagePower);

            //labelAverage.Text = averageValue.ToString();
            //labelAbsoluteAverage.Text = absoluteAverageValue.ToString();
            //labelVariance.Text = variance.ToString();
            //labelAveragePower.Text = averagePower.ToString();
            //labelRootAveragePower.Text = rootAveragePower.ToString();
        }

        private void RysujSzumImpulsowy()
        {
            DrawChart(equation.SzumImpulsowy());
            DataPoints = equation.SzumImpulsowy();
        }

        private void RysujImpulsJednostkowy()
        {
            DrawChart(equation.ImpulsJednostkowy());
            DataPoints = equation.ImpulsJednostkowy();
        }


        private void RysujSkokJednostkowy()
        {
            DrawChart(equation.SkokJednostkowy());
            DataPoints = equation.SkokJednostkowy();
        }

        private void RysujTrojkatny()
        {
            DrawChart(equation.Trojkatny());
            DataPoints = equation.Trojkatny();
        }

        private void RysujProstokatnySymetryczny()
        {
            DrawChart(equation.ProstokatnySymetryczny());
            DataPoints = equation.ProstokatnySymetryczny();
        }

        private void RysujProstokatny()
        {
            DrawChart(equation.Prostokatny());
            DataPoints = equation.Prostokatny();
        }

        private void RysujSinusoidalnyWyprostowanyDwupolowkowo()
        {
            DrawChart(equation.SinusWyprostowanyDwupolowkowo());
            DataPoints = equation.SinusWyprostowanyDwupolowkowo();
        }

        private void RysujSinusoidalnyWyprostowanyJednopolowkowo()
        {
            DrawChart(equation.SinusWyprostowanyJednopolowkowo());
            DataPoints = equation.SinusWyprostowanyJednopolowkowo();
        }

        private void RysujSinusoidalny()
        {
            DrawChart(equation.Sinus());
            DataPoints = equation.Sinus();
        }

        private void RysujSzumGaussowski()
        {
            DrawChart(equation.SzumGaussowski());
            DataPoints = equation.SzumGaussowski();
        }

        private void RysujSzumJednostajny()
        {
            DrawChart(equation.SzumJednostajny());
            DataPoints = equation.SzumJednostajny();
        }

        Dictionary<double, int> GenerateHistogram(List<DataPoint> dataPoints)
        {
            var h = new Dictionary<Double, Int32>();
            var ranges = new List<Double>();
            double min = dataPoints.Min(x => x.Y), max = dataPoints.Max(x => x.Y);
            var a = max - min;
            var step = a / SharedSettings.RangesAmount;
            for (int i = 0; i < SharedSettings.RangesAmount; i++)
            {
                ranges.Add(min + (i * step));
            }
            ranges.Add(max);

            foreach (double range in ranges)
            {
                var counter = dataPoints.Count(x => x.Y > range - step / 2 && x.Y < range + step / 2);
                h[range] = counter;
            }
            return h;
        }

        void DrawHistogram(IEnumerable<DataPoint> points)
        {
            //Pobranie punktów do histogramu
            var histogramData = GenerateHistogram(points.ToList());

            //Rysowanie histogramu
            var plotModel = new PlotModel { Title = Title };
            var histogramSeries = new ColumnSeries();
            plotModel.Axes.Add(new CategoryAxis { Position = AxisPosition.Bottom });
            foreach (var label in histogramData.Keys)
            {
                ((CategoryAxis)plotModel.Axes[0]).ActualLabels.Add(Math.Round(label, 1).ToString());
            }
            plotModel.Axes.Add(new LinearAxis() { Position = AxisPosition.Left });

            foreach (var y in histogramData.Values)
            {
                histogramSeries.Items.Add(new ColumnItem(y));
            }
            plotModel.Series.Add(histogramSeries);
            histogram.Model = plotModel;
        }

        void DrawChart(IEnumerable<DataPoint> points, bool drawHistogram = true)
        {
            //Rysowanie wykresu liniowego/punktowego
            var myModel = new PlotModel { Title = Title };
            var plotData = new LineSeries();

            foreach (var point in points)
            {
                plotData.Points.Add(point);
            }

            myModel.Series.Add(plotData);
            plot1.Model = myModel;

            if (drawHistogram)
            {
                DrawHistogram(plotData.Points);
            }
        }

        public void Export(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                sw.WriteLine(nameof(Plotter));
                sw.WriteLine(InitialTime);
                sw.WriteLine(FinalTime);
                sw.WriteLine(Period);
                sw.WriteLine(Frequency);
                foreach (var y in DataPoints.Select(y => y.Y))
                {
                    sw.Write($"{y} ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Export(folderBrowserDialog1.SelectedPath+"\\"+Title+".txt");
                MessageBox.Show("Pomyślnie wyeksportowano wykres do pliku");
            }
        }
    }
}
