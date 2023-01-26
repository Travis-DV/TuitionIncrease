using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuitionIncrease8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] costs = { -1, 0, 0, 0, 0 };
            for (int i = 0; i < costs.Length; i++)
            {
                if (i == 0)
                {
                    costs[i] = (6000/50)+6000;
                }
                else
                {
                    costs[i] = (costs[i - 1] / 50) + costs[i - 1];
                }
            }
            year1LB.Text += costs[0].ToString();
            year2LB.Text += costs[1].ToString();
            year3LB.Text += costs[2].ToString();
            year4LB.Text += costs[3].ToString();
            year5LB.Text += costs[4].ToString();
        }
    }
}
