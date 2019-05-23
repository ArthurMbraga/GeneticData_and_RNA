using GeneticData;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tester.Controls
{
    public partial class CSTControl : UserControl
    {
        private static Random random = new Random();
        private int lastPopSize;
        private ToolTip toolTip = new ToolTip();

        public CSTControl()
        {
            InitializeComponent();

            ChartArea CA = chartChromossomeSelection.ChartAreas[0];
            CA.Position = new ElementPosition(0, 0, 100, 100);
            CA.InnerPlotPosition = new ElementPosition(4, 2, 95, 93);


            textBoxTarget.Text = Convert.ToString(random.Next(-9999, 9999) / 1000f);
        }

        private void MultiThreadChromosomeSelection()
        {
            chartChromossomeSelection.ChartAreas[0].AxisY.Maximum = 100;
            chartChromossomeSelection.ChartAreas[0].AxisY.Minimum = 0;

            int pop_size = Convert.ToInt32(textBoxPop.Text);
            int generations = Convert.ToInt32(textBoxMaxGen.Text);
            int numberSelected = Convert.ToInt32(textBoxSelect.Text);
            float target = Convert.ToSingle(textBoxTarget.Text);
            int gens = 0;

            List<double[]> chartData = new List<double[]>();
            Chromosome[] population = new Chromosome[pop_size];
            const int MAXFITNESS = 100;

            chartChromossomeSelection.Series[0].Points.Clear();


            //Start Population
            Parallel.For(0, pop_size, i =>
            {
                population[i] = new Chromosome(3, checkBoxDominance.Checked ? ChromossomeConfig.WithDominance : ChromossomeConfig.NoDominance);
                population[i].Randomize(RandomizationType.FullRandom);
            });


            Chromosome bestChromossome = null;
            float bestResult = 0;

            for (int i = 0; i < generations; i++)
            {
                gens = i + 1;

                double[] fitnessArray = new double[pop_size];

                Parallel.For(0, pop_size, j =>
                {
                    Chromosome c = population[j];

                    //Fitness = X + XY(Z + Y) - ZY - ZY(X + Y)
                    float x = c.GeneListExpessed[0].Value;
                    float y = c.GeneListExpessed[1].Value;
                    float z = c.GeneListExpessed[2].Value;

                    float result = ValueFinalOperation(x, y, z);

                    c.Fitness = MAXFITNESS / (1 + (Math.Abs(target - result) / 100));
                    fitnessArray[j] = c.Fitness;
                });

                Array.Sort(fitnessArray);
                chartData.Add(fitnessArray);

                Array.Sort(population);
                Array.Reverse(population);

                bestChromossome = population[i];
                bestResult = ValueFinalOperation(bestChromossome.GeneListExpessed[0].Value, bestChromossome.GeneListExpessed[1].Value, bestChromossome.GeneListExpessed[2].Value);

                if (bestChromossome.Fitness == MAXFITNESS)
                    break;

                Parallel.For(numberSelected, pop_size, k =>
                {
                    int i1 = random.Next(0, numberSelected);
                    int i2 = random.Next(0, numberSelected);
                    Chromosome gene = new Chromosome(population[i1], population[i2]);

                    population[k] = gene;
                });
            }

            /*
             * Update GUI
             */

            //Update chart
            for (int g = 0; g < chartData.Count; g++)
                for (int f = 0; f < chartData[g].Length; f++)
                    chartChromossomeSelection.Series[0].Points.Add(chartData[g][f]);

            textBoxNumGen.Text = gens.ToString();
            textBoxBestFit.Text = bestChromossome.Fitness.ToString();
            textBoxVV1.Text = bestChromossome.GeneListExpessed[0].Value.ToString();
            textBoxVV2.Text = bestChromossome.GeneListExpessed[1].Value.ToString();
            textBoxVV3.Text = bestChromossome.GeneListExpessed[2].Value.ToString();
            textBoxVVF.Text = bestResult.ToString();

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


            groupBoxChartControl.Enabled = true;
            numericUpDownGenPerPage.Value = gens;
            trackBarPage.Value = 0;

            chartChromossomeSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartChromossomeSelection.ChartAreas[0].AxisX.Maximum = chartChromossomeSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

        }

        private void OneThreadChromosomeSelection()
        {
            chartChromossomeSelection.ChartAreas[0].AxisY.Maximum = 100;
            chartChromossomeSelection.ChartAreas[0].AxisY.Minimum = 0;

            int pop_size = Convert.ToInt32(textBoxPop.Text);
            int generations = Convert.ToInt32(textBoxMaxGen.Text);
            int numberSelected = Convert.ToInt32(textBoxSelect.Text);
            float target = Convert.ToSingle(textBoxTarget.Text);
            int gens = 0;

            List<double[]> chartData = new List<double[]>();
            Chromosome[] population = new Chromosome[pop_size];
            const int MAXFITNESS = 100;

            chartChromossomeSelection.Series[0].Points.Clear();


            //Start Population
            for (int i = 0; i < pop_size; i++)
                population[i] = new Chromosome(3, checkBoxDominance.Checked ? ChromossomeConfig.WithDominance : ChromossomeConfig.NoDominance);


            Chromosome bestChromossome = null;
            float bestResult = 0;

            for (int i = 0; i < generations; i++)
            {
                gens = i + 1;

                double[] fitnessArray = new double[pop_size];

                for (int j = 0; j < pop_size; j++)
                {
                    Chromosome c = population[j];

                    //Fitness = X + XY(Z + Y) - ZY - ZY(X + Y)
                    float x = c.GeneListExpessed[0].Value;
                    float y = c.GeneListExpessed[1].Value;
                    float z = c.GeneListExpessed[2].Value;

                    float result = ValueFinalOperation(x, y, z);

                    c.Fitness = MAXFITNESS / (1 + (Math.Abs(target - result) / 100));
                    fitnessArray[j] = c.Fitness;
                }

                Array.Sort(fitnessArray);
                chartData.Add(fitnessArray);

                Array.Sort(population);
                Array.Reverse(population);

                bestChromossome = population[i];
                bestResult = ValueFinalOperation(bestChromossome.GeneListExpessed[0].Value, bestChromossome.GeneListExpessed[1].Value, bestChromossome.GeneListExpessed[2].Value);

                if (bestChromossome.Fitness == MAXFITNESS)
                    break;

                for (int k = numberSelected; k < pop_size; k++)
                {
                    int i1 = random.Next(0, numberSelected);
                    int i2 = random.Next(0, numberSelected);
                    Chromosome gene = new Chromosome(population[i1], population[i2]);

                    population[k] = gene;
                }
            }

            /*
             * Update GUI
             */

            //Update chart
            for (int g = 0; g < chartData.Count; g++)
                for (int f = 0; f < chartData[g].Length; f++)
                    chartChromossomeSelection.Series[0].Points.Add(chartData[g][f]);

            textBoxNumGen.Text = gens.ToString();
            textBoxBestFit.Text = bestChromossome.Fitness.ToString();
            textBoxVV1.Text = bestChromossome.GeneListExpessed[0].Value.ToString();
            textBoxVV2.Text = bestChromossome.GeneListExpessed[1].Value.ToString();
            textBoxVV3.Text = bestChromossome.GeneListExpessed[2].Value.ToString();
            textBoxVVF.Text = bestResult.ToString();

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


            groupBoxChartControl.Enabled = true;
            numericUpDownGenPerPage.Value = gens;
            trackBarPage.Value = 0;

            chartChromossomeSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartChromossomeSelection.ChartAreas[0].AxisX.Maximum = chartChromossomeSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

        }

        private float ValueFinalOperation(float x, float y, float z) => x + x * y * (z + y) - z * y - z * y * (x + y);

        private void NumericUpDownGenPerPage_ValueChanged(object sender, EventArgs e)
        {
            chartChromossomeSelection.ChartAreas[0].AxisX.Minimum = trackBarPage.Value * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartChromossomeSelection.ChartAreas[0].AxisX.Maximum = chartChromossomeSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;
            int num_pages = (int)Math.Ceiling(Convert.ToInt32(textBoxNumGen.Text) / numericUpDownGenPerPage.Value);
            trackBarPage.Maximum = num_pages - 1;

            if (trackBarPage.Value > trackBarPage.Maximum)
                trackBarPage.Value = trackBarPage.Maximum;

            trackBarPage.Enabled = trackBarPage.Minimum != trackBarPage.Maximum;
        }

        private void TrackBarPage_Scroll(object sender, EventArgs e)
        {
            chartChromossomeSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartChromossomeSelection.ChartAreas[0].AxisX.Maximum = chartChromossomeSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

            toolTip.SetToolTip(trackBarPage, (trackBarPage.Value + 1) + "/" + (trackBarPage.Maximum + 1));
        }
        private void ButtonRun_Click(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;

            Utils.PrintTimingMethod("MultiThread", () => MultiThreadChromosomeSelection());

            //Utils.PrintTimingMethod("OneThread", () => OneThreadChromosomeSelection());
            buttonRun.Enabled = true;
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            textBoxTarget.Text = Convert.ToString(random.Next(-9999, 9999) / 1000f);
        }

    }
}
