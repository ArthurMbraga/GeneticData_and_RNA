namespace Tester.Controls
{
    partial class DMTControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMutation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxDeviation2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxChanges = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxMin2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMax2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMedian2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAverage2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxMutation2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonMutate = new System.Windows.Forms.Button();
            this.textBoxTimes2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxV3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxG3 = new System.Windows.Forms.TextBox();
            this.labelGC3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRandomStructure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMutation)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMutation
            // 
            this.chartMutation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartMutation.BorderlineColor = System.Drawing.Color.Black;
            this.chartMutation.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chartMutation.ChartAreas.Add(chartArea2);
            this.chartMutation.Location = new System.Drawing.Point(0, 217);
            this.chartMutation.Name = "chartMutation";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Maroon;
            series4.Name = "SeriesValue";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.DarkGreen;
            series5.Name = "SeriesMutationAverage";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.MarkerSize = 4;
            series6.Name = "SeriesMutations";
            series6.YValuesPerPoint = 2;
            this.chartMutation.Series.Add(series4);
            this.chartMutation.Series.Add(series5);
            this.chartMutation.Series.Add(series6);
            this.chartMutation.Size = new System.Drawing.Size(820, 273);
            this.chartMutation.TabIndex = 17;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxDeviation2);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.textBoxChanges);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.textBoxMin2);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.textBoxMax2);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textBoxMedian2);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textBoxAverage2);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(3, 126);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(404, 85);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Results";
            // 
            // textBoxDeviation2
            // 
            this.textBoxDeviation2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeviation2.Location = new System.Drawing.Point(321, 55);
            this.textBoxDeviation2.Name = "textBoxDeviation2";
            this.textBoxDeviation2.ReadOnly = true;
            this.textBoxDeviation2.Size = new System.Drawing.Size(66, 20);
            this.textBoxDeviation2.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Deviation:";
            // 
            // textBoxChanges
            // 
            this.textBoxChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChanges.Location = new System.Drawing.Point(321, 26);
            this.textBoxChanges.Name = "textBoxChanges";
            this.textBoxChanges.ReadOnly = true;
            this.textBoxChanges.Size = new System.Drawing.Size(66, 20);
            this.textBoxChanges.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(263, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Changes:";
            // 
            // textBoxMin2
            // 
            this.textBoxMin2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMin2.Location = new System.Drawing.Point(179, 55);
            this.textBoxMin2.Name = "textBoxMin2";
            this.textBoxMin2.ReadOnly = true;
            this.textBoxMin2.Size = new System.Drawing.Size(66, 20);
            this.textBoxMin2.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(146, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Min:";
            // 
            // textBoxMax2
            // 
            this.textBoxMax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMax2.Location = new System.Drawing.Point(179, 26);
            this.textBoxMax2.Name = "textBoxMax2";
            this.textBoxMax2.ReadOnly = true;
            this.textBoxMax2.Size = new System.Drawing.Size(66, 20);
            this.textBoxMax2.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(143, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Max:";
            // 
            // textBoxMedian2
            // 
            this.textBoxMedian2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMedian2.Location = new System.Drawing.Point(62, 55);
            this.textBoxMedian2.Name = "textBoxMedian2";
            this.textBoxMedian2.ReadOnly = true;
            this.textBoxMedian2.Size = new System.Drawing.Size(66, 20);
            this.textBoxMedian2.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Median:";
            // 
            // textBoxAverage2
            // 
            this.textBoxAverage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAverage2.Location = new System.Drawing.Point(62, 26);
            this.textBoxAverage2.Name = "textBoxAverage2";
            this.textBoxAverage2.ReadOnly = true;
            this.textBoxAverage2.Size = new System.Drawing.Size(66, 20);
            this.textBoxAverage2.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DarkGreen;
            this.label17.Location = new System.Drawing.Point(6, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Average:";
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxResults.Location = new System.Drawing.Point(414, 7);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(396, 204);
            this.richTextBoxResults.TabIndex = 15;
            this.richTextBoxResults.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxMutation2);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.buttonMutate);
            this.groupBox5.Controls.Add(this.textBoxTimes2);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBoxV3);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textBoxG3);
            this.groupBox5.Controls.Add(this.labelGC3);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.buttonRandomStructure);
            this.groupBox5.Location = new System.Drawing.Point(3, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(404, 123);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Base";
            // 
            // textBoxMutation2
            // 
            this.textBoxMutation2.Location = new System.Drawing.Point(51, 84);
            this.textBoxMutation2.Name = "textBoxMutation2";
            this.textBoxMutation2.Size = new System.Drawing.Size(90, 20);
            this.textBoxMutation2.TabIndex = 16;
            this.textBoxMutation2.Text = "0,01";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(0, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Mutation:";
            // 
            // buttonMutate
            // 
            this.buttonMutate.Location = new System.Drawing.Point(151, 83);
            this.buttonMutate.Name = "buttonMutate";
            this.buttonMutate.Size = new System.Drawing.Size(73, 20);
            this.buttonMutate.TabIndex = 14;
            this.buttonMutate.Text = "Mutate";
            this.buttonMutate.UseVisualStyleBackColor = true;
            this.buttonMutate.Click += new System.EventHandler(this.ButtonMutate_Click);
            // 
            // textBoxTimes2
            // 
            this.textBoxTimes2.Location = new System.Drawing.Point(51, 58);
            this.textBoxTimes2.Name = "textBoxTimes2";
            this.textBoxTimes2.Size = new System.Drawing.Size(90, 20);
            this.textBoxTimes2.TabIndex = 13;
            this.textBoxTimes2.Text = "500";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Times:";
            // 
            // textBoxV3
            // 
            this.textBoxV3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxV3.Location = new System.Drawing.Point(321, 19);
            this.textBoxV3.Name = "textBoxV3";
            this.textBoxV3.ReadOnly = true;
            this.textBoxV3.Size = new System.Drawing.Size(66, 20);
            this.textBoxV3.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(281, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Value:";
            // 
            // textBoxG3
            // 
            this.textBoxG3.Location = new System.Drawing.Point(50, 19);
            this.textBoxG3.Name = "textBoxG3";
            this.textBoxG3.Size = new System.Drawing.Size(199, 20);
            this.textBoxG3.TabIndex = 2;
            // 
            // labelGC3
            // 
            this.labelGC3.AutoSize = true;
            this.labelGC3.Location = new System.Drawing.Point(47, 42);
            this.labelGC3.Name = "labelGC3";
            this.labelGC3.Size = new System.Drawing.Size(13, 13);
            this.labelGC3.TabIndex = 9;
            this.labelGC3.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Gene:";
            // 
            // buttonRandomStructure
            // 
            this.buttonRandomStructure.Location = new System.Drawing.Point(255, 19);
            this.buttonRandomStructure.Name = "buttonRandomStructure";
            this.buttonRandomStructure.Size = new System.Drawing.Size(21, 20);
            this.buttonRandomStructure.TabIndex = 4;
            this.buttonRandomStructure.Text = "R";
            this.buttonRandomStructure.UseVisualStyleBackColor = true;
            this.buttonRandomStructure.Click += new System.EventHandler(this.ButtonRandomStructure_Click);
            // 
            // DMTControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMutation);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.richTextBoxResults);
            this.Controls.Add(this.groupBox5);
            this.Name = "DMTControl";
            this.Size = new System.Drawing.Size(820, 490);
            ((System.ComponentModel.ISupportInitialize)(this.chartMutation)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMutation;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxDeviation2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxChanges;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxMin2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMax2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMedian2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxAverage2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxMutation2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonMutate;
        private System.Windows.Forms.TextBox textBoxTimes2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxV3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxG3;
        private System.Windows.Forms.Label labelGC3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRandomStructure;
    }
}
