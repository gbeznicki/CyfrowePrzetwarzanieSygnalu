using System;
using System.Collections.Generic;
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
                //PlotType.ProstokatnySymetryczny, "Prostokątny Symetryczny", 5, 0, 10, 1, 0.7
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

        //private void zapiszDoPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ((Plotter)ActiveMdiChild).Equation.
        //}

        private void odczytajZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Plotter> plotters = new List<Plotter>();
            foreach(Plotter p in MdiChildren)
            {
                plotters.Add(p);
            }

            Operation operation = new Operation(OperationType.Adding, plotters);
            operation.Show();
        }
    }
}
