namespace Asignacion_Barberia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Informacion = new System.Windows.Forms.GroupBox();
            this.CancelBtt = new System.Windows.Forms.Button();
            this.SaveBtt = new System.Windows.Forms.Button();
            this.Hora = new System.Windows.Forms.ComboBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ListBarb = new System.Windows.Forms.ComboBox();
            this.LblBarbero = new System.Windows.Forms.Label();
            this.CorreoClnt = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.NumClnt = new System.Windows.Forms.TextBox();
            this.LblNumeroTel = new System.Windows.Forms.Label();
            this.NomClnt = new System.Windows.Forms.TextBox();
            this.LabelNomClnt = new System.Windows.Forms.Label();
            this.CrearCita = new System.Windows.Forms.Button();
            this.Namelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Informacion
            // 
            this.Informacion.Controls.Add(this.CancelBtt);
            this.Informacion.Controls.Add(this.SaveBtt);
            this.Informacion.Controls.Add(this.Hora);
            this.Informacion.Controls.Add(this.LblHora);
            this.Informacion.Controls.Add(this.LblFecha);
            this.Informacion.Controls.Add(this.dateTimePicker1);
            this.Informacion.Controls.Add(this.ListBarb);
            this.Informacion.Controls.Add(this.LblBarbero);
            this.Informacion.Controls.Add(this.CorreoClnt);
            this.Informacion.Controls.Add(this.LblCorreo);
            this.Informacion.Controls.Add(this.NumClnt);
            this.Informacion.Controls.Add(this.LblNumeroTel);
            this.Informacion.Controls.Add(this.NomClnt);
            this.Informacion.Controls.Add(this.LabelNomClnt);
            this.Informacion.Location = new System.Drawing.Point(279, 21);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(509, 417);
            this.Informacion.TabIndex = 1;
            this.Informacion.TabStop = false;
            this.Informacion.Text = "Informacion";
            this.Informacion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CancelBtt
            // 
            this.CancelBtt.Location = new System.Drawing.Point(426, 360);
            this.CancelBtt.Name = "CancelBtt";
            this.CancelBtt.Size = new System.Drawing.Size(68, 51);
            this.CancelBtt.TabIndex = 13;
            this.CancelBtt.Text = "CANCEL";
            this.CancelBtt.UseVisualStyleBackColor = true;
            // 
            // SaveBtt
            // 
            this.SaveBtt.Location = new System.Drawing.Point(324, 360);
            this.SaveBtt.Name = "SaveBtt";
            this.SaveBtt.Size = new System.Drawing.Size(68, 51);
            this.SaveBtt.TabIndex = 12;
            this.SaveBtt.Text = "SAVE";
            this.SaveBtt.UseVisualStyleBackColor = true;
            this.SaveBtt.Click += new System.EventHandler(this.SaveBtt_Click);
            // 
            // Hora
            // 
            this.Hora.FormattingEnabled = true;
            this.Hora.Location = new System.Drawing.Point(60, 253);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(251, 23);
            this.Hora.TabIndex = 11;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(6, 256);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(33, 15);
            this.LblHora.TabIndex = 10;
            this.LblHora.Text = "Hora";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(6, 217);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(38, 15);
            this.LblFecha.TabIndex = 9;
            this.LblFecha.Text = "Fecha";
            this.LblFecha.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // ListBarb
            // 
            this.ListBarb.FormattingEnabled = true;
            this.ListBarb.Location = new System.Drawing.Point(60, 165);
            this.ListBarb.Name = "ListBarb";
            this.ListBarb.Size = new System.Drawing.Size(251, 23);
            this.ListBarb.TabIndex = 7;
            // 
            // LblBarbero
            // 
            this.LblBarbero.AutoSize = true;
            this.LblBarbero.Location = new System.Drawing.Point(6, 168);
            this.LblBarbero.Name = "LblBarbero";
            this.LblBarbero.Size = new System.Drawing.Size(48, 15);
            this.LblBarbero.TabIndex = 6;
            this.LblBarbero.Text = "Barbero";
            this.LblBarbero.Click += new System.EventHandler(this.Barbero_Click);
            // 
            // CorreoClnt
            // 
            this.CorreoClnt.Location = new System.Drawing.Point(174, 105);
            this.CorreoClnt.Name = "CorreoClnt";
            this.CorreoClnt.Size = new System.Drawing.Size(308, 23);
            this.CorreoClnt.TabIndex = 5;
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(6, 108);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(162, 15);
            this.LblCorreo.TabIndex = 4;
            this.LblCorreo.Text = "Correo electronico del cliente";
            this.LblCorreo.Click += new System.EventHandler(this.label3_Click);
            // 
            // NumClnt
            // 
            this.NumClnt.Location = new System.Drawing.Point(120, 65);
            this.NumClnt.Name = "NumClnt";
            this.NumClnt.Size = new System.Drawing.Size(308, 23);
            this.NumClnt.TabIndex = 3;
            // 
            // LblNumeroTel
            // 
            this.LblNumeroTel.AutoSize = true;
            this.LblNumeroTel.Location = new System.Drawing.Point(6, 65);
            this.LblNumeroTel.Name = "LblNumeroTel";
            this.LblNumeroTel.Size = new System.Drawing.Size(108, 15);
            this.LblNumeroTel.TabIndex = 2;
            this.LblNumeroTel.Text = "Numero del cliente";
            this.LblNumeroTel.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomClnt
            // 
            this.NomClnt.Location = new System.Drawing.Point(120, 29);
            this.NomClnt.Name = "NomClnt";
            this.NomClnt.Size = new System.Drawing.Size(308, 23);
            this.NomClnt.TabIndex = 1;
            this.NomClnt.TextChanged += new System.EventHandler(this.NomClnt_TextChanged);
            // 
            // LabelNomClnt
            // 
            this.LabelNomClnt.AutoSize = true;
            this.LabelNomClnt.Location = new System.Drawing.Point(6, 32);
            this.LabelNomClnt.Name = "LabelNomClnt";
            this.LabelNomClnt.Size = new System.Drawing.Size(108, 15);
            this.LabelNomClnt.TabIndex = 0;
            this.LabelNomClnt.Text = "Nombre del cliente";
            // 
            // CrearCita
            // 
            this.CrearCita.Location = new System.Drawing.Point(30, 415);
            this.CrearCita.Name = "CrearCita";
            this.CrearCita.Size = new System.Drawing.Size(185, 23);
            this.CrearCita.TabIndex = 2;
            this.CrearCita.Text = "Nueva Cita";
            this.CrearCita.UseVisualStyleBackColor = true;
            this.CrearCita.Click += new System.EventHandler(this.button1_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(12, 21);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(68, 15);
            this.Namelbl.TabIndex = 3;
            this.Namelbl.Text = "BarberShop";
            this.Namelbl.Click += new System.EventHandler(this.Namelbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.CrearCita);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Informacion.ResumeLayout(false);
            this.Informacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox Informacion;
        private Label LblNumeroTel;
        private TextBox NomClnt;
        private Label LabelNomClnt;
        private TextBox NumClnt;
        private Label LblCorreo;
        private ComboBox ListBarb;
        private Label LblBarbero;
        private TextBox CorreoClnt;
        private Label LblFecha;
        private DateTimePicker dateTimePicker1;
        private ComboBox Hora;
        private Label LblHora;
        private Button CrearCita;
        private Button SaveBtt;
        private Button CancelBtt;
        private Label Namelbl;
    }
}