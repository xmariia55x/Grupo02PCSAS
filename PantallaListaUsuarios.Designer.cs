﻿
namespace formsprueba
{
    partial class PantallaListaUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lMiPerfil = new System.Windows.Forms.Label();
            this.lProfesor = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lHola = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lCurso = new System.Windows.Forms.Label();
            this.lNombreCurso = new System.Windows.Forms.Label();
            this.lNombreProfesorCurso = new System.Windows.Forms.Label();
            this.lProfesorCurso = new System.Windows.Forms.Label();
            this.lListaUsuarios = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lMiPerfil);
            this.panel1.Controls.Add(this.lProfesor);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Controls.Add(this.lHola);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-8, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 287);
            this.panel1.TabIndex = 0;
            // 
            // lMiPerfil
            // 
            this.lMiPerfil.AutoSize = true;
            this.lMiPerfil.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiPerfil.Location = new System.Drawing.Point(1316, 222);
            this.lMiPerfil.Name = "lMiPerfil";
            this.lMiPerfil.Size = new System.Drawing.Size(102, 29);
            this.lMiPerfil.TabIndex = 6;
            this.lMiPerfil.Text = "Mi perfil";
            // 
            // lProfesor
            // 
            this.lProfesor.AutoSize = true;
            this.lProfesor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProfesor.Location = new System.Drawing.Point(1109, 181);
            this.lProfesor.Name = "lProfesor";
            this.lProfesor.Size = new System.Drawing.Size(101, 29);
            this.lProfesor.TabIndex = 5;
            this.lProfesor.Text = "Profesor";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(1048, 181);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(55, 29);
            this.lRol.TabIndex = 4;
            this.lRol.Text = "Rol:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(839, 110);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(371, 55);
            this.lNombre.TabIndex = 3;
            this.lNombre.Text = "Nombre Apellidos";
            // 
            // lHola
            // 
            this.lHola.AutoSize = true;
            this.lHola.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHola.Location = new System.Drawing.Point(715, 110);
            this.lHola.Name = "lHola";
            this.lHola.Size = new System.Drawing.Size(129, 55);
            this.lHola.TabIndex = 2;
            this.lHola.Text = "Hola,";
            this.lHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "E:\\Fotos\\usuario.PNG";
            this.pictureBox2.Location = new System.Drawing.Point(1280, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lCurso
            // 
            this.lCurso.AutoSize = true;
            this.lCurso.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurso.Location = new System.Drawing.Point(585, 343);
            this.lCurso.Name = "lCurso";
            this.lCurso.Size = new System.Drawing.Size(149, 55);
            this.lCurso.TabIndex = 7;
            this.lCurso.Text = "Curso:";
            this.lCurso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lNombreCurso
            // 
            this.lNombreCurso.AutoSize = true;
            this.lNombreCurso.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreCurso.Location = new System.Drawing.Point(731, 343);
            this.lNombreCurso.Name = "lNombreCurso";
            this.lNombreCurso.Size = new System.Drawing.Size(179, 55);
            this.lNombreCurso.TabIndex = 7;
            this.lNombreCurso.Text = "Nombre";
            this.lNombreCurso.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lNombreProfesorCurso
            // 
            this.lNombreProfesorCurso.AutoSize = true;
            this.lNombreProfesorCurso.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreProfesorCurso.Location = new System.Drawing.Point(735, 433);
            this.lNombreProfesorCurso.Name = "lNombreProfesorCurso";
            this.lNombreProfesorCurso.Size = new System.Drawing.Size(113, 36);
            this.lNombreProfesorCurso.TabIndex = 8;
            this.lNombreProfesorCurso.Text = "Nombre";
            // 
            // lProfesorCurso
            // 
            this.lProfesorCurso.AutoSize = true;
            this.lProfesorCurso.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProfesorCurso.Location = new System.Drawing.Point(601, 433);
            this.lProfesorCurso.Name = "lProfesorCurso";
            this.lProfesorCurso.Size = new System.Drawing.Size(128, 36);
            this.lProfesorCurso.TabIndex = 9;
            this.lProfesorCurso.Text = "Profesor:";
            // 
            // lListaUsuarios
            // 
            this.lListaUsuarios.AutoSize = true;
            this.lListaUsuarios.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lListaUsuarios.Location = new System.Drawing.Point(664, 510);
            this.lListaUsuarios.Name = "lListaUsuarios";
            this.lListaUsuarios.Size = new System.Drawing.Size(186, 36);
            this.lListaUsuarios.TabIndex = 10;
            this.lListaUsuarios.Text = "Lista Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(31, 574);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(1401, 298);
            this.dgvUsuarios.TabIndex = 11;
            // 
            // PantallaListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1465, 1024);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lListaUsuarios);
            this.Controls.Add(this.lNombreProfesorCurso);
            this.Controls.Add(this.lProfesorCurso);
            this.Controls.Add(this.lNombreCurso);
            this.Controls.Add(this.lCurso);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaListaUsuarios";
            this.Text = "PantallaListaUSuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lProfesor;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lHola;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lMiPerfil;
        private System.Windows.Forms.Label lCurso;
        private System.Windows.Forms.Label lNombreCurso;
        private System.Windows.Forms.Label lNombreProfesorCurso;
        private System.Windows.Forms.Label lProfesorCurso;
        private System.Windows.Forms.Label lListaUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}
