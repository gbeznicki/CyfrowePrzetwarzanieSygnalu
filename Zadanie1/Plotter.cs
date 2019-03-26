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
        public double Amplitude { get; set; }
        /// <summary>
        /// Czas początkowy - czas w którym rozpoczyna się sygnał okresowy
        /// </summary>
        public double InitialTime { get; set; }
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
        public double ImpletionRate { get; set; }
        /// <summary>
        /// Tytuł wykresu
        /// </summary>
        public string Title { get; set; }

        private Equation equation;

        public Plotter(PlotType type, string Title, double Amplitude, double InitialTime, double TotalTime, double Period, double ImpletionRate = 0)
        {
            InitializeComponent();
            this.Title = Title;
            this.Amplitude = Amplitude;
            this.InitialTime = InitialTime;
            this.TotalTime = TotalTime;
            this.Period = Period;
            this.ImpletionRate = ImpletionRate;

            equation = new Equation();
            equation.Amplitude = Amplitude;
            equation.Period = Period;
            equation.InitialTime = InitialTime;
            Plot(type);
        }

        private void Plot(PlotType type)
        {
            switch (type)
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
            }
        }

        private void RysujSkokJednostkowy()
        {
            throw new NotImplementedException();
        }

        private void RysujTrojkatny()
        {
            throw new NotImplementedException();
        }

        private void RysujProstokatnySymetryczny()
        {
            throw new NotImplementedException();
        }

        private void RysujProstokatny()
        {
            throw new NotImplementedException();
        }

        private void RysujSinusoidalnyWyprostowanyDwupolowkowo()
        {
            throw new NotImplementedException();
        }

        private void RysujSinusoidalnyWyprostowanyJednopolowkowo()
        {
            throw new NotImplementedException();
        }

        private void RysujSinusoidalny()
        {

            PlotModel myModel = new PlotModel { Title = Title };
            myModel.Series.Add(new FunctionSeries(equation.Sinus,InitialTime, InitialTime+TotalTime, 0.001));
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
