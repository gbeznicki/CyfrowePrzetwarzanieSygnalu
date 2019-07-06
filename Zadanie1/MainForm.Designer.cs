namespace Zadanie1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytajZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodawanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odejmowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnożenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dzielenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szumORozkłJednostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szumGaussowskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sygnałSinusoidalnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sygnałSinJednopWypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ątnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sygProstokątnySymToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sygTrójkątnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skokJednostkowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impulsJednostkowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szumImpulsowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samplingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincReconstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourierTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastOurierTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseFourierTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wykresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseFastFourierTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bladSredniokwadratowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.operacjeToolStripMenuItem,
            this.generujToolStripMenuItem,
            this.aCToolStripMenuItem,
            this.cAToolStripMenuItem,
            this.transformacjaToolStripMenuItem,
            this.mSEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odczytajZPlikuToolStripMenuItem,
            this.ustawieniaToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // odczytajZPlikuToolStripMenuItem
            // 
            this.odczytajZPlikuToolStripMenuItem.Name = "odczytajZPlikuToolStripMenuItem";
            this.odczytajZPlikuToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.odczytajZPlikuToolStripMenuItem.Text = "Import z pliku";
            this.odczytajZPlikuToolStripMenuItem.Click += new System.EventHandler(this.odczytajZPlikuToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodawanieToolStripMenuItem,
            this.odejmowanieToolStripMenuItem,
            this.mnożenieToolStripMenuItem,
            this.dzielenieToolStripMenuItem});
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjeToolStripMenuItem.Text = "Operacja";
            // 
            // dodawanieToolStripMenuItem
            // 
            this.dodawanieToolStripMenuItem.Name = "dodawanieToolStripMenuItem";
            this.dodawanieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dodawanieToolStripMenuItem.Text = "Dodawanie";
            this.dodawanieToolStripMenuItem.Click += new System.EventHandler(this.dodawanieToolStripMenuItem_Click);
            // 
            // odejmowanieToolStripMenuItem
            // 
            this.odejmowanieToolStripMenuItem.Name = "odejmowanieToolStripMenuItem";
            this.odejmowanieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.odejmowanieToolStripMenuItem.Text = "Odejmowanie";
            this.odejmowanieToolStripMenuItem.Click += new System.EventHandler(this.odejmowanieToolStripMenuItem_Click);
            // 
            // mnożenieToolStripMenuItem
            // 
            this.mnożenieToolStripMenuItem.Name = "mnożenieToolStripMenuItem";
            this.mnożenieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.mnożenieToolStripMenuItem.Text = "Mnożenie";
            this.mnożenieToolStripMenuItem.Click += new System.EventHandler(this.mnożenieToolStripMenuItem_Click);
            // 
            // dzielenieToolStripMenuItem
            // 
            this.dzielenieToolStripMenuItem.Name = "dzielenieToolStripMenuItem";
            this.dzielenieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dzielenieToolStripMenuItem.Text = "Dzielenie";
            this.dzielenieToolStripMenuItem.Click += new System.EventHandler(this.dzielenieToolStripMenuItem_Click);
            // 
            // generujToolStripMenuItem
            // 
            this.generujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szumORozkłJednostToolStripMenuItem,
            this.szumGaussowskiToolStripMenuItem,
            this.sygnałSinusoidalnyToolStripMenuItem,
            this.sygnałSinJednopWypToolStripMenuItem,
            this.syToolStripMenuItem,
            this.ątnyToolStripMenuItem,
            this.sygProstokątnySymToolStripMenuItem,
            this.sygTrójkątnyToolStripMenuItem,
            this.skokJednostkowyToolStripMenuItem,
            this.impulsJednostkowyToolStripMenuItem,
            this.szumImpulsowyToolStripMenuItem});
            this.generujToolStripMenuItem.Name = "generujToolStripMenuItem";
            this.generujToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.generujToolStripMenuItem.Text = "Generuj";
            // 
            // szumORozkłJednostToolStripMenuItem
            // 
            this.szumORozkłJednostToolStripMenuItem.Name = "szumORozkłJednostToolStripMenuItem";
            this.szumORozkłJednostToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.szumORozkłJednostToolStripMenuItem.Text = "Szum o rozkł. jednost.";
            this.szumORozkłJednostToolStripMenuItem.Click += new System.EventHandler(this.szumORozkłJednostToolStripMenuItem_Click);
            // 
            // szumGaussowskiToolStripMenuItem
            // 
            this.szumGaussowskiToolStripMenuItem.Name = "szumGaussowskiToolStripMenuItem";
            this.szumGaussowskiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.szumGaussowskiToolStripMenuItem.Text = "Szum gaussowski";
            this.szumGaussowskiToolStripMenuItem.Click += new System.EventHandler(this.szumGaussowskiToolStripMenuItem_Click);
            // 
            // sygnałSinusoidalnyToolStripMenuItem
            // 
            this.sygnałSinusoidalnyToolStripMenuItem.Name = "sygnałSinusoidalnyToolStripMenuItem";
            this.sygnałSinusoidalnyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sygnałSinusoidalnyToolStripMenuItem.Text = "Syg sinusoidalny";
            this.sygnałSinusoidalnyToolStripMenuItem.Click += new System.EventHandler(this.sygnałSinusoidalnyToolStripMenuItem_Click);
            // 
            // sygnałSinJednopWypToolStripMenuItem
            // 
            this.sygnałSinJednopWypToolStripMenuItem.Name = "sygnałSinJednopWypToolStripMenuItem";
            this.sygnałSinJednopWypToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sygnałSinJednopWypToolStripMenuItem.Text = "Syg sin. jednop. wyp";
            this.sygnałSinJednopWypToolStripMenuItem.Click += new System.EventHandler(this.sygnałSinJednopWypToolStripMenuItem_Click);
            // 
            // syToolStripMenuItem
            // 
            this.syToolStripMenuItem.Name = "syToolStripMenuItem";
            this.syToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.syToolStripMenuItem.Text = "Syg sin.  dwup. wyp";
            this.syToolStripMenuItem.Click += new System.EventHandler(this.sygSinusoidalnyWyprostowanyDwupolowkowoToolStripMenuItem_Click);
            // 
            // ątnyToolStripMenuItem
            // 
            this.ątnyToolStripMenuItem.Name = "ątnyToolStripMenuItem";
            this.ątnyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ątnyToolStripMenuItem.Text = "Syg prostokątny";
            this.ątnyToolStripMenuItem.Click += new System.EventHandler(this.sygProstokątnyToolStripMenuItem_Click);
            // 
            // sygProstokątnySymToolStripMenuItem
            // 
            this.sygProstokątnySymToolStripMenuItem.Name = "sygProstokątnySymToolStripMenuItem";
            this.sygProstokątnySymToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sygProstokątnySymToolStripMenuItem.Text = "Syg prostokątny sym.";
            this.sygProstokątnySymToolStripMenuItem.Click += new System.EventHandler(this.sygProstokątnySymToolStripMenuItem_Click);
            // 
            // sygTrójkątnyToolStripMenuItem
            // 
            this.sygTrójkątnyToolStripMenuItem.Name = "sygTrójkątnyToolStripMenuItem";
            this.sygTrójkątnyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sygTrójkątnyToolStripMenuItem.Text = "Syg trójkątny";
            this.sygTrójkątnyToolStripMenuItem.Click += new System.EventHandler(this.sygTrójkątnyToolStripMenuItem_Click);
            // 
            // skokJednostkowyToolStripMenuItem
            // 
            this.skokJednostkowyToolStripMenuItem.Name = "skokJednostkowyToolStripMenuItem";
            this.skokJednostkowyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.skokJednostkowyToolStripMenuItem.Text = "Skok jednostkowy";
            this.skokJednostkowyToolStripMenuItem.Click += new System.EventHandler(this.skokJednostkowyToolStripMenuItem_Click);
            // 
            // impulsJednostkowyToolStripMenuItem
            // 
            this.impulsJednostkowyToolStripMenuItem.Name = "impulsJednostkowyToolStripMenuItem";
            this.impulsJednostkowyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.impulsJednostkowyToolStripMenuItem.Text = "Impuls jednostkowy";
            this.impulsJednostkowyToolStripMenuItem.Click += new System.EventHandler(this.impulsJednostkowyToolStripMenuItem_Click);
            // 
            // szumImpulsowyToolStripMenuItem
            // 
            this.szumImpulsowyToolStripMenuItem.Name = "szumImpulsowyToolStripMenuItem";
            this.szumImpulsowyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.szumImpulsowyToolStripMenuItem.Text = "Szum impulsowy";
            this.szumImpulsowyToolStripMenuItem.Click += new System.EventHandler(this.szumImpulsowyToolStripMenuItem_Click);
            // 
            // aCToolStripMenuItem
            // 
            this.aCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samplingToolStripMenuItem,
            this.quantizationToolStripMenuItem});
            this.aCToolStripMenuItem.Name = "aCToolStripMenuItem";
            this.aCToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aCToolStripMenuItem.Text = "A/C";
            // 
            // samplingToolStripMenuItem
            // 
            this.samplingToolStripMenuItem.Name = "samplingToolStripMenuItem";
            this.samplingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.samplingToolStripMenuItem.Text = "Sampling";
            this.samplingToolStripMenuItem.Click += new System.EventHandler(this.samplingToolStripMenuItem_Click);
            // 
            // quantizationToolStripMenuItem
            // 
            this.quantizationToolStripMenuItem.Name = "quantizationToolStripMenuItem";
            this.quantizationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.quantizationToolStripMenuItem.Text = "Quantization";
            this.quantizationToolStripMenuItem.Click += new System.EventHandler(this.quantizationToolStripMenuItem_Click);
            // 
            // cAToolStripMenuItem
            // 
            this.cAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interpolationToolStripMenuItem,
            this.sincReconstructionToolStripMenuItem});
            this.cAToolStripMenuItem.Name = "cAToolStripMenuItem";
            this.cAToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.cAToolStripMenuItem.Text = "C/A";
            // 
            // interpolationToolStripMenuItem
            // 
            this.interpolationToolStripMenuItem.Name = "interpolationToolStripMenuItem";
            this.interpolationToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.interpolationToolStripMenuItem.Text = "Interpolation";
            this.interpolationToolStripMenuItem.Click += new System.EventHandler(this.interpolationToolStripMenuItem_Click);
            // 
            // sincReconstructionToolStripMenuItem
            // 
            this.sincReconstructionToolStripMenuItem.Name = "sincReconstructionToolStripMenuItem";
            this.sincReconstructionToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.sincReconstructionToolStripMenuItem.Text = "GetSincValue Reconstruction";
            this.sincReconstructionToolStripMenuItem.Click += new System.EventHandler(this.sincReconstructionToolStripMenuItem_Click);
            // 
            // transformacjaToolStripMenuItem
            // 
            this.transformacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourierTransformToolStripMenuItem,
            this.fastOurierTransformToolStripMenuItem,
            this.reverseFourierTransformToolStripMenuItem,
            this.reverseFastFourierTransformToolStripMenuItem});
            this.transformacjaToolStripMenuItem.Name = "transformacjaToolStripMenuItem";
            this.transformacjaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.transformacjaToolStripMenuItem.Text = "Transformacja";
            // 
            // fourierTransformToolStripMenuItem
            // 
            this.fourierTransformToolStripMenuItem.Name = "fourierTransformToolStripMenuItem";
            this.fourierTransformToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.fourierTransformToolStripMenuItem.Text = "Fourier Transform";
            this.fourierTransformToolStripMenuItem.Click += new System.EventHandler(this.fourierTransformToolStripMenuItem_Click);
            // 
            // fastOurierTransformToolStripMenuItem
            // 
            this.fastOurierTransformToolStripMenuItem.Name = "fastOurierTransformToolStripMenuItem";
            this.fastOurierTransformToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.fastOurierTransformToolStripMenuItem.Text = "Fast Fourier Transform";
            this.fastOurierTransformToolStripMenuItem.Click += new System.EventHandler(this.fastOurierTransformToolStripMenuItem_Click);
            // 
            // reverseFourierTransformToolStripMenuItem
            // 
            this.reverseFourierTransformToolStripMenuItem.Name = "reverseFourierTransformToolStripMenuItem";
            this.reverseFourierTransformToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.reverseFourierTransformToolStripMenuItem.Text = "Reverse Fourier Transform";
            this.reverseFourierTransformToolStripMenuItem.Click += new System.EventHandler(this.reverseFourierTransformToolStripMenuItem_Click);
            // 
            // reverseFourierTransformToolStripMenuItem
            // 
            this.reverseFourierTransformToolStripMenuItem.Name = "reverseFourierTransformToolStripMenuItem";
            this.reverseFourierTransformToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reverseFourierTransformToolStripMenuItem.Text = "Reverse Fourier Transform";
            this.reverseFourierTransformToolStripMenuItem.Click += new System.EventHandler(this.reverseFourierTransformToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wykresToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 48);
            // 
            // wykresToolStripMenuItem
            // 
            this.wykresToolStripMenuItem.Name = "wykresToolStripMenuItem";
            this.wykresToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.wykresToolStripMenuItem.Text = "Wykres";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // reverseFastFourierTransformToolStripMenuItem
            // 
            this.reverseFastFourierTransformToolStripMenuItem.Name = "reverseFastFourierTransformToolStripMenuItem";
            this.reverseFastFourierTransformToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.reverseFastFourierTransformToolStripMenuItem.Text = "Reverse Fast Fourier Transform";
            this.reverseFastFourierTransformToolStripMenuItem.Click += new System.EventHandler(this.reverseFastFourierTransformToolStripMenuItem_Click);
            // mSEToolStripMenuItem
            // 
            this.mSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bladSredniokwadratowyToolStripMenuItem});
            this.mSEToolStripMenuItem.Name = "mSEToolStripMenuItem";
            this.mSEToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.mSEToolStripMenuItem.Text = "Błąd";
            // 
            // bladSredniokwadratowyToolStripMenuItem
            // 
            this.bladSredniokwadratowyToolStripMenuItem.Name = "bladSredniokwadratowyToolStripMenuItem";
            this.bladSredniokwadratowyToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bladSredniokwadratowyToolStripMenuItem.Text = "Błąd średniokwadratowy";
            this.bladSredniokwadratowyToolStripMenuItem.Click += new System.EventHandler(this.bladSredniokwadratowyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 578);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytajZPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodawanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odejmowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnożenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dzielenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szumORozkłJednostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szumGaussowskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sygnałSinusoidalnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sygnałSinJednopWypToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ątnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sygProstokątnySymToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sygTrójkątnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skokJednostkowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impulsJednostkowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szumImpulsowyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wykresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem samplingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sincReconstructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourierTransformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastOurierTransformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseFourierTransformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseFastFourierTransformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bladSredniokwadratowyToolStripMenuItem;
    }
}

