
namespace Grupo02PCSAS
{
    partial class fPantallaPrincipalAlumno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lMiPerfil = new System.Windows.Forms.Label();
            this.lAlumno = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lNombreApellidos = new System.Windows.Forms.Label();
            this.lHola = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lNuevosCursos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNuevosCursos = new System.Windows.Forms.DataGridView();
            this.dgvNuevasActividades = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvMisActividades = new System.Windows.Forms.DataGridView();
            this.dgvMisCursos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevosCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevasActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lMiPerfil);
            this.panel1.Controls.Add(this.lAlumno);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.lNombreApellidos);
            this.panel1.Controls.Add(this.lHola);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 220);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lMiPerfil
            // 
            this.lMiPerfil.AutoSize = true;
            this.lMiPerfil.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiPerfil.Location = new System.Drawing.Point(1156, 170);
            this.lMiPerfil.Name = "lMiPerfil";
            this.lMiPerfil.Size = new System.Drawing.Size(87, 26);
            this.lMiPerfil.TabIndex = 6;
            this.lMiPerfil.Text = "Mi Perfil";
            // 
            // lAlumno
            // 
            this.lAlumno.AutoSize = true;
            this.lAlumno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlumno.Location = new System.Drawing.Point(845, 161);
            this.lAlumno.Name = "lAlumno";
            this.lAlumno.Size = new System.Drawing.Size(80, 26);
            this.lAlumno.TabIndex = 5;
            this.lAlumno.Text = "Alumno";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(791, 161);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(47, 26);
            this.lRol.TabIndex = 4;
            this.lRol.Text = "Rol:";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(653, 96);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(311, 46);
            this.lNombreApellidos.TabIndex = 3;
            this.lNombreApellidos.Text = "Nombre Apellidos";
            // 
            // lHola
            // 
            this.lHola.AutoSize = true;
            this.lHola.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHola.Location = new System.Drawing.Point(533, 96);
            this.lHola.Name = "lHola";
            this.lHola.Size = new System.Drawing.Size(108, 46);
            this.lHola.TabIndex = 2;
            this.lHola.Text = "Hola,";
            this.lHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(1121, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.pcsas;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(-11, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lNuevosCursos
            // 
            this.lNuevosCursos.AutoSize = true;
            this.lNuevosCursos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNuevosCursos.Location = new System.Drawing.Point(524, 267);
            this.lNuevosCursos.Name = "lNuevosCursos";
            this.lNuevosCursos.Size = new System.Drawing.Size(139, 26);
            this.lNuevosCursos.TabIndex = 7;
            this.lNuevosCursos.Text = "Nuevos cursos";
            this.lNuevosCursos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nuevas actividades";
            // 
            // dgvNuevosCursos
            // 
            this.dgvNuevosCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevosCursos.Location = new System.Drawing.Point(463, 304);
            this.dgvNuevosCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNuevosCursos.Name = "dgvNuevosCursos";
            this.dgvNuevosCursos.RowHeadersWidth = 62;
            this.dgvNuevosCursos.RowTemplate.Height = 28;
            this.dgvNuevosCursos.Size = new System.Drawing.Size(740, 165);
            this.dgvNuevosCursos.TabIndex = 9;
            // 
            // dgvNuevasActividades
            // 
            this.dgvNuevasActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevasActividades.Location = new System.Drawing.Point(463, 548);
            this.dgvNuevasActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNuevasActividades.Name = "dgvNuevasActividades";
            this.dgvNuevasActividades.RowHeadersWidth = 62;
            this.dgvNuevasActividades.RowTemplate.Height = 28;
            this.dgvNuevasActividades.Size = new System.Drawing.Size(740, 165);
            this.dgvNuevasActividades.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 730);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Acceder al foro";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 291);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "     Mis actividades     ▼";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(11, 515);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 52);
            this.button3.TabIndex = 13;
            this.button3.Text = "           Mis cursos        ▼";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvMisActividades
            // 
            this.dgvMisActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisActividades.Location = new System.Drawing.Point(11, 346);
            this.dgvMisActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisActividades.Name = "dgvMisActividades";
            this.dgvMisActividades.RowHeadersWidth = 62;
            this.dgvMisActividades.RowTemplate.Height = 28;
            this.dgvMisActividades.Size = new System.Drawing.Size(277, 165);
            this.dgvMisActividades.TabIndex = 14;
            // 
            // dgvMisCursos
            // 
            this.dgvMisCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisCursos.Location = new System.Drawing.Point(11, 561);
            this.dgvMisCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisCursos.Name = "dgvMisCursos";
            this.dgvMisCursos.RowHeadersWidth = 62;
            this.dgvMisCursos.RowTemplate.Height = 28;
            this.dgvMisCursos.Size = new System.Drawing.Size(277, 165);
            this.dgvMisCursos.TabIndex = 15;
            // 
            // fPantallaPrincipalAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1302, 819);
            this.Controls.Add(this.dgvMisCursos);
            this.Controls.Add(this.dgvMisActividades);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvNuevasActividades);
            this.Controls.Add(this.dgvNuevosCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNuevosCursos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fPantallaPrincipalAlumno";
            this.Text = "fPantallaPrincipalAlumno";
            this.Load += new System.EventHandler(this.fPantallaPrincipalAlumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevosCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevasActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lHola;
        private System.Windows.Forms.Label lMiPerfil;
        private System.Windows.Forms.Label lAlumno;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lNombreApellidos;
        private System.Windows.Forms.Label lNuevosCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNuevosCursos;
        private System.Windows.Forms.DataGridView dgvNuevasActividades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvMisActividades;
        private System.Windows.Forms.DataGridView dgvMisCursos;
    }
}