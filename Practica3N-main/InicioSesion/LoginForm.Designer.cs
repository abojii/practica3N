namespace InicioSesion
{
   partial class LoginForm
   {
      /// <summary>
      /// Variable del diseñador necesaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpiar los recursos que se estén usando.
      /// </summary>
      /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código generado por el Diseñador de Windows Forms

      /// <summary>
      /// Método necesario para admitir el Diseñador. No se puede modificar
      /// el contenido de este método con el editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.tbUser = new System.Windows.Forms.TextBox();
         this.tbPassword = new System.Windows.Forms.TextBox();
         this.btnLogin = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label1.Location = new System.Drawing.Point(27, 95);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(52, 15);
         this.label1.TabIndex = 0;
         this.label1.Text = "Usuario:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label2.Location = new System.Drawing.Point(8, 126);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 15);
         this.label2.TabIndex = 1;
         this.label2.Text = "Contraseña:";
         // 
         // tbUser
         // 
         this.tbUser.Location = new System.Drawing.Point(104, 95);
         this.tbUser.Name = "tbUser";
         this.tbUser.Size = new System.Drawing.Size(155, 20);
         this.tbUser.TabIndex = 2;
         // 
         // tbPassword
         // 
         this.tbPassword.Location = new System.Drawing.Point(104, 126);
         this.tbPassword.Name = "tbPassword";
         this.tbPassword.PasswordChar = '$';
         this.tbPassword.Size = new System.Drawing.Size(155, 20);
         this.tbPassword.TabIndex = 3;
         // 
         // btnLogin
         // 
         this.btnLogin.Location = new System.Drawing.Point(142, 178);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(82, 40);
         this.btnLogin.TabIndex = 4;
         this.btnLogin.Text = "Iniciar Sesion";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.Transparent;
         this.panel1.BackgroundImage = global::InicioSesion.Properties.Resources.iniciar_sesion__2_;
         this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
         this.panel1.Location = new System.Drawing.Point(309, 80);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(144, 138);
         this.panel1.TabIndex = 5;
         // 
         // LoginForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(501, 287);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.tbPassword);
         this.Controls.Add(this.tbUser);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "LoginForm";
         this.Text = "Inicio de Sesion";
         this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
         this.Theme = MetroFramework.MetroThemeStyle.Default;
         this.Load += new System.EventHandler(this.LoginForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox tbUser;
      private System.Windows.Forms.TextBox tbPassword;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Panel panel1;
   }
}

