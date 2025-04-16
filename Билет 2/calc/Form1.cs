using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double valInMem = 0;
        string signInMem = string.Empty;
        bool isNegative = false;
        public Form1()
        {
            InitializeComponent();
            answerLabel.Text = "";
            memLabel.Text = "0";
        }

        private void NumButtonsClick_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "1":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "1"; return; }
                    answerLabel.Text += "1";
                    break;
                case "2":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "2"; return; }
                    answerLabel.Text += "2";
                    break;
                case "3":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "3"; return; }
                    answerLabel.Text += "3";
                    break;
                case "4":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "4"; return; }
                    answerLabel.Text += "4";
                    break;
                case "5":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "5"; return; }
                    answerLabel.Text += "5";
                    break;
                case "6":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "6"; return; }
                    answerLabel.Text += "6";
                    break;
                case "7":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "7"; return; }
                    answerLabel.Text += "7";
                    break;
                case "8":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "8"; return; }
                    answerLabel.Text += "8";
                    break;
                case "9":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { answerLabel.Text = "9";return; }
                    answerLabel.Text += "9";
                    break;
                case "0":
                    if (answerLabel.Text.Length == 1 & answerLabel.Text.Contains("0"))
                    { return; }
                    answerLabel.Text += "0";
                    break;
                case "-":
                    if (answerLabel.Text.EndsWith(","))
                    {
                        answerLabel.Text += "0";
                    }
                    isNegative = false;
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = "";
                    signInMem = "-";
                    signLabel.Text = signInMem;
                    break;
                case "/":
                    if (answerLabel.Text.EndsWith(","))
                    {
                        answerLabel.Text += "0";
                    }
                    isNegative = false;
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = "";
                    signInMem = "/";
                    signLabel.Text = signInMem;
                    break;
                case "+":
                    if (answerLabel.Text.EndsWith(","))
                    {
                        answerLabel.Text += "0";
                    }
                    isNegative = false;
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = "";
                    signInMem = "+";
                    signLabel.Text = signInMem;
                    break;
                case "*":
                    if (answerLabel.Text.EndsWith(","))
                    {
                        answerLabel.Text += "0";
                    }
                    isNegative = false;
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = "";
                    signInMem = "*";
                    signLabel.Text = signInMem;
                    break;
                case "M+":
                    if (!IsDoubleValid(answerLabel.Text))
                    { return; }
                    if (answerLabel.Text == "")
                    { return; }
                    if (memLabel.Text == "")
                    {
                        memLabel.Text = answerLabel.Text;
                    }
                    memLabel.Text = (Convert.ToDouble(memLabel.Text) + Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "M-":
                    if (answerLabel.Text == "")
                    { return; }
                    if (memLabel.Text == "")
                    {
                        memLabel.Text = answerLabel.Text;
                    }
                    if (!IsDoubleValid(answerLabel.Text))
                    { return; }
                    memLabel.Text = (Convert.ToDouble(memLabel.Text) - Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "MC":
                    memLabel.Text = "";
                    break;
                case "MR":
                    if (memLabel.Text == "")
                    { return; }
                    if(memLabel.Text.Contains("-"))
                    { isNegative = true; }
                    answerLabel.Text = memLabel.Text;
                    break; 
                case ",":
                    if (answerLabel.Text.Contains(","))
                    { return; }
                    answerLabel.Text += ",";
                    break;
                case "+/-":
                    if (answerLabel.Text == "0")
                    { return; }
                    if (answerLabel.Text == "")
                    {
                        return;
                    }
                    if (isNegative)
                    {
                        string tempAnsw = string.Empty;
                        for (int i = 1; i < answerLabel.Text.Length; i++)
                        {
                            tempAnsw += answerLabel.Text[i];
                        }
                        answerLabel.Text = tempAnsw;
                        isNegative = false;
                        return;
                    }
                    if (!isNegative)
                    {
                        string answerStringWithMinus = "-" + answerLabel.Text;
                        answerLabel.Text = answerStringWithMinus;
                        isNegative = true;
                        return;
                    }
                    break;
                case "<-":
                    if (answerLabel.Text == string.Empty)
                    { return; }
                    answerLabel.Text = answerLabel.Text.Remove(answerLabel.Text.Length - 1, 1);
                    break;
                case "C":
                    answerLabel.Text = "";
                    break;
                case "pi":
                    answerLabel.Text = Math.PI.ToString();
                    break;
                case "sin":
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = Math.Sin(Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "cos":
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = Math.Cos(Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "exp":
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = Math.Exp(Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "tg":
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = Math.Tan(Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "x^2":
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = (Convert.ToDouble(answerLabel.Text) * Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "x^3":
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = (Convert.ToDouble(answerLabel.Text) * Convert.ToDouble(answerLabel.Text) * Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "ln":
                    if (answerLabel.Text.Length <= 0)
                    {
                        return;
                    }
                    if (Convert.ToDouble(answerLabel.Text) < 0)
                    {
                        return;
                    }
                    answerLabel.Text = Math.Log10(Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "1/x":
                    if (answerLabel.Text == "0")
                    {MessageBox.Show("на 0 делить нельзя"); return; }
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = (1/Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "sqrt":
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = Math.Sqrt(Convert.ToDouble(answerLabel.Text)).ToString();
                    break;
                case "x^y":
                    if (IsDoubleValid(answerLabel.Text))
                    {
                        valInMem = Convert.ToDouble(answerLabel.Text);
                    }
                    else
                    {
                        return;
                    }
                    answerLabel.Text = Math.Pow(Convert.ToDouble(answerLabel.Text),valInMem).ToString();
                    break;
                case "n!":
                    if (!int.TryParse(answerLabel.Text, out int result))
                    {
                        return;
                    }
                    int temp = 1;
                    for (int i = 2; i <= Convert.ToInt16(answerLabel.Text); i++)
                    {
                        temp *= i;
                    }
                    answerLabel.Text = temp.ToString();
                    break;
                case "=":
                    if (!IsDoubleValid(answerLabel.Text))
                    {
                        MessageBox.Show("try again lol");
                        return;
                    }
                    if (answerLabel.Text == "0")
                    { MessageBox.Show("на 0 делить нельзя");
                        return;
                    }
                    switch (signInMem)
                    {
                        case "+":
                            answerLabel.Text = (valInMem + Convert.ToDouble(answerLabel.Text)).ToString();
                            break;
                        case "*":
                            answerLabel.Text = (valInMem * Convert.ToDouble(answerLabel.Text)).ToString();
                            break;
                        case "-":
                            answerLabel.Text = (valInMem - Convert.ToDouble(answerLabel.Text)).ToString();
                            break;
                        case "/":
                            answerLabel.Text = (valInMem / Convert.ToDouble(answerLabel.Text)).ToString();
                            break;
                    }
                    signLabel.Text = string.Empty;
                    signInMem = "";
                    valInMem = 0;

                    break;
            }

        }
        private bool IsDoubleValid(string valToCheck)
        {
            if (double.TryParse(valToCheck, out double result))
            {
                return true;
            }
            else
            {
                MessageBox.Show("val is not valid");
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
