﻿
namespace Grupo02PCSAS
{
    partial class PantallaPrincipalForo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRolUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lNombreApellidos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lPerfil = new System.Windows.Forms.Label();
            this.pbSilueta = new System.Windows.Forms.PictureBox();
            this.pbLogoPcsas = new System.Windows.Forms.PictureBox();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lHola = new System.Windows.Forms.Label();
            this.lForo = new System.Windows.Forms.Label();
            this.lDebates = new System.Windows.Forms.Label();
            this.dgvDebatesRecientes = new System.Windows.Forms.DataGridView();
            this.dgvMisDebates = new System.Windows.Forms.DataGridView();
            this.bAniadirDebate = new System.Windows.Forms.Button();
            this.bMisDebatesForo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPcsas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebatesRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisDebates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lPerfil);
            this.panel1.Controls.Add(this.pbSilueta);
            this.panel1.Controls.Add(this.pbLogoPcsas);
            this.panel1.Controls.Add(this.lUsuario);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Controls.Add(this.lHola);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1658, 276);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lRolUsuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lNombreApellidos);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1658, 276);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1265, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mi perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "E:\\Fotos\\usuario.PNG";
            this.pictureBox1.Location = new System.Drawing.Point(1244, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pictureBox2.Location = new System.Drawing.Point(-12, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lRolUsuario
            // 
            this.lRolUsuario.AutoSize = true;
            this.lRolUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRolUsuario.Location = new System.Drawing.Point(1012, 163);
            this.lRolUsuario.Name = "lRolUsuario";
            this.lRolUsuario.Size = new System.Drawing.Size(94, 29);
            this.lRolUsuario.TabIndex = 3;
            this.lRolUsuario.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(951, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(778, 73);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(371, 55);
            this.lNombreApellidos.TabIndex = 1;
            this.lNombreApellidos.Text = "Nombre Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 55);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hola,";
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerfil.Location = new System.Drawing.Point(1511, 212);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(102, 29);
            this.lPerfil.TabIndex = 6;
            this.lPerfil.Text = "Mi perfil";
            // 
            // pbSilueta
            // 
            this.pbSilueta.ImageLocation = "E:\\Fotos\\usuario.PNG";
            this.pbSilueta.Location = new System.Drawing.Point(1470, 11);
            this.pbSilueta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSilueta.Name = "pbSilueta";
            this.pbSilueta.Size = new System.Drawing.Size(172, 199);
            this.pbSilueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSilueta.TabIndex = 5;
            this.pbSilueta.TabStop = false;
            // 
            // pbLogoPcsas
            // 
            this.pbLogoPcsas.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pbLogoPcsas.Location = new System.Drawing.Point(26, 4);
            this.pbLogoPcsas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogoPcsas.Name = "pbLogoPcsas";
            this.pbLogoPcsas.Size = new System.Drawing.Size(274, 271);
            this.pbLogoPcsas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoPcsas.TabIndex = 4;
            this.pbLogoPcsas.TabStop = false;
            this.pbLogoPcsas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.Location = new System.Drawing.Point(1258, 172);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(94, 29);
            this.lUsuario.TabIndex = 3;
            this.lUsuario.Text = "Usuario";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(1197, 172);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(55, 29);
            this.lRol.TabIndex = 2;
            this.lRol.Text = "Rol:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(1024, 82);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(371, 55);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre Apellidos";
            // 
            // lHola
            // 
            this.lHola.AutoSize = true;
            this.lHola.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHola.Location = new System.Drawing.Point(889, 82);
            this.lHola.Name = "lHola";
            this.lHola.Size = new System.Drawing.Size(129, 55);
            this.lHola.TabIndex = 0;
            this.lHola.Text = "Hola,";
            this.lHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // lForo
            // 
            this.lForo.AutoSize = true;
            this.lForo.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForo.Location = new System.Drawing.Point(787, 314);
            this.lForo.Name = "lForo";
            this.lForo.Size = new System.Drawing.Size(133, 55);
            this.lForo.TabIndex = 7;
            this.lForo.Text = "FORO";
            // 
            // lDebates
            // 
            this.lDebates.AutoSize = true;
            this.lDebates.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDebates.Location = new System.Drawing.Point(720, 434);
            this.lDebates.Name = "lDebates";
            this.lDebates.Size = new System.Drawing.Size(284, 29);
            this.lDebates.TabIndex = 8;
            this.lDebates.Text = "Debates más recientes...";
            // 
            // dgvDebatesRecientes
            // 
            this.dgvDebatesRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebatesRecientes.Location = new System.Drawing.Point(453, 560);
            this.dgvDebatesRecientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDebatesRecientes.Name = "dgvDebatesRecientes";
            this.dgvDebatesRecientes.RowHeadersWidth = 62;
            this.dgvDebatesRecientes.RowTemplate.Height = 28;
            this.dgvDebatesRecientes.Size = new System.Drawing.Size(808, 368);
            this.dgvDebatesRecientes.TabIndex = 9;
            // 
            // dgvMisDebates
            // 
            this.dgvMisDebates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisDebates.Location = new System.Drawing.Point(16, 604);
            this.dgvMisDebates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisDebates.Name = "dgvMisDebates";
            this.dgvMisDebates.RowHeadersWidth = 62;
            this.dgvMisDebates.RowTemplate.Height = 28;
            this.dgvMisDebates.Size = new System.Drawing.Size(217, 280);
            this.dgvMisDebates.TabIndex = 14;
            this.dgvMisDebates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // bAniadirDebate
            // 
            this.bAniadirDebate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAniadirDebate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAniadirDebate.Location = new System.Drawing.Point(25, 902);
            this.bAniadirDebate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAniadirDebate.Name = "bAniadirDebate";
            this.bAniadirDebate.Size = new System.Drawing.Size(204, 79);
            this.bAniadirDebate.TabIndex = 15;
            this.bAniadirDebate.Text = "Nuevo debate";
            this.bAniadirDebate.UseVisualStyleBackColor = false;
            this.bAniadirDebate.Click += new System.EventHandler(this.bAniadirDebate_Click);
            // 
            // bMisDebatesForo
            // 
            this.bMisDebatesForo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMisDebatesForo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMisDebatesForo.Location = new System.Drawing.Point(25, 504);
            this.bMisDebatesForo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bMisDebatesForo.Name = "bMisDebatesForo";
            this.bMisDebatesForo.Size = new System.Drawing.Size(204, 79);
            this.bMisDebatesForo.TabIndex = 16;
            this.bMisDebatesForo.Text = "Mis debates";
            this.bMisDebatesForo.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(114, 337);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.button1_Click);
            // 
            // PantallaPrincipalForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1465, 1024);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bMisDebatesForo);
            this.Controls.Add(this.bAniadirDebate);
            this.Controls.Add(this.dgvMisDebates);
            this.Controls.Add(this.dgvDebatesRecientes);
            this.Controls.Add(this.lDebates);
            this.Controls.Add(this.lForo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrincipalForo";
            this.Text = "PantallaBorrarCurso";
            this.Load += new System.EventHandler(this.PantallaBorrarCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPcsas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebatesRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisDebates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lHola;
        private System.Windows.Forms.PictureBox pbLogoPcsas;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lPerfil;
        private System.Windows.Forms.PictureBox pbSilueta;
        private System.Windows.Forms.Label lForo;
        private System.Windows.Forms.Label lDebates;
        private System.Windows.Forms.DataGridView dgvDebatesRecientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRolUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lNombreApellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMisDebates;
        private System.Windows.Forms.Button bAniadirDebate;
        private System.Windows.Forms.Button bMisDebatesForo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}