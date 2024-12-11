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
        
        private bool Label_overwrite = true;
        private bool Num_Plus = true;
        private bool Num_Dot = false;
        private double dNum;
        private Calculate calculate = new Calculate();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (Label_overwrite)
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
            if (Label_overwrite)
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
            if (Label_overwrite)
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
            if (Label_overwrite)
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
            if (Label_overwrite)
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
            if (Label_overwrite)
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
            if (Label_overwrite)
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
            if (Label_overwrite)
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
            if (Label_overwrite)
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
            if (Label_overwrite) 
            { 
                num.Text = zero.Text;
                Label_overwrite = false;
            } 
            else 
            { 
                num.Text += zero.Text; 
            }
        }

        private void Operation_Click(object sender, EventArgs e, Calculate.MarksType type)
        { 
            Num_Dot = false;
            Label_overwrite = true;
            dNum = double.Parse(num.Text);
            calculate.SetOperation(type);
            num.Text = calculate.Calculation(dNum).ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e, Calculate.MarksType.PLUS);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e, Calculate.MarksType.MINUS);
        }

        private void multiplied_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e, Calculate.MarksType.MULTIPLIED);
        }

        private void divided_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e, Calculate.MarksType.DEVIDED);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            dNum = double.Parse(num.Text);
            num.Text = calculate.Calculation(dNum).ToString(); 
            Num_Dot = false;
            Label_overwrite = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num.Text = "0";
            Label_overwrite = true;
        }
    }
}
