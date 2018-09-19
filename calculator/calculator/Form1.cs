using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator {
    public partial class Form1 : Form {
        double firstNumber;
        string operation;
        public Form1() {
            InitializeComponent();
        }

        private void number_1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "1";
            } else {
                    textBox1.Text = textBox1.Text + "1";
            }
        }

        private void number_2_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "2";
            } else {
                    textBox1.Text = textBox1.Text + "2";
            }
        }

        private void number_3_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "3";
            } else {
                    textBox1.Text = textBox1.Text + "3";
            }
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "4";
            } else {
                    textBox1.Text = textBox1.Text + "4";
            }
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "5";
            } else {
                    textBox1.Text = textBox1.Text + "5";
            }

        }

        private void number_6_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "6";
            } else {
                    textBox1.Text = textBox1.Text + "6";
            }

        }

        private void number_7_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "7";
            } else {
                    textBox1.Text = textBox1.Text + "7";
            }

        }

        private void number_8_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "8";
            } else {
                    textBox1.Text = textBox1.Text + "8";
            }
        }

        private void number_9_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "9";
            } else {
                    textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button_0_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "0";    
            } else {
                    textBox1.Text = textBox1.Text + "0";
            }
        }

        private void plus_sign_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void subtraction_key_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }

        private void multiplication_key_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void division_key_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void enter_key_Click(object sender, EventArgs e) {
            double secondNumber;
            double result;
            secondNumber = Convert.ToDouble(textBox1.Text);
            if(operation == "+") {
                result = (firstNumber + secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
                if (operation == "-") {
                    result = (firstNumber - secondNumber);
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                    if (operation == "*") {
                        result = (firstNumber * secondNumber);
                        textBox1.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                        if (operation == "/") {
                            if (secondNumber == 0){
                                textBox1.Text = "invalid operation";
                            } else {
                                    result = (firstNumber / secondNumber);
                                    textBox1.Text = Convert.ToString(result);
                                    firstNumber = result;
                            }
                        }   
        }

        private void clear_key_Click(object sender, EventArgs e) {
            textBox1.Text = "0";
        }

        private void decimal_point_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + ".";
        }

        
    }
}
