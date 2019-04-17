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
        /// Tytuł wykresu
        /// </summary>
        public string Title { get { return _title; } set { _title = value; } }
        private string _title;
        /// <summary>
        /// Czas skoku jednostkowego
        /// </summary>
        /// <summary>
        /// Typ wykresu
        /// </summary>
        public PlotType PlotType { get; set; }

        private Equation equation;

        public List<DataPoint> dataPoints;

        private static int counter;

        public Plotter()
        {
            InitializeComponent();
            equation = new Equation();
            counter++;
        }



        public void Plot()
        {
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
            dataPoints = equation.SzumImpulsowy();
        }

        private void RysujImpulsJednostkowy()
        {
            Rysuj(equation.ImpulsJednostkowy());
            dataPoints = equation.ImpulsJednostkowy();
        }


        private void RysujSkokJednostkowy()
        {
            Rysuj(equation.SkokJednostkowy());
            dataPoints = equation.SkokJednostkowy();
        }

        private void RysujTrojkatny()
        {
            Rysuj(equation.Trojkatny());
            dataPoints = equation.Trojkatny();
        }

        private void RysujProstokatnySymetryczny()
        {
            Rysuj(equation.ProstokatnySymetryczny());
            dataPoints = equation.ProstokatnySymetryczny();
        }

        private void RysujProstokatny()
        {
            Rysuj(equation.Prostokatny());
            dataPoints = equation.Prostokatny();
        }

        private void RysujSinusoidalnyWyprostowanyDwupolowkowo()
        {
            Rysuj(equation.SinusWyprostowanyDwupolowkowo());
            dataPoints = equation.SinusWyprostowanyDwupolowkowo();
        }

        private void RysujSinusoidalnyWyprostowanyJednopolowkowo()
        {
            Rysuj(equation.SinusWyprostowanyJednopolowkowo());
            dataPoints = equation.SinusWyprostowanyJednopolowkowo();
        }

        private void RysujSinusoidalny()
        {
            Rysuj(equation.Sinus());
            dataPoints = equation.Sinus();
        }

        private void RysujSzumGaussowski()
        {
            Rysuj(equation.SzumGaussowski());
            dataPoints = equation.SzumGaussowski();
        }

        private void RysujSzumJednostajny()
        {
            Rysuj(equation.SzumJednostajny());
            dataPoints = equation.SzumJednostajny();
        }

        Dictionary<Double, Int32> GenerateHistogram(List<DataPoint> dataPoints)
        {
            Dictionary<Double, Int32> h = new Dictionary<Double, Int32>();
            List<Double> krancePrzedzialow = new List<Double>();
            Double min = dataPoints.Min(x => x.Y), max = dataPoints.Max(x => x.Y);
            Double A = max - min;
            Double krok = A / SharedSettings.RangesAmount;
            for (int i = 0; i < SharedSettings.RangesAmount; i++)
            {
                krancePrzedzialow.Add(min + (i * krok));
            }
            krancePrzedzialow.Add(max);

            foreach (double kraniec in krancePrzedzialow)
            {
                int licznik = dataPoints.Where(x => x.Y > kraniec - krok / 2 && x.Y < kraniec + krok / 2).Count();
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

        private void Plotter_FormClosing(object sender, FormClosingEventArgs e)
        {
            counter--;
        }

        public override string ToString()
        {
            return String.Format("{0} + {1}", Title, counter);
        }
    }
}
