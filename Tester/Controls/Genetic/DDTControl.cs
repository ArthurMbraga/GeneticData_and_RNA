using GeneticData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tester.Controls
{
    public partial class DDTControl : UserControl
    {
        private static Random random = new Random()
            ;
        public DDTControl()
        {
            InitializeComponent();


            ChartArea CA = chartDispertion.ChartAreas[0];
            CA.Position = new ElementPosition(0, 0, 100, 100);
            CA.InnerPlotPosition = new ElementPosition(4, 2, 95, 93);
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            float[] values = new float[1000];
            chartDispertion.Series[0].Points.Clear();
            chartDispertion.ChartAreas[0].AxisY.Minimum = -600;
            chartDispertion.ChartAreas[0].AxisY.Maximum = +600;

            for (int i = 0; i < 1000; i++)
                values[i] = random.Next(-600, 600);

            Array.Sort(values);

            chartDispertion.Series[0].Points.DataBindY(values);
        }

        private void ButtonBinary_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGenetic_Click(object sender, EventArgs e)
        {
            List<Gene> genes = new List<Gene>();
            chartDispertion.Series[0].Points.Clear();
            chartDispertion.ChartAreas[0].AxisY.Minimum = -100;
            chartDispertion.ChartAreas[0].AxisY.Maximum = 100;

            for (int i = 0; i < 1000; i++)
            {
                Gene d = new Gene(RandomizationType.FullRandom);
                genes.Add(d);
            }

            genes = genes.OrderBy(o => o.Value).ToList();

            foreach (Gene d in genes)
                chartDispertion.Series[0].Points.AddY(d.Value);
        }

        private void ButtonDerivate_Click(object sender, EventArgs e)
        {
            double[] values = new double[chartDispertion.Series[0].Points.Count - 1];

            for (int i = 0; i < values.Length - 1; i++)
                values[i] = chartDispertion.Series[0].Points[i + 1].YValues[0] - chartDispertion.Series[0].Points[i].YValues[0];

            chartDispertion.Series[0].Points.Clear();

            chartDispertion.ChartAreas[0].AxisY.Minimum = -10;
            chartDispertion.ChartAreas[0].AxisY.Maximum = 10;


            chartDispertion.Series[0].Points.DataBindY(values);
        }
    }
}
