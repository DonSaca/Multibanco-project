
namespace Multibanco
{
    partial class ContaAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumConta = new System.Windows.Forms.Label();
            this.lbTitular = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblPIN = new System.Windows.Forms.Label();
            this.lblDataCria = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.dtpDataCriacao = new System.Windows.Forms.DateTimePicker();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnMaior = new System.Windows.Forms.Button();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnApagarConta = new System.Windows.Forms.Button();
            this.lbContas = new System.Windows.Forms.ListBox();
            this.lblListaDeContas = new System.Windows.Forms.Label();
            this.lbCreditos = new System.Windows.Forms.ListBox();
            this.lblCreditosPendentes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Location = new System.Drawing.Point(13, 48);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(119, 17);
            this.lblNumConta.TabIndex = 0;
            this.lblNumConta.Text = "Numero de Conta";
            // 
            // lbTitular
            // 
            this.lbTitular.AutoSize = true;
            this.lbTitular.Location = new System.Drawing.Point(13, 84);
            this.lbTitular.Name = "lbTitular";
            this.lbTitular.Size = new System.Drawing.Size(48, 17);
            this.lbTitular.TabIndex = 1;
            this.lbTitular.Text = "Titular";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 135);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 17);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Location = new System.Drawing.Point(13, 180);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(30, 17);
            this.lblPIN.TabIndex = 3;
            this.lblPIN.Text = "PIN";
            // 
            // lblDataCria
            // 
            this.lblDataCria.AutoSize = true;
            this.lblDataCria.Location = new System.Drawing.Point(12, 216);
            this.lblDataCria.Name = "lblDataCria";
            this.lblDataCria.Size = new System.Drawing.Size(110, 17);
            this.lblDataCria.TabIndex = 4;
            this.lblDataCria.Text = "Data de Criação";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(138, 45);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(150, 22);
            this.txtNumeroConta.TabIndex = 5;
            this.txtNumeroConta.TextChanged += new System.EventHandler(this.txtNumeroConta_TextChanged);
            this.txtNumeroConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroConta_KeyPress);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(67, 84);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(221, 22);
            this.txtTitular.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(67, 135);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(221, 22);
            this.txtSaldo.TabIndex = 7;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(67, 177);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(221, 22);
            this.txtPin.TabIndex = 8;
            this.txtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // dtpDataCriacao
            // 
            this.dtpDataCriacao.Location = new System.Drawing.Point(129, 216);
            this.dtpDataCriacao.Name = "dtpDataCriacao";
            this.dtpDataCriacao.Size = new System.Drawing.Size(200, 22);
            this.dtpDataCriacao.TabIndex = 9;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(55, 375);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(123, 67);
            this.btnMedia.TabIndex = 11;
            this.btnMedia.Text = "Ver Media do Saldo de Todas as Contas";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(6, 313);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(123, 56);
            this.btnMenor.TabIndex = 12;
            this.btnMenor.Text = "Ver Conta Com Menor Saldo";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMaior
            // 
            this.btnMaior.Location = new System.Drawing.Point(6, 261);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(123, 46);
            this.btnMaior.TabIndex = 13;
            this.btnMaior.Text = "Ver Conta Com Maior Saldo";
            this.btnMaior.UseVisualStyleBackColor = true;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Location = new System.Drawing.Point(135, 261);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(75, 46);
            this.btnCriarConta.TabIndex = 14;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnApagarConta
            // 
            this.btnApagarConta.Location = new System.Drawing.Point(135, 313);
            this.btnApagarConta.Name = "btnApagarConta";
            this.btnApagarConta.Size = new System.Drawing.Size(75, 56);
            this.btnApagarConta.TabIndex = 15;
            this.btnApagarConta.Text = "Apagar Conta";
            this.btnApagarConta.UseVisualStyleBackColor = true;
            this.btnApagarConta.Click += new System.EventHandler(this.btnApagarConta_Click);
            // 
            // lbContas
            // 
            this.lbContas.FormattingEnabled = true;
            this.lbContas.ItemHeight = 16;
            this.lbContas.Location = new System.Drawing.Point(335, 45);
            this.lbContas.Name = "lbContas";
            this.lbContas.Size = new System.Drawing.Size(313, 228);
            this.lbContas.TabIndex = 16;
            // 
            // lblListaDeContas
            // 
            this.lblListaDeContas.AutoSize = true;
            this.lblListaDeContas.Location = new System.Drawing.Point(335, 22);
            this.lblListaDeContas.Name = "lblListaDeContas";
            this.lblListaDeContas.Size = new System.Drawing.Size(183, 17);
            this.lblListaDeContas.TabIndex = 17;
            this.lblListaDeContas.Text = "Lista de contas que existem";
            // 
            // lbCreditos
            // 
            this.lbCreditos.FormattingEnabled = true;
            this.lbCreditos.ItemHeight = 16;
            this.lbCreditos.Location = new System.Drawing.Point(338, 303);
            this.lbCreditos.Name = "lbCreditos";
            this.lbCreditos.Size = new System.Drawing.Size(310, 212);
            this.lbCreditos.TabIndex = 18;
            // 
            // lblCreditosPendentes
            // 
            this.lblCreditosPendentes.AutoSize = true;
            this.lblCreditosPendentes.Location = new System.Drawing.Point(335, 283);
            this.lblCreditosPendentes.Name = "lblCreditosPendentes";
            this.lblCreditosPendentes.Size = new System.Drawing.Size(132, 17);
            this.lblCreditosPendentes.TabIndex = 19;
            this.lblCreditosPendentes.Text = "Creditos Pendentes";
            // 
            // ContaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 530);
            this.Controls.Add(this.lblCreditosPendentes);
            this.Controls.Add(this.lbCreditos);
            this.Controls.Add(this.lblListaDeContas);
            this.Controls.Add(this.lbContas);
            this.Controls.Add(this.btnApagarConta);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.dtpDataCriacao);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.lblDataCria);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lbTitular);
            this.Controls.Add(this.lblNumConta);
            this.Name = "ContaAdmin";
            this.Text = "Conta Administrador";
            this.Shown += new System.EventHandler(this.ContaAdmin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.Label lbTitular;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.Label lblDataCria;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.DateTimePicker dtpDataCriacao;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnApagarConta;
        private System.Windows.Forms.ListBox lbContas;
        private System.Windows.Forms.Label lblListaDeContas;
        private System.Windows.Forms.ListBox lbCreditos;
        private System.Windows.Forms.Label lblCreditosPendentes;
    }
}

