using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_Pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_Pressed))
                result.Clear();

            operation_Pressed = false;
            Button b = (Button)sender;

            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text = result.Text + b.Text;
                }
            }
            else
            result.Text = result.Text + b.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                equal.PerformClick();
                operation_Pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_Pressed = true;
                equation.Text = value + " " + operation;
            } 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
            }

            value = double.Parse(result.Text);
            operation = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;

                case ".":
                    dec.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "*":
                    multiple.PerformClick();
                    break;
                case "/":
                    divide.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;

                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void firkant_Button_Click(object sender, EventArgs e)
        {
            string firkant = this.Text;
            textBox1.Text = "Areal af firkant: A = a * b                               (Hvor a er længden, og b er bredden.)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cirkel = this.Text;
            textBox1.Text = "Areal af cirkel: A = pi * (R^2-r^2)                    Hvor: A = Arealet                                                r = Radius af den lille cirkel                             R = radius af den store cirkel";
        }

        private void trapez_Button_Click(object sender, EventArgs e)
        {
            string trapez = this.Text;
            textBox1.Text = "Areal af trapez:  Areal = 1/2 * (a+c) * h          (Hvor a og c er sidelængder, og h er højden.)";
        }

        private void kegle_Button_Click(object sender, EventArgs e)
        {
            string kelge = this.Text;
            textBox1.Text = "Rumfang af kegle:  V = 1/3 * h * G";
        }
    }
}
