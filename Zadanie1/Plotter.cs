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
            Rysuj(equation.SzumImpulsowy());
        }

        private void RysujImpulsJednostkowy()
        {
            Rysuj(equation.ImpulsJednostkowy());
        }


        private void RysujSkokJednostkowy()
        {
            Rysuj(equation.SkokJednostkowy());
        }

        private void RysujTrojkatny()
        {
            Rysuj(equation.Trojkatny());
        }

        private void RysujProstokatnySymetryczny()
        {
            Rysuj(equation.ProstokatnySymetryczny());
        }

        private void RysujProstokatny()
        {
            Rysuj(equation.Prostokatny());
        }

        private void RysujSinusoidalnyWyprostowanyDwupolowkowo()
        {
            Rysuj(equation.SinusWyprostowanyDwupolowkowo());
        }

        private void RysujSinusoidalnyWyprostowanyJednopolowkowo()
        {
            Rysuj(equation.SinusWyprostowanyJednopolowkowo());
        }

        private void RysujSinusoidalny()
        {
            Rysuj(equation.Sinus());
        }

        private void RysujSzumGaussowski()
        {
            Rysuj(equation.SzumGaussowski());
        }

        private void RysujSzumJednostajny()
        {
            Rysuj(equation.SzumJednostajny());
        }

        private void FillEquation()
        {
            equation.Amplitude = Amplitude;
            equation.Period = Period;
            equation.InitialTime = InitialTime;
            equation.ImpletionRate = ImpletionRate;
            equation.JumpTime = JumpTime;
            equation.Probability = Probability;
            equation.ImpletionRate = ImpletionRate;
            equation.SamplingFrequency = samplingFrequency;
            equation.TotalTime = TotalTime;
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

        private void Rysuj(List<DataPoint> points)
        {
            //Rysowanie wykresu liniowego/punktowego
            PlotModel myModel = new PlotModel { Title = Title };
            LineSeries plotData = new LineSeries();
            foreach (DataPoint point in points)
            {
                plotData.Points.Add(point);
            }
            myModel.Series.Add(plotData);
            plot1.Model = myModel;

            //Pobranie punktów do histogramu
            Dictionary<Double, Int32> histogramData = GenerateHistogram(plotData.Points);

            //Rysowanie histogramu
            PlotModel plotModel = new PlotModel { Title = Title };
            ColumnSeries histogramSeries = new ColumnSeries();
            plotModel.Axes.Add(new CategoryAxis() { Position = AxisPosition.Bottom });
            foreach (double label in histogramData.Keys)
            {
                ((CategoryAxis)plotModel.Axes[0]).ActualLabels.Add(Math.Round(label, 1).ToString());
            }
            plotModel.Axes.Add(new LinearAxis() { Position = AxisPosition.Left });

            foreach (Double y in histogramData.Values)
            {
                histogramSeries.Items.Add(new ColumnItem(y));
            }
            plotModel.Series.Add(histogramSeries);
            histogram.Model = plotModel;
        }
    }
}
