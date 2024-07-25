using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result_Value = 0;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if(tb_Result.Text == "0" || isOperationPerformed)
            {
                tb_Result.Clear();
            }

            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if(!tb_Result.Text.Contains("."))
                {
                    tb_Result.Text = tb_Result.Text + btn.Text;
                }
                    
            }
            else
            {
                tb_Result.Text = tb_Result.Text + btn.Text;
            }

            isOperationPerformed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void op_performance(object sender, EventArgs e)
        {
            if(result_Value != 0)
            {
                button18.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(tb_Result.Text);

                lb_Result.Text = result_Value + " " + operation;
                isOperationPerformed = true;
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(tb_Result.Text);

                lb_Result.Text = result_Value + " " + operation;
                isOperationPerformed = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
            lb_Result.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    tb_Result.Text = (result_Value + double.Parse(tb_Result.Text)).ToString();
                    break;
                case "-":
                    tb_Result.Text = (result_Value - double.Parse(tb_Result.Text)).ToString();
                    break;
                case "*":
                    tb_Result.Text = (result_Value * double.Parse(tb_Result.Text)).ToString();
                    break;
                case "/":
                    tb_Result.Text = (result_Value / double.Parse(tb_Result.Text)).ToString();
                    break;
                default:
                    break;
            }   
        }
    }
}
