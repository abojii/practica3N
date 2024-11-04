using InicioSesion.models;
using InicioSesion.Servicios;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioSesion
{
   public partial class LoginForm : MetroFramework.Forms.MetroForm
   {
      public LoginForm()
      {
         InitializeComponent();
      }

      private void LoginForm_Load(object sender, EventArgs e)
      {

      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
        if(tbUser.Text.Trim()== "" || tbPassword.Text.Trim()== "")
         {
            MetroMessageBox.Show(this, "No se pueden dejar espacios en blanco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         Usuario usuario = new Usuario()
         {
            User = tbUser.Text,
            Password = tbPassword.Text
         };
         UserServicio userServicio = new UserServicio();

         if(userServicio.ValidateUser(usuario.User, usuario.Password)) 
         {
            MetroMessageBox.Show(this, "Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         else
         {
            MetroMessageBox.Show(this, "Usuario o comtraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}