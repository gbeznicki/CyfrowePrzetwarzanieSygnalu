namespace Zadanie1
{
    partial class Plotter
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
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.histogram = new OxyPlot.WindowsForms.PlotView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelVariance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAveragePower = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRootAveragePower = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAbsoluteAverage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot1
            // 
            this.plot1.BackColor = System.Drawing.Color.Bisque;
            this.plot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot1.Location = new System.Drawing.Point(0, 0);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(617, 185);
            this.plot1.TabIndex = 0;
            this.plot1.Text = "plotView1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.plot1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.histogram);
            this.splitContainer1.Size = new System.Drawing.Size(617, 450);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 1;
            // 
            // histogram
            // 
            this.histogram.BackColor = System.Drawing.Color.PaleGreen;
            this.histogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogram.Location = new System.Drawing.Point(0, 0);
            this.histogram.Name = "histogram";
            this.histogram.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.histogram.Size = new System.Drawing.Size(617, 261);
            this.histogram.TabIndex = 0;
            this.histogram.Text = "plotView1";
            this.histogram.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.histogram.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.histogram.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.labelVariance);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.labelAveragePower);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.labelRootAveragePower);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.labelAbsoluteAverage);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.labelAverage);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(788, 450);
            this.splitContainer2.SplitterDistance = 617;
            this.splitContainer2.TabIndex = 2;
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVariance.Location = new System.Drawing.Point(55, 313);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(54, 16);
            this.labelVariance.TabIndex = 9;
            this.labelVariance.Text = "wartość";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Wariancja:";
            // 
            // labelAveragePower
            // 
            this.labelAveragePower.AutoSize = true;
            this.labelAveragePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAveragePower.Location = new System.Drawing.Point(55, 228);
            this.labelAveragePower.Name = "labelAveragePower";
            this.labelAveragePower.Size = new System.Drawing.Size(54, 16);
            this.labelAveragePower.TabIndex = 7;
            this.labelAveragePower.Text = "wartość";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Moc średnia:";
            // 
            // labelRootAveragePower
            // 
            this.labelRootAveragePower.AutoSize = true;
            this.labelRootAveragePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRootAveragePower.Location = new System.Drawing.Point(55, 412);
            this.labelRootAveragePower.Name = "labelRootAveragePower";
            this.labelRootAveragePower.Size = new System.Drawing.Size(54, 16);
            this.labelRootAveragePower.TabIndex = 5;
            this.labelRootAveragePower.Text = "wartość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Wartość skuteczna:";
            // 
            // labelAbsoluteAverage
            // 
            this.labelAbsoluteAverage.AutoSize = true;
            this.labelAbsoluteAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAbsoluteAverage.Location = new System.Drawing.Point(55, 159);
            this.labelAbsoluteAverage.Name = "labelAbsoluteAverage";
            this.labelAbsoluteAverage.Size = new System.Drawing.Size(54, 16);
            this.labelAbsoluteAverage.TabIndex = 3;
            this.labelAbsoluteAverage.Text = "wartość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Średnia bezwzględna: ";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAverage.Location = new System.Drawing.Point(55, 75);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(54, 16);
            this.labelAverage.TabIndex = 1;
            this.labelAverage.Text = "wartość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Średnia: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eksportuj wykres do pliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Plotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Plotter";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private OxyPlot.WindowsForms.PlotView histogram;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelAveragePower;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRootAveragePower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAbsoluteAverage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}