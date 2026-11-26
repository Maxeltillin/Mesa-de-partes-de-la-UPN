namespace PROYECTO_AVANCE
{
    partial class GESTIONUSUARIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            titulo = new Label();
            dataGridViewUsuarios = new DataGridView();
            lbl_usuario = new Label();
            lbl_contraseña = new Label();
            txt_usuario = new TextBox();
            txt_contraseña = new TextBox();
            btn_registrarusuario = new Button();
            btn_regresar = new Button();
            btn_eliminarusuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(213, 225, 239);
            label1.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-2, 60);
            label1.Name = "label1";
            label1.Size = new Size(1354, 48);
            label1.TabIndex = 19;
            label1.Text = "Mesa de partes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titulo
            // 
            titulo.BackColor = Color.FromArgb(213, 225, 239);
            titulo.Font = new Font("Swis721 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.ForeColor = SystemColors.ActiveCaptionText;
            titulo.Location = new Point(-2, -3);
            titulo.Name = "titulo";
            titulo.Size = new Size(1354, 81);
            titulo.TabIndex = 18;
            titulo.Text = "💼 GESTIÓN DE USUARIOS";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(30, 173);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(831, 384);
            dataGridViewUsuarios.TabIndex = 20;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(933, 216);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(62, 20);
            lbl_usuario.TabIndex = 21;
            lbl_usuario.Text = "Usuario:";
            // 
            // lbl_contraseña
            // 
            lbl_contraseña.AutoSize = true;
            lbl_contraseña.Location = new Point(909, 268);
            lbl_contraseña.Name = "lbl_contraseña";
            lbl_contraseña.Size = new Size(86, 20);
            lbl_contraseña.TabIndex = 22;
            lbl_contraseña.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(1026, 216);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(259, 27);
            txt_usuario.TabIndex = 23;
            // 
            // txt_contraseña
            // 
            txt_contraseña.Location = new Point(1026, 268);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(259, 27);
            txt_contraseña.TabIndex = 24;
            // 
            // btn_registrarusuario
            // 
            btn_registrarusuario.BackColor = Color.FromArgb(213, 225, 239);
            btn_registrarusuario.FlatAppearance.BorderSize = 0;
            btn_registrarusuario.FlatStyle = FlatStyle.Flat;
            btn_registrarusuario.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            btn_registrarusuario.Location = new Point(1026, 322);
            btn_registrarusuario.Name = "btn_registrarusuario";
            btn_registrarusuario.Size = new Size(259, 39);
            btn_registrarusuario.TabIndex = 25;
            btn_registrarusuario.Text = "REGISTRAR USUARIO";
            btn_registrarusuario.UseVisualStyleBackColor = false;
            btn_registrarusuario.Click += btn_registrarusuario_Click;
            // 
            // btn_regresar
            // 
            btn_regresar.BackColor = Color.FromArgb(192, 57, 43);
            btn_regresar.FlatAppearance.BorderSize = 0;
            btn_regresar.FlatStyle = FlatStyle.Flat;
            btn_regresar.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresar.ForeColor = SystemColors.ButtonHighlight;
            btn_regresar.Location = new Point(1191, 556);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(105, 50);
            btn_regresar.TabIndex = 26;
            btn_regresar.Text = "REGRESAR";
            btn_regresar.UseVisualStyleBackColor = false;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // btn_eliminarusuario
            // 
            btn_eliminarusuario.BackColor = Color.FromArgb(192, 57, 43);
            btn_eliminarusuario.FlatAppearance.BorderSize = 0;
            btn_eliminarusuario.FlatStyle = FlatStyle.Flat;
            btn_eliminarusuario.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminarusuario.ForeColor = SystemColors.ButtonHighlight;
            btn_eliminarusuario.Location = new Point(1026, 388);
            btn_eliminarusuario.Name = "btn_eliminarusuario";
            btn_eliminarusuario.Size = new Size(259, 39);
            btn_eliminarusuario.TabIndex = 27;
            btn_eliminarusuario.Text = "ELIMINAR USUARIO";
            btn_eliminarusuario.UseVisualStyleBackColor = false;
            btn_eliminarusuario.Click += btn_eliminarusuario_Click;
            // 
            // GESTIONUSUARIO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 636);
            Controls.Add(btn_eliminarusuario);
            Controls.Add(btn_regresar);
            Controls.Add(btn_registrarusuario);
            Controls.Add(txt_contraseña);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_contraseña);
            Controls.Add(lbl_usuario);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(label1);
            Controls.Add(titulo);
            Name = "GESTIONUSUARIO";
            Text = "GESTIONUSUARIO";
            Load += GESTIONUSUARIO_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label titulo;
        private DataGridView dataGridViewUsuarios;
        private Label lbl_usuario;
        private Label lbl_contraseña;
        private TextBox txt_usuario;
        private TextBox txt_contraseña;
        private Button btn_registrarusuario;
        private Button btn_regresar;
        private Button btn_eliminarusuario;
    }
}