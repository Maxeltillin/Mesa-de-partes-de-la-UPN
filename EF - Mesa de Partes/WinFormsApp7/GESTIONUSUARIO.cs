using System.Net;
using WinFormsApp7;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PROYECTO_AVANCE
{
    public partial class GESTIONUSUARIO : Form
    {
        private string usuarioActual;
        private string contraseñaActual;

        private string rutaUsuarios = Path.Combine(Application.StartupPath, "usuarios.dat");

        private string rutaExpedientes = Path.Combine(Application.StartupPath, "expedientes.dat");

        private struct Usuario
        {
            public string nombre;
            public string contraseña;
        }

        private struct Expediente
        {
            public string nombre;
            public string dni;
            public string telefono;
            public string correo;
            public string codigo;
            public string tipoDocumento;
            public string asunto;
            public string usuario;

            //para que no marque como campo vacio
            public Expediente()
            {
                nombre = "";
                dni = "";
                telefono = "";
                correo = "";
                codigo = "";
                tipoDocumento = "";
                asunto = "";
                usuario = "";
            }
        }

        public GESTIONUSUARIO(string usuario, string contraseña)
        {
            InitializeComponent();

            usuarioActual = usuario;
            contraseñaActual = contraseña;
        }

        private void GESTIONUSUARIO_Load(object sender, EventArgs e)
        {
            ConfigurarGridUsuarios();
            CargarUsuarios();
        }

        //configuracion para que aparezcan las columnas en el datagrid para los usuarios y las contraseñas
        private void ConfigurarGridUsuarios()
        {
            dataGridViewUsuarios.Columns.Add("nombre", "Usuario");
            dataGridViewUsuarios.Columns.Add("contraseña", "Contraseña");
        }

        //configuracion del para cargar los datos registrados de expediente al datagrid
        private void CargarUsuarios()
        {
            dataGridViewUsuarios.Rows.Clear();

            try
            {
                using (BinaryReader lector = new BinaryReader(File.Open(rutaUsuarios, FileMode.Open, FileAccess.Read)))
                {
                    while (lector.BaseStream.Position < lector.BaseStream.Length)
                    {
                        Usuario usuario;

                        usuario.nombre = lector.ReadString();
                        usuario.contraseña = lector.ReadString();

                        dataGridViewUsuarios.Rows.Add(
                            usuario.nombre,
                            usuario.contraseña);
                    }
                }
            }
            catch { }
        }

        //boton para registrar usuarios
        private void btn_registrarusuario_Click(object sender, EventArgs e)
        {
            string nombre = txt_usuario.Text.Trim();
            string contraseña = txt_contraseña.Text.Trim();
            //corroborar que los datos no esten vacios
            if (nombre == "" || contraseña == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            //el nombre admin esta reservado
            if (nombre == "admin")
            {
                MessageBox.Show("Ese nombre de usuario está reservado.");
                return;
            }

            try
            {
                bool existe = false;

                if (File.Exists(rutaUsuarios))
                {
                    using (BinaryReader lector = new BinaryReader(File.Open(rutaUsuarios, FileMode.Open, FileAccess.Read)))
                    {
                        while (lector.BaseStream.Position < lector.BaseStream.Length)
                        {
                            Usuario usuario;

                            usuario.nombre = lector.ReadString();
                            usuario.contraseña = lector.ReadString();

                            if (usuario.nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                            {
                                existe = true;
                                break;
                            }
                        }
                    }
                }

                if (existe)
                {
                    MessageBox.Show("El usuario ya existe.");
                    return;
                }

                using (BinaryWriter escritor = new BinaryWriter(File.Open(rutaUsuarios, FileMode.Append, FileAccess.Write)))
                {
                    escritor.Write(nombre);
                    escritor.Write(contraseña);
                }

                MessageBox.Show("Usuario registrado correctamente.");

                txt_usuario.Clear();
                txt_contraseña.Clear();

                CargarUsuarios();
            }
            catch { }
        }
        //boton para eliminar usuario
        private void btn_eliminarusuario_Click(object sender, EventArgs e)
        {

            string nombre = Convert.ToString(dataGridViewUsuarios.SelectedRows[0].Cells["nombre"].Value) ?? "";

            if (nombre == "admin")
            {
                MessageBox.Show("No se puede eliminar el administrador.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar este usuario y sus expedientes asociados?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            string temporalUsuarios = rutaUsuarios + ".tmp";
            string temporalExpedientes = rutaExpedientes + ".tmp";

            try
            {
                // Reescribir usuarios sin el usuario seleccionado.
                using (BinaryReader lector = new BinaryReader(File.Open(rutaUsuarios, FileMode.Open, FileAccess.Read)))
                using (BinaryWriter escritor = new BinaryWriter(File.Open(temporalUsuarios, FileMode.Create, FileAccess.Write)))
                {
                    while (lector.BaseStream.Position < lector.BaseStream.Length)
                    {
                        Usuario usuario;

                        usuario.nombre = lector.ReadString();
                        usuario.contraseña = lector.ReadString();

                        if (!usuario.nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                        {
                            escritor.Write(usuario.nombre);
                            escritor.Write(usuario.contraseña);
                        }
                    }
                }

                File.Copy(temporalUsuarios, rutaUsuarios, true);
                File.Delete(temporalUsuarios);

                if (File.Exists(temporalExpedientes))
                {
                    File.Copy(temporalExpedientes, rutaExpedientes, true);
                    File.Delete(temporalExpedientes);
                }

                CargarUsuarios();

                MessageBox.Show(
                    "Usuario eliminado correctamente.");
            }
            catch{}
        }

        //boton regresar al menu de opciones
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            SEGUNDA_INTERFAZ formulario = new SEGUNDA_INTERFAZ(usuarioActual, contraseñaActual);

            formulario.Show();
            this.Close();
        }
    }
}