using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimientoGasto
{
    public partial class Login : Form
    {
        private string usuarioAdmin = "admin";
        private string contraseñaAdmin = "1234";
        private string usuario;
        private string contraseña;
        private Conexion conex = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Autenticacion admin
            //
            ////Usuarios obj = conex.buscarUsuario(textUsuario.Text);

            if (textUsuario.Text == usuarioAdmin)
            {
                if (textPassword.Text == contraseñaAdmin)
                {
                    MessageBox.Show("Acceso permitido...");
                    Admin ventana2 = new Admin(this);
                    ventana2.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Contraseña erronea...");
                }   
            }else if (textUsuario.Text != "")
            {
                Usuarios obj = conex.buscarUsuario(textUsuario.Text);
                if (obj.usuario != "")
                {
                    if (textUsuario.Text == obj.usuario)
                    {
                        if (textPassword.Text == obj.contraseña)
                        {
                            MessageBox.Show("Acceso permitido...");
                            User ventana3 = new User(this,obj.idUsuario);
                            ventana3.Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña erronea...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario erroneo...");
                    }
                }
                else if(obj.usuario == "")
                {
                    MessageBox.Show("Usuario no existe...");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario...");
            }
            /*
            if ((textUsuario.Text == usuarioAdmin) && (textPassword.Text == contraseñaAdmin)){
                MessageBox.Show("Acceso permitido...");
                Admin ventana2 = new Admin(this);
                ventana2.Visible = true;
                this.Visible = false;
                //this.Activate();
            }else if ((textUsuario.Text != usuarioAdmin) && (textPassword.Text != contraseñaAdmin))
            {
                MessageBox.Show("Usuario y contraseña erroneos...");
            }
            else if(textUsuario.Text != usuarioAdmin)
            {
                MessageBox.Show("Usuario erroneo...");
            }
            else if(textPassword.Text != contraseñaAdmin)
            {
                MessageBox.Show("Contraseña erronea...");
            }else if ((textUsuario.Text == obj.usuario) && (textPassword.Text == obj.contraseña))
            {
                MessageBox.Show("Acceso permitido...");
                User ventana3 = new User(this);
                ventana3.Visible = true;
                this.Visible = false;
                //this.Activate();
            }
            else if ((textUsuario.Text != obj.usuario) && (textPassword.Text != obj.contraseña))
            {
                MessageBox.Show("Usuario y contraseña erroneos...");
            }
            else if (textUsuario.Text != obj.usuario)
            {
                MessageBox.Show("Usuario erroneo...");
            }
            else if (textPassword.Text != obj.contraseña)
            {
                MessageBox.Show("Contraseña erronea...");
            }*/
        }
    }
}
