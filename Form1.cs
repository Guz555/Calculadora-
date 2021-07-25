using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string num1, num2;
        int click = 0;
        bool soma, sub, mult, div = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_display.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_display.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_display.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_display.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_display.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_display.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_display.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_display.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_display.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_display.Text += "0";
        }
        private void btn_ponto_Click(object sender, EventArgs e)
        {
            
            if(click == 0)
            {
                if (txt_display.Text == "")
                {
                    txt_display.Text += "0,";
                    click += 1;
                }
                else
                {
                    txt_display.Text += ",";
                    click += 1;
                }
            }
            else
            {
                txt_display.Text += "";
            }
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            num1 = txt_display.Text;
            txt_display.Text = "";
            soma = true;
            lbl_display.Text = num1 + " + ";
            click = 0;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            num1 = txt_display.Text;
            txt_display.Text = "";
            sub = true;
            lbl_display.Text = num1 + " - ";
            click = 0;
        }
        private void btn_mult_Click(object sender, EventArgs e)
        {
            num1 = txt_display.Text;
            txt_display.Text = "";
            mult = true;
            lbl_display.Text = num1 + " * ";
            click = 0;
        }
        private void btn_div_Click(object sender, EventArgs e)
        {
            num1 = txt_display.Text;
            txt_display.Text = "";
            div = true;
            lbl_display.Text = num1 + " / ";
            click = 0;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            
            num2 = txt_display.Text;
            lbl_display.Text += num2 + " =";
            if (num1 == "" || num2 == "")
            {
                clear();
            }
            else
            {
                if (soma)
                {
                    //somar(int.Parse(num1), int.Parse(num2));
                    if (num1 == "")
                    {
                        num1 = "0";
                    }
                    else
                    {
                        txt_display.Text = somar(Convert.ToDouble(num1), Convert.ToDouble(num2)).ToString();
                        soma = false;
                        num1 = "";
                    }
                    
                }
                if (sub)
                {
                    if (num1 == "")
                    {
                        num1 += "-";
                    }
                    else
                    {
                        //subtrair(int.Parse(num1), int.Parse(num2));
                        txt_display.Text = subtrair(double.Parse(num1), double.Parse(num2)).ToString();
                        sub = false;
                        num1 = "";
                    }
                }
                if (mult)
                {
                    if (num1 == "")
                    {
                        num1 = "0";
                    }
                    else 
                    {
                        txt_display.Text = multiplicar(double.Parse(num1), double.Parse(num2)).ToString();
                        mult = false;
                        num1 = "";
                    }             
                }
                if (div)
                {
                    if (num1 == "")
                    {
                        num1 = "0";
                    }
                    else
                    {
                        txt_display.Text = dividir(double.Parse(num1), double.Parse(num2)).ToString();
                        div = false;
                        num1 = "";
                    }
                }
                
            }
        }
        private void txt_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private double somar(double n1, double n2)
        {
            double r;
            r = n1 + n2;
            return r;
        }

        private void clear()
        {
            click = 0;
            txt_display.Text = "";
            lbl_display.Text = "";
            num1 = "";
            num2 = "";
        }
        private double subtrair(double n1, double n2)
        {
            double r;
            r = n1 - n2;
            return r;
        }
        private double multiplicar(double n1, double n2)
        {
            double r;
            r = n1 * n2;
            return r;
        }
        private double dividir(double n1, double n2)
        {
            double r;
            if (n2 == 0)
            {
                lbl_display.Text = "Não é possivel dividir por 0";
                return 0;
            }
            else
            {
                r = n1 / n2;
                return r;
            }
            
            
        }
    }
        
}
