﻿
namespace Grupo02PCSAS
{
    partial class fVerValoraciones
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvValoracionCursos = new System.Windows.Forms.DataGridView();
            this.dgvValoracionesActividad = new System.Windows.Forms.DataGridView();
            this.lCurso = new System.Windows.Forms.Label();
            this.lActividad = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValoracionCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValoracionesActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lRol);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lNombreUser);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 177);
            this.panel2.TabIndex = 77;
            this.panel2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1320, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 26);
            this.label13.TabIndex = 7;
            this.label13.Text = "Mi perfil";
            this.label13.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1303, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // lRol
            // 
            this.lRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(633, 116);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(63, 26);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(574, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 26);
            this.label14.TabIndex = 4;
            this.label14.Text = "Rol: ";
            // 
            // lNombreUser
            // 
            this.lNombreUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(688, 38);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(346, 44);
            this.lNombreUser.TabIndex = 3;
            this.lNombreUser.Text = "Nombre y apellidos";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(570, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 49);
            this.label15.TabIndex = 2;
            this.label15.Text = "Hola,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvValoracionCursos
            // 
            this.dgvValoracionCursos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvValoracionCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValoracionCursos.Location = new System.Drawing.Point(71, 330);
            this.dgvValoracionCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvValoracionCursos.Name = "dgvValoracionCursos";
            this.dgvValoracionCursos.RowHeadersWidth = 62;
            this.dgvValoracionCursos.RowTemplate.Height = 28;
            this.dgvValoracionCursos.Size = new System.Drawing.Size(1301, 290);
            this.dgvValoracionCursos.TabIndex = 78;
            // 
            // dgvValoracionesActividad
            // 
            this.dgvValoracionesActividad.AllowUserToAddRows = false;
            this.dgvValoracionesActividad.AllowUserToDeleteRows = false;
            this.dgvValoracionesActividad.AllowUserToOrderColumns = true;
            this.dgvValoracionesActividad.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvValoracionesActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValoracionesActividad.Location = new System.Drawing.Point(71, 330);
            this.dgvValoracionesActividad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvValoracionesActividad.MultiSelect = false;
            this.dgvValoracionesActividad.Name = "dgvValoracionesActividad";
            this.dgvValoracionesActividad.ReadOnly = true;
            this.dgvValoracionesActividad.RowHeadersWidth = 62;
            this.dgvValoracionesActividad.RowTemplate.Height = 28;
            this.dgvValoracionesActividad.Size = new System.Drawing.Size(1301, 290);
            this.dgvValoracionesActividad.TabIndex = 79;
            // 
            // lCurso
            // 
            this.lCurso.AutoSize = true;
            this.lCurso.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurso.Location = new System.Drawing.Point(578, 237);
            this.lCurso.Name = "lCurso";
            this.lCurso.Size = new System.Drawing.Size(297, 29);
            this.lCurso.TabIndex = 80;
            this.lCurso.Text = "VALORACIONES DEL CURSO";
            // 
            // lActividad
            // 
            this.lActividad.AutoSize = true;
            this.lActividad.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lActividad.Location = new System.Drawing.Point(542, 237);
            this.lActividad.Name = "lActividad";
            this.lActividad.Size = new System.Drawing.Size(366, 29);
            this.lActividad.TabIndex = 81;
            this.lActividad.Text = "VALORACIONES DE LA  ACTIVIDAD";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(31, 197);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // fVerValoraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1428, 814);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lActividad);
            this.Controls.Add(this.lCurso);
            this.Controls.Add(this.dgvValoracionesActividad);
            this.Controls.Add(this.dgvValoracionCursos);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fVerValoraciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver valoraciones de una actividad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fVerValoraciones_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValoracionCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValoracionesActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvValoracionCursos;
        private System.Windows.Forms.DataGridView dgvValoracionesActividad;
        private System.Windows.Forms.Label lCurso;
        private System.Windows.Forms.Label lActividad;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}