using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double? op1 = null;
        private double? op2 = null;
        private double? ans = null;
        private char op = '\0';

        private string memory = "";

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (input.Length == 0) return;

            op1 = double.Parse(input);

            op = '+';

            textBox1.Text = string.Empty;

        }

        private void button4_Click(object sender, EventArgs e)  
        {
            
            string input = textBox1.Text;
            if (input.Length == 0) return;

            op1 = double.Parse(input);

            op = '%';

            textBox1.Text = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string input = textBox1.Text;
            if (input.Length == 0) return;

            op1 = double.Parse(input);

            op = '-';

            textBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (input.Length == 0) return;
            op1 = double.Parse(input);

            op = '*';

            textBox1.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            string input = textBox1.Text;
            if (input.Length == 0) return;
            op1 = double.Parse(input);

            op = '/';

            textBox1.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && op != '\0')
            {
                string input = textBox1.Text;

                op2 = double.Parse(input);
                textBox1.Text = string.Empty;

                if(op == '/' && op2 == 0)
                {
                    textBox4.Text = "undefined";
                    return;
                }


                ans = calculate(op1, op2, op);

                if(ans != null)
                {
                    textBox3.Text = $"{op1} {op} {op2} =";
                    textBox4.Text = $"{ans}";
                }
            }
        }

        private double? calculate(double? a, double? b, char c)
        {
            if(c == '+')
            {
                return a + b;
            }

            if (c == '-')
            {
                return a - b;
            }

            if (c == '*')
            {
                return a * b;
            }

            if (c == '/')
            {
                return a / b;
            }

            if(c == '%')
            {
                return a % b;
            }

            return null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            op1 = op2 = null;
            op = '\0';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

            op1 = op2 = null;
            op = '\0';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                memory = textBox1.Text;
                textBox2.Text = memory;
                textBox1.Text = string.Empty;
            }       
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(memory != "")
            {
                textBox1.Text = memory;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }
    }
}
