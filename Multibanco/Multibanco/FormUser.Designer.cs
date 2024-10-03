
namespace Multibanco
{
    partial class FormUser
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
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.btnLevantamento = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lbTransacoes = new System.Windows.Forms.ListBox();
            this.btnPedirCredito = new System.Windows.Forms.Button();
            this.btnPagarDivida = new System.Windows.Forms.Button();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtAbate = new System.Windows.Forms.TextBox();
            this.lblAbate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(151, 120);
            this.txtOrdem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(169, 26);
            this.txtOrdem.TabIndex = 0;
            this.txtOrdem.TextChanged += new System.EventHandler(this.txtOrdem_TextChanged);
            this.txtOrdem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrdem_KeyPress);
            // 
            // btnLevantamento
            // 
            this.btnLevantamento.Location = new System.Drawing.Point(14, 84);
            this.btnLevantamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLevantamento.Name = "btnLevantamento";
            this.btnLevantamento.Size = new System.Drawing.Size(122, 39);
            this.btnLevantamento.TabIndex = 1;
            this.btnLevantamento.Text = "Levantamento";
            this.btnLevantamento.UseVisualStyleBackColor = true;
            this.btnLevantamento.Click += new System.EventHandler(this.btnLevantamento_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(14, 145);
            this.btnDeposito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(117, 36);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(15, 24);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(129, 20);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Esta conta é de: ";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(15, 280);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(58, 20);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo: ";
            // 
            // lbTransacoes
            // 
            this.lbTransacoes.FormattingEnabled = true;
            this.lbTransacoes.ItemHeight = 20;
            this.lbTransacoes.Location = new System.Drawing.Point(349, 24);
            this.lbTransacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTransacoes.Name = "lbTransacoes";
            this.lbTransacoes.Size = new System.Drawing.Size(286, 364);
            this.lbTransacoes.TabIndex = 5;
            // 
            // btnPedirCredito
            // 
            this.btnPedirCredito.Location = new System.Drawing.Point(14, 341);
            this.btnPedirCredito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPedirCredito.Name = "btnPedirCredito";
            this.btnPedirCredito.Size = new System.Drawing.Size(130, 48);
            this.btnPedirCredito.TabIndex = 6;
            this.btnPedirCredito.Text = "Pedir Credito";
            this.btnPedirCredito.UseVisualStyleBackColor = true;
            this.btnPedirCredito.Click += new System.EventHandler(this.btnPedirCredito_Click);
            // 
            // btnPagarDivida
            // 
            this.btnPagarDivida.Location = new System.Drawing.Point(14, 396);
            this.btnPagarDivida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagarDivida.Name = "btnPagarDivida";
            this.btnPagarDivida.Size = new System.Drawing.Size(130, 48);
            this.btnPagarDivida.TabIndex = 7;
            this.btnPagarDivida.Text = "Pagar Divida";
            this.btnPagarDivida.UseVisualStyleBackColor = true;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(19, 469);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(64, 20);
            this.lblCredito.TabIndex = 8;
            this.lblCredito.Text = "Credito:";
            // 
            // txtAbate
            // 
            this.txtAbate.Location = new System.Drawing.Point(150, 418);
            this.txtAbate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAbate.Name = "txtAbate";
            this.txtAbate.Size = new System.Drawing.Size(169, 26);
            this.txtAbate.TabIndex = 9;
            // 
            // lblAbate
            // 
            this.lblAbate.AutoSize = true;
            this.lblAbate.Location = new System.Drawing.Point(150, 394);
            this.lblAbate.Name = "lblAbate";
            this.lblAbate.Size = new System.Drawing.Size(113, 20);
            this.lblAbate.TabIndex = 10;
            this.lblAbate.Text = "Valor do abate";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 554);
            this.Controls.Add(this.lblAbate);
            this.Controls.Add(this.txtAbate);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.btnPagarDivida);
            this.Controls.Add(this.btnPedirCredito);
            this.Controls.Add(this.lbTransacoes);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnLevantamento);
            this.Controls.Add(this.txtOrdem);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.Shown += new System.EventHandler(this.FormUser_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.Button btnLevantamento;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ListBox lbTransacoes;
        private System.Windows.Forms.Button btnPedirCredito;
        private System.Windows.Forms.Button btnPagarDivida;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.TextBox txtAbate;
        private System.Windows.Forms.Label lblAbate;
    }
}