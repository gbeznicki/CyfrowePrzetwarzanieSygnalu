namespace Zadanie1
{
    partial class SinglePlotOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCurrentPlots = new System.Windows.Forms.ComboBox();
            this.labelPlotToUse = new System.Windows.Forms.Label();
            this.buttonGeneratePlot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCurrentPlots
            // 
            this.comboBoxCurrentPlots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrentPlots.FormattingEnabled = true;
            this.comboBoxCurrentPlots.Location = new System.Drawing.Point(66, 39);
            this.comboBoxCurrentPlots.Name = "comboBoxCurrentPlots";
            this.comboBoxCurrentPlots.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCurrentPlots.TabIndex = 1;
            // 
            // labelPlotToUse
            // 
            this.labelPlotToUse.AutoSize = true;
            this.labelPlotToUse.Location = new System.Drawing.Point(63, 23);
            this.labelPlotToUse.Name = "labelPlotToUse";
            this.labelPlotToUse.Size = new System.Drawing.Size(57, 13);
            this.labelPlotToUse.TabIndex = 3;
            this.labelPlotToUse.Text = "Plot to use";
            // 
            // buttonGeneratePlot
            // 
            this.buttonGeneratePlot.Location = new System.Drawing.Point(109, 80);
            this.buttonGeneratePlot.Name = "buttonGeneratePlot";
            this.buttonGeneratePlot.Size = new System.Drawing.Size(75, 23);
            this.buttonGeneratePlot.TabIndex = 5;
            this.buttonGeneratePlot.Text = "Generate";
            this.buttonGeneratePlot.UseVisualStyleBackColor = true;
            this.buttonGeneratePlot.Click += new System.EventHandler(this.buttonGeneratePlot_Click);
            // 
            // SinglePlotOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 125);
            this.Controls.Add(this.buttonGeneratePlot);
            this.Controls.Add(this.labelPlotToUse);
            this.Controls.Add(this.comboBoxCurrentPlots);
            this.Name = "SinglePlotOperation";
            this.Text = "Single Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCurrentPlots;
        private System.Windows.Forms.Label labelPlotToUse;
        private System.Windows.Forms.Button buttonGeneratePlot;
    }
}