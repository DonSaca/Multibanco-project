using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multibanco
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            double saldo = Generic.CurrentAccount.Saldo;
            string nome = Generic.CurrentAccount.Titular;
            lblSaldo.Text = "O seu Saldo é: " + saldo;
            lblTitular.Text = "esta conta é de: " + nome;
        }

        private void btnLevantamento_Click(object sender, EventArgs e)
        {
            try
            {
                double ordem = double.Parse(txtOrdem.Text);
                Generic.CurrentAccount.Levantamento(ordem);
                double saldo = Generic.CurrentAccount.Saldo;
                lblSaldo.Text = $"O seu Saldo é:  {saldo:C}";
                lbTransacoes.Items.Add("Levantamento de "+ordem.ToString());
            }
            catch (Exception erro)
            {
                
                MessageBox.Show(erro.Message, "erro na formatacao, tenta com , (virgula) ou . (ponto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                double ordem = double.Parse(txtOrdem.Text);
                Generic.CurrentAccount.Deposito(ordem);
                double saldo = Generic.CurrentAccount.Saldo;
                lblSaldo.Text = $"O seu Saldo é:  {saldo:C}";
                lbTransacoes.Items.Add("Deposito de " + ordem.ToString());
            }
            catch (Exception erro)
            {
               
                MessageBox.Show(erro.Message, "erro na formatacao, tenta com , (virgula) ou . (ponto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUser_Shown(object sender, EventArgs e)
        {
            double saldo = Generic.CurrentAccount.Saldo;
            string nome = Generic.CurrentAccount.Titular;
            lblSaldo.Text = $"O seu Saldo é:  {saldo:C}";
            lblTitular.Text = "esta conta é de: " + nome;

        }

        private void btnPedirCredito_Click(object sender, EventArgs e)
        {
            Generic.CurrentAccount.SolicitarCredito();
            lblCredito.Text = $"Credito: {Generic.CurrentAccount.CreditoAtivo.ValorCredito:C}";
        }

        private void txtOrdem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrdem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
