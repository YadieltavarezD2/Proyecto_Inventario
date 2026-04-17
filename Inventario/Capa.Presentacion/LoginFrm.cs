using Capa.Entidades;
using Capa.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class LoginFrm : Form
    {
        int intentos = 0;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            UsuariosBL bl = new UsuariosBL();
            Usuarios u = bl.Login(user, pass);

            if (u != null)
            {
                MessageBox.Show("Bienvenido " + u.Nombre);

                int idUsuario = u.Id_Usuario;
                int idRol = u.Id_Rol;

                InicioFrm frm = new InicioFrm(idRol,idUsuario);
                frm.Show();
                this.Hide();
            }
            else
            {
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Demasiados intentos fallidos. El sistema se cerrará.");
                    Application.Exit(); 
                }
                else
                {
                    MessageBox.Show($"Usuario o contraseña incorrectos. Intento {intentos} de 3");
                }
            }
        }
    }
    }

