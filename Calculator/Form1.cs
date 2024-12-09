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
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
            num.Text = one.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            num.Text += two.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            num.Text += three.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            num.Text += four.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            num.Text += five.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            num.Text += six.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            num.Text += seven.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            num.Text += eight.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            num.Text += nine.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            num.Text += zero.Text;
            //Num_Labelを上書きするか
            if (Label_overwrite == true)
            {
                Label_overwrite = false;
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
