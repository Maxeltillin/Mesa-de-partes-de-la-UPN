using PROYECTO_AVANCE;
using System;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace WinFormsApp7
{
    public partial class SEGUNDA_INTERFAZ : Form
    {
        private string usuarioActual;
        private string contraseñaActual;
        private bool esAdministrador;


        
        public SEGUNDA_INTERFAZ(string usuario, string contraseña)
        {
            InitializeComponent();

            usuarioActual = usuario;
            contraseñaActual = contraseña;
            esAdministrador = usuario == "admin";
        }

        //boton de registar usuario solo visible para administrador
        private void SEGUNDA_INTERFAZ_Load(object sender, EventArgs e)
        {
            btn_registrar.Visible = esAdministrador;
            pictureBox3.Visible = esAdministrador;
        }

        //boton cerrar sesion
        private void btn_cerrarsesion_(object sender, EventArgs e)
        {
            INICIO formulario = new INICIO();
            formulario.Show();
            this.Close();
        }
        //boton registrar expedientes
        private void btn_registro_Click(object sender, EventArgs e)
        {
            EXPEDIENTE formulario =
                new EXPEDIENTE(usuarioActual, contraseñaActual);

            formulario.Show();
            this.Hide();
        }
        //boton gestionar expedientes
        private void btn_gestion_Click(object sender, EventArgs e)
        {
            GESTIONDATOS formulario =
                new GESTIONDATOS(usuarioActual, contraseñaActual);

            formulario.Show();
            this.Hide();
        }
        //boton parar registrar usuarios
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (!esAdministrador)
            {
                MessageBox.Show("No tiene permisos para gestionar usuarios.");
                return;
            }

            GESTIONUSUARIO formulario = new GESTIONUSUARIO(usuarioActual, contraseñaActual);

            formulario.Show();
            this.Hide();
        }
    }
}