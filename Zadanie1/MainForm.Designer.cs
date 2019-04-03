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
            this.zapiszDoPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytajZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wykresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.operacjeToolStripMenuItem,
            this.generujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszDoPlikuToolStripMenuItem,
            this.odczytajZPlikuToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszDoPlikuToolStripMenuItem
            // 
            this.zapiszDoPlikuToolStripMenuItem.Name = "zapiszDoPlikuToolStripMenuItem";
            this.zapiszDoPlikuToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.zapiszDoPlikuToolStripMenuItem.Text = "Zapisz do pliku";
            // 
            // odczytajZPlikuToolStripMenuItem
            // 
            this.odczytajZPlikuToolStripMenuItem.Name = "odczytajZPlikuToolStripMenuItem";
            this.odczytajZPlikuToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.odczytajZPlikuToolStripMenuItem.Text = "Odczytaj z pliku";
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
            // 
            // odejmowanieToolStripMenuItem
            // 
            this.odejmowanieToolStripMenuItem.Name = "odejmowanieToolStripMenuItem";
            this.odejmowanieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.odejmowanieToolStripMenuItem.Text = "Odejmowanie";
            // 
            // mnożenieToolStripMenuItem
            // 
            this.mnożenieToolStripMenuItem.Name = "mnożenieToolStripMenuItem";
            this.mnożenieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.mnożenieToolStripMenuItem.Text = "Mnożenie";
            // 
            // dzielenieToolStripMenuItem
            // 
            this.dzielenieToolStripMenuItem.Name = "dzielenieToolStripMenuItem";
            this.dzielenieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dzielenieToolStripMenuItem.Text = "Dzielenie";
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
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 554);
            this.listBox1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 578);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPlikuToolStripMenuItem;
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wykresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
    }
}

