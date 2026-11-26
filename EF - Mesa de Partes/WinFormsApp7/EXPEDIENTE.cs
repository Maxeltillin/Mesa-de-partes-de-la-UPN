namespace WinFormsApp7
{
    public partial class EXPEDIENTE : Form
    {
        private string usuarioActual;
        private string contraseñaActual;

        private string rutaExpedientes = Path.Combine(Application.StartupPath, "expedientes.dat");

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
        }

        public EXPEDIENTE(string usuario, string contraseña)
        {
            InitializeComponent();

            usuarioActual = usuario;
            contraseñaActual = contraseña;
        }

        private void EXPEDIENTE_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }


        //boton para guardar expediente
        private void btn_guardarexpediente(object sender, EventArgs e)
        {
            Expediente expediente;
            //registro de los datos colocados
            expediente.nombre = textname.Text;
            expediente.dni = textdni.Text;
            expediente.telefono = texttelefono.Text;
            expediente.correo = textcorreo.Text;
            expediente.codigo = textcodigo.Text;
            expediente.tipoDocumento = combotipodoc.Text;
            expediente.asunto = textasunto.Text;
            expediente.usuario = usuarioActual;
            //si los datos estan vacios marcara error
            if (expediente.nombre == "" || expediente.dni == "" || expediente.telefono == "" ||
                expediente.correo == "" || expediente.codigo == "" || expediente.tipoDocumento == "" ||
                expediente.asunto == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            //Verificar que el dni tenga exclusivamente 8 digitos
            if (expediente.dni.Length != 8)
            {
                MessageBox.Show("El DNI debe contener exactamente 8 números.");
                return;
            }

            try
            {
                using (BinaryWriter escritor = new BinaryWriter(File.Open(rutaExpedientes, FileMode.Append, FileAccess.Write)))
                {
                    escritor.Write(expediente.nombre);
                    escritor.Write(expediente.dni);
                    escritor.Write(expediente.telefono);
                    escritor.Write(expediente.correo);
                    escritor.Write(expediente.codigo);
                    escritor.Write(expediente.tipoDocumento);
                    escritor.Write(expediente.asunto);
                    escritor.Write(expediente.usuario);
                }

                MessageBox.Show("Expediente registrado correctamente.");

                textname.Clear();
                textdni.Clear();
                texttelefono.Clear();
                textcorreo.Clear();
                textcodigo.Clear();
                combotipodoc.SelectedIndex = -1;
                textasunto.Clear();
            }
            catch { }
        }

        //Generador de codigo
        private void GenerarCodigo()
        {
            int ultimoNumero = 0;

            try
            {
                if (File.Exists(rutaExpedientes))
                {
                    using (BinaryReader lector = new BinaryReader(File.Open(rutaExpedientes, FileMode.Open, FileAccess.Read)))
                    {
                        while (lector.BaseStream.Position < lector.BaseStream.Length)
                        {
                            string codigo = lector.ReadString();

                            if (codigo.StartsWith("EXP-") &&
                                int.TryParse(codigo.Substring(4), out int numero))
                            {
                                if (numero > ultimoNumero)
                                {
                                    ultimoNumero = numero;
                                }
                            }
                        }
                    }
                }

                textcodigo.Text = "EXP-" + (ultimoNumero + 1).ToString("D4");
                textcodigo.ReadOnly = true;
            }
            catch { }
        }

        //boton para regresar al menu de opciones
        private void btn_regreso_Click(object sender, EventArgs e)
        {
            SEGUNDA_INTERFAZ formulario = new SEGUNDA_INTERFAZ(usuarioActual, contraseñaActual);

            formulario.Show();
            this.Close();
        }
    }
}