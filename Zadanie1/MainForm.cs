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
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.Sinusoidalny,
                Title = "Sinusoidalny",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void szumORozkłJednostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.SzumJednostajny,
                Title = "Szum Jednostajny",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void szumGaussowskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.SzumGaussowski,
                Title = "Szum Gaussowski",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();

        }

        private void sygnałSinJednopWypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.SinusoidalnyWyprostowanyJednopolowkowo,
                Title = "Sinusoidalny wyprostowany jednopołówkowo",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void sygSinusoidalnyWyprostowanyDwupolowkowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.SinusoidalnyWyprostowanyDwupolowkowo,
                Title = "Sinusoidalny wyprostowany dwupołówkowo",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void sygProstokątnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.Prostokatny,
                Title = "Prostokątny",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void sygProstokątnySymToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.ProstokatnySymetryczny,
                Title = "Prostokątny Symetryczny",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void sygTrójkątnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.Trojkatny,
                Title = "Trójkątny",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void skokJednostkowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.SkokJednostkowy,
                Title = "Skok Jednostkowy",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void impulsJednostkowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.ImpulsJednostkowy,
                Title = "Impuls Jednostkowy",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();

        }

        private void szumImpulsowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotController plotController = new PlotController()
            {
                PlotType = PlotType.SzumImpulsowy,
                Title = "Szum Impulsowy",
            };
            plotController.DrawPlot();
            // Set the Parent Form of the Child window.  
            plotController.MdiParent = this;
            // Display the new form.  
            plotController.Show();
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PlotController> plotters = new List<PlotController>();
            foreach(PlotController p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Adding, plotters);
            operation.ShowDialog();
            PlotController plotController = operation.Result;
            if(plotController != null)
            {
                plotController.PlotType = PlotType.WynikDzialania;
                plotController.DrawPlot();
                plotController.MdiParent = this;
                plotController.Show();
            }
        }

        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PlotController> plotters = new List<PlotController>();
            foreach (PlotController p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Substracting, plotters);
            operation.ShowDialog();
            PlotController plotController = operation.Result;
            if (plotController != null)
            {
                plotController.PlotType = PlotType.WynikDzialania;
                plotController.DrawPlot();
                plotController.MdiParent = this;
                plotController.Show();
            }
        }

        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PlotController> plotters = new List<PlotController>();
            foreach (PlotController p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Multiplying, plotters);
            operation.ShowDialog();
            PlotController plotController = operation.Result;
            if (plotController != null)
            {
                plotController.PlotType = PlotType.WynikDzialania;
                plotController.DrawPlot();
                plotController.MdiParent = this;
                plotController.Show();
            }

        }

        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PlotController> plotters = new List<PlotController>();
            foreach (PlotController p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Dividing, plotters);
            operation.ShowDialog();
            PlotController plotController = operation.Result;
            if (plotController != null)
            {
                plotController.PlotType = PlotType.WynikDzialania;
                plotController.DrawPlot();
                plotController.MdiParent = this;
                plotController.Show();
            }

        }

        private void odczytajZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PlotController plotController = Import(openFileDialog.FileName);
                if (plotController != null)
                {
                    plotController.PlotType = PlotType.WynikDzialania;
                    plotController.DrawPlot();
                    plotController.MdiParent = this;
                    plotController.Show();
                }
            }
        }

        private PlotController Import(string path)
        {
            PlotController plotController;
            using (var sr = new StreamReader(path))
            {
                var type = sr.ReadLine();
                switch (type)
                {
                    case nameof(PlotController):
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

                        plotController = new PlotController() { Title = "zaimportowany" };
                        plotController.DataPoints = resultPoints;
                        break;
                    default:
                        plotController = null;
                        break;
                }
            }

            return plotController;
        }

        private void samplingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currPlotters = MdiChildren.Cast<PlotController>().ToList();
            var operation = new SinglePlotOperation(currPlotters, SinglePlotOperationType.Sampling);
            operation.ShowDialog();
            var plotController = operation.Result;
            if (plotController != null)
            {
                plotController.PlotType = PlotType.Sampling;
                plotController.DrawPlot();
                plotController.MdiParent = this;
                plotController.Show();
            }
        }

        private void quantizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currPlotters = MdiChildren.Cast<PlotController>().ToList();
            var operation = new SinglePlotOperation(currPlotters, SinglePlotOperationType.Quantization);
            operation.ShowDialog();
            var plotController = operation.Result;
            if (plotController != null)
            {
                plotController.PlotType = PlotType.Quantization;
                plotController.DrawPlot();
                plotController.MdiParent = this;
                plotController.Show();
            }
        }

        private void interpolationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currPlotters = MdiChildren.Cast<PlotController>().ToList();
            var operation = new SinglePlotOperation(currPlotters, SinglePlotOperationType.Interpolation);
            operation.ShowDialog();
            var plotController = operation.Result;
            if (plotController != null)
            {
                plotController.PlotType = PlotType.Interpolation;
                plotController.DrawPlot();
                plotController.MdiParent = this;
                plotController.Show();
            }
        }

        private void sincReconstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currPlotters = MdiChildren.Cast<PlotController>().ToList();
            var operation = new SinglePlotOperation(currPlotters, SinglePlotOperationType.SincReconstruction);
            operation.ShowDialog();
            var plotController = operation.Result;
            if (plotController != null)
            {
                plotController.PlotType = PlotType.SincReconstruction;
                plotController.DrawPlot();
                plotController.MdiParent = this;
                plotController.Show();
            }
        }
    }
}
