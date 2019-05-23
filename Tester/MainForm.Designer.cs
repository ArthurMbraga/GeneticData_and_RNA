namespace Tester
{
    partial class MainForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageDDT = new System.Windows.Forms.TabPage();
            this.ddtControl1 = new Tester.Controls.DDTControl();
            this.tabPageDMT = new System.Windows.Forms.TabPage();
            this.dmtControl1 = new Tester.Controls.DMTControl();
            this.tabPageCOGT = new System.Windows.Forms.TabPage();
            this.cogtControl1 = new Tester.Controls.COGTControl();
            this.tabPageCST = new System.Windows.Forms.TabPage();
            this.cstControl1 = new Tester.Controls.CSTControl();
            this.tabPageGST = new System.Windows.Forms.TabPage();
            this.gstControl = new Tester.GSTControl();
            this.tabControlGenetic = new System.Windows.Forms.TabControl();
            this.tabControlType = new System.Windows.Forms.TabControl();
            this.tabPageGenetic = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMutation = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPattern = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gnnstControl1 = new Tester.Controls.GeneticNeural.GNNSTControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageDDT.SuspendLayout();
            this.tabPageDMT.SuspendLayout();
            this.tabPageCOGT.SuspendLayout();
            this.tabPageCST.SuspendLayout();
            this.tabPageGST.SuspendLayout();
            this.tabControlGenetic.SuspendLayout();
            this.tabControlType.SuspendLayout();
            this.tabPageGenetic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutation)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDDT
            // 
            this.tabPageDDT.Controls.Add(this.ddtControl1);
            this.tabPageDDT.Location = new System.Drawing.Point(4, 22);
            this.tabPageDDT.Name = "tabPageDDT";
            this.tabPageDDT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDDT.Size = new System.Drawing.Size(803, 480);
            this.tabPageDDT.TabIndex = 1;
            this.tabPageDDT.Text = "Dna Dispertion Test";
            this.tabPageDDT.UseVisualStyleBackColor = true;
            // 
            // ddtControl1
            // 
            this.ddtControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddtControl1.Location = new System.Drawing.Point(3, 3);
            this.ddtControl1.Name = "ddtControl1";
            this.ddtControl1.Size = new System.Drawing.Size(797, 474);
            this.ddtControl1.TabIndex = 0;
            // 
            // tabPageDMT
            // 
            this.tabPageDMT.Controls.Add(this.dmtControl1);
            this.tabPageDMT.Location = new System.Drawing.Point(4, 22);
            this.tabPageDMT.Name = "tabPageDMT";
            this.tabPageDMT.Size = new System.Drawing.Size(803, 480);
            this.tabPageDMT.TabIndex = 3;
            this.tabPageDMT.Text = "Dna Mutation Test";
            this.tabPageDMT.UseVisualStyleBackColor = true;
            // 
            // dmtControl1
            // 
            this.dmtControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmtControl1.Location = new System.Drawing.Point(0, 0);
            this.dmtControl1.Name = "dmtControl1";
            this.dmtControl1.Size = new System.Drawing.Size(803, 480);
            this.dmtControl1.TabIndex = 0;
            // 
            // tabPageCOGT
            // 
            this.tabPageCOGT.Controls.Add(this.cogtControl1);
            this.tabPageCOGT.Location = new System.Drawing.Point(4, 22);
            this.tabPageCOGT.Name = "tabPageCOGT";
            this.tabPageCOGT.Size = new System.Drawing.Size(803, 480);
            this.tabPageCOGT.TabIndex = 2;
            this.tabPageCOGT.Text = "Crossing Over Gene Test";
            this.tabPageCOGT.UseVisualStyleBackColor = true;
            // 
            // cogtControl1
            // 
            this.cogtControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogtControl1.Location = new System.Drawing.Point(0, 0);
            this.cogtControl1.Name = "cogtControl1";
            this.cogtControl1.Size = new System.Drawing.Size(803, 480);
            this.cogtControl1.TabIndex = 0;
            // 
            // tabPageCST
            // 
            this.tabPageCST.Controls.Add(this.cstControl1);
            this.tabPageCST.Location = new System.Drawing.Point(4, 22);
            this.tabPageCST.Name = "tabPageCST";
            this.tabPageCST.Size = new System.Drawing.Size(803, 480);
            this.tabPageCST.TabIndex = 5;
            this.tabPageCST.Text = "Chromossome Selection Test";
            this.tabPageCST.UseVisualStyleBackColor = true;
            // 
            // cstControl1
            // 
            this.cstControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cstControl1.Location = new System.Drawing.Point(0, 0);
            this.cstControl1.Name = "cstControl1";
            this.cstControl1.Size = new System.Drawing.Size(803, 480);
            this.cstControl1.TabIndex = 0;
            // 
            // tabPageGST
            // 
            this.tabPageGST.Controls.Add(this.gstControl);
            this.tabPageGST.Location = new System.Drawing.Point(4, 22);
            this.tabPageGST.Name = "tabPageGST";
            this.tabPageGST.Size = new System.Drawing.Size(803, 480);
            this.tabPageGST.TabIndex = 4;
            this.tabPageGST.Text = "Gene Selection Test";
            this.tabPageGST.UseVisualStyleBackColor = true;
            // 
            // gstControl
            // 
            this.gstControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gstControl.Location = new System.Drawing.Point(0, 0);
            this.gstControl.Name = "gstControl";
            this.gstControl.Size = new System.Drawing.Size(803, 480);
            this.gstControl.TabIndex = 0;
            // 
            // tabControlGenetic
            // 
            this.tabControlGenetic.Controls.Add(this.tabPageGST);
            this.tabControlGenetic.Controls.Add(this.tabPageCST);
            this.tabControlGenetic.Controls.Add(this.tabPageCOGT);
            this.tabControlGenetic.Controls.Add(this.tabPageDMT);
            this.tabControlGenetic.Controls.Add(this.tabPageDDT);
            this.tabControlGenetic.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlGenetic.Location = new System.Drawing.Point(3, 3);
            this.tabControlGenetic.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlGenetic.Name = "tabControlGenetic";
            this.tabControlGenetic.SelectedIndex = 0;
            this.tabControlGenetic.Size = new System.Drawing.Size(811, 506);
            this.tabControlGenetic.TabIndex = 12;
            // 
            // tabControlType
            // 
            this.tabControlType.Controls.Add(this.tabPageGenetic);
            this.tabControlType.Controls.Add(this.tabPage2);
            this.tabControlType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlType.Location = new System.Drawing.Point(0, 0);
            this.tabControlType.Name = "tabControlType";
            this.tabControlType.SelectedIndex = 0;
            this.tabControlType.Size = new System.Drawing.Size(946, 538);
            this.tabControlType.TabIndex = 1;
            // 
            // tabPageGenetic
            // 
            this.tabPageGenetic.Controls.Add(this.groupBox1);
            this.tabPageGenetic.Controls.Add(this.tabControlGenetic);
            this.tabPageGenetic.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenetic.Name = "tabPageGenetic";
            this.tabPageGenetic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenetic.Size = new System.Drawing.Size(938, 512);
            this.tabPageGenetic.TabIndex = 0;
            this.tabPageGenetic.Text = "Genetic Data";
            this.tabPageGenetic.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownMutation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxPattern);
            this.groupBox1.Location = new System.Drawing.Point(817, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Config";
            // 
            // numericUpDownMutation
            // 
            this.numericUpDownMutation.DecimalPlaces = 5;
            this.numericUpDownMutation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMutation.Location = new System.Drawing.Point(6, 61);
            this.numericUpDownMutation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMutation.Name = "numericUpDownMutation";
            this.numericUpDownMutation.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownMutation.TabIndex = 1;
            this.numericUpDownMutation.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMutation.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mutation Chance:";
            // 
            // checkBoxPattern
            // 
            this.checkBoxPattern.AutoSize = true;
            this.checkBoxPattern.Location = new System.Drawing.Point(6, 22);
            this.checkBoxPattern.Name = "checkBoxPattern";
            this.checkBoxPattern.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPattern.TabIndex = 0;
            this.checkBoxPattern.Text = "Pattern";
            this.checkBoxPattern.UseVisualStyleBackColor = true;
            this.checkBoxPattern.CheckedChanged += new System.EventHandler(this.CheckBoxPattern_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(938, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Genetic Neural Network";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gnnstControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Selection Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gnnstControl1
            // 
            this.gnnstControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnnstControl1.Location = new System.Drawing.Point(3, 3);
            this.gnnstControl1.Name = "gnnstControl1";
            this.gnnstControl1.Size = new System.Drawing.Size(918, 474);
            this.gnnstControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(924, 480);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 538);
            this.Controls.Add(this.tabControlType);
            this.Name = "MainForm";
            this.Text = "Tester";
            this.tabPageDDT.ResumeLayout(false);
            this.tabPageDMT.ResumeLayout(false);
            this.tabPageCOGT.ResumeLayout(false);
            this.tabPageCST.ResumeLayout(false);
            this.tabPageGST.ResumeLayout(false);
            this.tabControlGenetic.ResumeLayout(false);
            this.tabControlType.ResumeLayout(false);
            this.tabPageGenetic.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutation)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageDDT;
        private System.Windows.Forms.TabPage tabPageDMT;
        private System.Windows.Forms.TabPage tabPageCOGT;
        private System.Windows.Forms.TabPage tabPageCST;
        private System.Windows.Forms.TabPage tabPageGST;
        private System.Windows.Forms.TabControl tabControlGenetic;
        public System.Windows.Forms.ToolTip toolTip;
        private GSTControl gstControl;
        private Controls.CSTControl cstControl1;
        private Controls.COGTControl cogtControl1;
        private Controls.DMTControl dmtControl1;
        private Controls.DDTControl ddtControl1;
        private System.Windows.Forms.TabControl tabControlType;
        private System.Windows.Forms.TabPage tabPageGenetic;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private Controls.GeneticNeural.GNNSTControl gnnstControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPattern;
        private System.Windows.Forms.NumericUpDown numericUpDownMutation;
    }
}

