using GeneticData;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tester
{
    public partial class GSTControl : UserControl
    {
        private static Random random = new Random();
        private int lastPopSize;
        private ToolTip toolTip = new ToolTip();

        public GSTControl()
        {
            InitializeComponent();

            textBoxTarget.Text = Convert.ToString(random.Next(-9999, 9999) / 1000f);

            ChartArea CA = chartGeneSelection.ChartAreas[0];
            CA.Position = new ElementPosition(0, 0, 100, 100);
            CA.InnerPlotPosition = new ElementPosition(4, 2, 95, 93);
        }

        private void MultiThreadGeneSelection()
        {
            chartGeneSelection.ChartAreas[0].AxisY.Maximum = 100;
            chartGeneSelection.ChartAreas[0].AxisY.Minimum = 0;

            int pop_size = Convert.ToInt32(textBoxPop.Text);
            int generations = Convert.ToInt32(textBoxMaxGen.Text);
            int numberSelected = Convert.ToInt32(textBoxSelect.Text);
            float target = Convert.ToSingle(textBoxTarget.Text);
            int gens = 0;
            Gene[] population = new Gene[pop_size];
            List<double[]> chartData = new List<double[]>();

            object monitor = new object();
            Gene bestdna = null;
            const int MAXFITNESS = 100;

            chartGeneSelection.Series[0].Points.Clear();

            //Start Population
            Parallel.For(0, pop_size, i => population[i] = new Gene(MainForm.RandomizationType));


            //Start Simulation
            for (int i = 0; i < generations; i++)
            {
                gens = i + 1;

                double[] fitnessArray = new double[pop_size];

                Parallel.For(0, pop_size, j =>
                {
                    Gene gene = population[j];

                    gene.Fitness = MAXFITNESS / (1 + (Math.Abs(target - gene.Value) / 100));

                    fitnessArray[j] = gene.Fitness;
                });

                Array.Sort(fitnessArray);
                chartData.Add(fitnessArray);

                Array.Sort(population);
                Array.Reverse(population);

                bestdna = population[0];

                if (bestdna.Fitness == MAXFITNESS)
                    break;

                Parallel.For(numberSelected, pop_size, k =>
                {
                    int i1 = random.Next(0, numberSelected);
                    int i2 = random.Next(0, numberSelected);
                    Gene gene = new Gene(population[i1], population[i2]);

                    population[k] = gene;
                });
            }


            /*
             * Update GUI
             */

            //Update chart
            for (int g = 0; g < chartData.Count; g++)
                for (int f = 0; f < chartData[g].Length; f++)
                    chartGeneSelection.Series[0].Points.Add(chartData[g][f]);

            textBoxBestDna.Text = bestdna.GetDnaSequenceReadable(false);
            labelCG.Text = bestdna.DnaSequence.ToString();
            textBoxNumGen.Text = gens.ToString();

            textBoxBestFit.Text = bestdna.Fitness.ToString();
            textBoxV4.Text = bestdna.Value.ToString();


            //Update chart tools
            lastPopSize = pop_size;

            int num_pages = (int)Math.Ceiling(gens / numericUpDownGenPerPage.Value);

            trackBarPage.Maximum = num_pages - 1;
            if (trackBarPage.Value > trackBarPage.Maximum)
                trackBarPage.Value = trackBarPage.Maximum;
            trackBarPage.Enabled = trackBarPage.Minimum != trackBarPage.Maximum;

            numericUpDownGenPerPage.Maximum = gens;
            if (numericUpDownGenPerPage.Value > numericUpDownGenPerPage.Maximum)
                numericUpDownGenPerPage.Value = numericUpDownGenPerPage.Maximum;


            groupBoxChartControl1.Enabled = true;
            numericUpDownGenPerPage.Value = gens;
            trackBarPage.Value = 0;

            chartGeneSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartGeneSelection.ChartAreas[0].AxisX.Maximum = chartGeneSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

        }

        private void OneThreadGeneSelection()
        {
            chartGeneSelection.ChartAreas[0].AxisY.Maximum = 100;
            chartGeneSelection.ChartAreas[0].AxisY.Minimum = 0;

            int pop_size = Convert.ToInt32(textBoxPop.Text);
            int generations = Convert.ToInt32(textBoxMaxGen.Text);
            int numberSelected = Convert.ToInt32(textBoxSelect.Text);
            float target = Convert.ToSingle(textBoxTarget.Text);
            int gens = 0;
            Gene[] population = new Gene[pop_size];
            List<double[]> chartData = new List<double[]>();

            Gene bestdna = null;
            const int MAXFITNESS = 100;

            chartGeneSelection.Series[0].Points.Clear();

            //Start Population
            for (int i = 0; i < pop_size; i++)
                population[i] = new Gene(MainForm.RandomizationType);


            for (int i = 0; i < generations; i++)
            {
                gens = i + 1;

                double[] fitnessArray = new double[pop_size];

                for (int j = 0; j < pop_size; j++)
                {
                    Gene gene = population[j];

                    gene.Fitness = MAXFITNESS / (1 + (Math.Abs(target - gene.Value) / 100));
                    fitnessArray[j] = gene.Fitness;
                }

                Array.Sort(fitnessArray);
                chartData.Add(fitnessArray);

                Array.Sort(population);
                Array.Reverse(population);

                bestdna = population[0];

                if (bestdna.Fitness == MAXFITNESS)
                    break;

                for (int k = numberSelected; k < pop_size; k++)
                {
                    int i1 = random.Next(0, numberSelected);
                    int i2 = random.Next(0, numberSelected);
                    Gene gene = new Gene(population[i1], population[i2]);

                    population[k] = gene;
                }
            }

            /*
             * Update GUI
             */

            //Update chart
            for (int g = 0; g < chartData.Count; g++)
                for (int f = 0; f < chartData[g].Length; f++)
                    chartGeneSelection.Series[0].Points.Add(chartData[g][f]);

            textBoxBestDna.Text = bestdna.GetDnaSequenceReadable(false);
            labelCG.Text = bestdna.DnaSequence.ToString();
            textBoxNumGen.Text = gens.ToString();

            textBoxBestFit.Text = bestdna.Fitness.ToString();
            textBoxV4.Text = bestdna.Value.ToString();


            //Update chart tools
            lastPopSize = pop_size;

            int num_pages = (int)Math.Ceiling(gens / numericUpDownGenPerPage.Value);

            trackBarPage.Maximum = num_pages - 1;
            if (trackBarPage.Value > trackBarPage.Maximum)
                trackBarPage.Value = trackBarPage.Maximum;
            trackBarPage.Enabled = trackBarPage.Minimum != trackBarPage.Maximum;

            numericUpDownGenPerPage.Maximum = gens;
            if (numericUpDownGenPerPage.Value > numericUpDownGenPerPage.Maximum)
                numericUpDownGenPerPage.Value = numericUpDownGenPerPage.Maximum;

            groupBoxChartControl1.Enabled = true;
            numericUpDownGenPerPage.Value = gens;
            trackBarPage.Value = 0;

            chartGeneSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartGeneSelection.ChartAreas[0].AxisX.Maximum = chartGeneSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

        }

        private void NumericUpDownGenPerPage_ValueChanged(object sender, EventArgs e)
        {
            chartGeneSelection.ChartAreas[0].AxisX.Minimum = trackBarPage.Value * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartGeneSelection.ChartAreas[0].AxisX.Maximum = chartGeneSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;
            int num_pages = (int)Math.Ceiling(Convert.ToInt32(textBoxNumGen.Text) / numericUpDownGenPerPage.Value);
            trackBarPage.Maximum = num_pages - 1;

            if (trackBarPage.Value > trackBarPage.Maximum)
                trackBarPage.Value = trackBarPage.Maximum;

            trackBarPage.Enabled = trackBarPage.Minimum != trackBarPage.Maximum;
        }

        private void TrackBarPage_Scroll(object sender, EventArgs e)
        {
            chartGeneSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartGeneSelection.ChartAreas[0].AxisX.Maximum = chartGeneSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

            toolTip.SetToolTip(trackBarPage, trackBarPage.Value + 1 + "/" + (trackBarPage.Maximum + 1));
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;

            Utils.PrintTimingMethod("MultiThread", () => MultiThreadGeneSelection());

            // Utils.PrintTimingMethod("OneThread", () => OneThreadGeneSelection());
            buttonRun.Enabled = true;
        }

        private void ButtonRadom_Click(object sender, EventArgs e)
        {
            textBoxTarget.Text = Convert.ToString(random.Next(-9999, 9999) / 1000f);
        }

    }
}
