using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ejercicio_T003
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "Username" && txtUsuario.TextLength > 2)
            {
                if (txtContrasenia.Text != "Password")
                {
                    //UserModel user = new UserModel();
                    //var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    var validLogin = true;
                    if (validLogin == true)
                    {
                        FormMenuPrincipal mainMenu = new FormMenuPrincipal();
                        //MessageBox.Show("Bienvenido " + UserCache.FirstName + "," + UserCache.LastName);
                        mainMenu.Show();
                        //mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n Please try again.");
                        txtContrasenia.Text = "Password";
                        txtContrasenia.UseSystemPasswordChar = false;
                        txtUsuario.Focus();
                    }
                }
                else msgError("Please enter password.");
            }
            else msgError("Please enter username.");

        }
        private void msgError(string mensaje) {

            MessageBox.Show(mensaje);
        }
    }
}
