namespace WinFormsApp7
{
    partial class SEGUNDA_INTERFAZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEGUNDA_INTERFAZ));
            btn_registro = new Button();
            btn_gestion = new Button();
            btn_cerrarsesion = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tituloO = new Label();
            pictureBox3 = new PictureBox();
            btn_registrar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_registro
            // 
            btn_registro.BackColor = Color.FromArgb(213, 225, 239);
            btn_registro.FlatAppearance.BorderSize = 0;
            btn_registro.FlatStyle = FlatStyle.Flat;
            btn_registro.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registro.Location = new Point(49, 175);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(140, 50);
            btn_registro.TabIndex = 0;
            btn_registro.Text = "REGISTRAR EXPEDIENTE";
            btn_registro.UseVisualStyleBackColor = false;
            btn_registro.Click += btn_registro_Click;
            // 
            // btn_gestion
            // 
            btn_gestion.BackColor = Color.FromArgb(213, 225, 239);
            btn_gestion.FlatAppearance.BorderSize = 0;
            btn_gestion.FlatStyle = FlatStyle.Flat;
            btn_gestion.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_gestion.Location = new Point(424, 175);
            btn_gestion.Name = "btn_gestion";
            btn_gestion.Size = new Size(140, 50);
            btn_gestion.TabIndex = 1;
            btn_gestion.Text = "GESTIONAR O BUSCAR";
            btn_gestion.UseVisualStyleBackColor = false;
            btn_gestion.Click += btn_gestion_Click;
            // 
            // btn_cerrarsesion
            // 
            btn_cerrarsesion.BackColor = Color.FromArgb(192, 57, 43);
            btn_cerrarsesion.FlatAppearance.BorderSize = 0;
            btn_cerrarsesion.FlatStyle = FlatStyle.Flat;
            btn_cerrarsesion.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrarsesion.ForeColor = SystemColors.ButtonFace;
            btn_cerrarsesion.Location = new Point(439, 422);
            btn_cerrarsesion.Name = "btn_cerrarsesion";
            btn_cerrarsesion.Size = new Size(148, 41);
            btn_cerrarsesion.TabIndex = 2;
            btn_cerrarsesion.Text = "CERRAR SESIÓN";
            btn_cerrarsesion.UseVisualStyleBackColor = false;
            btn_cerrarsesion.Click += btn_cerrarsesion_;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 242);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(424, 242);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // tituloO
            // 
            tituloO.BackColor = Color.FromArgb(213, 225, 239);
            tituloO.BorderStyle = BorderStyle.FixedSingle;
            tituloO.Font = new Font("Swis721 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloO.ForeColor = SystemColors.ActiveCaptionText;
            tituloO.Location = new Point(-9, -7);
            tituloO.Name = "tituloO";
            tituloO.Size = new Size(635, 117);
            tituloO.TabIndex = 5;
            tituloO.Text = "⚙ MENÚ DE OPCIONES";
            tituloO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(236, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 140);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = Color.FromArgb(213, 225, 239);
            btn_registrar.FlatAppearance.BorderSize = 0;
            btn_registrar.FlatStyle = FlatStyle.Flat;
            btn_registrar.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.Location = new Point(236, 175);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(140, 50);
            btn_registrar.TabIndex = 6;
            btn_registrar.Text = "REGISTRAR USUARIO";
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(213, 225, 239);
            label1.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-9, 74);
            label1.Name = "label1";
            label1.Size = new Size(632, 48);
            label1.TabIndex = 10;
            label1.Text = "Mesa de partes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // SEGUNDA_INTERFAZ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 506);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(btn_registrar);
            Controls.Add(tituloO);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_cerrarsesion);
            Controls.Add(btn_gestion);
            Controls.Add(btn_registro);
            Name = "SEGUNDA_INTERFAZ";
            Text = "Menú de opciones";
            Load += SEGUNDA_INTERFAZ_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_registro;
        private Button btn_gestion;
        private Button btn_cerrarsesion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label tituloO;
        private PictureBox pictureBox3;
        private Button btn_registrar;
        private Label label1;
    }
}