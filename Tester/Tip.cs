using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Tip
    {
        /// <summary>
        /// The paremeter that you will use to find the tip
        /// </summary>
        string name;

        /// <summary>
        /// The text that will appear in the tip
        /// </summary>
        string text;

        public Tip(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get => name; set => name = value; }
        public string Text { get => text; set => text = value; }
    }
}
