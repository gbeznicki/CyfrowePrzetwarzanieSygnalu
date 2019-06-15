using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class PlotController : Form
    {
        /// <summary>
        /// Tytuł wykresu
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Typ wykresu
        /// </summary>
        public PlotType PlotType { get; set; }

        public List<DataPoint> DataPoints;
        public double Frequency;
        public double InitialTime;
        public double FinalTime;
        public double Period;

        public int SamplingFrequencyAc;
        public int ReconstructionFrequency;
        public int QuantizationLevel;
        public int ConsideredSamplesNumber;

        private readonly EquationsProvider equationsProvider;

        // results and measures
        private double averageValue;
        private double absoluteAverageValue;
        private double averagePower;
        private double variance;
        private double rootAveragePower;

        private readonly StairStepSeries interpolatedSeries = new StairStepSeries
        {
            MarkerStrokeThickness = .1,
            MarkerSize = 1,
            MarkerStroke = OxyColors.Blue,
            MarkerFill = OxyColors.Transparent,
            MarkerType = MarkerType.Diamond,
            Color = OxyColors.Blue,
            BrokenLineColor = OxyColors.Blue
        };

        private readonly LineSeries sincSeries = new LineSeries
        {
            MarkerStrokeThickness = .1,
            MarkerSize = 1,
            MarkerStroke = OxyColors.Orange,
            MarkerFill = OxyColors.Transparent,
            MarkerType = MarkerType.Diamond,
            Color = OxyColors.Orange,
            BrokenLineColor = OxyColors.Orange,
        };

        public PlotController()
        {
            InitializeComponent();
            equationsProvider = new EquationsProvider();
            equationsProvider.InitializeValues(
                SharedSettings.Amplitude, SharedSettings.Period, SharedSettings.InitialTime, 
                SharedSettings.ImpletionRate, SharedSettings.JumpTime, SharedSettings.TotalTime, 
                SharedSettings.Frequency, SharedSettings.Probability
            );

            Frequency = SharedSettings.Frequency;
            InitialTime = SharedSettings.InitialTime;
            FinalTime = SharedSettings.InitialTime + SharedSettings.TotalTime;
            Period = SharedSettings.Period;

            SamplingFrequencyAc = SharedSettings.SamplingFrequencyAc;
            ReconstructionFrequency = SharedSettings.ReconstructionFrequency;
            QuantizationLevel = SharedSettings.QuantizationLevel;
            ConsideredSamplesNumber = SharedSettings.ConsideredSamplesNumber;
        }

        public void DrawPlot()
        {
            List<double> caMeasuredValues = null;

            switch (PlotType)
            {
                case PlotType.SzumJednostajny:
                    RysujSzumJednostajny();
                    break;
                case PlotType.SzumGaussowski:
                    RysujSzumGaussowski();
                    break;
                case PlotType.Sinusoidalny:
                    RysujSinusoidalny();
                    break;
                case PlotType.SinusoidalnyWyprostowanyJednopolowkowo:
                    RysujSinusoidalnyWyprostowanyJednopolowkowo();
                    break;
                case PlotType.SinusoidalnyWyprostowanyDwupolowkowo:
                    RysujSinusoidalnyWyprostowanyDwupolowkowo();
                    break;
                case PlotType.Prostokatny:
                    RysujProstokatny();
                    break;
                case PlotType.ProstokatnySymetryczny:
                    RysujProstokatnySymetryczny();
                    break;
                case PlotType.Trojkatny:
                    RysujTrojkatny();
                    break;
                case PlotType.SkokJednostkowy:
                    RysujSkokJednostkowy();
                    break;
                case PlotType.ImpulsJednostkowy:
                    RysujImpulsJednostkowy();
                    break;
                case PlotType.SzumImpulsowy:
                    RysujSzumImpulsowy();
                    break;
                case PlotType.WynikDzialania:
                    DrawChart(DataPoints);
                    break;
                case PlotType.Sampling:
                    DrawSamplingPlot(DataPoints, out caMeasuredValues);
                    break;
                case PlotType.Quantization:
                    DrawQuantizedPlot(DataPoints, out caMeasuredValues);
                    break;
                case PlotType.Interpolation:
                    DrawInterpolatedPlot(DataPoints, out caMeasuredValues);
                    break;
                case PlotType.SincReconstruction:
                    DrawSincReconstructionPlot(DataPoints, out caMeasuredValues);
                    break;
            }

            PrintResults(caMeasuredValues);
        }

        private void RysujSzumImpulsowy()
        {
            DrawChart(equationsProvider.SzumImpulsowy());
            DataPoints = equationsProvider.SzumImpulsowy();
        }

        private void RysujImpulsJednostkowy()
        {
            DrawChart(equationsProvider.ImpulsJednostkowy());
            DataPoints = equationsProvider.ImpulsJednostkowy();
        }


        private void RysujSkokJednostkowy()
        {
            DrawChart(equationsProvider.SkokJednostkowy());
            DataPoints = equationsProvider.SkokJednostkowy();
        }

        private void RysujTrojkatny()
        {
            DrawChart(equationsProvider.Trojkatny());
            DataPoints = equationsProvider.Trojkatny();
        }

        private void RysujProstokatnySymetryczny()
        {
            DrawChart(equationsProvider.ProstokatnySymetryczny());
            DataPoints = equationsProvider.ProstokatnySymetryczny();
        }

        private void RysujProstokatny()
        {
            DrawChart(equationsProvider.Prostokatny());
            DataPoints = equationsProvider.Prostokatny();
        }

        private void RysujSinusoidalnyWyprostowanyDwupolowkowo()
        {
            DrawChart(equationsProvider.SinusWyprostowanyDwupolowkowo());
            DataPoints = equationsProvider.SinusWyprostowanyDwupolowkowo();
        }

        private void RysujSinusoidalnyWyprostowanyJednopolowkowo()
        {
            DrawChart(equationsProvider.SinusWyprostowanyJednopolowkowo());
            DataPoints = equationsProvider.SinusWyprostowanyJednopolowkowo();
        }

        private void RysujSinusoidalny()
        {
            DrawChart(equationsProvider.Sinus());
            DataPoints = equationsProvider.Sinus();
        }

        private void RysujSzumGaussowski()
        {
            DrawChart(equationsProvider.SzumGaussowski());
            DataPoints = equationsProvider.SzumGaussowski();
        }

        private void RysujSzumJednostajny()
        {
            DrawChart(equationsProvider.SzumJednostajny());
            DataPoints = equationsProvider.SzumJednostajny();
        }

        void DrawInterpolatedPlot(List<DataPoint> previousPoints, out List<double> measuredValues)
        {
            DrawSamplingPlot(previousPoints, out _, false);

            var sampledSignal = SignalConverter.SampleSignal(previousPoints, Frequency, SamplingFrequencyAc, out measuredValues);
            var extrapolatedPoints = SignalConverter.ZeroAndHoldExtrapolation(sampledSignal.ToList(),
                SamplingFrequencyAc, ConsideredSamplesNumber).ToList();
            
            //var interpolatedPoints = SignalConverter.Interpolate(previousPoints.Count, 
            //    previousPoints.Select(p => new ScatterPoint(p.X, p.Y)).ToList(), SamplingFrequency, SamplingFrequencyAc, InitialTime, out var measures);
            measuredValues = extrapolatedPoints.Select(p => p.Y).ToList();

            interpolatedSeries.Points.Clear();
            foreach (var point in extrapolatedPoints)
            {
                interpolatedSeries.Points.Add(point);
            }
            plot1.Model.Series.Add(interpolatedSeries);
        }

        void DrawSincReconstructionPlot(List<DataPoint> previousPoints, out List<double> measuredValues)
        {
            DrawSamplingPlot(previousPoints, out _, false);

            var sampledSignal = SignalConverter.SampleSignal(previousPoints, Frequency, SamplingFrequencyAc, out measuredValues);
            var sincPoints = SignalConverter.SincReconstruction(sampledSignal.ToList(), SamplingFrequencyAc,
                ConsideredSamplesNumber).ToList();
            measuredValues = sincPoints.Select(p => p.Y).ToList();

            foreach (var point in sincPoints)
            {
                sincSeries.Points.Add(point);
            }
            plot1.Model.Series.Add(sincSeries);
        }

        void DrawQuantizedPlot(List<DataPoint> previousPoints, out List<double> measuredValues)
        {
            DrawChart(previousPoints, false);
            var quantizedPoints = SignalConverter.QuantizeSignal(previousPoints, QuantizationLevel, out var measures);

            //var interpolatedPoints = SignalConverter.Interpolate(previousPoints.Count, 
            //    previousPoints.Select(p => new ScatterPoint(p.X, p.Y)).ToList(), SamplingFrequency, SamplingFrequencyAc, InitialTime, out var measures);
            measuredValues = measures;
            var stepSizeSeries = new StairStepSeries
            {
                MarkerStrokeThickness = .1,
                MarkerSize = 1,
                MarkerStroke = OxyColors.Blue,
                MarkerFill = OxyColors.Transparent,
                MarkerType = MarkerType.Diamond,
                Color = OxyColors.Blue,
                BrokenLineColor = OxyColors.Blue,
                BrokenLineThickness = .1,
                StrokeThickness = .1,
            };

            foreach (var point in quantizedPoints)
            {
                stepSizeSeries.Points.Add(point);
            }
            plot1.Model.Series.Add(stepSizeSeries);
        }

        void DrawSamplingPlot(List<DataPoint> previousPoints, out List<double> measuredValues, bool drawOriginalSignal = true)
        {
            // draw original signal
            DrawChart(previousPoints, false, drawOriginalSignal);

            var sampledPoints = SignalConverter.SampleSignal(previousPoints, Frequency, SamplingFrequencyAc, out measuredValues);
            var scatterSeries = new ScatterSeries
            {
                MarkerStrokeThickness = .1,
                MarkerSize = 2,
                MarkerStroke = OxyColors.Red,
                MarkerFill = OxyColors.Transparent,
                MarkerType = MarkerType.Diamond
            };

            foreach (var point in sampledPoints)
            {
                scatterSeries.Points.Add(point);
            }
            plot1.Model.Series.Add(scatterSeries);
        }

        private void PrintResults(List<double> measuredValues = null)
        {
            labelMeasureValue_0.Text = measuredValues == null ? "Średnia" : "Błąd średniokwadratowy";
            labelMeasureValue_1.Text = measuredValues == null ? "Średnia bezwzględna" : "Stosunek sygnał-szum";
            labelMeasureValue_3.Text = measuredValues == null ? "Moc średnia" : "Szczytowy stosunek sygnał-szum";
            labelMeasureValue_2.Text = measuredValues == null ? "Wariancja" : "Maksymalna różnica";
            labelMeasureValue_4.Text = measuredValues == null ? "Wartość skuteczna" : "";

            if (measuredValues == null)
            {
                int howManyPeriods = (int)(SharedSettings.TotalTime / SharedSettings.Period);
                int length = (int)(howManyPeriods * SharedSettings.Period * Frequency);

                var pointsRange = DataPoints.GetRange(0, length);

                averageValue = pointsRange.Select(y => y.Y).Sum() / pointsRange.Count;
                absoluteAverageValue = pointsRange.Select(y => y.Y).Sum(x => Math.Abs(x)) / pointsRange.Count;
                variance = pointsRange.Select(y => y.Y).Sum(x => Math.Pow(x - averageValue, 2)) / pointsRange.Count;
                averagePower = pointsRange.Select(y => y.Y).Sum(x => x * x) / pointsRange.Count;
                rootAveragePower = Math.Sqrt(averagePower);

                labelMeasureValue_0.Text = averageValue.ToString(CultureInfo.InvariantCulture);
                labelMeasureValue_1.Text = absoluteAverageValue.ToString(CultureInfo.InvariantCulture);
                labelMeasureValue_3.Text = variance.ToString(CultureInfo.InvariantCulture);
                labelMeasureValue_2.Text = averagePower.ToString(CultureInfo.InvariantCulture);
                labelMeasureValue_4.Text = rootAveragePower.ToString(CultureInfo.InvariantCulture);

                labelMeasure_0.Text = "Średnia";
                labelMeasure_1.Text = "Średnia bezwzględna";
                labelMeasure_2.Text = "Moc średnia";
                labelMeasure_3.Text = "Wariancja";
                labelMeasure_4.Text = "Wartość skuteczna";
            }
            else
            {
                labelMeasureValue_0.Text = measuredValues[0].ToString(CultureInfo.InvariantCulture);
                labelMeasureValue_1.Text = measuredValues[1].ToString(CultureInfo.InvariantCulture);
                labelMeasureValue_3.Text = measuredValues[2].ToString(CultureInfo.InvariantCulture);
                labelMeasureValue_2.Text = measuredValues[3].ToString(CultureInfo.InvariantCulture);
                labelMeasureValue_4.Text = "";

                labelMeasure_0.Text = "MSE";
                labelMeasure_1.Text = "SNR";
                labelMeasure_2.Text = "PSNR";
                labelMeasure_3.Text = "MD";
                labelMeasure_4.Text = "";
            }
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

        void DrawChart(IEnumerable<DataPoint> points, bool drawHistogram = true, bool drawOriginalSignal = true)
        {
            //Rysowanie wykresu liniowego/punktowego
            var myModel = new PlotModel { Title = Title };

            if (drawOriginalSignal)
            {
                var plotData = new LineSeries();
                foreach (var point in points)
                {
                    plotData.Points.Add(point);
                }
                myModel.Series.Add(plotData);

                if (drawHistogram)
                {
                    DrawHistogram(plotData.Points);
                }
            }
       
            plot1.Model = myModel;
        }

        public void Export(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                sw.WriteLine(nameof(PlotController));
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
