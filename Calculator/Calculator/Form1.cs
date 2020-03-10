using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private bool ok = false, ok2 = false;
        private double a, b, m;
        private char op;

        private void operatii(object sender, EventArgs e)
        {
            if (ok == true)
            {
                ajutor();
                ok2 = true;
                a = Convert.ToDouble(rezultat.Text);
                Button B = new Button();
                B = sender as Button;
                op = Convert.ToChar(B.Text);
                semn.Text = B.Text;
            }
            else
            {
                a = Convert.ToDouble(rezultat.Text);
                rezultat.Text = "0";
                Button B = new Button();
                B = sender as Button;
                op = Convert.ToChar(B.Text);
                semn.Text = B.Text;
                ok = true;
            }
        }

        private void Numere(object sender, EventArgs e)
        {
            if (rezultat.Text == "0"||b!=0)
                rezultat.Text = "";
            Button B = new Button();
            B = sender as Button;
            rezultat.Text += B.Text;
        }

        private void ajutor()
        {
            bool ok1 = false;
            double answer = 0;
            if (rezultat.Text != "")
            {
                b = Convert.ToDouble(rezultat.Text);
                ok1 = true;
            }
            switch (op)
            {
                case '+':
                    if (!ok1)
                        b = 0;
                    answer = a + b;
                    rezultat.Text = answer.ToString();
                    break;
                case '-':
                    if (!ok1)
                        b = 0;
                    answer = a - b;
                    rezultat.Text = answer.ToString();
                    break;
                case 'x':
                    if (!ok1)
                        b = 1;
                    answer = a * b;
                    rezultat.Text = answer.ToString();
                    break;
                case '/':
                    if (b == 0)
                    {
                        rezultat.Text = "Eroare";
                        break;
                    }
                    else
                    {
                        if (!ok1)
                            b = 1;
                        answer = a / b;
                        rezultat.Text = answer.ToString();
                        break;
                    }
            }
        }

        private void Egal(object sender, EventArgs e)
        {
            semn.Text = "=";
            if (ok2==true)
                rezultat.Text = "";
            ajutor();
        }

        private void backspace(object sender, EventArgs e)
        {
            if (rezultat.Text != "0") 
               rezultat.Text = rezultat.Text.Substring(0, rezultat.Text.Length - 1);
        }

        private void C_Click(object sender, EventArgs e)
        {
            rezultat.Clear();
            a = 0;
            b = 0;
            op = '\n';
            rezultat.Text = "0";
            ok = false;
            semn.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            rezultat.Clear();
            rezultat.Text = "0";
        }

        private void invers(object sender, EventArgs e)
        {
            a = Convert.ToDouble(rezultat.Text);
            double x = 1 / a;
            rezultat.Text = x.ToString();
            semn.Text = "1/x";
        }

        private void sqrt_click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(rezultat.Text);
            double x = Math.Sqrt(a);
            rezultat.Text = x.ToString();
            semn.Text = "sqrt";
        }

        private void plus_minus_click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(rezultat.Text);
            double x = -a;
            rezultat.Text = x.ToString();
        }

        private void mem(object sender, EventArgs e)
        {
            rezultat.Text = m.ToString();
        }

        private void procent_click(object sender, EventArgs e)
        {
            double answer = 0;
            b = Convert.ToDouble(rezultat.Text);
            answer = b / 100 * a;
            rezultat.Text = answer.ToString();
            semn.Text = "%";
        }

        private void virgula_click(object sender, EventArgs e)
        {
            rezultat.Text += ".";
        }

        private void mplus_Click(object sender, EventArgs e)
        {
            double answer = 0;
            b = Convert.ToDouble(rezultat.Text);
            switch (op)
            {
                case '+':
                    answer = a + b;
                    m += answer;
                    break;
                case '-':
                    answer = a - b;
                    m += answer;
                    break;
                case 'x':
                    answer = a * b;
                    m += answer;
                    break;
                case '/':
                    if (b == 0)
                    {
                        rezultat.Text = "Eroare";
                        break;
                    }
                    else
                    {
                        answer = a / b;
                        m += answer;
                        break;
                    }
            }
            rezultat.Text = answer.ToString();
        }
        private void mminus_Click(object sender, EventArgs e)
        {
            double answer = 0;
            b = Convert.ToDouble(rezultat.Text);
            switch (op)
            {
                case '+':
                    answer = a + b;
                    m -= answer;
                    break;
                case '-':
                    answer = a - b;
                    m -= answer;
                    break;
                case 'x':
                    answer = a * b;
                    m -= answer;
                    break;
                case '/':
                    if (b == 0)
                    {
                        rezultat.Text = "Eroare";
                        break;
                    }
                    else
                    {
                        answer = a / b;
                        m -= answer;
                        break;
                    }
            }
            rezultat.Text = answer.ToString();
        }

        private void mclear(object sender, EventArgs e)
        {
            m = 0;
        }
    }
}