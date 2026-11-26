namespace WinFormsApp7
{
    partial class GESTIONDATOS
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
            dataGridViewExpedientes = new DataGridView();
            btn_eliminar = new Button();
            btn_ordenar = new Button();
            titulo = new Label();
            txt_buscar = new TextBox();
            lbl_buscar = new Label();
            btn_buscar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpedientes).BeginInit();
            SuspendLayout();
            // 
            // btn_regreso
            // 
            btn_regreso.BackColor = Color.FromArgb(192, 57, 43);
            btn_regreso.FlatAppearance.BorderSize = 0;
            btn_regreso.FlatStyle = FlatStyle.Flat;
            btn_regreso.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regreso.ForeColor = SystemColors.ButtonHighlight;
            btn_regreso.Location = new Point(37, 564);
            btn_regreso.Name = "btn_regreso";
            btn_regreso.Size = new Size(105, 50);
            btn_regreso.TabIndex = 1;
            btn_regreso.Text = "REGRESAR";
            btn_regreso.UseVisualStyleBackColor = false;
            btn_regreso.Click += btn_regreso_Click;
            // 
            // dataGridViewExpedientes
            // 
            dataGridViewExpedientes.AllowUserToAddRows = false;
            dataGridViewExpedientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewExpedientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExpedientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewExpedientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpedientes.Location = new Point(37, 214);
            dataGridViewExpedientes.MultiSelect = false;
            dataGridViewExpedientes.Name = "dataGridViewExpedientes";
            dataGridViewExpedientes.ReadOnly = true;
            dataGridViewExpedientes.RowHeadersWidth = 51;
            dataGridViewExpedientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpedientes.Size = new Size(1261, 329);
            dataGridViewExpedientes.TabIndex = 5;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(213, 225, 239);
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(1202, 138);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(105, 50);
            btn_eliminar.TabIndex = 6;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_;
            // 
            // btn_ordenar
            // 
            btn_ordenar.BackColor = Color.FromArgb(213, 225, 239);
            btn_ordenar.FlatAppearance.BorderSize = 0;
            btn_ordenar.FlatStyle = FlatStyle.Flat;
            btn_ordenar.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ordenar.Location = new Point(1065, 138);
            btn_ordenar.Name = "btn_ordenar";
            btn_ordenar.Size = new Size(105, 50);
            btn_ordenar.TabIndex = 7;
            btn_ordenar.Text = "ORDENAR";
            btn_ordenar.UseVisualStyleBackColor = false;
            btn_ordenar.Click += btn_ordenar_Click;
            // 
            // titulo
            // 
            titulo.BackColor = Color.FromArgb(213, 225, 239);
            titulo.Font = new Font("Swis721 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.ForeColor = SystemColors.ActiveCaptionText;
            titulo.Location = new Point(-2, -1);
            titulo.Name = "titulo";
            titulo.Size = new Size(1354, 81);
            titulo.TabIndex = 8;
            titulo.Text = "💼 GESTIÓN DE DATOS";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(224, 150);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(343, 27);
            txt_buscar.TabIndex = 14;
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.Location = new Point(51, 153);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(167, 20);
            lbl_buscar.TabIndex = 15;
            lbl_buscar.Text = "Buscar por Codigo/DNI:";
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(213, 225, 239);
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            btn_buscar.Location = new Point(589, 138);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(112, 44);
            btn_buscar.TabIndex = 16;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(213, 225, 239);
            label1.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-2, 62);
            label1.Name = "label1";
            label1.Size = new Size(1354, 48);
            label1.TabIndex = 17;
            label1.Text = "Mesa de partes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // GESTIONDATOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1348, 636);
            Controls.Add(label1);
            Controls.Add(btn_buscar);
            Controls.Add(lbl_buscar);
            Controls.Add(txt_buscar);
            Controls.Add(titulo);
            Controls.Add(btn_ordenar);
            Controls.Add(btn_eliminar);
            Controls.Add(dataGridViewExpedientes);
            Controls.Add(btn_regreso);
            Name = "GESTIONDATOS";
            Text = "Gestión de Datos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpedientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_regreso;
        private DataGridView dataGridViewExpedientes;
        private Button btn_eliminar;
        private Button btn_ordenar;
        private Label titulo;
        private TextBox txt_buscar;
        private Label lbl_buscar;
        private Button btn_buscar;
        private Label label1;
    }
}