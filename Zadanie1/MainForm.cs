using System;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public double Amplitude { get; set; }
        public double InitialTime { get; set; }
        public double TotalTime { get; set; }
        public double Period { get; set; }
        public double ImpletionRate { get; set; }

        private void sygnałSinusoidalnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter plotter = new Plotter()
            {
                PlotType = PlotType.Sinusoidalny,
                Title = "Sinusoidalny",
                Amplitude = 10,
                InitialTime = 0,
                TotalTime = 10,
                Period = 5
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
                Amplitude = 10,
                InitialTime = 0,
                TotalTime = 10,
                Period = 0
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
                Amplitude = 10,
                InitialTime = 0,
                TotalTime = 10,
                Period = 0
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
                Amplitude = 10,
                InitialTime = 0,
                TotalTime = 10,
                Period = 5
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
                Amplitude = 10,
                InitialTime = 0,
                TotalTime = 10,
                Period = 5
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
                Amplitude = 5,
                InitialTime = 0,
                TotalTime = 10,
                Period = 1,
                ImpletionRate = 0.7
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
                Amplitude = 5,
                InitialTime = 0,
                TotalTime = 10,
                Period = 1,
                ImpletionRate = 0.7
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
                Amplitude = 5,
                InitialTime = 0,
                TotalTime = 10,
                Period = 1,
                ImpletionRate = 0.7
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
                Amplitude = 5,
                InitialTime = 0,
                TotalTime = 10,
                Period = 1,
                ImpletionRate = 0.7,
                JumpTime = 6
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
                Amplitude = 5,
                InitialTime = 0,
                TotalTime = 10,
                Period = 1,
                JumpTime = 6
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
                Amplitude = 5,
                InitialTime = 0,
                TotalTime = 10,
                Period = 1,
                JumpTime = 6,
                Probability = 0.10
            };
            plotter.Plot();
            // Set the Parent Form of the Child window.  
            plotter.MdiParent = this;
            // Display the new form.  
            plotter.Show();
        }
    }
}
