using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Plotter : Form
    {
        /// <summary>
        /// Amplituda - określa maksymalną wartość bezwzględną sygnału
        /// </summary>
        public double Amplitude
        {
            get; set;
        }
        /// <summary>
        /// Czas początkowy - czas w którym rozpoczyna się sygnał okresowy
        /// </summary>
        public double InitialTime
        {
            get; set;
        }
        /// <summary>
        /// Czas trwania sygnału
        /// </summary>
        public double TotalTime { get; set; }
        /// <summary>
        /// Okres podstawowy
        /// </summary>
        public double Period { get; set; }
        /// <summary>
        /// Współczynnik wypełnienia - dotyczy sygnały prostokątnego i trójkątnego
        /// </summary>
        public double ImpletionRate
        {
            get; set;
        }
        /// <summary>
        /// Tytuł wykresu
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Czas skoku jednostkowego
        /// </summary>
        public double JumpTime
        {
            get; set;
        }
        /// <summary>
        /// Typ wykresu
        /// </summary>
        public PlotType PlotType { get; set; }

        /// <summary>
        /// Prawdopodobieństwo, dotyczy szumu jednostkowego
        /// </summary>
        public double Probability { get; set; }

        /// <summary>
        /// Liczba przedziałów histogramu
        /// </summary>
        public int RangesAmount { get; set; } = 10;

        private int samplingFrequency = 1000;
        private Equation equation;

        public Plotter()
        {
            InitializeComponent();
            equation = new Equation();
        }

        public void Plot()
        {
            FillEquation();
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
            }
        }

        private void RysujSzumImpulsowy()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            var points = equation.SzumImpulsowy(Amplitude, InitialTime, TotalTime, Probability, samplingFrequency - 990);
            ScatterSeries plotData = new ScatterSeries();
            foreach (DataPoint point in points)
            {
                plotData.Points.Add(new ScatterPoint(point.X, point.Y, 2));
            }
            myModel.Series.Add(plotData);
            plot1.Model = myModel;
        }

        private void RysujImpulsJednostkowy()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            var points = equation.ImpulsJednostkowy(Amplitude, InitialTime, TotalTime, JumpTime, samplingFrequency - 990);
            ScatterSeries plotData = new ScatterSeries();
            foreach (DataPoint point in points)
            {
                plotData.Points.Add(new ScatterPoint(point.X, point.Y, 2));
            }
            myModel.Series.Add(plotData);
            plot1.Model = myModel;
        }

        private void FillEquation()
        {
            equation.Amplitude = Amplitude;
            equation.Period = Period;
            equation.InitialTime = InitialTime;
            equation.ImpletionRate = ImpletionRate;
            equation.JumpTime = JumpTime;
        }

        private void RysujSkokJednostkowy()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            myModel.Series.Add(new FunctionSeries(equation.SkokJednostkowy, InitialTime, InitialTime + TotalTime, 0.001));
            plot1.Model = myModel;
        }

        private void RysujTrojkatny()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            var points = equation.Trojkatny(TotalTime, samplingFrequency, InitialTime, Period, ImpletionRate, Amplitude);
            LineSeries plotData = new LineSeries();
            foreach (DataPoint point in points)
            {
                plotData.Points.Add(point);
            }
            myModel.Series.Add(plotData);
            plot1.Model = myModel;
        }

        private void RysujProstokatnySymetryczny()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            var points = equation.ProstokatnySymetryczny(TotalTime, samplingFrequency, InitialTime, Period, ImpletionRate, Amplitude);
            LineSeries plotData = new LineSeries();
            foreach (DataPoint point in points)
            {
                plotData.Points.Add(point);
            }
            myModel.Series.Add(plotData);
            plot1.Model = myModel;

            Dictionary<Double, Int32> histogramData = GenerateHistogram(plotData.Points);

            PlotModel plotModel = new PlotModel { Title = Title };
            ColumnSeries histogramSeries = new ColumnSeries();
            plotModel.Axes.Add(new CategoryAxis() { Position = AxisPosition.Bottom });
            foreach(double label in histogramData.Keys)
            {
                ((CategoryAxis)plotModel.Axes[0]).ActualLabels.Add(label.ToString());
            }
            plotModel.Axes.Add(new LinearAxis() { Position = AxisPosition.Left });

            foreach (Double y in histogramData.Values)
            {
                histogramSeries.Items.Add(new ColumnItem(y));
            }
            plotModel.Series.Add(histogramSeries);
            histogram.Model = plotModel;
            
        }

        private void RysujProstokatny()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            var points = equation.Prostokatny(TotalTime, samplingFrequency, InitialTime, Period, ImpletionRate, Amplitude);
            LineSeries plotData = new LineSeries();
            foreach (DataPoint point in points)
            {
                plotData.Points.Add(point);
            }
            myModel.Series.Add(plotData);
            plot1.Model = myModel;
        }

        private void RysujSinusoidalnyWyprostowanyDwupolowkowo()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            myModel.Series.Add(new FunctionSeries(equation.SinusWyprostowanyDwupolowkowo, InitialTime, InitialTime + TotalTime, 0.001));
            plot1.Model = myModel;
        }

        private void RysujSinusoidalnyWyprostowanyJednopolowkowo()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            myModel.Series.Add(new FunctionSeries(equation.SinusWyprostowanyJednopolowkowo, InitialTime, InitialTime + TotalTime, 0.001));
            plot1.Model = myModel;
        }

        private void RysujSinusoidalny()
        {

            PlotModel myModel = new PlotModel { Title = Title };
            myModel.Series.Add(new FunctionSeries(equation.Sinus, InitialTime, InitialTime + TotalTime, 0.001));
            plot1.Model = myModel;
        }

        private void RysujSzumGaussowski()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            myModel.Series.Add(new FunctionSeries(equation.SzumGaussowski, InitialTime, InitialTime + TotalTime, 0.001));
            plot1.Model = myModel;
        }

        private void RysujSzumJednostajny()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            myModel.Series.Add(new FunctionSeries(equation.SzumJednostajny, InitialTime, InitialTime + TotalTime, 0.001));
            plot1.Model = myModel;
        }

        Dictionary<Double, Int32> GenerateHistogram(List<DataPoint> dataPoints)
        {
            Dictionary<Double, Int32> h = new Dictionary<Double, Int32> ();
            List<Double> krancePrzedzialow = new List<Double>();
            Double min = dataPoints.Min(x => x.Y), max = dataPoints.Max(x=> x.Y);
            Double A = max - min;
            Double krok = A / RangesAmount;
            for (int i = 0; i < RangesAmount; i++)
            {
                krancePrzedzialow.Add(min + (i * krok));
            }
            krancePrzedzialow.Add(max);

            foreach(double kraniec in krancePrzedzialow)
            {
                int licznik = dataPoints.Where(x => x.Y > kraniec - krok/2 && x.Y < kraniec + krok/2).Count();
                h[kraniec] = licznik;
            }
            return h;
        }
    }
}
