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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblPIN_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string NumConta = txtNumConta.Text;
            string Pin = txtPIN.Text;

            var account = Generic.ListaContas.FirstOrDefault(c => c.NumeroConta == NumConta && c.PIN == Pin);
            if (account != null)
            {
                if (account.IsAdmin == true)
                {
                    ContaAdmin ContaAdmin = new ContaAdmin();
                    ContaAdmin.Show();
                }
                else
                {
                    FormUser UserForm = new FormUser();
                    UserForm.Show();
                    Generic.CurrentAccount = account;
                }
            }
            else
            {
                
                MessageBox.Show("Numero de conta ou PIN incorrectos!");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            DateTime tempDate = new DateTime(); 
            Generic.ListaContas.Add(Generic.admin);
            Generic.admin.CriarConta("1111", "joe", 1111, "1111",  tempDate.Date);
            Generic.admin.CriarConta("2222", "joe2", 2222, "2222", tempDate.Date);
            Generic.admin.CriarConta("3333", "joe3", 3333, "3333", tempDate.Date);
            Generic.admin.CriarConta("4444", "joe4", 4444, "4444", tempDate.Date);

        }

        private void txtNumConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && txtNumConta.Text.Length >= 4)
            {
                e.Handled = true; // Block input if length exceeds 4 characters
            }
        }

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && txtPIN.Text.Length >= 4)
            {
                e.Handled = true; // Block input if length exceeds 4 characters
            }
        }
    }
}
