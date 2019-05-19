using OxyPlot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sygnałSinusoidalnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.Sinusoidalny,
                Title = "Sinusoidalny",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void szumORozkłJednostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.SzumJednostajny,
                Title = "Szum Jednostajny",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void szumGaussowskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.SzumGaussowski,
                Title = "Szum Gaussowski",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();

        }

        private void sygnałSinJednopWypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.SinusoidalnyWyprostowanyJednopolowkowo,
                Title = "Sinusoidalny wyprostowany jednopołówkowo",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void sygSinusoidalnyWyprostowanyDwupolowkowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.SinusoidalnyWyprostowanyDwupolowkowo,
                Title = "Sinusoidalny wyprostowany dwupołówkowo",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void sygProstokątnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.Prostokatny,
                Title = "Prostokątny",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void sygProstokątnySymToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.ProstokatnySymetryczny,
                Title = "Prostokątny Symetryczny",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void sygTrójkątnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.Trojkatny,
                Title = "Trójkątny",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void skokJednostkowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.SkokJednostkowy,
                Title = "Skok Jednostkowy",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void impulsJednostkowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.ImpulsJednostkowy,
                Title = "Impuls Jednostkowy",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();

        }

        private void szumImpulsowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.SzumImpulsowy,
                Title = "Szum Impulsowy",
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Plotter> plotters = new List<Plotter>();
            foreach(Plotter p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Adding, plotters);
            operation.ShowDialog();
            Plotter plotter = operation.result;
            if(plotter != null)
            {
                plotter.PlotType = PlotType.WynikDzialania;
                plotter.Plot();
                plotter.MdiParent = this;
                plotter.Show();
            }
        }

        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Plotter> plotters = new List<Plotter>();
            foreach (Plotter p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Substracting, plotters);
            operation.ShowDialog();
            Plotter plotter = operation.result;
            if (plotter != null)
            {
                plotter.PlotType = PlotType.WynikDzialania;
                plotter.Plot();
                plotter.MdiParent = this;
                plotter.Show();
            }
        }

        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Plotter> plotters = new List<Plotter>();
            foreach (Plotter p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Multiplying, plotters);
            operation.ShowDialog();
            Plotter plotter = operation.result;
            if (plotter != null)
            {
                plotter.PlotType = PlotType.WynikDzialania;
                plotter.Plot();
                plotter.MdiParent = this;
                plotter.Show();
            }

        }

        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Plotter> plotters = new List<Plotter>();
            foreach (Plotter p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Dividing, plotters);
            operation.ShowDialog();
            Plotter plotter = operation.result;
            if (plotter != null)
            {
                plotter.PlotType = PlotType.WynikDzialania;
                plotter.Plot();
                plotter.MdiParent = this;
                plotter.Show();
            }

        }

        private void odczytajZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Plotter plotter = Import(openFileDialog.FileName);
                if (plotter != null)
                {
                    plotter.PlotType = PlotType.WynikDzialania;
                    plotter.Plot();
                    plotter.MdiParent = this;
                    plotter.Show();
                }
            }
        }

        private Plotter Import(string path)
        {
            Plotter plotter;
            using (var sr = new StreamReader(path))
            {
                var type = sr.ReadLine();
                switch (type)
                {
                    case nameof(Plotter):
                        double.TryParse(sr.ReadLine(), out var initialTime);
                        double.TryParse(sr.ReadLine(), out var finalTime);
                        double? period;
                        if (!double.TryParse(sr.ReadLine(), out var p))
                        {
                            period = null;
                        }
                        else
                        {
                            period = p;
                        }

                        double.TryParse(sr.ReadLine(), out var samplingFrequency);
                        List<double> amplitudes = sr.ReadLine()?.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                        List<double> resultTime = new List<double>();
                        for (double i = initialTime; i < finalTime; i += 1.0 / samplingFrequency)
                        {
                            resultTime.Add(i);
                        }

                        List<DataPoint> resultPoints = new List<DataPoint>();
                        for (int i = 0; i < amplitudes.Count; i++)
                        {
                            resultPoints.Add(new DataPoint(resultTime[i], amplitudes[i]));
                        }

                        plotter = new Plotter() { Title = "zaimportowany" };
                        plotter.dataPoints = resultPoints;
                        break;
                    default:
                        plotter = null;
                        break;
                }
            }

            return plotter;
        }
    }
}
