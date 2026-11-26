namespace WinFormsApp7
{
    public partial class INICIO : Form
    {
        private string rutaUsuarios = Path.Combine(Application.StartupPath, "usuarios.dat");

        private struct Usuario
        {
            public string nombre;
            public string contraseña;
        }

        public INICIO()
        {
            InitializeComponent();
        }
        private void INICIO_Load(object sender, EventArgs e)
        {

        }

        //boton para iniciar sesion
        private void btn_ingresar_(object sender, EventArgs e)
        {
            string nombre = textBox_usuario.Text;
            string contraseña = textBox_contraseña.Text;

            //Verificar que las casillas no esten vacias
            if (nombre == "" || contraseña == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }


            //Si el usuario no ha sido encontrado
            bool encontrado = false;

            try
            {
                using (BinaryReader lector = new BinaryReader(File.Open(rutaUsuarios, FileMode.Open, FileAccess.Read)))
                {
                    while (lector.BaseStream.Position < lector.BaseStream.Length)
                    {
                        Usuario usuario;

                        usuario.nombre = lector.ReadString();
                        usuario.contraseña = lector.ReadString();

                        if (usuario.nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) && usuario.contraseña == contraseña)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                }
                //Usuario encontrado
                if (encontrado)
                {
                    SEGUNDA_INTERFAZ formulario =
                        new SEGUNDA_INTERFAZ(nombre, contraseña);

                    formulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }

            catch
            {

            }
        }
        //Mostrar contraseña
        private void checkBox_Mostrarcontraseña(object sender, EventArgs e)
        {
            textBox_contraseña.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}