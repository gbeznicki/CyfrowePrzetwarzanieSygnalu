using OxyPlot;
using OxyPlot.Series;
using System;
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
            throw new NotImplementedException();
        }

        private void RysujImpulsJednostkowy()
        {
            throw new NotImplementedException();
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
            var points = equation.Trojkatny(TotalTime, 1000, InitialTime, Period, ImpletionRate, Amplitude);
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
            var points = equation.ProstokatnySymetryczny(TotalTime, 1000, InitialTime, Period, ImpletionRate, Amplitude);
            LineSeries plotData = new LineSeries();
            foreach (DataPoint point in points)
            {
                plotData.Points.Add(point);
            }
            myModel.Series.Add(plotData);
            plot1.Model = myModel;
        }

        private void RysujProstokatny()
        {
            PlotModel myModel = new PlotModel { Title = Title };
            var points = equation.Prostokatny(TotalTime, 1000, InitialTime, Period, ImpletionRate, Amplitude);
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
    }
}
