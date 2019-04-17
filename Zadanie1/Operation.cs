using System.Collections.Generic;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Operation : Form
    {
        private List<Plotter> plots;
        private OperationType operationType;

        public Operation(OperationType operationType, List<Plotter> plots)
        {
            InitializeComponent();
            this.plots = plots;
            this.operationType = operationType;
            comboBoxLeft.DataSource = plots;
            comboBoxLeft.DisplayMember = "Title";
            comboBoxRight.DataSource = plots;
            comboBoxRight.DisplayMember = "Title";

            switch (operationType)
            {
                case OperationType.Adding:
                    label1.Text = "Składnik";
                    label2.Text = "Składnik";
                    button1.Text = "Dodaj";
                    break;
                case OperationType.Substracting:
                    label1.Text = "Odjemna";
                    label2.Text = "Odjemnik";
                    button1.Text = "Odejmij";
                    break;
                case OperationType.Multiplying:
                    label1.Text = "Czynnik";
                    label2.Text = "Czynnik";
                    button1.Text = "Pomnóż";
                    break;
                case OperationType.Dividing:
                    label1.Text = "Dzielna";
                    label2.Text = "Dzielnik";
                    button1.Text = "Podziel";
                    break;
            }
        }

        private void Add() { }

        private void Substract() { }

        private void Multiply() { }

        private void Divide() { }
    }
}
