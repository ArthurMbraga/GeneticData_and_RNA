using GeneticData;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tester.Controls
{
    public partial class COGTControl : UserControl
    {
        public COGTControl()
        {
            InitializeComponent();

            Gene g1 = new Gene(MainForm.RandomizationType);
            Gene g2 = new Gene(MainForm.RandomizationType);

            textBoxG1.Text = g1.GetDnaSequenceReadable(false);
            textBoxV1.Text = g1.Value.ToString();
            labelGC1.Text = g1.DnaSequence.ToString();

            textBoxG2.Text = g2.GetDnaSequenceReadable(false);
            textBoxV2.Text = g2.Value.ToString();
            labelGC2.Text = g2.DnaSequence.ToString();

            ChartArea CA = chartDistribution.ChartAreas[0];
            CA.Position = new ElementPosition(0, 0, 100, 100);
            CA.InnerPlotPosition = new ElementPosition(4, 2, 95, 92);
        }

        private void TextBoxG1_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxV1.Text = "";
            labelGC1.Text = "Error";

            try
            {
                Gene temp = new Gene(Gene.GetDnaSequenceByReadable(textBoxG1.Text));
                textBoxV1.Text = temp.Value.ToString();
                labelGC1.Text = temp.DnaSequence.ToString();
                buttonRun.Enabled = true;
            }
            catch { buttonRun.Enabled = false; }
        }

        private void TextBoxG2_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxV2.Text = "ERROR";
            labelGC2.Text = "-";

            try
            {
                Gene temp = new Gene(Gene.GetDnaSequenceByReadable(textBoxG2.Text));
                textBoxV2.Text = temp.Value.ToString();
                buttonRun.Enabled = true;
            }
            catch { buttonRun.Enabled = false; }
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {            
            chartDistribution.Series[0].Points.Clear();
            chartDistribution.Series[1].Points.Clear();
            chartDistribution.Series[2].Points.Clear();
            chartDistribution.Series[3].Points.Clear();
            chartDistribution.Series[4].Points.Clear();


            int times = Convert.ToInt32(textBoxTimes.Text);
            

            Gene g1 = new Gene(Gene.GetDnaSequenceByReadable(textBoxG1.Text));
            Gene g2 = new Gene(Gene.GetDnaSequenceByReadable(textBoxG2.Text));

            float[] values = new float[times];

            float median = 0;
            float resultAverage = 0;
            float min = 10000;
            float max = -10000;
            float deviation = 0;


            for (int i = 0; i < times; i++)
            {
                Gene temp = new Gene(g1, g2);
                values[i] = temp.Value;

                resultAverage += temp.Value;

                if (temp.Value > max)
                    max = temp.Value;

                if (temp.Value < min)
                    min = temp.Value;
            }

            if (checkBoxSort.Checked)
                Array.Sort(values);

            resultAverage /= times;

            foreach (float f in values)
                deviation += (float)Math.Pow(f - resultAverage, 2);

            deviation /= times;
            deviation = (float)Math.Sqrt(deviation);

            if (times % 2 == 0)
                median = (values[(times - 1) / 2] + values[(times) / 2]) / 2;
            else
                median = values[(int)Math.Round(times / 2f)];


            /*
             * Update GUI
             */

            textBoxAverage.Text = resultAverage.ToString();
            textBoxMedian.Text = median.ToString();
            textBoxMax.Text = max.ToString();
            textBoxMin.Text = min.ToString();
            textBoxDeviation.Text = deviation.ToString();

            //Update Chart

            float labelXPoint1 = times * 0.95f;
            float labelXPoint2 = times * 0.05f;
            //V1
            chartDistribution.Series[0].Points.AddXY(0, g1.Value);
            chartDistribution.Series[0].Points.AddXY(labelXPoint1, g1.Value);
            chartDistribution.Series[0].Points.AddXY(times, g1.Value);
            chartDistribution.Series[0].Points[1].Label = "Value 1";
            chartDistribution.Series[0].Points[1].LabelBackColor = Color.White;

            //V2
            chartDistribution.Series[1].Points.AddXY(0, g2.Value);
            chartDistribution.Series[1].Points.AddXY(labelXPoint1, g2.Value);
            chartDistribution.Series[1].Points.AddXY(times, g2.Value);
            chartDistribution.Series[1].Points[1].Label = "Value 2";
            chartDistribution.Series[1].Points[1].LabelBackColor = Color.White;

            //Result Average
            chartDistribution.Series[2].Points.AddXY(0, resultAverage);
            chartDistribution.Series[2].Points.AddXY(labelXPoint2, resultAverage);
            chartDistribution.Series[2].Points.AddXY(times, resultAverage);
            chartDistribution.Series[2].Points[1].Label = "Result Average";
            chartDistribution.Series[2].Points[1].LabelBackColor = Color.White;

            //Values Average
            float valuesAverage = Convert.ToSingle(labelAverage.Text);
            chartDistribution.Series[3].Points.AddXY(0, valuesAverage);
            chartDistribution.Series[3].Points.AddXY(labelXPoint2, valuesAverage);
            chartDistribution.Series[3].Points.AddXY(times, valuesAverage);
            chartDistribution.Series[3].Points[1].LabelBackColor = Color.White;
            chartDistribution.Series[3].Points[1].Label = "Values Average";

            //Values
            chartDistribution.Series[4].Points.DataBindY(values);

            chartDistribution.ChartAreas[0].AxisX.Minimum = 0;
            chartDistribution.ChartAreas[0].AxisX.Maximum = times;
            chartDistribution.ChartAreas[0].AxisY.Maximum = Math.Ceiling(deviation);
            chartDistribution.ChartAreas[0].AxisY.Minimum = Math.Ceiling(-deviation);
        }
        private void TextBoxValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxV1.Text.Length > 0 && textBoxV2.Text.Length > 0)
            {
                float v1 = Convert.ToSingle(textBoxV1.Text);
                float v2 = Convert.ToSingle(textBoxV2.Text);
                float average = (v1 + v2) / 2;
                labelAverage.Text = average.ToString();
            }
            else
                labelAverage.Text = "-";
        }

        private void ButtonRandomStructure1_Click(object sender, EventArgs e)
        {
            Gene g = new Gene(MainForm.RandomizationType);
            textBoxG1.Text = g.GetDnaSequenceReadable(false);
            textBoxV1.Text = g.Value.ToString();
            labelGC1.Text = g.DnaSequence.ToString();
        }

        private void ButtonRandomStructure2_Click(object sender, EventArgs e)
        {
            Gene g = new Gene(MainForm.RandomizationType);
            textBoxG2.Text = g.GetDnaSequenceReadable(false);
            textBoxV2.Text = g.Value.ToString();
            labelGC2.Text = g.DnaSequence.ToString();
        }
    }
}
