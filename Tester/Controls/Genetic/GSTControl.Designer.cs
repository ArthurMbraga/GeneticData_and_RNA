namespace Tester
{
    partial class GSTControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxChartControl1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPage = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownGenPerPage = new System.Windows.Forms.NumericUpDown();
            this.chartGeneSelection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxV4 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxNumGen = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.labelCG = new System.Windows.Forms.Label();
            this.textBoxBestDna = new System.Windows.Forms.TextBox();
            this.textBoxBestFit = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.buttonRadom = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxMaxGen = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBoxChartControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneSelection)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChartControl1
            // 
            this.groupBoxChartControl1.Controls.Add(this.label1);
            this.groupBoxChartControl1.Controls.Add(this.trackBarPage);
            this.groupBoxChartControl1.Controls.Add(this.label2);
            this.groupBoxChartControl1.Controls.Add(this.numericUpDownGenPerPage);
            this.groupBoxChartControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxChartControl1.Enabled = false;
            this.groupBoxChartControl1.Location = new System.Drawing.Point(0, 453);
            this.groupBoxChartControl1.Name = "groupBoxChartControl1";
            this.groupBoxChartControl1.Size = new System.Drawing.Size(820, 37);
            this.groupBoxChartControl1.TabIndex = 16;
            this.groupBoxChartControl1.TabStop = false;
            this.groupBoxChartControl1.Text = "Chart Control";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generations per page:";
            // 
            // trackBarPage
            // 
            this.trackBarPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPage.AutoSize = false;
            this.trackBarPage.LargeChange = 1;
            this.trackBarPage.Location = new System.Drawing.Point(213, 8);
            this.trackBarPage.Maximum = 0;
            this.trackBarPage.Name = "trackBarPage";
            this.trackBarPage.Size = new System.Drawing.Size(607, 26);
            this.trackBarPage.TabIndex = 9;
            this.trackBarPage.Scroll += new System.EventHandler(this.TrackBarPage_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Page:";
            // 
            // numericUpDownGenPerPage
            // 
            this.numericUpDownGenPerPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownGenPerPage.Location = new System.Drawing.Point(120, 12);
            this.numericUpDownGenPerPage.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGenPerPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGenPerPage.Name = "numericUpDownGenPerPage";
            this.numericUpDownGenPerPage.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownGenPerPage.TabIndex = 11;
            this.numericUpDownGenPerPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGenPerPage.ValueChanged += new System.EventHandler(this.NumericUpDownGenPerPage_ValueChanged);
            // 
            // chartGeneSelection
            // 
            this.chartGeneSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartGeneSelection.BorderlineColor = System.Drawing.Color.Black;
            this.chartGeneSelection.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartGeneSelection.ChartAreas.Add(chartArea1);
            this.chartGeneSelection.Location = new System.Drawing.Point(0, 81);
            this.chartGeneSelection.Name = "chartGeneSelection";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.MarkerSize = 2;
            series1.Name = "Series1";
            this.chartGeneSelection.Series.Add(series1);
            this.chartGeneSelection.Size = new System.Drawing.Size(820, 372);
            this.chartGeneSelection.TabIndex = 15;
            this.chartGeneSelection.Text = "chart2";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxV4);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.textBoxNumGen);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.labelCG);
            this.groupBox8.Controls.Add(this.textBoxBestDna);
            this.groupBox8.Controls.Add(this.textBoxBestFit);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Location = new System.Drawing.Point(375, 1);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(439, 77);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Results";
            // 
            // textBoxV4
            // 
            this.textBoxV4.Location = new System.Drawing.Point(359, 14);
            this.textBoxV4.Name = "textBoxV4";
            this.textBoxV4.ReadOnly = true;
            this.textBoxV4.Size = new System.Drawing.Size(66, 20);
            this.textBoxV4.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(316, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 13);
            this.label28.TabIndex = 14;
            this.label28.Text = "Value:";
            // 
            // textBoxNumGen
            // 
            this.textBoxNumGen.Location = new System.Drawing.Point(244, 14);
            this.textBoxNumGen.Name = "textBoxNumGen";
            this.textBoxNumGen.ReadOnly = true;
            this.textBoxNumGen.Size = new System.Drawing.Size(66, 20);
            this.textBoxNumGen.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(148, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "Num generations:";
            // 
            // labelCG
            // 
            this.labelCG.AutoSize = true;
            this.labelCG.Location = new System.Drawing.Point(74, 61);
            this.labelCG.Name = "labelCG";
            this.labelCG.Size = new System.Drawing.Size(13, 13);
            this.labelCG.TabIndex = 11;
            this.labelCG.Text = "--";
            // 
            // textBoxBestDna
            // 
            this.textBoxBestDna.Location = new System.Drawing.Point(76, 41);
            this.textBoxBestDna.Name = "textBoxBestDna";
            this.textBoxBestDna.ReadOnly = true;
            this.textBoxBestDna.Size = new System.Drawing.Size(349, 20);
            this.textBoxBestDna.TabIndex = 10;
            // 
            // textBoxBestFit
            // 
            this.textBoxBestFit.Location = new System.Drawing.Point(76, 14);
            this.textBoxBestFit.Name = "textBoxBestFit";
            this.textBoxBestFit.ReadOnly = true;
            this.textBoxBestFit.Size = new System.Drawing.Size(66, 20);
            this.textBoxBestFit.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(16, 43);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Best Dna:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Best fitness:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxSelect);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.buttonRadom);
            this.groupBox7.Controls.Add(this.buttonRun);
            this.groupBox7.Controls.Add(this.textBoxMaxGen);
            this.groupBox7.Controls.Add(this.textBoxTarget);
            this.groupBox7.Controls.Add(this.textBoxPop);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Location = new System.Drawing.Point(3, 1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(366, 77);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuration";
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(222, 41);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(49, 20);
            this.textBoxSelect.TabIndex = 9;
            this.textBoxSelect.Text = "100";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(176, 43);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Select:";
            // 
            // buttonRadom
            // 
            this.buttonRadom.Location = new System.Drawing.Point(126, 40);
            this.buttonRadom.Name = "buttonRadom";
            this.buttonRadom.Size = new System.Drawing.Size(22, 21);
            this.buttonRadom.TabIndex = 7;
            this.buttonRadom.Text = "R";
            this.buttonRadom.UseVisualStyleBackColor = true;
            this.buttonRadom.Click += new System.EventHandler(this.ButtonRadom_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(277, 14);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(82, 49);
            this.buttonRun.TabIndex = 6;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // textBoxMaxGen
            // 
            this.textBoxMaxGen.Location = new System.Drawing.Point(222, 14);
            this.textBoxMaxGen.Name = "textBoxMaxGen";
            this.textBoxMaxGen.Size = new System.Drawing.Size(49, 20);
            this.textBoxMaxGen.TabIndex = 5;
            this.textBoxMaxGen.Text = "100";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(72, 40);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(48, 20);
            this.textBoxTarget.TabIndex = 4;
            // 
            // textBoxPop
            // 
            this.textBoxPop.Location = new System.Drawing.Point(72, 14);
            this.textBoxPop.Name = "textBoxPop";
            this.textBoxPop.Size = new System.Drawing.Size(48, 20);
            this.textBoxPop.TabIndex = 3;
            this.textBoxPop.Text = "500";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(126, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Max Generations:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Target:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Population:";
            // 
            // GSTControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxChartControl1);
            this.Controls.Add(this.chartGeneSelection);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Name = "GSTControl";
            this.Size = new System.Drawing.Size(820, 490);
            this.groupBoxChartControl1.ResumeLayout(false);
            this.groupBoxChartControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneSelection)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChartControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGenPerPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneSelection;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxV4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxNumGen;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label labelCG;
        private System.Windows.Forms.TextBox textBoxBestDna;
        private System.Windows.Forms.TextBox textBoxBestFit;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button buttonRadom;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxMaxGen;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.TextBox textBoxPop;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
    }
}
