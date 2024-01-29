using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickAScriptureAppUI
{
    public partial class PickAScripture : Form
    {
        public PickAScripture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] pickedScripters = PickAScriptureClass.PickRandomScripture((int)numberOfScriptures.Value);
            scriptureDisplay.Items.Clear();

            foreach (string scripture in pickedScripters)
            {
                scriptureDisplay.Items.Add(scripture);
            }
        }
    }
}