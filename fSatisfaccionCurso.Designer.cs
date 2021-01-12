
namespace Grupo02PCSAS
{
    partial class fSatisfaccionCurso
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lInscrito = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lNombreCurso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nSatisfaccion = new System.Windows.Forms.NumericUpDown();
            this.nLugar = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nHora = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nOrganizadores = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.tComentarios = new System.Windows.Forms.TextBox();
            this.bEnviar = new System.Windows.Forms.Button();
            this.cRepetir = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSatisfaccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOrganizadores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lNombreUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1653, 221);
            this.panel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1318, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mi perfil";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1299, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lRol
            // 
            this.lRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(759, 145);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(73, 29);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rol: ";
            // 
            // lNombreUser
            // 
            this.lNombreUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(821, 48);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(408, 52);
            this.lNombreUser.TabIndex = 3;
            this.lNombreUser.Text = "Nombre y apellidos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hola,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(112, 290);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lInscrito);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lNombreCurso);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 221);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1653, 186);
            this.panel2.TabIndex = 25;
            // 
            // lInscrito
            // 
            this.lInscrito.AutoSize = true;
            this.lInscrito.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInscrito.Location = new System.Drawing.Point(1390, 82);
            this.lInscrito.Name = "lInscrito";
            this.lInscrito.Size = new System.Drawing.Size(94, 29);
            this.lInscrito.TabIndex = 6;
            this.lInscrito.Text = "Inscrito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1282, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "ESTADO:";
            // 
            // lNombreCurso
            // 
            this.lNombreCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreCurso.AutoSize = true;
            this.lNombreCurso.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreCurso.Location = new System.Drawing.Point(493, 64);
            this.lNombreCurso.Name = "lNombreCurso";
            this.lNombreCurso.Size = new System.Drawing.Size(201, 57);
            this.lNombreCurso.TabIndex = 4;
            this.lNombreCurso.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 57);
            this.label6.TabIndex = 3;
            this.label6.Text = "CURSO:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox4.Location = new System.Drawing.Point(9, 11);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Satisfacción general";
            // 
            // nSatisfaccion
            // 
            this.nSatisfaccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSatisfaccion.Location = new System.Drawing.Point(348, 461);
            this.nSatisfaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nSatisfaccion.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nSatisfaccion.Name = "nSatisfaccion";
            this.nSatisfaccion.Size = new System.Drawing.Size(135, 37);
            this.nSatisfaccion.TabIndex = 28;
            this.nSatisfaccion.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nLugar
            // 
            this.nLugar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLugar.Location = new System.Drawing.Point(348, 549);
            this.nLugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nLugar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nLugar.Name = "nLugar";
            this.nLugar.Size = new System.Drawing.Size(135, 37);
            this.nLugar.TabIndex = 30;
            this.nLugar.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Lugar";
            // 
            // nHora
            // 
            this.nHora.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nHora.Location = new System.Drawing.Point(348, 640);
            this.nHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nHora.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nHora.Name = "nHora";
            this.nHora.Size = new System.Drawing.Size(135, 37);
            this.nHora.TabIndex = 32;
            this.nHora.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 642);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Adecuación horaria";
            // 
            // nOrganizadores
            // 
            this.nOrganizadores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOrganizadores.Location = new System.Drawing.Point(348, 731);
            this.nOrganizadores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nOrganizadores.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nOrganizadores.Name = "nOrganizadores";
            this.nOrganizadores.Size = new System.Drawing.Size(135, 37);
            this.nOrganizadores.TabIndex = 34;
            this.nOrganizadores.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(75, 734);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 29);
            this.label11.TabIndex = 33;
            this.label11.Text = "Organizadores";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(675, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 29);
            this.label10.TabIndex = 35;
            this.label10.Text = "Comentarios opcionales";
            // 
            // tComentarios
            // 
            this.tComentarios.Location = new System.Drawing.Point(681, 516);
            this.tComentarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tComentarios.Multiline = true;
            this.tComentarios.Name = "tComentarios";
            this.tComentarios.Size = new System.Drawing.Size(742, 254);
            this.tComentarios.TabIndex = 36;
            // 
            // bEnviar
            // 
            this.bEnviar.BackColor = System.Drawing.Color.White;
            this.bEnviar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviar.Location = new System.Drawing.Point(690, 881);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(125, 52);
            this.bEnviar.TabIndex = 37;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = false;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // cRepetir
            // 
            this.cRepetir.AutoSize = true;
            this.cRepetir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cRepetir.Location = new System.Drawing.Point(81, 826);
            this.cRepetir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cRepetir.Name = "cRepetir";
            this.cRepetir.Size = new System.Drawing.Size(478, 33);
            this.cRepetir.TabIndex = 38;
            this.cRepetir.Text = "¿Volverias a repetir un curso similar?";
            this.cRepetir.UseVisualStyleBackColor = true;
            // 
            // fSatisfaccionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1653, 1050);
            this.Controls.Add(this.cRepetir);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.tComentarios);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nOrganizadores);
            this.Controls.Add(this.nHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nLugar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nSatisfaccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "fSatisfaccionCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSatisfaccionCurso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fSatisfaccionCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSatisfaccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOrganizadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lInscrito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lNombreCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nSatisfaccion;
        private System.Windows.Forms.NumericUpDown nLugar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nOrganizadores;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tComentarios;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.CheckBox cRepetir;
    }
}