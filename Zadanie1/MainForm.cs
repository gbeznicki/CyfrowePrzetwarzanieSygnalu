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

        private void sygnałSinusoidalnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter newMDIChild = new Plotter(PlotType.Sinusoidalny, "Sinus", 0, 0, 10,0);
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
    }
}
