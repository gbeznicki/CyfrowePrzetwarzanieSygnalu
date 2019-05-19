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

        public double samplingFrequency;
        public double initialTime;
        public double finalTime;
        public double period;

        private double averageValue;
        private double absoluteAverageValue;
        private double averagePower;
        private double variance;
        private double rootAveragePower;

        public Plotter()
        {
            InitializeComponent();
            equation = new Equation();
            samplingFrequency = SharedSettings.SamplingFrequency;
            initialTime = SharedSettings.InitialTime;
            finalTime = SharedSettings.InitialTime + SharedSettings.TotalTime;
            period = SharedSettings.Period;
        }



        public void Plot()
        {
            switch (PlotType)
            {
                case PlotType.SzumJednostajny:
                    RysujSzumJednostajny();
                    ObliczWartosci();
                    break;
                case PlotType.SzumGaussowski:
                    RysujSzumGaussowski();
                    ObliczWartosci();
                    break;
                case PlotType.Sinusoidalny:
                    RysujSinusoidalny();
                    ObliczWartosci();
                    break;
                case PlotType.SinusoidalnyWyprostowanyJednopolowkowo:
                    RysujSinusoidalnyWyprostowanyJednopolowkowo();
                    ObliczWartosci();
                    break;
                case PlotType.SinusoidalnyWyprostowanyDwupolowkowo:
                    RysujSinusoidalnyWyprostowanyDwupolowkowo();
                    ObliczWartosci();
                    break;
                case PlotType.Prostokatny:
                    RysujProstokatny();
                    ObliczWartosci();
                    break;
                case PlotType.ProstokatnySymetryczny:
                    RysujProstokatnySymetryczny();
                    ObliczWartosci();
                    break;
                case PlotType.Trojkatny:
                    RysujTrojkatny();
                    ObliczWartosci();
                    break;
                case PlotType.SkokJednostkowy:
                    RysujSkokJednostkowy();
                    ObliczWartosci();
                    break;
                case PlotType.ImpulsJednostkowy:
                    RysujImpulsJednostkowy();
                    ObliczWartosci();
                    break;
                case PlotType.SzumImpulsowy:
                    RysujSzumImpulsowy();
                    ObliczWartosci();
                    break;
                case PlotType.WynikDzialania:
                    Rysuj(dataPoints);
                    ObliczWartosci();
                    break;
            }
        }

        private void ObliczWartosci()
        {
            int howManyPeriods = (int)(SharedSettings.TotalTime / SharedSettings.Period);
            int lenght = (int)(howManyPeriods * SharedSettings.Period * samplingFrequency);

            List<DataPoint> pointsRange = dataPoints.GetRange(0, lenght);

            averageValue = pointsRange.Select(y => y.Y).Sum() / pointsRange.Count;
            absoluteAverageValue = pointsRange.Select(y => y.Y).Sum(x => Math.Abs(x)) / pointsRange.Count;
            variance = pointsRange.Select(y => y.Y).Sum(x => Math.Pow(x - averageValue, 2)) / pointsRange.Count;
            averagePower = pointsRange.Select(y => y.Y).Sum(x => x * x) / pointsRange.Count;
            rootAveragePower = Math.Sqrt(averagePower);

            labelAverage.Text = averageValue.ToString();
            labelAbsoluteAverage.Text = absoluteAverageValue.ToString();
            labelVariance.Text = variance.ToString();
            labelAveragePower.Text = averagePower.ToString();
            labelRootAveragePower.Text = rootAveragePower.ToString();
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
            PlotModel myModel = new PlotModel { Title = Title };

            if (PlotType == PlotType.ImpulsJednostkowy || PlotType == PlotType.SzumImpulsowy)
            {
                ///Rysowanie wykresu punktowego
                ScatterSeries plotData = new ScatterSeries();
                foreach (DataPoint point in points)
                {
                    plotData.Points.Add(new ScatterPoint(point.X, point.Y, 2));
                }
                myModel.Series.Add(plotData);
                plot1.Model = myModel;
            }
            else
            {
                //Rysowanie wykresu liniowego
                LineSeries plotData = new LineSeries();
                foreach (DataPoint point in points)
                {
                    plotData.Points.Add(point);
                }
                myModel.Series.Add(plotData);
                plot1.Model = myModel;
            }


            //Pobranie punktów do histogramu
            Dictionary<Double, Int32> histogramData = GenerateHistogram(points);

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

        public void Export(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                sw.WriteLine(nameof(Plotter));
                sw.WriteLine(initialTime);
                sw.WriteLine(finalTime);
                sw.WriteLine(period);
                sw.WriteLine(samplingFrequency);
                foreach (var y in dataPoints.Select(y => y.Y))
                {
                    sw.Write($"{y} ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Export(folderBrowserDialog1.SelectedPath + "\\" + Title + ".txt");
                MessageBox.Show("Pomyślnie wyeksportowano wykres do pliku");
            }
        }
    }
}
