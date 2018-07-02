using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void btnVerfic_Click(object sender, EventArgs e)
        {
            //corrigir
            lblResult.Text = "";

            switch (txbNum.Text)
            {
                case "1":
                    lblResult.Text = "Janeiro";
                    break;
                case "2":
                    lblResult.Text = "Fevereiro";
                    break;
                case "3":
                    lblResult.Text = "Março";
                    break;
                case "4":
                    lblResult.Text = "Abril";
                    break;
                case "5":
                    lblResult.Text = "Maio";
                    break;
                case "6":
                    lblResult.Text = "Junho";
                    break;
                case "7":
                    lblResult.Text = "Julho";
                    break;
                case "8":
                    lblResult.Text = "Agosto";
                    break;
                case "9":
                    lblResult.Text = "Setembro";
                    break;
                case "10":
                    lblResult.Text = "Outubro";
                    break;
                case "11":
                    lblResult.Text = "Novembro";
                    break;
                case "12":
                    lblResult.Text = "Dezembro";
                    break;
                default:
                    break;
            }
        }
    }
}
