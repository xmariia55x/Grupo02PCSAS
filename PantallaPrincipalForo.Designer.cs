
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
            this.lHola = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.pbLogoPcsas = new System.Windows.Forms.PictureBox();
            this.pbSilueta = new System.Windows.Forms.PictureBox();
            this.lPerfil = new System.Windows.Forms.Label();
            this.lForo = new System.Windows.Forms.Label();
            this.lDebates = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lMisDebates = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lNuevoDebate = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPcsas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1658, 276);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lHola
            // 
            this.lHola.AutoSize = true;
            this.lHola.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHola.Location = new System.Drawing.Point(889, 83);
            this.lHola.Name = "lHola";
            this.lHola.Size = new System.Drawing.Size(129, 55);
            this.lHola.TabIndex = 0;
            this.lHola.Text = "Hola,";
            this.lHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(1024, 83);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(371, 55);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre Apellidos";
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
            // pbLogoPcsas
            // 
            this.pbLogoPcsas.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pbLogoPcsas.Location = new System.Drawing.Point(26, 4);
            this.pbLogoPcsas.Name = "pbLogoPcsas";
            this.pbLogoPcsas.Size = new System.Drawing.Size(275, 271);
            this.pbLogoPcsas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoPcsas.TabIndex = 4;
            this.pbLogoPcsas.TabStop = false;
            this.pbLogoPcsas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbSilueta
            // 
            this.pbSilueta.ImageLocation = "E:\\Fotos\\usuario.PNG";
            this.pbSilueta.Location = new System.Drawing.Point(1470, 11);
            this.pbSilueta.Name = "pbSilueta";
            this.pbSilueta.Size = new System.Drawing.Size(172, 199);
            this.pbSilueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSilueta.TabIndex = 5;
            this.pbSilueta.TabStop = false;
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerfil.Location = new System.Drawing.Point(1511, 213);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(102, 29);
            this.lPerfil.TabIndex = 6;
            this.lPerfil.Text = "Mi perfil";
            // 
            // lForo
            // 
            this.lForo.AutoSize = true;
            this.lForo.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForo.Location = new System.Drawing.Point(736, 342);
            this.lForo.Name = "lForo";
            this.lForo.Size = new System.Drawing.Size(133, 55);
            this.lForo.TabIndex = 7;
            this.lForo.Text = "FORO";
            // 
            // lDebates
            // 
            this.lDebates.AutoSize = true;
            this.lDebates.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDebates.Location = new System.Drawing.Point(669, 463);
            this.lDebates.Name = "lDebates";
            this.lDebates.Size = new System.Drawing.Size(284, 29);
            this.lDebates.TabIndex = 8;
            this.lDebates.Text = "Debates más recientes...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 582);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(808, 367);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1658, 276);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1511, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mi perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "E:\\Fotos\\usuario.PNG";
            this.pictureBox1.Location = new System.Drawing.Point(1470, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pictureBox2.Location = new System.Drawing.Point(26, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1258, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1197, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1024, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 55);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(889, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 55);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hola,";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lMisDebates);
            this.panel3.Location = new System.Drawing.Point(12, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 38);
            this.panel3.TabIndex = 10;
            // 
            // lMisDebates
            // 
            this.lMisDebates.AutoSize = true;
            this.lMisDebates.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMisDebates.Location = new System.Drawing.Point(36, 7);
            this.lMisDebates.Name = "lMisDebates";
            this.lMisDebates.Size = new System.Drawing.Size(141, 29);
            this.lMisDebates.TabIndex = 0;
            this.lMisDebates.Text = "Mis Debates";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lNuevoDebate);
            this.panel7.Location = new System.Drawing.Point(12, 890);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(221, 38);
            this.panel7.TabIndex = 13;
            // 
            // lNuevoDebate
            // 
            this.lNuevoDebate.AutoSize = true;
            this.lNuevoDebate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNuevoDebate.Location = new System.Drawing.Point(36, 7);
            this.lNuevoDebate.Name = "lNuevoDebate";
            this.lNuevoDebate.Size = new System.Drawing.Size(163, 29);
            this.lNuevoDebate.TabIndex = 0;
            this.lNuevoDebate.Text = "Nuevo Debate";
            this.lNuevoDebate.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 604);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(217, 280);
            this.dataGridView2.TabIndex = 14;
            // 
            // PantallaPrincipalForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1653, 1291);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lDebates);
            this.Controls.Add(this.lForo);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaPrincipalForo";
            this.Text = "PantallaBorrarCurso";
            this.Load += new System.EventHandler(this.PantallaBorrarCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPcsas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lMisDebates;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lNuevoDebate;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}