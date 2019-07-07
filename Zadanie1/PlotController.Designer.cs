namespace Zadanie1
{
    partial class PlotController
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
            this.components = new System.ComponentModel.Container();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OryginalnyDystans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObliczonyDystans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roznica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histogram = new OxyPlot.WindowsForms.PlotView();
            this.lowestPlot = new OxyPlot.WindowsForms.PlotView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMeasureValue_3 = new System.Windows.Forms.Label();
            this.labelMeasure_3 = new System.Windows.Forms.Label();
            this.labelMeasureValue_2 = new System.Windows.Forms.Label();
            this.labelMeasure_2 = new System.Windows.Forms.Label();
            this.labelMeasureValue_4 = new System.Windows.Forms.Label();
            this.labelMeasure_4 = new System.Windows.Forms.Label();
            this.labelMeasureValue_1 = new System.Windows.Forms.Label();
            this.labelMeasure_1 = new System.Windows.Forms.Label();
            this.labelMeasureValue_0 = new System.Windows.Forms.Label();
            this.labelMeasure_0 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.antennaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antennaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // plot1
            // 
            this.plot1.BackColor = System.Drawing.Color.Bisque;
            this.plot1.Location = new System.Drawing.Point(0, 0);
            this.plot1.Margin = new System.Windows.Forms.Padding(4);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(849, 253);
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.plot1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.histogram);
            this.splitContainer1.Panel2.Controls.Add(this.lowestPlot);
            this.splitContainer1.Size = new System.Drawing.Size(856, 744);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OryginalnyDystans,
            this.ObliczonyDystans,
            this.Roznica});
            this.dataGridView1.Location = new System.Drawing.Point(860, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(461, 446);
            this.dataGridView1.TabIndex = 1;
            // 
            // OryginalnyDystans
            // 
            this.OryginalnyDystans.HeaderText = "Oryginalny dystans";
            this.OryginalnyDystans.Name = "OryginalnyDystans";
            // 
            // ObliczonyDystans
            // 
            this.ObliczonyDystans.HeaderText = "Obliczony dystans";
            this.ObliczonyDystans.Name = "ObliczonyDystans";
            // 
            // Roznica
            // 
            this.Roznica.HeaderText = "Różnica";
            this.Roznica.Name = "Roznica";
            // 
            // histogram
            // 
            this.histogram.BackColor = System.Drawing.Color.BurlyWood;
            this.histogram.Location = new System.Drawing.Point(4, -8);
            this.histogram.Margin = new System.Windows.Forms.Padding(4);
            this.histogram.Name = "histogram";
            this.histogram.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.histogram.Size = new System.Drawing.Size(849, 237);
            this.histogram.TabIndex = 0;
            this.histogram.Text = "plotView1";
            this.histogram.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.histogram.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.histogram.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // lowestPlot
            // 
            this.lowestPlot.BackColor = System.Drawing.Color.PapayaWhip;
            this.lowestPlot.Location = new System.Drawing.Point(0, 229);
            this.lowestPlot.Name = "lowestPlot";
            this.lowestPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.lowestPlot.Size = new System.Drawing.Size(849, 220);
            this.lowestPlot.TabIndex = 1;
            this.lowestPlot.Text = "plotView1";
            this.lowestPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.lowestPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.lowestPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Wheat;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AccessibleName = "";
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasureValue_3);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasure_3);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasureValue_2);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasure_2);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasureValue_4);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasure_4);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasureValue_1);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasure_1);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasureValue_0);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasure_0);
            this.splitContainer2.Panel2.Tag = "";
            this.splitContainer2.Size = new System.Drawing.Size(1095, 744);
            this.splitContainer2.SplitterDistance = 856;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eksportuj wykres do pliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMeasureValue_3
            // 
            this.labelMeasureValue_3.AutoSize = true;
            this.labelMeasureValue_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_3.Location = new System.Drawing.Point(16, 378);
            this.labelMeasureValue_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasureValue_3.Name = "labelMeasureValue_3";
            this.labelMeasureValue_3.Size = new System.Drawing.Size(75, 20);
            this.labelMeasureValue_3.TabIndex = 9;
            this.labelMeasureValue_3.Text = "wartość";
            // 
            // labelMeasure_3
            // 
            this.labelMeasure_3.AutoSize = true;
            this.labelMeasure_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_3.Location = new System.Drawing.Point(16, 358);
            this.labelMeasure_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasure_3.Name = "labelMeasure_3";
            this.labelMeasure_3.Size = new System.Drawing.Size(89, 20);
            this.labelMeasure_3.TabIndex = 8;
            this.labelMeasure_3.Text = "Wariancja:";
            // 
            // labelMeasureValue_2
            // 
            this.labelMeasureValue_2.AutoSize = true;
            this.labelMeasureValue_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_2.Location = new System.Drawing.Point(16, 273);
            this.labelMeasureValue_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasureValue_2.Name = "labelMeasureValue_2";
            this.labelMeasureValue_2.Size = new System.Drawing.Size(75, 20);
            this.labelMeasureValue_2.TabIndex = 7;
            this.labelMeasureValue_2.Text = "wartość";
            // 
            // labelMeasure_2
            // 
            this.labelMeasure_2.AutoSize = true;
            this.labelMeasure_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_2.Location = new System.Drawing.Point(16, 254);
            this.labelMeasure_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasure_2.Name = "labelMeasure_2";
            this.labelMeasure_2.Size = new System.Drawing.Size(106, 20);
            this.labelMeasure_2.TabIndex = 6;
            this.labelMeasure_2.Text = "Moc średnia:";
            // 
            // labelMeasureValue_4
            // 
            this.labelMeasureValue_4.AutoSize = true;
            this.labelMeasureValue_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_4.Location = new System.Drawing.Point(16, 491);
            this.labelMeasureValue_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasureValue_4.Name = "labelMeasureValue_4";
            this.labelMeasureValue_4.Size = new System.Drawing.Size(75, 20);
            this.labelMeasureValue_4.TabIndex = 5;
            this.labelMeasureValue_4.Text = "wartość";
            // 
            // labelMeasure_4
            // 
            this.labelMeasure_4.AutoSize = true;
            this.labelMeasure_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_4.Location = new System.Drawing.Point(16, 471);
            this.labelMeasure_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasure_4.Name = "labelMeasure_4";
            this.labelMeasure_4.Size = new System.Drawing.Size(158, 20);
            this.labelMeasure_4.TabIndex = 4;
            this.labelMeasure_4.Text = "Wartość skuteczna:";
            // 
            // labelMeasureValue_1
            // 
            this.labelMeasureValue_1.AutoSize = true;
            this.labelMeasureValue_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_1.Location = new System.Drawing.Point(16, 188);
            this.labelMeasureValue_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasureValue_1.Name = "labelMeasureValue_1";
            this.labelMeasureValue_1.Size = new System.Drawing.Size(75, 20);
            this.labelMeasureValue_1.TabIndex = 3;
            this.labelMeasureValue_1.Text = "wartość";
            // 
            // labelMeasure_1
            // 
            this.labelMeasure_1.AutoSize = true;
            this.labelMeasure_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_1.Location = new System.Drawing.Point(16, 169);
            this.labelMeasure_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasure_1.Name = "labelMeasure_1";
            this.labelMeasure_1.Size = new System.Drawing.Size(178, 20);
            this.labelMeasure_1.TabIndex = 2;
            this.labelMeasure_1.Text = "Średnia bezwzględna: ";
            // 
            // labelMeasureValue_0
            // 
            this.labelMeasureValue_0.AutoSize = true;
            this.labelMeasureValue_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_0.Location = new System.Drawing.Point(16, 85);
            this.labelMeasureValue_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasureValue_0.Name = "labelMeasureValue_0";
            this.labelMeasureValue_0.Size = new System.Drawing.Size(75, 20);
            this.labelMeasureValue_0.TabIndex = 1;
            this.labelMeasureValue_0.Text = "wartość";
            // 
            // labelMeasure_0
            // 
            this.labelMeasure_0.AutoSize = true;
            this.labelMeasure_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_0.Location = new System.Drawing.Point(16, 65);
            this.labelMeasure_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasure_0.Name = "labelMeasure_0";
            this.labelMeasure_0.Size = new System.Drawing.Size(76, 20);
            this.labelMeasure_0.TabIndex = 0;
            this.labelMeasure_0.Text = "Średnia: ";
            // 
            // antennaBindingSource
            // 
            this.antennaBindingSource.DataSource = typeof(Zadanie1.Zadanie3.Antenna);
            // 
            // PlotController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 744);
            this.Controls.Add(this.splitContainer2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlotController";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.antennaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private OxyPlot.WindowsForms.PlotView histogram;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelMeasureValue_2;
        private System.Windows.Forms.Label labelMeasure_2;
        private System.Windows.Forms.Label labelMeasureValue_4;
        private System.Windows.Forms.Label labelMeasureValue_1;
        private System.Windows.Forms.Label labelMeasure_1;
        private System.Windows.Forms.Label labelMeasureValue_0;
        private System.Windows.Forms.Label labelMeasure_0;
        private System.Windows.Forms.Label labelMeasureValue_3;
        private System.Windows.Forms.Label labelMeasure_3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelMeasure_4;
        private OxyPlot.WindowsForms.PlotView lowestPlot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource antennaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn OryginalnyDystans;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObliczonyDystans;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roznica;
    }
}