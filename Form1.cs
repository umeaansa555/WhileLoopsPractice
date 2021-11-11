using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLoopsPractice
{
    public partial class Form1 : Form
    {
        string value1;
        string value2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            int value1 = Convert.ToInt32(value1Input.Text);
            int value2 = Convert.ToInt32(value2Input.Text);

            int i = value1;

            while (i <= value2)
            {
                outputLabel.Text += $"{i}\n";
                i++;
            }

        }
    }
}
