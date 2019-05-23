namespace Tester.Controls
{
    partial class COGTControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDeviation = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMedian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            this.textBoxTimes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRandomStructure2 = new System.Windows.Forms.Button();
            this.buttonRandomStructure1 = new System.Windows.Forms.Button();
            this.labelAverage = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.labelGC2 = new System.Windows.Forms.Label();
            this.labelGC1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxV2 = new System.Windows.Forms.TextBox();
            this.textBoxG1 = new System.Windows.Forms.TextBox();
            this.textBoxV1 = new System.Windows.Forms.TextBox();
            this.textBoxG2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribution)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDistribution
            // 
            this.chartDistribution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDistribution.BorderlineColor = System.Drawing.Color.Black;
            this.chartDistribution.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.Name = "ChartArea1";
            this.chartDistribution.ChartAreas.Add(chartArea3);
            this.chartDistribution.Location = new System.Drawing.Point(0, 113);
            this.chartDistribution.Name = "chartDistribution";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.MediumBlue;
            series11.Name = "SeriesV1";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.LightSeaGreen;
            series12.Name = "SeriesV2";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.DarkGreen;
            series13.Name = "SeriesResultAverage";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.DarkGoldenrod;
            series14.Name = "SeriesValuesAverage";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series15.MarkerSize = 3;
            series15.Name = "SeriesValue";
            this.chartDistribution.Series.Add(series11);
            this.chartDistribution.Series.Add(series12);
            this.chartDistribution.Series.Add(series13);
            this.chartDistribution.Series.Add(series14);
            this.chartDistribution.Series.Add(series15);
            this.chartDistribution.Size = new System.Drawing.Size(820, 377);
            this.chartDistribution.TabIndex = 14;
            this.chartDistribution.Text = "chartDistrbution";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDeviation);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.textBoxMin);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxMax);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBoxMedian);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxAverage);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(537, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 111);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // textBoxDeviation
            // 
            this.textBoxDeviation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeviation.Location = new System.Drawing.Point(62, 72);
            this.textBoxDeviation.Name = "textBoxDeviation";
            this.textBoxDeviation.ReadOnly = true;
            this.textBoxDeviation.Size = new System.Drawing.Size(66, 20);
            this.textBoxDeviation.TabIndex = 20;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1, 75);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(55, 13);
            this.label44.TabIndex = 21;
            this.label44.Text = "Deviation:";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMin.Location = new System.Drawing.Point(179, 46);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(66, 20);
            this.textBoxMin.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Min:";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMax.Location = new System.Drawing.Point(179, 20);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(66, 20);
            this.textBoxMax.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Max:";
            // 
            // textBoxMedian
            // 
            this.textBoxMedian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMedian.Location = new System.Drawing.Point(62, 46);
            this.textBoxMedian.Name = "textBoxMedian";
            this.textBoxMedian.ReadOnly = true;
            this.textBoxMedian.Size = new System.Drawing.Size(66, 20);
            this.textBoxMedian.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Median:";
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAverage.Location = new System.Drawing.Point(62, 20);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(66, 20);
            this.textBoxAverage.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Average:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxSort);
            this.groupBox3.Controls.Add(this.textBoxTimes);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.buttonRun);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(3, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 112);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration";
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.Checked = true;
            this.checkBoxSort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSort.Location = new System.Drawing.Point(397, 47);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(45, 17);
            this.checkBoxSort.TabIndex = 12;
            this.checkBoxSort.Text = "Sort";
            this.checkBoxSort.UseVisualStyleBackColor = true;
            // 
            // textBoxTimes
            // 
            this.textBoxTimes.Location = new System.Drawing.Point(449, 19);
            this.textBoxTimes.Name = "textBoxTimes";
            this.textBoxTimes.Size = new System.Drawing.Size(67, 20);
            this.textBoxTimes.TabIndex = 10;
            this.textBoxTimes.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Times:";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(449, 45);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(67, 23);
            this.buttonRun.TabIndex = 9;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRandomStructure2);
            this.groupBox2.Controls.Add(this.buttonRandomStructure1);
            this.groupBox2.Controls.Add(this.labelAverage);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.labelGC2);
            this.groupBox2.Controls.Add(this.labelGC1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxV2);
            this.groupBox2.Controls.Add(this.textBoxG1);
            this.groupBox2.Controls.Add(this.textBoxV1);
            this.groupBox2.Controls.Add(this.textBoxG2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 88);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basis";
            // 
            // buttonRandomStructure2
            // 
            this.buttonRandomStructure2.Location = new System.Drawing.Point(235, 56);
            this.buttonRandomStructure2.Name = "buttonRandomStructure2";
            this.buttonRandomStructure2.Size = new System.Drawing.Size(21, 20);
            this.buttonRandomStructure2.TabIndex = 13;
            this.buttonRandomStructure2.Text = "R";
            this.buttonRandomStructure2.UseVisualStyleBackColor = true;
            this.buttonRandomStructure2.Click += new System.EventHandler(this.ButtonRandomStructure2_Click);
            // 
            // buttonRandomStructure1
            // 
            this.buttonRandomStructure1.Location = new System.Drawing.Point(235, 13);
            this.buttonRandomStructure1.Name = "buttonRandomStructure1";
            this.buttonRandomStructure1.Size = new System.Drawing.Size(21, 20);
            this.buttonRandomStructure1.TabIndex = 12;
            this.buttonRandomStructure1.Text = "R";
            this.buttonRandomStructure1.UseVisualStyleBackColor = true;
            this.buttonRandomStructure1.Click += new System.EventHandler(this.ButtonRandomStructure1_Click);
            // 
            // labelAverage
            // 
            this.labelAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(308, 40);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(10, 13);
            this.labelAverage.TabIndex = 11;
            this.labelAverage.Text = "-";
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label45.Location = new System.Drawing.Point(255, 39);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(50, 13);
            this.label45.TabIndex = 10;
            this.label45.Text = "Average:";
            // 
            // labelGC2
            // 
            this.labelGC2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGC2.AutoSize = true;
            this.labelGC2.Location = new System.Drawing.Point(51, 76);
            this.labelGC2.Name = "labelGC2";
            this.labelGC2.Size = new System.Drawing.Size(13, 13);
            this.labelGC2.TabIndex = 9;
            this.labelGC2.Text = "--";
            // 
            // labelGC1
            // 
            this.labelGC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGC1.AutoSize = true;
            this.labelGC1.Location = new System.Drawing.Point(51, 33);
            this.labelGC1.Name = "labelGC1";
            this.labelGC1.Size = new System.Drawing.Size(13, 13);
            this.labelGC1.TabIndex = 8;
            this.labelGC1.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gene1:";
            // 
            // textBoxV2
            // 
            this.textBoxV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxV2.Location = new System.Drawing.Point(308, 56);
            this.textBoxV2.Name = "textBoxV2";
            this.textBoxV2.ReadOnly = true;
            this.textBoxV2.Size = new System.Drawing.Size(66, 20);
            this.textBoxV2.TabIndex = 7;
            this.textBoxV2.TextChanged += new System.EventHandler(this.TextBoxValue_TextChanged);
            // 
            // textBoxG1
            // 
            this.textBoxG1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxG1.Location = new System.Drawing.Point(54, 13);
            this.textBoxG1.Name = "textBoxG1";
            this.textBoxG1.Size = new System.Drawing.Size(178, 20);
            this.textBoxG1.TabIndex = 0;
            // 
            // textBoxV1
            // 
            this.textBoxV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxV1.Location = new System.Drawing.Point(308, 13);
            this.textBoxV1.Name = "textBoxV1";
            this.textBoxV1.ReadOnly = true;
            this.textBoxV1.Size = new System.Drawing.Size(66, 20);
            this.textBoxV1.TabIndex = 6;
            this.textBoxV1.TextChanged += new System.EventHandler(this.TextBoxValue_TextChanged);
            // 
            // textBoxG2
            // 
            this.textBoxG2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxG2.Location = new System.Drawing.Point(54, 56);
            this.textBoxG2.Name = "textBoxG2";
            this.textBoxG2.Size = new System.Drawing.Size(178, 20);
            this.textBoxG2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Value2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gene2:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value1:";
            // 
            // COGTControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartDistribution);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "COGTControl";
            this.Size = new System.Drawing.Size(820, 490);
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribution)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistribution;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxDeviation;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMedian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxSort;
        private System.Windows.Forms.TextBox textBoxTimes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRandomStructure2;
        private System.Windows.Forms.Button buttonRandomStructure1;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label labelGC2;
        private System.Windows.Forms.Label labelGC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxV2;
        private System.Windows.Forms.TextBox textBoxG1;
        private System.Windows.Forms.TextBox textBoxV1;
        private System.Windows.Forms.TextBox textBoxG2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
