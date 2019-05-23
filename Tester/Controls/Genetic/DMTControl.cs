using GeneticData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tester.Controls
{
    public partial class DMTControl : UserControl
    {
        public DMTControl()
        {
            InitializeComponent();

            ChartArea CA = chartMutation.ChartAreas[0];
            CA.Position = new ElementPosition(0, 0, 100, 100);
            CA.InnerPlotPosition = new ElementPosition(4, 2, 95, 93);


            Gene g = new Gene(MainForm.RandomizationType);

            textBoxG3.Text = g.GetDnaSequenceReadable(false);
            textBoxV3.Text = g.Value.ToString();
            labelGC3.Text = g.DnaSequence.ToString();
        }

        private void ButtonRandomStructure_Click(object sender, EventArgs e)
        {
            Gene g = new Gene(MainForm.RandomizationType);
            textBoxG3.Text = g.GetDnaSequenceReadable(false);
            textBoxV3.Text = g.Value.ToString();
            labelGC3.Text = g.DnaSequence.ToString();
        }

        private void TextBoxG_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxV3.Text = "";
            labelGC3.Text = "";

            try
            {
                Gene temp = new Gene(Gene.GetDnaSequenceByReadable(textBoxG3.Text));
                textBoxV3.Text = temp.Value.ToString();
                labelGC3.Text = temp.DnaSequence.ToString();
            }
            catch { }
        }

        private void ButtonMutate_Click(object sender, EventArgs e)
        {
            chartMutation.Series[0].Points.Clear();
            chartMutation.Series[1].Points.Clear();
            chartMutation.Series[2].Points.Clear();

            List<float> mutationValues = new List<float>();

            int cicles = Convert.ToInt32(textBoxTimes2.Text);
            float max = -10000;
            float min = 10000;
            float average = 0;
            float median;
            float deviation = 0;
            float percent;


            richTextBoxResults.Text = "";

            Gene gMother = new Gene(Gene.GetDnaSequenceByReadable(textBoxG3.Text));

            for (int i = 0; i < cicles; i++)
            {
                Gene g3 = new Gene(Gene.GetDnaSequenceByReadable(textBoxG3.Text));
                g3.Mutate();
                if (g3.DnaSequence.ToString() != gMother.DnaSequence.ToString())
                {
                    average += g3.Value;
                    mutationValues.Add(g3.Value);
                    richTextBoxResults.Text += g3.DnaSequence + " => " + g3.Value.ToString() + "\n";

                    deviation += (float)Math.Pow(g3.Value - Convert.ToSingle(textBoxV3.Text), 2);

                    if (g3.Value > max)
                        max = g3.Value;

                    if (g3.Value < min)
                        min = g3.Value;
                }
            }

            mutationValues.Sort();


            deviation /= mutationValues.Count;
            deviation = (float)Math.Sqrt(deviation);

            average /= mutationValues.Count;

            if (mutationValues.Count != 0)
                if (mutationValues.Count % 2 == 0)
                    median = (mutationValues[(mutationValues.Count - 1) / 2] + mutationValues[(mutationValues.Count) / 2]) / 2;
                else
                    median = mutationValues[(int)Math.Round(mutationValues.Count / 2f)];
            else
                median = 0;

            percent = mutationValues.Count * 100f / cicles;

            textBoxMedian2.Text = median.ToString();
            textBoxChanges.Text = mutationValues.Count.ToString() + " / " + percent.ToString() + "%";
            textBoxAverage2.Text = average.ToString();
            textBoxMax2.Text = max.ToString();
            textBoxMin2.Text = min.ToString();
            textBoxDeviation2.Text = deviation.ToString();

            //Update Chart

            //Value
            chartMutation.Series[0].Points.AddXY(0, gMother.Value);
            chartMutation.Series[0].Points.AddXY(mutationValues.Count, gMother.Value);

            //Average Mutations
            chartMutation.Series[1].Points.AddXY(0, average);
            chartMutation.Series[1].Points.AddXY(mutationValues.Count, average);

            chartMutation.Series[2].Points.DataBindY(mutationValues);

            chartMutation.ChartAreas[0].AxisX.Minimum = 0;
            chartMutation.ChartAreas[0].AxisX.Maximum = mutationValues.Count;
        }
    }
}
