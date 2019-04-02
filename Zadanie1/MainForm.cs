using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Plotter newMDIChild = new Plotter(PlotType.Sinusoidalny, "Sinus", 10, 0, 10,5);
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void szumORozkłJednostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter newMDIChild = new Plotter(PlotType.SzumJednostajny, "Szum Jednostajny", 10.5, 0.5, 10.1, 0);
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void szumGaussowskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter newMDIChild = new Plotter(PlotType.SzumGaussowski, "Szum Gaussowski", 10.5, 0.5, 10.1, 0);
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();

        }

        private void sygnałSinJednopWypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter newMDIChild = new Plotter(PlotType.SinusoidalnyWyprostowanyJednopolowkowo, "Sinusoidalny wyprostowany jednopołówkowo", 10, 0, 10, 5);
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void sygSinusoidalnyWyprostowanyDwupolowkowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter newMDIChild = new Plotter(PlotType.SinusoidalnyWyprostowanyDwupolowkowo, "Sinusoidalny wyprostowany dwupołówkowo", 10, 0, 10, 5);
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void sygProstokątnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter newMDIChild = new Plotter(PlotType.Prostokatny, "Prostokątny", 5, 0, 10, 1, 0.7);
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void sygProstokątnySymToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter newMDIChild = new Plotter(PlotType.ProstokatnySymetryczny, "Prostokątny Symetryczny", 5, 0, 10, 1, 0.7);
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }
    }
}
