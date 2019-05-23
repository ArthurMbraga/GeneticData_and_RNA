using System;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {

        public static Random random = new Random();

        private readonly Tip[] toolTips = {
            new Tip("Gene Selection Test",
                "Generates a series of random genes that will get mixed up until one of them reaches the target value\n" +
                "\n" +
                "Objective: To Show the optimization of the fitness of the genes when they are mixed up"),

            new Tip("Chromossome Selection Test",
                "Generates a series of random chromosomes that will get mixed up until its genes values, when put in a mathematical expression, get to the target value\n" +
                "\n" +
                "Objective: To Show the optimization of the fitness of the mix of chromosomes genes when the genes are dependent on each other to generate fitness value" ),

            new Tip("Crossing Over Gene test",
                "Mix up the customizable genes\n" +
                "\n" +
                "Objective: To Show the behavior of the crossing over" ),

            new Tip("Dna Mutation Test",
                "Realize x customizable mutations of a customizable gene\n" +
                "\n" +
                "Objective: To Show the mutations behavior" ),

            new Tip("Dna Dispertion Test",
                "Generates random genes with different construction methods, organizes their values ​​in crescent order, and shows them in a chart\n" +
                "\n" +
                "Objective: Shows the distribution of values of different gene construction methods" ),

            new Tip("Eficiency Comparation",
                "...\n" +
                "\n" +
                "Objective:..." ),

            new Tip("Dna Efficiency",
                "...\n" +
                "\n" +
                "Objective:..." ),
        };
        /*foreach (TabPage tPage in tabControl.TabPages)
                Console.WriteLine("new Tip(\"" + tPage.Text + "\", \"...\" ),");*/

        public Form1()
        {
            InitializeComponent();

            //Tab toolTip
            tabControlGenetic.ShowToolTips = true;
            foreach (TabPage tPage in tabControlGenetic.TabPages)
                foreach (Tip tip in toolTips)
                    if (tip.Name == tPage.Text)
                    {
                        tPage.ToolTipText = tip.Text;
                        break;
                    }
        }
    }
}
