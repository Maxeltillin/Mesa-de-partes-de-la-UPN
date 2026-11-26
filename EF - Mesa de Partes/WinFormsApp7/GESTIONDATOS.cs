namespace WinFormsApp7
{
    public partial class GESTIONDATOS : Form
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

        private void GESTIONDATOS_Load(object sender, EventArgs e)
        {
            CargarExpedientes();
        }
        public GESTIONDATOS(string usuario, string contraseña)
        {
            InitializeComponent();

            usuarioActual = usuario;
            contraseñaActual = contraseña;

            ConfigurarGridExpedientes();
            CargarExpedientes();
        }

        //Configuracion del datagrid para que aparezcan las columnas registradas del expediente
        private void ConfigurarGridExpedientes()
        {
            dataGridViewExpedientes.Columns.Clear();

            dataGridViewExpedientes.Columns.Add("nombre", "Nombre");
            dataGridViewExpedientes.Columns.Add("dni", "DNI");
            dataGridViewExpedientes.Columns.Add("telefono", "Teléfono");
            dataGridViewExpedientes.Columns.Add("correo", "Correo");
            dataGridViewExpedientes.Columns.Add("codigo", "Código");
            dataGridViewExpedientes.Columns.Add("tipoDocumento", "Tipo de documento");
            dataGridViewExpedientes.Columns.Add("asunto", "Asunto");
        }

        //configuracion del datagrid para que carguen los datos registrados del expediente 
        private void CargarExpedientes()
        {
            dataGridViewExpedientes.Rows.Clear();

            try
            {
                using (BinaryReader lector = new BinaryReader(File.Open(rutaExpedientes, FileMode.Open, FileAccess.Read)))
                {
                    while (lector.BaseStream.Position < lector.BaseStream.Length)
                    {
                        Expediente expediente;

                        expediente.nombre = lector.ReadString();
                        expediente.dni = lector.ReadString();
                        expediente.telefono = lector.ReadString();
                        expediente.correo = lector.ReadString();
                        expediente.codigo = lector.ReadString();
                        expediente.tipoDocumento = lector.ReadString();
                        expediente.asunto = lector.ReadString();
                        expediente.usuario = lector.ReadString();

                        dataGridViewExpedientes.Rows.Add(
                            expediente.nombre,
                            expediente.dni,
                            expediente.telefono,
                            expediente.correo,
                            expediente.codigo,
                            expediente.tipoDocumento,
                            expediente.asunto);
                    }
                }
            }
            catch { }
        }

        //boton para buscar expediente por codigo o Dni 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string busqueda = txt_buscar.Text;

            //si el boton busqueda esta vacio se cargaran todos los expedientes
            if (busqueda == "")
            {
                CargarExpedientes();
                return;
            }

            bool encontrado = false;

            foreach (DataGridViewRow fila in dataGridViewExpedientes.Rows)
            {
                string dni = fila.Cells["dni"]?.Value as string ?? "";
                string codigo = fila.Cells["codigo"]?.Value as string ?? "";

                bool coincideDni = dni.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0;

                bool coincideCodigo = codigo.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0;

                bool mostrar = coincideDni || coincideCodigo;

                fila.Visible = mostrar;

                if (mostrar)
                    encontrado = true;
            }

            if (!encontrado)
                MessageBox.Show("No se encontraron expedientes.");
        }

        //Boton para ordenar por orden alfabetico
        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            var columnaNombre = dataGridViewExpedientes.Columns["nombre"];

            if (columnaNombre != null)
            {
                dataGridViewExpedientes.Sort(columnaNombre, System.ComponentModel.ListSortDirection.Ascending);
            }
        }

        //boton para eliminar expediente
        private void btn_eliminar_(object sender, EventArgs e)
        {

            var filaSeleccionada = dataGridViewExpedientes.SelectedRows[0];

            string codigo = filaSeleccionada.Cells["codigo"]?.Value as string ?? "";


            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este expediente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            string rutaTemporal = rutaExpedientes + ".tmp";

            try
            {
                using (BinaryReader lector = new BinaryReader(File.Open(rutaExpedientes, FileMode.Open, FileAccess.Read)))
                using (BinaryWriter escritor = new BinaryWriter(File.Open(rutaTemporal, FileMode.Create, FileAccess.Write)))
                {
                    while (lector.BaseStream.Position < lector.BaseStream.Length)
                    {
                        Expediente expediente;

                        expediente.nombre = lector.ReadString();
                        expediente.dni = lector.ReadString();
                        expediente.telefono = lector.ReadString();
                        expediente.correo = lector.ReadString();
                        expediente.codigo = lector.ReadString();
                        expediente.tipoDocumento = lector.ReadString();
                        expediente.asunto = lector.ReadString();
                        expediente.usuario = lector.ReadString();

                        if (!expediente.codigo.Equals(
                            codigo, StringComparison.OrdinalIgnoreCase))
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
                    }
                }

                File.Copy(rutaTemporal, rutaExpedientes, true);
                File.Delete(rutaTemporal);

                CargarExpedientes();

                MessageBox.Show("Expediente eliminado correctamente.");
            }
            catch { }
        }

        //bototon para regresar al menu de opciones

        private void btn_regreso_Click(object sender, EventArgs e)
        {
            SEGUNDA_INTERFAZ formulario = new SEGUNDA_INTERFAZ(usuarioActual, contraseñaActual);

            formulario.Show();
            this.Close();
        }


    }
}
