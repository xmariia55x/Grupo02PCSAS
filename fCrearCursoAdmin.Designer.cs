
namespace Grupo02PCSAS
{
    partial class fCrearCursoAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.tNombreCurso = new System.Windows.Forms.TextBox();
            this.tDescripcionCurso = new System.Windows.Forms.TextBox();
            this.tAforoCurso = new System.Windows.Forms.TextBox();
            this.tLugarCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rOnline = new System.Windows.Forms.RadioButton();
            this.rPresencial = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.bAniadirArchivosCurso = new System.Windows.Forms.Button();
            this.bGuardarCambiosCurso = new System.Windows.Forms.Button();
            this.dFechaIniCurso = new System.Windows.Forms.DateTimePicker();
            this.dFechaFinCurso = new System.Windows.Forms.DateTimePicker();
            this.dHoraIniCurso = new System.Windows.Forms.DateTimePicker();
            this.dHoraFinCurso = new System.Windows.Forms.DateTimePicker();
            this.listProfesor = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crear Curso";
            // 
            // tNombreCurso
            // 
            this.tNombreCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreCurso.Location = new System.Drawing.Point(238, 448);
            this.tNombreCurso.MaxLength = 50;
            this.tNombreCurso.Name = "tNombreCurso";
            this.tNombreCurso.Size = new System.Drawing.Size(218, 31);
            this.tNombreCurso.TabIndex = 3;
            // 
            // tDescripcionCurso
            // 
            this.tDescripcionCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcionCurso.Location = new System.Drawing.Point(238, 549);
            this.tDescripcionCurso.MaxLength = 300;
            this.tDescripcionCurso.Multiline = true;
            this.tDescripcionCurso.Name = "tDescripcionCurso";
            this.tDescripcionCurso.Size = new System.Drawing.Size(218, 151);
            this.tDescripcionCurso.TabIndex = 4;
            // 
            // tAforoCurso
            // 
            this.tAforoCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAforoCurso.Location = new System.Drawing.Point(1076, 646);
            this.tAforoCurso.MaxLength = 8;
            this.tAforoCurso.Name = "tAforoCurso";
            this.tAforoCurso.Size = new System.Drawing.Size(196, 31);
            this.tAforoCurso.TabIndex = 5;
            // 
            // tLugarCurso
            // 
            this.tLugarCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLugarCurso.Location = new System.Drawing.Point(657, 646);
            this.tLugarCurso.MaxLength = 50;
            this.tLugarCurso.Multiline = true;
            this.tLugarCurso.Name = "tLugarCurso";
            this.tLugarCurso.Size = new System.Drawing.Size(218, 54);
            this.tLugarCurso.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Breve descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha de finalización";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lugar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1071, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hora de inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1071, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hora de finalización";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1071, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "Aforo";
            // 
            // rOnline
            // 
            this.rOnline.AutoSize = true;
            this.rOnline.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rOnline.Location = new System.Drawing.Point(657, 714);
            this.rOnline.Name = "rOnline";
            this.rOnline.Size = new System.Drawing.Size(91, 30);
            this.rOnline.TabIndex = 21;
            this.rOnline.TabStop = true;
            this.rOnline.Text = "Online";
            this.rOnline.UseVisualStyleBackColor = true;
            // 
            // rPresencial
            // 
            this.rPresencial.AutoSize = true;
            this.rPresencial.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rPresencial.Location = new System.Drawing.Point(797, 714);
            this.rPresencial.Name = "rPresencial";
            this.rPresencial.Size = new System.Drawing.Size(125, 30);
            this.rPresencial.TabIndex = 22;
            this.rPresencial.TabStop = true;
            this.rPresencial.Text = "Presencial";
            this.rPresencial.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Profesor";
            // 
            // bAniadirArchivosCurso
            // 
            this.bAniadirArchivosCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAniadirArchivosCurso.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAniadirArchivosCurso.Location = new System.Drawing.Point(238, 727);
            this.bAniadirArchivosCurso.Name = "bAniadirArchivosCurso";
            this.bAniadirArchivosCurso.Size = new System.Drawing.Size(132, 79);
            this.bAniadirArchivosCurso.TabIndex = 25;
            this.bAniadirArchivosCurso.Text = "Añadir archivos";
            this.bAniadirArchivosCurso.UseVisualStyleBackColor = false;
            // 
            // bGuardarCambiosCurso
            // 
            this.bGuardarCambiosCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGuardarCambiosCurso.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardarCambiosCurso.Location = new System.Drawing.Point(677, 762);
            this.bGuardarCambiosCurso.Name = "bGuardarCambiosCurso";
            this.bGuardarCambiosCurso.Size = new System.Drawing.Size(181, 63);
            this.bGuardarCambiosCurso.TabIndex = 26;
            this.bGuardarCambiosCurso.Text = "Guardar cambios";
            this.bGuardarCambiosCurso.UseVisualStyleBackColor = false;
            this.bGuardarCambiosCurso.Click += new System.EventHandler(this.bGuardarCambiosCurso_Click);
            // 
            // dFechaIniCurso
            // 
            this.dFechaIniCurso.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFechaIniCurso.CustomFormat = "dd/MM/yyyy";
            this.dFechaIniCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFechaIniCurso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dFechaIniCurso.Location = new System.Drawing.Point(657, 448);
            this.dFechaIniCurso.Name = "dFechaIniCurso";
            this.dFechaIniCurso.Size = new System.Drawing.Size(218, 31);
            this.dFechaIniCurso.TabIndex = 28;
            // 
            // dFechaFinCurso
            // 
            this.dFechaFinCurso.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFechaFinCurso.CustomFormat = "dd/MM/yyyy";
            this.dFechaFinCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFechaFinCurso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dFechaFinCurso.Location = new System.Drawing.Point(657, 549);
            this.dFechaFinCurso.Name = "dFechaFinCurso";
            this.dFechaFinCurso.Size = new System.Drawing.Size(218, 31);
            this.dFechaFinCurso.TabIndex = 29;
            // 
            // dHoraIniCurso
            // 
            this.dHoraIniCurso.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dHoraIniCurso.CustomFormat = "HH:mm";
            this.dHoraIniCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dHoraIniCurso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dHoraIniCurso.Location = new System.Drawing.Point(1076, 448);
            this.dHoraIniCurso.Name = "dHoraIniCurso";
            this.dHoraIniCurso.Size = new System.Drawing.Size(196, 31);
            this.dHoraIniCurso.TabIndex = 30;
            // 
            // dHoraFinCurso
            // 
            this.dHoraFinCurso.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dHoraFinCurso.CustomFormat = "HH:mm";
            this.dHoraFinCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dHoraFinCurso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dHoraFinCurso.Location = new System.Drawing.Point(1076, 549);
            this.dHoraFinCurso.Name = "dHoraFinCurso";
            this.dHoraFinCurso.Size = new System.Drawing.Size(196, 31);
            this.dHoraFinCurso.TabIndex = 31;
            // 
            // listProfesor
            // 
            this.listProfesor.FormattingEnabled = true;
            this.listProfesor.ItemHeight = 16;
            this.listProfesor.Location = new System.Drawing.Point(0, 41);
            this.listProfesor.Name = "listProfesor";
            this.listProfesor.Size = new System.Drawing.Size(196, 52);
            this.listProfesor.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.listProfesor);
            this.panel1.Location = new System.Drawing.Point(1076, 714);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(238, 193);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox1.Location = new System.Drawing.Point(625, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // fCrearCursoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1469, 844);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dHoraFinCurso);
            this.Controls.Add(this.dHoraIniCurso);
            this.Controls.Add(this.dFechaFinCurso);
            this.Controls.Add(this.dFechaIniCurso);
            this.Controls.Add(this.bGuardarCambiosCurso);
            this.Controls.Add(this.bAniadirArchivosCurso);
            this.Controls.Add(this.rPresencial);
            this.Controls.Add(this.rOnline);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tLugarCurso);
            this.Controls.Add(this.tAforoCurso);
            this.Controls.Add(this.tDescripcionCurso);
            this.Controls.Add(this.tNombreCurso);
            this.Controls.Add(this.label1);
            this.Name = "fCrearCursoAdmin";
            this.Text = "fCrearCursoAdmin";
            this.Load += new System.EventHandler(this.fCrearCursoAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNombreCurso;
        private System.Windows.Forms.TextBox tDescripcionCurso;
        private System.Windows.Forms.TextBox tAforoCurso;
        private System.Windows.Forms.TextBox tLugarCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rOnline;
        private System.Windows.Forms.RadioButton rPresencial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bAniadirArchivosCurso;
        private System.Windows.Forms.Button bGuardarCambiosCurso;
        private System.Windows.Forms.DateTimePicker dFechaIniCurso;
        private System.Windows.Forms.DateTimePicker dFechaFinCurso;
        private System.Windows.Forms.DateTimePicker dHoraIniCurso;
        private System.Windows.Forms.DateTimePicker dHoraFinCurso;
        private System.Windows.Forms.ListBox listProfesor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}