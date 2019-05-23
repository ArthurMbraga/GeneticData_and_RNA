namespace Tester.Controls
{
    partial class CSTControl
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
            this.groupBoxChartControl = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.numericUpDownGenPerPage = new System.Windows.Forms.NumericUpDown();
            this.trackBarPage = new System.Windows.Forms.TrackBar();
            this.chartChromossomeSelection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxVVF = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBoxVV3 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBoxVV2 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBoxVV1 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxNumGen = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxBestFit = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBoxDominance = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxMaxGen = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBoxChartControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChromossomeSelection)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChartControl
            // 
            this.groupBoxChartControl.Controls.Add(this.label42);
            this.groupBoxChartControl.Controls.Add(this.label43);
            this.groupBoxChartControl.Controls.Add(this.numericUpDownGenPerPage);
            this.groupBoxChartControl.Controls.Add(this.trackBarPage);
            this.groupBoxChartControl.Enabled = false;
            this.groupBoxChartControl.Location = new System.Drawing.Point(375, 64);
            this.groupBoxChartControl.Name = "groupBoxChartControl";
            this.groupBoxChartControl.Size = new System.Drawing.Size(439, 38);
            this.groupBoxChartControl.TabIndex = 18;
            this.groupBoxChartControl.TabStop = false;
            this.groupBoxChartControl.Text = "ChartControl";
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 14);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(112, 13);
            this.label42.TabIndex = 6;
            this.label42.Text = "Generations per page:";
            // 
            // label43
            // 
            this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(174, 14);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(35, 13);
            this.label43.TabIndex = 8;
            this.label43.Text = "Page:";
            // 
            // numericUpDownGenPerPage
            // 
            this.numericUpDownGenPerPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownGenPerPage.Location = new System.Drawing.Point(118, 12);
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
            // trackBarPage
            // 
            this.trackBarPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPage.AutoSize = false;
            this.trackBarPage.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarPage.LargeChange = 1;
            this.trackBarPage.Location = new System.Drawing.Point(215, 7);
            this.trackBarPage.Maximum = 0;
            this.trackBarPage.Name = "trackBarPage";
            this.trackBarPage.Size = new System.Drawing.Size(223, 29);
            this.trackBarPage.TabIndex = 9;
            this.trackBarPage.Scroll += new System.EventHandler(this.TrackBarPage_Scroll);
            // 
            // chartChromossomeSelection
            // 
            this.chartChromossomeSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartChromossomeSelection.BorderlineColor = System.Drawing.Color.Black;
            this.chartChromossomeSelection.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartChromossomeSelection.ChartAreas.Add(chartArea1);
            this.chartChromossomeSelection.Location = new System.Drawing.Point(0, 104);
            this.chartChromossomeSelection.Name = "chartChromossomeSelection";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.MarkerSize = 2;
            series1.Name = "Series1";
            this.chartChromossomeSelection.Series.Add(series1);
            this.chartChromossomeSelection.Size = new System.Drawing.Size(820, 386);
            this.chartChromossomeSelection.TabIndex = 17;
            this.chartChromossomeSelection.Text = "chartChromossomeSelection";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxVVF);
            this.groupBox9.Controls.Add(this.label39);
            this.groupBox9.Controls.Add(this.textBoxVV3);
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Controls.Add(this.textBoxVV2);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.textBoxVV1);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.textBoxNumGen);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.textBoxBestFit);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Location = new System.Drawing.Point(375, 1);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(439, 64);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Results";
            // 
            // textBoxVVF
            // 
            this.textBoxVVF.Location = new System.Drawing.Point(332, 40);
            this.textBoxVVF.Name = "textBoxVVF";
            this.textBoxVVF.ReadOnly = true;
            this.textBoxVVF.Size = new System.Drawing.Size(66, 20);
            this.textBoxVVF.TabIndex = 21;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(289, 43);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(43, 13);
            this.label39.TabIndex = 20;
            this.label39.Text = "ValueF:";
            // 
            // textBoxVV3
            // 
            this.textBoxVV3.Location = new System.Drawing.Point(217, 38);
            this.textBoxVV3.Name = "textBoxVV3";
            this.textBoxVV3.ReadOnly = true;
            this.textBoxVV3.Size = new System.Drawing.Size(66, 20);
            this.textBoxVV3.TabIndex = 19;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(174, 41);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(43, 13);
            this.label38.TabIndex = 18;
            this.label38.Text = "Value3:";
            // 
            // textBoxVV2
            // 
            this.textBoxVV2.Location = new System.Drawing.Point(332, 12);
            this.textBoxVV2.Name = "textBoxVV2";
            this.textBoxVV2.ReadOnly = true;
            this.textBoxVV2.Size = new System.Drawing.Size(66, 20);
            this.textBoxVV2.TabIndex = 17;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(289, 15);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 13);
            this.label32.TabIndex = 16;
            this.label32.Text = "Value2:";
            // 
            // textBoxVV1
            // 
            this.textBoxVV1.Location = new System.Drawing.Point(217, 12);
            this.textBoxVV1.Name = "textBoxVV1";
            this.textBoxVV1.ReadOnly = true;
            this.textBoxVV1.Size = new System.Drawing.Size(66, 20);
            this.textBoxVV1.TabIndex = 15;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(174, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "Value1:";
            // 
            // textBoxNumGen
            // 
            this.textBoxNumGen.Location = new System.Drawing.Point(102, 38);
            this.textBoxNumGen.Name = "textBoxNumGen";
            this.textBoxNumGen.ReadOnly = true;
            this.textBoxNumGen.Size = new System.Drawing.Size(66, 20);
            this.textBoxNumGen.TabIndex = 13;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 41);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(90, 13);
            this.label30.TabIndex = 12;
            this.label30.Text = "Num generations:";
            // 
            // textBoxBestFit
            // 
            this.textBoxBestFit.Location = new System.Drawing.Point(102, 12);
            this.textBoxBestFit.Name = "textBoxBestFit";
            this.textBoxBestFit.ReadOnly = true;
            this.textBoxBestFit.Size = new System.Drawing.Size(66, 20);
            this.textBoxBestFit.TabIndex = 9;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(32, 15);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 13);
            this.label33.TabIndex = 7;
            this.label33.Text = "Best fitness:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBoxDominance);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.textBoxSelect);
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.buttonRandom);
            this.groupBox10.Controls.Add(this.buttonRun);
            this.groupBox10.Controls.Add(this.textBoxMaxGen);
            this.groupBox10.Controls.Add(this.textBoxTarget);
            this.groupBox10.Controls.Add(this.textBoxPop);
            this.groupBox10.Controls.Add(this.label35);
            this.groupBox10.Controls.Add(this.label36);
            this.groupBox10.Controls.Add(this.label37);
            this.groupBox10.Location = new System.Drawing.Point(3, 1);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(366, 102);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Configuration";
            // 
            // checkBoxDominance
            // 
            this.checkBoxDominance.AutoSize = true;
            this.checkBoxDominance.Location = new System.Drawing.Point(222, 76);
            this.checkBoxDominance.Name = "checkBoxDominance";
            this.checkBoxDominance.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDominance.TabIndex = 11;
            this.checkBoxDominance.Text = "Dominance";
            this.checkBoxDominance.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 76);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(202, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "Operation: X + XY(Z + Y) - ZY - ZY(X + Y)";
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(222, 41);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(49, 20);
            this.textBoxSelect.TabIndex = 9;
            this.textBoxSelect.Text = "100";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(176, 43);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 13);
            this.label34.TabIndex = 8;
            this.label34.Text = "Select:";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(126, 40);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(22, 21);
            this.buttonRandom.TabIndex = 7;
            this.buttonRandom.Text = "R";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
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
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(126, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(90, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "Max Generations:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(25, 43);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "Target:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 17);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "Population:";
            // 
            // CSTControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxChartControl);
            this.Controls.Add(this.chartChromossomeSelection);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox10);
            this.Name = "CSTControl";
            this.Size = new System.Drawing.Size(820, 490);
            this.groupBoxChartControl.ResumeLayout(false);
            this.groupBoxChartControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChromossomeSelection)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChartControl;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown numericUpDownGenPerPage;
        private System.Windows.Forms.TrackBar trackBarPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChromossomeSelection;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxVVF;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBoxVV3;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBoxVV2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBoxVV1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxNumGen;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxBestFit;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox checkBoxDominance;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxMaxGen;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.TextBox textBoxPop;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
    }
}
