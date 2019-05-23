namespace Tester.Controls.GeneticNeural
{
    partial class GNNSTControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxChartControl1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPage = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownGenPerPage = new System.Windows.Forms.NumericUpDown();
            this.chartGNNSelection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxO1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumGen = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxBestFit = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBoxDominance = new System.Windows.Forms.CheckBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxHLN = new System.Windows.Forms.TextBox();
            this.textBoxHL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxMaxGen = new System.Windows.Forms.TextBox();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxO2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxV1 = new System.Windows.Forms.TextBox();
            this.groupBoxChartControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGNNSelection)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBoxChartControl1.Location = new System.Drawing.Point(0, 443);
            this.groupBoxChartControl1.Name = "groupBoxChartControl1";
            this.groupBoxChartControl1.Size = new System.Drawing.Size(799, 37);
            this.groupBoxChartControl1.TabIndex = 20;
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
            this.trackBarPage.Size = new System.Drawing.Size(586, 26);
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
            // chartGNNSelection
            // 
            this.chartGNNSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartGNNSelection.BorderlineColor = System.Drawing.Color.Black;
            this.chartGNNSelection.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.Name = "ChartArea1";
            this.chartGNNSelection.ChartAreas.Add(chartArea3);
            this.chartGNNSelection.Location = new System.Drawing.Point(0, 91);
            this.chartGNNSelection.Name = "chartGNNSelection";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.MarkerSize = 2;
            series3.Name = "Series1";
            this.chartGNNSelection.Series.Add(series3);
            this.chartGNNSelection.Size = new System.Drawing.Size(799, 352);
            this.chartGNNSelection.TabIndex = 19;
            this.chartGNNSelection.Text = "chart2";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.groupBoxTest);
            this.groupBox8.Controls.Add(this.textBoxNumGen);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.textBoxBestFit);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Location = new System.Drawing.Point(439, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(355, 83);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Results";
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.textBoxO2);
            this.groupBoxTest.Controls.Add(this.label9);
            this.groupBoxTest.Controls.Add(this.buttonRandom);
            this.groupBoxTest.Controls.Add(this.textBoxA);
            this.groupBoxTest.Controls.Add(this.label8);
            this.groupBoxTest.Controls.Add(this.textBoxO1);
            this.groupBoxTest.Controls.Add(this.label7);
            this.groupBoxTest.Controls.Add(this.textBoxV1);
            this.groupBoxTest.Controls.Add(this.label5);
            this.groupBoxTest.Enabled = false;
            this.groupBoxTest.Location = new System.Drawing.Point(105, 10);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(244, 65);
            this.groupBoxTest.TabIndex = 14;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Test";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 22;
            this.button1.Text = "V";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(104, 13);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(20, 20);
            this.buttonRandom.TabIndex = 21;
            this.buttonRandom.Text = "R";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(190, 39);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(48, 20);
            this.textBoxA.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ans:";
            // 
            // textBoxO1
            // 
            this.textBoxO1.Location = new System.Drawing.Point(28, 39);
            this.textBoxO1.Name = "textBoxO1";
            this.textBoxO1.ReadOnly = true;
            this.textBoxO1.Size = new System.Drawing.Size(48, 20);
            this.textBoxO1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "O1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sin of";
            // 
            // textBoxNumGen
            // 
            this.textBoxNumGen.Location = new System.Drawing.Point(51, 40);
            this.textBoxNumGen.Name = "textBoxNumGen";
            this.textBoxNumGen.ReadOnly = true;
            this.textBoxNumGen.Size = new System.Drawing.Size(48, 20);
            this.textBoxNumGen.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "Gens:";
            // 
            // textBoxBestFit
            // 
            this.textBoxBestFit.Location = new System.Drawing.Point(51, 17);
            this.textBoxBestFit.Name = "textBoxBestFit";
            this.textBoxBestFit.ReadOnly = true;
            this.textBoxBestFit.Size = new System.Drawing.Size(48, 20);
            this.textBoxBestFit.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Best fit:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxDominance);
            this.groupBox7.Controls.Add(this.buttonHelp);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.buttonRun);
            this.groupBox7.Controls.Add(this.textBoxSelect);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.textBoxMaxGen);
            this.groupBox7.Controls.Add(this.textBoxPop);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Location = new System.Drawing.Point(3, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(430, 84);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuration";
            // 
            // checkBoxDominance
            // 
            this.checkBoxDominance.AutoSize = true;
            this.checkBoxDominance.Checked = true;
            this.checkBoxDominance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDominance.Location = new System.Drawing.Point(278, 36);
            this.checkBoxDominance.Name = "checkBoxDominance";
            this.checkBoxDominance.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDominance.TabIndex = 22;
            this.checkBoxDominance.Text = "Dominance";
            this.checkBoxDominance.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(397, 56);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(23, 23);
            this.buttonHelp.TabIndex = 21;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHLN);
            this.groupBox1.Controls.Add(this.textBoxHL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 64);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neural Network";
            // 
            // textBoxHLN
            // 
            this.textBoxHLN.Location = new System.Drawing.Point(86, 36);
            this.textBoxHLN.Name = "textBoxHLN";
            this.textBoxHLN.Size = new System.Drawing.Size(48, 20);
            this.textBoxHLN.TabIndex = 23;
            this.textBoxHLN.Text = "5";
            // 
            // textBoxHL
            // 
            this.textBoxHL.Location = new System.Drawing.Point(86, 13);
            this.textBoxHL.Name = "textBoxHL";
            this.textBoxHL.Size = new System.Drawing.Size(48, 20);
            this.textBoxHL.TabIndex = 10;
            this.textBoxHL.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "HL Neurons:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hidden Layers:";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(278, 56);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(113, 23);
            this.buttonRun.TabIndex = 6;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(220, 40);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(49, 20);
            this.textBoxSelect.TabIndex = 9;
            this.textBoxSelect.Text = "100";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(174, 42);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Select:";
            // 
            // textBoxMaxGen
            // 
            this.textBoxMaxGen.Location = new System.Drawing.Point(371, 17);
            this.textBoxMaxGen.Name = "textBoxMaxGen";
            this.textBoxMaxGen.Size = new System.Drawing.Size(49, 20);
            this.textBoxMaxGen.TabIndex = 5;
            this.textBoxMaxGen.Text = "100";
            // 
            // textBoxPop
            // 
            this.textBoxPop.Location = new System.Drawing.Point(221, 17);
            this.textBoxPop.Name = "textBoxPop";
            this.textBoxPop.Size = new System.Drawing.Size(48, 20);
            this.textBoxPop.TabIndex = 3;
            this.textBoxPop.Text = "500";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(275, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Max Generations:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(155, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Population:";
            // 
            // textBoxO2
            // 
            this.textBoxO2.Location = new System.Drawing.Point(104, 39);
            this.textBoxO2.Name = "textBoxO2";
            this.textBoxO2.ReadOnly = true;
            this.textBoxO2.Size = new System.Drawing.Size(51, 20);
            this.textBoxO2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "O2:";
            // 
            // textBoxV1
            // 
            this.textBoxV1.Location = new System.Drawing.Point(46, 13);
            this.textBoxV1.Name = "textBoxV1";
            this.textBoxV1.Size = new System.Drawing.Size(48, 20);
            this.textBoxV1.TabIndex = 5;
            this.textBoxV1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxV_KeyUp);
            // 
            // GNNSTControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxChartControl1);
            this.Controls.Add(this.chartGNNSelection);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Name = "GNNSTControl";
            this.Size = new System.Drawing.Size(799, 480);
            this.Load += new System.EventHandler(this.GNNSTControl_Load);
            this.groupBoxChartControl1.ResumeLayout(false);
            this.groupBoxChartControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGNNSelection)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChartControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGenPerPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGNNSelection;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxNumGen;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxBestFit;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxMaxGen;
        private System.Windows.Forms.TextBox textBoxPop;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxHLN;
        private System.Windows.Forms.TextBox textBoxHL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxO1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBoxDominance;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxO2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxV1;
    }
}
