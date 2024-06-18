namespace Herencia.Formularios
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
            this.UsuarioLogin = new System.Windows.Forms.TextBox();
            this.ContrasenniaLogin = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UsuarioLogin.Location = new System.Drawing.Point(121, 164);
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.Size = new System.Drawing.Size(245, 30);
            this.UsuarioLogin.TabIndex = 0;
            this.UsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuarioLogin_KeyPress);
            // 
            // ContrasenniaLogin
            // 
            this.ContrasenniaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ContrasenniaLogin.Location = new System.Drawing.Point(121, 222);
            this.ContrasenniaLogin.Name = "ContrasenniaLogin";
            this.ContrasenniaLogin.Size = new System.Drawing.Size(245, 30);
            this.ContrasenniaLogin.TabIndex = 1;
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ingresar.ForeColor = System.Drawing.Color.White;
            this.Ingresar.Location = new System.Drawing.Point(200, 269);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(93, 39);
            this.Ingresar.TabIndex = 2;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(490, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.ContrasenniaLogin);
            this.Controls.Add(this.UsuarioLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioLogin;
        private System.Windows.Forms.TextBox ContrasenniaLogin;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}