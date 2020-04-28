using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operatorSymbol = "";
             bool isCalculate = false;
        String symbol ="";
        int first = 0;
        List<String> memory = new List<string>();
        
       
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbersClicked(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || isCalculate)
            {
                textBox1.Text = "";
                isCalculate = false;
            }
            textBox1.Text += ((Button)sender).Text;


        }

        private void operatorsClicked(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            switch (text)
            {
                case "+":
                    operatorSymbol = text;
                    first = int.Parse(textBox1.Text);
                    topText.Text = textBox1.Text + "+";
                    textBox1.Text = "";
                    break;
                case "-":
                    operatorSymbol = text;
                    first = int.Parse(textBox1.Text);
                    topText.Text = textBox1.Text + "-";
                    textBox1.Text = "";
                    break;
                case "=":
                    Debug.WriteLine("equal");
                    Debug.WriteLine("symbol==>" + symbol);
                    Debug.WriteLine("top==>"+topText.Text);
                    Debug.WriteLine("textBox==>"+textBox1.Text);
                    if (operatorSymbol !="" && topText.Text != "" && textBox1.Text != "")
                    {
                        Debug.WriteLine("calculate");
                        calculateAction(first, int.Parse(textBox1.Text), operatorSymbol);
                        isCalculate = true;
                    }
                    break;

            }
        }

        private void calculateAction(int a, int b, String action)
        {

            int result;
            switch (action)
            {
                case "-":
                    result = a - b;
                    break;
                case "+":
                    result = a + b;
                    break;

                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    result = 0;
                    break;
            }
             String m = a + " "+action+" "+b + " " + "=" + " " + result;
            memory.Add(m);
            topText.Text = m;
            textBox1.Text = result.ToString();
            memoryTextBox.Text = string.Join(Environment.NewLine, memory);
            
        }

        private void clearAction()
        {
            topText.Text = "";
            textBox1.Text = "";
            memoryTextBox.Text = "";
            memory.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearsClicked(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            switch (text)
            {
                case "C":
                    clearAction();
                    break;
                case "CE":
                    clearAction();
                    break;
                case "X":
                    if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    break;
            }
        }
    }
}
