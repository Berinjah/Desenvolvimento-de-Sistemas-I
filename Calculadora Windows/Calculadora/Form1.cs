using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double valor1 = 0; 
        string operador = "";

        
        public Calculadora()
        {
                       
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0") /* o visor, assim como a calculadora do windows inicia com 0, se o valor do visor for 0, é atribuido ao visor o valor de 1 fazendo com que o mesmo deixe de ser zero, como
                                        * isso é necessário para "transformar" o zero e qualquer número que será digitado(o mesmo vale para o restante dos números)*/
            {
                txbResult.Text = "1";
            }
            else //caso o valor do visor seja diferente de zero, o número 1 é concatenado ao valor contido no visor (o mesmo vale para o restante dos números)
            {
                txbResult.Text += "1"; 
            }
            lblContas.Text = lblContas.Text + 1; /*concatena o número 1 a label de visualização de contas (semelhante a contida no windows)
                                                  * o mesmo recurso pode ser encontrado a outros botões, como o de soma (nomeado btnPlus)*/

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0")
            {
                txbResult.Text = "2";
            }
            else
            {
                txbResult.Text += "2";
            }
            lblContas.Text = lblContas.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0")
            {
                txbResult.Text = "3";
            }
            else
            {
                txbResult.Text += "3";
            }
            lblContas.Text = lblContas.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0")
            {
                txbResult.Text = "4";
            }
            else
            {
                txbResult.Text += "4";
            }
            lblContas.Text = lblContas.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0")
            {
                txbResult.Text = "5";
            }
            else
            {
                txbResult.Text += "5";
            }
            lblContas.Text = lblContas.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0")
            {
                txbResult.Text = "6";
            }
            else
            {
                txbResult.Text += "6";
            }
            lblContas.Text = lblContas.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0")
            {
                txbResult.Text = "7";
            }
            else
            {
                txbResult.Text += "7";
            }
            lblContas.Text = lblContas.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0")
            {
                txbResult.Text = "8";
            }
            else
            {
                txbResult.Text += "8";
            }
            lblContas.Text = lblContas.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "0")
            {
                txbResult.Text = "9";
            }
            else
            {
                txbResult.Text += "9";
             }
            lblContas.Text = lblContas.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txbResult.Text != "0")
            {
                txbResult.Text += "0";
                lblContas.Text = lblContas.Text + 0;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (valor1 == 0) //caso o valor da variável valor1 seja 0, é atribuído a ela o valor contido no visor para ser utilizado posteriormente nos calculos (o mesmo vale para os outros botões de calculo)
            {
                valor1 = Double.Parse(txbResult.Text);

            }
            else /*caso o valor de valor1 seja diferente de 0, o botão de igual (nomeado btnEquals) é "pressionado", fazendo com que um calculo seja feito entre o valor1 e o valor do visor (txbResult) 
                  * (o mesmo vale para os outros botões de calculo)*/
            {
                btnEquals.PerformClick();
            }
            operador = "+"; // atribui o simbolo de soma a variável operador para ser utilzado no switch case no botão Equals (o mesmo vale para os outros botões de calculo)
            lblContas.Text = lblContas.Text + " + ";
            txbResult.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (valor1 == 0)
            {
                valor1 = Double.Parse(txbResult.Text);

            }
            else
            {
                btnEquals.PerformClick();
            }
            operador = "-";
            lblContas.Text = lblContas.Text + " - ";
            txbResult.Text = "";
        }

        private void btnMultiplied_Click(object sender, EventArgs e)
        {
            if (valor1 == 0)
            {
                valor1 = Double.Parse(txbResult.Text);

            }
            else
            {
                btnEquals.PerformClick();
            }
            operador = "*";
            lblContas.Text = lblContas.Text + " * ";
            txbResult.Text = "";
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (valor1 == 0)
            {
                valor1 = Double.Parse(txbResult.Text);

            }
            else
            {
                btnEquals.PerformClick();
            }
            operador = "/";
            lblContas.Text = lblContas.Text + " / ";
            txbResult.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operador) //Switch utilizado para os cálculos, um operador sempre é definido ao utilizar um botão de cálculo, como o btnMinus 
            {
                case "+": txbResult.Text = (valor1 = valor1 + Double.Parse(txbResult.Text)).ToString();
                    break;
                case "-": txbResult.Text = (valor1 = valor1 - Double.Parse(txbResult.Text)).ToString();
                    break;
                case "*": txbResult.Text = (valor1 = valor1 * Double.Parse(txbResult.Text)).ToString();
                    break;
                case "/": txbResult.Text = (valor1 = valor1 / Double.Parse(txbResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }         
    }
}
