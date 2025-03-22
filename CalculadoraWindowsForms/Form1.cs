using System;
using System.Data;
using System.Linq.Expressions;

namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    { 
        private bool somar = false;
        private bool dividir = false;
        private bool multiplicar = false;
        private bool subtrair = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "0";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtOperacao.Text.EndsWith("-") || txtOperacao.Text.EndsWith("*") || txtOperacao.Text.EndsWith("/"))
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (!txtOperacao.Text.EndsWith("+"))
            {
                txtOperacao.Text += "+";
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            dividir = false;
            subtrair = true;
            multiplicar = false;
            somar = false;

            if (txtOperacao.Text.EndsWith("+") || txtOperacao.Text.EndsWith("*") || txtOperacao.Text.EndsWith("/"))
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (!txtOperacao.Text.EndsWith("-"))
            {
                txtOperacao.Text += "-";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            dividir = true;
            subtrair = false;
            multiplicar = false;
            somar = false;

            if (txtOperacao.Text.EndsWith("+") || txtOperacao.Text.EndsWith("*") || txtOperacao.Text.EndsWith("-"))
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (!txtOperacao.Text.EndsWith("/"))
            {
                txtOperacao.Text += "/";
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            dividir = false;
            subtrair = false;
            multiplicar = true;
            somar = false;

            if (txtOperacao.Text.EndsWith("+") || txtOperacao.Text.EndsWith("-") || txtOperacao.Text.EndsWith("/"))
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (!txtOperacao.Text.EndsWith("*"))
            {
                txtOperacao.Text += "*";
            }
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "1";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                var expressao = txtOperacao.Text.Replace("x", "*");
                var resultado = new DataTable().Compute(expressao, null);
                txtOperacao.Text = resultado.ToString();

            }
            catch 
            {

            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "";
        }

        private void txtOperacao_TextChanged(object sender, EventArgs e)
        {
            // Aqui você pode adicionar código para manipular mudanças no texto, se necessário.
        }
    }
}

            