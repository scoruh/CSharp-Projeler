using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pascal_ucgeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //https://www.geeksforgeeks.org/pascal-triangle/ 
        private void btn_pascalHesapla_Click(object sender, EventArgs e)
        {

            this.listBox1.Items.Clear();

            printPascal((int)this.num_pascalKatman.Value, this.listBox1);
        }

        // See https://www.geeksforgeeks.org/space-and-time-efficient-binomial-coefficient/
        // for details of this function
        int binomialCoeff(int n, int k)
        {
            int res = 1;
            if (k > n - k)
                k = n - k;
            for (int i = 0; i < k; ++i)
            {
                res *= (n - i);
                res /= (i + 1);
            }

            return res;
        }

        // Function to print first
        // n lines of Pascal's
        // Triangle
        void printPascal(int n, ListBox listBox1)
        {
            // Iterate through every line and
            // print entries in it
            for (int line = 0; line < n; line++)
            {
                string listboxLine = String.Empty;
                // Every line has number of
                // integers equal to line
                // number
                for (int i = 0; i <= line; i++)
                    listboxLine += " " + binomialCoeff(line, i);

                listBox1.Items.Add(listboxLine);

            }
        }


    }
}
