using Calculatorusing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calculatorusing.Calculate;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Num_Labelの上書きをする場合はtrue
        private bool Label_overwrite = true; 

        private void one_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = one.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += one.Text;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = two.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += two.Text;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = three.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += three.Text;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = four.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += four.Text;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = five.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += five.Text;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = six.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += six.Text;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = seven.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += seven.Text;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = eight.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += eight.Text;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = nine.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += nine.Text;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                num.Text = zero.Text;
                Label_overwrite = false;
            }
            else
            {
                num.Text += zero.Text;
            }
        }

        Calculate calculate = new Calculate();
        MarksType marksType = new MarksType();

        private void plus_Click(object sender, EventArgs e)
        {
            Label_overwrite = true;
            calculate.Num_PoolMethod(num.Text);
            marksType = MarksType.PLUS;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Label_overwrite = true;
            calculate.Num_PoolMethod(num.Text);
            marksType = MarksType.MINUS;
        }

        private void multiplied_Click(object sender, EventArgs e)
        {
            Label_overwrite = true;
            calculate.Num_PoolMethod(num.Text);
            marksType = MarksType.MULTIPLIED;
        }

        private void divided_Click(object sender, EventArgs e)
        {
            Label_overwrite = true;
            calculate.Num_PoolMethod(num.Text);
            marksType = MarksType.DEVIDED;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Label_overwrite = true;
            calculate.Num_PoolMethod(num.Text);
            marksType = MarksType.EQUAL;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num.Text = "0";
            Label_overwrite = true;
        }
    }
}
