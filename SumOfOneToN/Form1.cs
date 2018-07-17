using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfOneToN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtNum.Text);
            int sum = 0;

            //for loop

            //for (int N = 1; N < 100; N++)
            //{
            //    sum += i;
         
            //    MessageBox.Show(" The sum of 1 to N is: " + sum);               
            //}

            //do while loop

            do
            {
                N++;
                sum += N;
                MessageBox.Show(" The Sum of 1 to N is: " + sum);

            } while (N != 0);
        }

    }
}
