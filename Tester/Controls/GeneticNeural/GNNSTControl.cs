using ArtificialNeuralNetwork;
using GeneticData;
using GeneticNeuralNetwork;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester.Controls.GeneticNeural
{
    public partial class GNNSTControl : UserControl
    {
        private int lastPopSize;

        const int MAXFITNESS = 100;
        const int RANGE = 720;
        const int FITNESSREPTIONS = 360;
        private GenNeuralNet bestGNN = null;

        public GNNSTControl()
        {
            InitializeComponent();
        }

        private void GNNSTControl_Load(object sender, EventArgs e)
        {

        }

        private void NumericUpDownGenPerPage_ValueChanged(object sender, EventArgs e)
        {
            chartGNNSelection.ChartAreas[0].AxisX.Minimum = trackBarPage.Value * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartGNNSelection.ChartAreas[0].AxisX.Maximum = chartGNNSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;
            int num_pages = (int)Math.Ceiling(Convert.ToInt32(textBoxNumGen.Text) / numericUpDownGenPerPage.Value);
            trackBarPage.Maximum = num_pages - 1;

            if (trackBarPage.Value > trackBarPage.Maximum)
                trackBarPage.Value = trackBarPage.Maximum;

            trackBarPage.Enabled = trackBarPage.Minimum != trackBarPage.Maximum;
        }

        private void TrackBarPage_Scroll(object sender, EventArgs e)
        {
            chartGNNSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartGNNSelection.ChartAreas[0].AxisX.Maximum = chartGNNSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

            toolTip.SetToolTip(trackBarPage, trackBarPage.Value + 1 + "/" + (trackBarPage.Maximum + 1));
        }

        private void OneThreadGNNSelection()
        {
            chartGNNSelection.ChartAreas[0].AxisY.Maximum = 100;
            chartGNNSelection.ChartAreas[0].AxisY.Minimum = 0;

            int pop_size = Convert.ToInt32(textBoxPop.Text);
            int generations = Convert.ToInt32(textBoxMaxGen.Text);
            int numberSelected = Convert.ToInt32(textBoxSelect.Text);

            int numHL = Convert.ToInt32(textBoxHL.Text);
            int numHLN = Convert.ToInt32(textBoxHLN.Text);


            int gens = 0;


            GenNeuralNet[] population = new GenNeuralNet[pop_size];
            List<double[]> chartData = new List<double[]>();




            chartGNNSelection.Series[0].Points.Clear();

            ChromossomeConfig config = checkBoxDominance.Checked ? ChromossomeConfig.WithDominance : ChromossomeConfig.NoDominance;

            //Start Population
            for (int i = 0; i < pop_size; i++)
            {
                population[i] = new GenNeuralNet(3, numHL, numHLN, 1, config);
                population[i].Randomize();
            }

            for (int i = 0; i < generations; i++)
            {
                gens = i + 1;

                double[] fitnessArray = new double[pop_size];

                for (int j = 0; j < pop_size; j++)
                {
                    GenNeuralNet genNeuralNet = population[j];

                    //Calculate fitness
                    Matrix<float> inputs = Matrix<float>.Build.Dense(1, 3);

                    float sumFit = 0;
                    for (int t = 0; t < FITNESSREPTIONS; t++)
                    {
                        inputs[0, 0] = ThreadSafeRandom.Next(-RANGE, RANGE);
                        inputs[0, 1] = ThreadSafeRandom.Next(-RANGE, RANGE);

                        int target;

                        if (t < FITNESSREPTIONS / 2)
                        {
                            inputs[0, 2] = inputs[0, 0] + inputs[0, 1];
                            target = 1;
                        }
                        else
                        {
                            inputs[0, 2] = ThreadSafeRandom.Next(-2 * RANGE, 2 * RANGE);

                            while (inputs[0, 2] == inputs[0, 0] + inputs[0, 1])
                                inputs[0, 2] = ThreadSafeRandom.Next(-2 * RANGE, 2 * RANGE);

                            target = 0;
                        }

                        Matrix<float> result = genNeuralNet.Compute(inputs);

                        sumFit += (float)Math.Pow(Math.Abs(target - result[0, 0]), 2);
                    }

                    genNeuralNet.Fitness = MAXFITNESS / (1 + (sumFit / 100));

                    fitnessArray[j] = genNeuralNet.Fitness;
                }

                Array.Sort(fitnessArray);
                chartData.Add(fitnessArray);

                Array.Sort(population);
                Array.Reverse(population);

                bestGNN = population[0];

                if (bestGNN.Fitness == MAXFITNESS)
                    break;

                for (int k = numberSelected; k < pop_size; k++)
                {
                    int i1 = ThreadSafeRandom.Next(0, numberSelected);
                    int i2 = ThreadSafeRandom.Next(0, numberSelected);
                    GenNeuralNet genNeuralNet = new GenNeuralNet(population[i1], population[i2]);

                    population[k] = genNeuralNet;
                }
            }

            /*
             * Update GUI
             */

            //Update chart
            for (int g = 0; g < chartData.Count; g++)
                for (int f = 0; f < chartData[g].Length; f++)
                    chartGNNSelection.Series[0].Points.Add(chartData[g][f]);

            textBoxNumGen.Text = gens.ToString();
            textBoxBestFit.Text = bestGNN.Fitness.ToString();
            groupBoxTest.Enabled = true;

            FillRandom();

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

            chartGNNSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartGNNSelection.ChartAreas[0].AxisX.Maximum = chartGNNSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

        }

        private void MultiThreadGNNSelection()
        {
            chartGNNSelection.ChartAreas[0].AxisY.Maximum = 100;
            chartGNNSelection.ChartAreas[0].AxisY.Minimum = 0;

            int pop_size = Convert.ToInt32(textBoxPop.Text);
            int generations = Convert.ToInt32(textBoxMaxGen.Text);
            int numberSelected = Convert.ToInt32(textBoxSelect.Text);

            int numHL = Convert.ToInt32(textBoxHL.Text);
            int numHLN = Convert.ToInt32(textBoxHLN.Text);


            int gens = 0;


            GenNeuralNet[] population = new GenNeuralNet[pop_size];
            List<double[]> chartData = new List<double[]>();


            chartGNNSelection.Series[0].Points.Clear();

            ChromossomeConfig config = checkBoxDominance.Checked ? ChromossomeConfig.WithDominance : ChromossomeConfig.NoDominance;

            //Start Population
            for (int i = 0; i < pop_size; i++)
            {
                population[i] = new GenNeuralNet(1, numHL, numHLN, 1, config);
                population[i].Randomize();
            }

            for (int i = 0; i < generations; i++)
            {
                gens = i + 1;

                double[] fitnessArray = new double[pop_size];

                Parallel.For(0, pop_size, j =>
                {
                    GenNeuralNet genNeuralNet = population[j];

                    //Calculate fitness
                    Matrix<float> inputs = Matrix<float>.Build.Dense(1, 1);

                    float sumFit = 0;

                    for (int t = 0; t < FITNESSREPTIONS; t++)
                    {
                        inputs[0, 0] = t;
                       // inputs[0, 1] = ThreadSafeRandom.Next(-RANGE, RANGE);

                        float targetTrue = (float)Math.Sin(ConvertToRadians(inputs[0, 0]));

                        /*if (t < FITNESSREPTIONS/2)
                        {
                            inputs[0, 2] = inputs[0, 0] + inputs[0, 1];
                            targetTrue = 1;
                        }
                        else
                        {
                            if (ThreadSafeRandom.TorF)
                            {
                                inputs[0, 2] = ThreadSafeRandom.Next(-2 * RANGE, 2 * RANGE);

                                while (inputs[0, 2] == inputs[0, 0] + inputs[0, 1])
                                    inputs[0, 2] = ThreadSafeRandom.Next(-2 * RANGE, 2 * RANGE);
                            }
                            else
                            {
                                inputs[0, 2] = inputs[0, 0] + inputs[0, 1];

                                if (ThreadSafeRandom.TorF)
                                    inputs[0, 1] += ThreadSafeRandom.TorF ? 1 : -1;
                                else
                                    inputs[0, 2] += ThreadSafeRandom.TorF ? 1 : -1;
                            }
                            targetTrue = 0;
                        }*/



                        Matrix<float> result = genNeuralNet.Compute(inputs);

                        float dist = (float)Math.Pow(Math.Abs(targetTrue) - result[0, 0], 2);

                        //int targetFalse = Math.Abs(targetTrue - 1);

                        //dist += Math.Abs(targetFalse - result[0, 1]);
                        sumFit += dist;
                    }
                    
                    sumFit /= FITNESSREPTIONS;

                    sumFit = (float)Math.Sqrt(sumFit);

                    /*if (sumFit > 0.5f)
                        sumFit = 0.5f;*/

                    genNeuralNet.Fitness = (float)Math.Pow((2f * sumFit) - 1f, 2) * MAXFITNESS;

                    /*if (genNeuralNet.Fitness < 0)
                        Console.Write("");*/

                    fitnessArray[j] = genNeuralNet.Fitness;
                });

                Array.Sort(fitnessArray);
                chartData.Add(fitnessArray);

                Array.Sort(population);
                Array.Reverse(population);

                bestGNN = population[0];

                /*if (bestGNN.Fitness == MAXFITNESS)
                    break;*/

                Parallel.For(numberSelected, pop_size, k =>
                {
                    int i1 = ThreadSafeRandom.Next(0, numberSelected);
                    int i2 = ThreadSafeRandom.Next(0, numberSelected);
                    GenNeuralNet genNeuralNet = new GenNeuralNet(population[i1], population[i2]);

                    population[k] = genNeuralNet;
                });
            }

            /*
             * Update GUI
             */

            //Update chart
            for (int g = 0; g < chartData.Count; g++)
                for (int f = 0; f < chartData[g].Length; f++)
                    chartGNNSelection.Series[0].Points.Add(chartData[g][f]);

            textBoxNumGen.Text = gens.ToString();
            textBoxBestFit.Text = bestGNN.Fitness.ToString();
            groupBoxTest.Enabled = true;

            FillRandom();

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

            chartGNNSelection.ChartAreas[0].AxisX.Minimum = (trackBarPage.Value) * (int)numericUpDownGenPerPage.Value * lastPopSize;
            chartGNNSelection.ChartAreas[0].AxisX.Maximum = chartGNNSelection.ChartAreas[0].AxisX.Minimum + (int)numericUpDownGenPerPage.Value * lastPopSize;

        }

        private void FillRandom()
        {
            int v1 = ThreadSafeRandom.Next(-RANGE, RANGE);
            //int v2 = ThreadSafeRandom.Next(-RANGE, RANGE);
            //int v3;

            textBoxV1.Text = v1.ToString();
            /*textBoxV2.Text = v2.ToString();

            if (ThreadSafeRandom.TorF)
            {
                v3 = v1 + v2;

                textBoxA.Text = "1 / 0";
            }
            else
            {
                if (ThreadSafeRandom.TorF)
                {
                    v3 = ThreadSafeRandom.Next(-2 * RANGE, 2 * RANGE);

                    while (v3 == v1 + v2)
                        v3 = ThreadSafeRandom.Next(-2000, 2000);
                }
                else
                {
                    v3 = v1 + v2;

                    if (ThreadSafeRandom.TorF)
                        v1 += ThreadSafeRandom.TorF ? -1 : 1;
                    else
                        v2 += ThreadSafeRandom.TorF ? -1 : 1;
                }

                textBoxA.Text = "0 / 1";
            }
            */

            //textBoxV3.Text = v3.ToString();
            Matrix<float> input = Matrix<float>.Build.Dense(1, 1);
            input[0, 0] = v1;
            textBoxA.Text = Math.Sin(ConvertToRadians(v1)).ToString();

            textBoxO1.Text = bestGNN.Compute(input)[0, 0].ToString("0.00");
          //  textBoxO2.Text = bestGNN.Compute(input)[0, 1].ToString("0.00");
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            FillRandom();
            // Console.WriteLine(bestGNN.Weights[ThreadSafeRandom.Next(0,bestGNN.Weights.Length)].ToString());
            Console.WriteLine(bestGNN.AccountsToString());
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            //OneThreadGNNSelection();
            MultiThreadGNNSelection();
        }

        private void TextBoxV_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                float v1 = Convert.ToSingle(textBoxV1.Text);

                Matrix<float> input = Matrix<float>.Build.Dense(1, 1);
                input[0, 0] = v1;

                textBoxA.Text = Math.Sin(ConvertToRadians(v1)).ToString();
                textBoxO1.Text = bestGNN.Compute(input)[0, 0].ToString("0.00");
              //  textBoxO2.Text = bestGNN.Compute(input)[0, 1].ToString("0.00");
            }
            catch
            {
                textBoxA.Text = "";
                textBoxO1.Text = "";
                textBoxO2.Text = "";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (Form form = new Form())
            {
                Bitmap img = bestGNN.Draw();

                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = new Size((int)(img.Size.Width * 1.2f), (int)(img.Size.Height * 1.2f));
                form.MinimumSize = img.Size;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = img;

                form.Controls.Add(pb);
                form.ShowDialog();
            }
        }

        public double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

    }
}
