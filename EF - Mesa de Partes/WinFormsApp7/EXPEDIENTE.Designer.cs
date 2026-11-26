namespace WinFormsApp7
{
    partial class EXPEDIENTE
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
            btn_regreso = new Button();
            titulo = new Label();
            label3 = new Label();
            label5 = new Label();
            textasunto = new TextBox();
            label6 = new Label();
            label4 = new Label();
            texttelefono = new TextBox();
            btn_guardarexpe = new Button();
            combotipodoc = new ComboBox();
            label7 = new Label();
            textcorreo = new TextBox();
            label2 = new Label();
            textdni = new TextBox();
            textname = new TextBox();
            label1 = new Label();
            label8 = new Label();
            textcodigo = new TextBox();
            SuspendLayout();
            // 
            // btn_regreso
            // 
            btn_regreso.BackColor = Color.FromArgb(192, 57, 43);
            btn_regreso.FlatAppearance.BorderSize = 0;
            btn_regreso.FlatStyle = FlatStyle.Flat;
            btn_regreso.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regreso.ForeColor = Color.Transparent;
            btn_regreso.Location = new Point(96, 541);
            btn_regreso.Name = "btn_regreso";
            btn_regreso.Size = new Size(105, 50);
            btn_regreso.TabIndex = 0;
            btn_regreso.Text = "REGRESAR";
            btn_regreso.UseVisualStyleBackColor = false;
            btn_regreso.Click += btn_regreso_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.BackColor = Color.Transparent;
            titulo.Font = new Font("Swis721 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.ForeColor = SystemColors.ActiveCaptionText;
            titulo.Location = new Point(132, 51);
            titulo.Name = "titulo";
            titulo.Size = new Size(381, 34);
            titulo.TabIndex = 4;
            titulo.Text = "👤 DATOS DEL USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(86, 343);
            label3.Name = "label3";
            label3.Size = new Size(441, 34);
            label3.TabIndex = 11;
            label3.Text = "👤 DATOS DEL DOCUMENTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 407);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 16;
            label5.Text = "Tipo de Documento:";
            // 
            // textasunto
            // 
            textasunto.Location = new Point(114, 463);
            textasunto.Name = "textasunto";
            textasunto.Size = new Size(452, 27);
            textasunto.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(38, 463);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 12;
            label6.Text = "Asunto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(296, 181);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 18;
            label4.Text = "Teléfono:";
            // 
            // texttelefono
            // 
            texttelefono.Location = new Point(384, 174);
            texttelefono.Name = "texttelefono";
            texttelefono.Size = new Size(182, 27);
            texttelefono.TabIndex = 17;
            // 
            // btn_guardarexpe
            // 
            btn_guardarexpe.BackColor = Color.FromArgb(213, 225, 239);
            btn_guardarexpe.FlatAppearance.BorderSize = 0;
            btn_guardarexpe.FlatStyle = FlatStyle.Flat;
            btn_guardarexpe.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardarexpe.Location = new Point(408, 541);
            btn_guardarexpe.Name = "btn_guardarexpe";
            btn_guardarexpe.Size = new Size(105, 50);
            btn_guardarexpe.TabIndex = 19;
            btn_guardarexpe.Text = "GUARDAR EXPEDIENTE";
            btn_guardarexpe.UseVisualStyleBackColor = false;
            btn_guardarexpe.Click += btn_guardarexpediente;
            // 
            // combotipodoc
            // 
            combotipodoc.FormattingEnabled = true;
            combotipodoc.Items.AddRange(new object[] { "DNI (Documento Nacional de Identidad)", "RUC (Registro Unico de Contribuyentes)", "Carnet de Extranjería", "Pasaporte (Docuemento de Identificación Nacional)", "Oficio (Documento oficial enviado entre instituciones)", "Solicitud (El trámite o petición formal)   " });
            combotipodoc.Location = new Point(219, 407);
            combotipodoc.Name = "combotipodoc";
            combotipodoc.RightToLeft = RightToLeft.No;
            combotipodoc.Size = new Size(347, 28);
            combotipodoc.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(35, 230);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 22;
            label7.Text = "Correo electrónico:";
            // 
            // textcorreo
            // 
            textcorreo.Location = new Point(176, 230);
            textcorreo.Name = "textcorreo";
            textcorreo.Size = new Size(390, 27);
            textcorreo.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 120);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombres:";
            // 
            // textdni
            // 
            textdni.Location = new Point(86, 174);
            textdni.Name = "textdni";
            textdni.Size = new Size(176, 27);
            textdni.TabIndex = 8;
            // 
            // textname
            // 
            textname.Location = new Point(114, 120);
            textname.Name = "textname";
            textname.Size = new Size(452, 27);
            textname.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 177);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 9;
            label1.Text = "DNI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(35, 284);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 24;
            label8.Text = "Código:";
            // 
            // textcodigo
            // 
            textcodigo.Location = new Point(114, 281);
            textcodigo.Name = "textcodigo";
            textcodigo.Size = new Size(452, 27);
            textcodigo.TabIndex = 23;
            // 
            // EXPEDIENTE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 653);
            Controls.Add(label8);
            Controls.Add(textcodigo);
            Controls.Add(label7);
            Controls.Add(textcorreo);
            Controls.Add(combotipodoc);
            Controls.Add(btn_guardarexpe);
            Controls.Add(label4);
            Controls.Add(texttelefono);
            Controls.Add(label5);
            Controls.Add(textasunto);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textdni);
            Controls.Add(textname);
            Controls.Add(titulo);
            Controls.Add(btn_regreso);
            Name = "EXPEDIENTE";
            Text = "Registro de Datos";
            Load += EXPEDIENTE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_regreso;
        private Label titulo;
        private Label label3;
        private Label label5;
        private TextBox textasunto;
        private Label label6;
        private Label label4;
        private TextBox texttelefono;
        private Button btn_guardarexpe;
        private ComboBox combotipodoc;
        private Label label7;
        private TextBox textcorreo;
        private Label label2;
        private TextBox textdni;
        private TextBox textname;
        private Label label1;
        private Label label8;
        private TextBox textcodigo;
    }
}