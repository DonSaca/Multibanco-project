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
    public partial class ContaAdmin : Form 
    {

        public ContaAdmin()
        {
            InitializeComponent();
        }
        //Metodos 
        private void LoadContasToListBox()
        {
            // Limpar a listbox pra n haver duplicados
            lbContas.Items.Clear();

            // Dar um loop pelos objectos em Listacontas
            foreach (var conta in Generic.ListaContas)
            {
             
                string contaInfo = $"{conta.NumeroConta} - {conta.Titular}: {conta.Saldo:C}";

                
                lbContas.Items.Add(contaInfo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conta Menor = Generic.admin.GetContaMenorSaldo();

            string saldo = Menor.Saldo.ToString();
            string nome = Menor.Titular;

            MessageBox.Show("A conta com menor saldo pertence à: " + nome + "Com saldo de: " + saldo);
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {

            
                string numero = txtNumeroConta.Text;
                string titular = txtTitular.Text;
            string pin = txtPin.Text;
            DateTime data = dtpDataCriacao.Value;
            try
            {
                double saldo = double.Parse(txtSaldo.Text);
                try
                {
                    Generic.admin.CriarConta(numero, titular, saldo, pin, data);
                    MessageBox.Show("Conta criada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
             (Exception erro)
            {

                MessageBox.Show(erro.Message, "erro na formatacao do campo saldo, tenta com , (virgula) ou . (ponto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadContasToListBox();
    
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            conta Maior = Generic.admin.GetContaMaiorSaldo();

            string saldo = Maior.Saldo.ToString();
            string nome = Maior.Titular;

            MessageBox.Show("A conta com maior saldo pertence à: " + nome + "Com saldo de: " + saldo);
        }

        private void btnApagarConta_Click(object sender, EventArgs e)
        {
            string NumConta = txtNumeroConta.Text;
            
           var account = Generic.ListaContas.FirstOrDefault(c => c.NumeroConta == NumConta);
            if(account!= null)
            {
                if (Generic.ListaContas.Remove(account) == true)
                {
                    MessageBox.Show("Conta apagada com sucesso ");
                }
            }
            else
            {
                MessageBox.Show("Conta não existe");
            }

            LoadContasToListBox();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double media= Generic.admin.CalcularMediaSaldos();
            MessageBox.Show("A media é: " + media.ToString());



        }

        private void txtNumeroConta_TextChanged(object sender, EventArgs e)
        {
            // Se o texto n é numerico ele apaga mesmo com ctrl V
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNumeroConta.Text, @"^[0-9]*(\.[0-9]*)?$"))
            {
                MessageBox.Show("Please enter a valid number.");
                txtNumeroConta.Clear();
            }
        }

        private void txtNumeroConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && txtNumeroConta.Text.Length >= 4)
            {
                e.Handled = true; 
            }


        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && txtPin.Text.Length >= 4)
            {
                e.Handled = true; 
            }
        }

        private void ContaAdmin_Shown(object sender, EventArgs e)
        {
            LoadContasToListBox();
        }
    }
}
