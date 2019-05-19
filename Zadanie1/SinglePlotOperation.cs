using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class SinglePlotOperation : Form
    {
        public PlotController Result { get; private set; }

        private readonly SinglePlotOperationType singlePlotOperationType;

        public SinglePlotOperation(List<PlotController> currentlyDrawnPlots, SinglePlotOperationType operationType)
        {
            InitializeComponent();
            singlePlotOperationType = operationType;

            comboBoxCurrentPlots.DataSource = currentlyDrawnPlots.Where(p =>
                p.PlotType != PlotType.Quantization &&
                p.PlotType != PlotType.Sampling &&
                p.PlotType != PlotType.SincReconstruction &&
                p.PlotType != PlotType.Interpolation).ToList();
            comboBoxCurrentPlots.DisplayMember = "Title";
        }

        private void buttonGeneratePlot_Click(object sender, System.EventArgs e)
        {
            var selectedItem = comboBoxCurrentPlots.SelectedItem;
            if (selectedItem != null)
            {
                if (!(selectedItem is PlotController selectedPlot))
                {
                    Close();
                    return;
                }

                Result = new PlotController
                {
                    Title = singlePlotOperationType.ToString(),
                    DataPoints = selectedPlot.DataPoints,
                    InitialTime = selectedPlot.InitialTime,
                    FinalTime = selectedPlot.FinalTime,
                    SamplingFrequency = selectedPlot.SamplingFrequency
                };
            }
            Close();
        }
    }
}
