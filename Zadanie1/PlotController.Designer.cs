﻿namespace Zadanie1
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
            this.upperPlot = new OxyPlot.WindowsForms.PlotView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lowerPlot = new OxyPlot.WindowsForms.PlotView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelMeasureValue_Time = new System.Windows.Forms.Label();
            this.labelMeasure_Time = new System.Windows.Forms.Label();
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
            // upperPlot
            // 
            this.upperPlot.BackColor = System.Drawing.Color.Bisque;
            this.upperPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperPlot.Location = new System.Drawing.Point(0, 0);
            this.upperPlot.Name = "upperPlot";
            this.upperPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.upperPlot.Size = new System.Drawing.Size(617, 185);
            this.upperPlot.TabIndex = 0;
            this.upperPlot.Text = "plotView1";
            this.upperPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.upperPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.upperPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
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
            this.splitContainer1.Panel1.Controls.Add(this.upperPlot);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lowerPlot);
            this.splitContainer1.Size = new System.Drawing.Size(617, 450);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 1;
            // 
            // lowerPlot
            // 
            this.lowerPlot.BackColor = System.Drawing.Color.Wheat;
            this.lowerPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerPlot.Location = new System.Drawing.Point(0, 0);
            this.lowerPlot.Name = "lowerPlot";
            this.lowerPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.lowerPlot.Size = new System.Drawing.Size(617, 261);
            this.lowerPlot.TabIndex = 0;
            this.lowerPlot.Text = "plotView1";
            this.lowerPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.lowerPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.lowerPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Wheat;
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
            this.splitContainer2.Panel2.AccessibleName = "";
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasureValue_Time);
            this.splitContainer2.Panel2.Controls.Add(this.labelMeasure_Time);
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
            this.splitContainer2.Size = new System.Drawing.Size(788, 450);
            this.splitContainer2.SplitterDistance = 617;
            this.splitContainer2.TabIndex = 2;
            // 
            // labelMeasureValue_Time
            // 
            this.labelMeasureValue_Time.AutoSize = true;
            this.labelMeasureValue_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_Time.Location = new System.Drawing.Point(12, 45);
            this.labelMeasureValue_Time.Name = "labelMeasureValue_Time";
            this.labelMeasureValue_Time.Size = new System.Drawing.Size(61, 16);
            this.labelMeasureValue_Time.TabIndex = 11;
            this.labelMeasureValue_Time.Text = "wartość";
            // 
            // labelMeasure_Time
            // 
            this.labelMeasure_Time.AutoSize = true;
            this.labelMeasure_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_Time.Location = new System.Drawing.Point(12, 29);
            this.labelMeasure_Time.Name = "labelMeasure_Time";
            this.labelMeasure_Time.Size = new System.Drawing.Size(97, 16);
            this.labelMeasure_Time.TabIndex = 10;
            this.labelMeasure_Time.Text = "Czas obliczeń: ";
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
            // labelMeasureValue_3
            // 
            this.labelMeasureValue_3.AutoSize = true;
            this.labelMeasureValue_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_3.Location = new System.Drawing.Point(12, 307);
            this.labelMeasureValue_3.Name = "labelMeasureValue_3";
            this.labelMeasureValue_3.Size = new System.Drawing.Size(61, 16);
            this.labelMeasureValue_3.TabIndex = 9;
            this.labelMeasureValue_3.Text = "wartość";
            // 
            // labelMeasure_3
            // 
            this.labelMeasure_3.AutoSize = true;
            this.labelMeasure_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_3.Location = new System.Drawing.Point(12, 291);
            this.labelMeasure_3.Name = "labelMeasure_3";
            this.labelMeasure_3.Size = new System.Drawing.Size(72, 16);
            this.labelMeasure_3.TabIndex = 8;
            this.labelMeasure_3.Text = "Wariancja:";
            // 
            // labelMeasureValue_2
            // 
            this.labelMeasureValue_2.AutoSize = true;
            this.labelMeasureValue_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_2.Location = new System.Drawing.Point(12, 222);
            this.labelMeasureValue_2.Name = "labelMeasureValue_2";
            this.labelMeasureValue_2.Size = new System.Drawing.Size(61, 16);
            this.labelMeasureValue_2.TabIndex = 7;
            this.labelMeasureValue_2.Text = "wartość";
            // 
            // labelMeasure_2
            // 
            this.labelMeasure_2.AutoSize = true;
            this.labelMeasure_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_2.Location = new System.Drawing.Point(12, 206);
            this.labelMeasure_2.Name = "labelMeasure_2";
            this.labelMeasure_2.Size = new System.Drawing.Size(85, 16);
            this.labelMeasure_2.TabIndex = 6;
            this.labelMeasure_2.Text = "Moc średnia:";
            // 
            // labelMeasureValue_4
            // 
            this.labelMeasureValue_4.AutoSize = true;
            this.labelMeasureValue_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_4.Location = new System.Drawing.Point(12, 399);
            this.labelMeasureValue_4.Name = "labelMeasureValue_4";
            this.labelMeasureValue_4.Size = new System.Drawing.Size(61, 16);
            this.labelMeasureValue_4.TabIndex = 5;
            this.labelMeasureValue_4.Text = "wartość";
            // 
            // labelMeasure_4
            // 
            this.labelMeasure_4.AutoSize = true;
            this.labelMeasure_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_4.Location = new System.Drawing.Point(12, 383);
            this.labelMeasure_4.Name = "labelMeasure_4";
            this.labelMeasure_4.Size = new System.Drawing.Size(124, 16);
            this.labelMeasure_4.TabIndex = 4;
            this.labelMeasure_4.Text = "Wartość skuteczna:";
            // 
            // labelMeasureValue_1
            // 
            this.labelMeasureValue_1.AutoSize = true;
            this.labelMeasureValue_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_1.Location = new System.Drawing.Point(12, 153);
            this.labelMeasureValue_1.Name = "labelMeasureValue_1";
            this.labelMeasureValue_1.Size = new System.Drawing.Size(61, 16);
            this.labelMeasureValue_1.TabIndex = 3;
            this.labelMeasureValue_1.Text = "wartość";
            // 
            // labelMeasure_1
            // 
            this.labelMeasure_1.AutoSize = true;
            this.labelMeasure_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_1.Location = new System.Drawing.Point(12, 137);
            this.labelMeasure_1.Name = "labelMeasure_1";
            this.labelMeasure_1.Size = new System.Drawing.Size(143, 16);
            this.labelMeasure_1.TabIndex = 2;
            this.labelMeasure_1.Text = "Średnia bezwzględna: ";
            // 
            // labelMeasureValue_0
            // 
            this.labelMeasureValue_0.AutoSize = true;
            this.labelMeasureValue_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasureValue_0.Location = new System.Drawing.Point(12, 97);
            this.labelMeasureValue_0.Name = "labelMeasureValue_0";
            this.labelMeasureValue_0.Size = new System.Drawing.Size(61, 16);
            this.labelMeasureValue_0.TabIndex = 1;
            this.labelMeasureValue_0.Text = "wartość";
            // 
            // labelMeasure_0
            // 
            this.labelMeasure_0.AutoSize = true;
            this.labelMeasure_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeasure_0.Location = new System.Drawing.Point(12, 81);
            this.labelMeasure_0.Name = "labelMeasure_0";
            this.labelMeasure_0.Size = new System.Drawing.Size(61, 16);
            this.labelMeasure_0.TabIndex = 0;
            this.labelMeasure_0.Text = "Średnia: ";
            // 
            // PlotController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.splitContainer2);
            this.Name = "PlotController";
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

        private OxyPlot.WindowsForms.PlotView upperPlot;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private OxyPlot.WindowsForms.PlotView lowerPlot;
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
        private System.Windows.Forms.Label labelMeasureValue_Time;
        private System.Windows.Forms.Label labelMeasure_Time;
    }
}