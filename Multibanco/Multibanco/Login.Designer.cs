
namespace Multibanco
{
    partial class Login
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
            this.lblPIN = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Location = new System.Drawing.Point(15, 61);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(119, 17);
            this.lblNumConta.TabIndex = 0;
            this.lblNumConta.Text = "Numero de Conta";
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Location = new System.Drawing.Point(104, 94);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(30, 17);
            this.lblPIN.TabIndex = 1;
            this.lblPIN.Text = "PIN";
            this.lblPIN.Click += new System.EventHandler(this.lblPIN_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(140, 137);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log-in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtNumConta
            // 
            this.txtNumConta.Location = new System.Drawing.Point(140, 61);
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(129, 22);
            this.txtNumConta.TabIndex = 3;
            this.txtNumConta.TextChanged += new System.EventHandler(this.txtNumConta_TextChanged);
            this.txtNumConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumConta_KeyPress);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(140, 89);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(129, 22);
            this.txtPIN.TabIndex = 4;
            this.txtPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIN_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 436);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.lblNumConta);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.TextBox txtPIN;
    }
}