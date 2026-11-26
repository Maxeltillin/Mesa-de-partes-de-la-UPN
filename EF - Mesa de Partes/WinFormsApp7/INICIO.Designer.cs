namespace WinFormsApp7
{
    partial class INICIO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            btn_ingresar = new Button();
            titulo = new Label();
            text_usuario = new Label();
            text_contraseña = new Label();
            textBox_usuario = new TextBox();
            textBox_contraseña = new TextBox();
            LOGO = new PictureBox();
            checkBox1 = new CheckBox();
            INTERFAZ = new Label();
            ((System.ComponentModel.ISupportInitialize)LOGO).BeginInit();
            SuspendLayout();
            // 
            // btn_ingresar
            // 
            btn_ingresar.AutoEllipsis = true;
            btn_ingresar.BackColor = Color.FromArgb(213, 225, 239);
            btn_ingresar.FlatAppearance.BorderSize = 0;
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            btn_ingresar.ForeColor = SystemColors.ActiveCaptionText;
            btn_ingresar.Location = new Point(161, 337);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(293, 40);
            btn_ingresar.TabIndex = 0;
            btn_ingresar.Text = "INGRESAR";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_;
            // 
            // titulo
            // 
            titulo.BackColor = Color.FromArgb(213, 225, 239);
            titulo.Font = new Font("Swis721 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.ForeColor = SystemColors.ActiveCaptionText;
            titulo.Location = new Point(-9, -12);
            titulo.Name = "titulo";
            titulo.Size = new Size(632, 117);
            titulo.TabIndex = 1;
            titulo.Text = "🔒 INICIO DE SESIÓN";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // text_usuario
            // 
            text_usuario.AutoSize = true;
            text_usuario.BackColor = Color.Transparent;
            text_usuario.Font = new Font("Segoe UI", 9F);
            text_usuario.ForeColor = SystemColors.ActiveCaptionText;
            text_usuario.Location = new Point(70, 168);
            text_usuario.Name = "text_usuario";
            text_usuario.Size = new Size(62, 20);
            text_usuario.TabIndex = 2;
            text_usuario.Text = "Usuario:";
            // 
            // text_contraseña
            // 
            text_contraseña.AutoSize = true;
            text_contraseña.BackColor = Color.Transparent;
            text_contraseña.Font = new Font("Segoe UI", 9F);
            text_contraseña.ForeColor = SystemColors.ActiveCaptionText;
            text_contraseña.Location = new Point(46, 219);
            text_contraseña.Name = "text_contraseña";
            text_contraseña.Size = new Size(86, 20);
            text_contraseña.TabIndex = 3;
            text_contraseña.Text = "Contraseña:";
            // 
            // textBox_usuario
            // 
            textBox_usuario.Location = new Point(161, 165);
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.Size = new Size(254, 27);
            textBox_usuario.TabIndex = 4;
            // 
            // textBox_contraseña
            // 
            textBox_contraseña.Location = new Point(161, 212);
            textBox_contraseña.Name = "textBox_contraseña";
            textBox_contraseña.Size = new Size(254, 27);
            textBox_contraseña.TabIndex = 5;
            textBox_contraseña.UseSystemPasswordChar = true;
            // 
            // LOGO
            // 
            LOGO.ErrorImage = null;
            LOGO.Image = (Image)resources.GetObject("LOGO.Image");
            LOGO.Location = new Point(450, 154);
            LOGO.Name = "LOGO";
            LOGO.Size = new Size(130, 130);
            LOGO.SizeMode = PictureBoxSizeMode.StretchImage;
            LOGO.TabIndex = 6;
            LOGO.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(161, 260);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox_Mostrarcontraseña;
            // 
            // INTERFAZ
            // 
            INTERFAZ.BackColor = Color.FromArgb(213, 225, 239);
            INTERFAZ.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            INTERFAZ.ForeColor = SystemColors.ActiveCaptionText;
            INTERFAZ.Location = new Point(-9, 70);
            INTERFAZ.Name = "INTERFAZ";
            INTERFAZ.Size = new Size(632, 48);
            INTERFAZ.TabIndex = 9;
            INTERFAZ.Text = "Mesa de partes";
            INTERFAZ.TextAlign = ContentAlignment.TopCenter;
            // 
            // INICIO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 422);
            Controls.Add(INTERFAZ);
            Controls.Add(checkBox1);
            Controls.Add(LOGO);
            Controls.Add(textBox_contraseña);
            Controls.Add(textBox_usuario);
            Controls.Add(text_contraseña);
            Controls.Add(text_usuario);
            Controls.Add(titulo);
            Controls.Add(btn_ingresar);
            ForeColor = SystemColors.ControlText;
            Name = "INICIO";
            Text = "Inicio de Sesión";
            Load += INICIO_Load;
            ((System.ComponentModel.ISupportInitialize)LOGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ingresar;
        private Label titulo;
        private Label text_usuario;
        private Label text_contraseña;
        private TextBox textBox_usuario;
        private TextBox textBox_contraseña;
        private PictureBox LOGO;
        private CheckBox checkBox1;
        private Label INTERFAZ;
    }
}
