
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bAniadirDebate = new System.Windows.Forms.Button();
            this.bMisDebatesForo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPcsas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 221);
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
            this.panel2.Size = new System.Drawing.Size(1474, 221);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1343, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mi perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox1.ImageLocation = "E:\\Fotos\\usuario.PNG";
            this.pictureBox1.Location = new System.Drawing.Point(1324, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.pcsas;
            this.pictureBox2.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pictureBox2.Location = new System.Drawing.Point(-11, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lRolUsuario
            // 
            this.lRolUsuario.AutoSize = true;
            this.lRolUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRolUsuario.Location = new System.Drawing.Point(1118, 138);
            this.lRolUsuario.Name = "lRolUsuario";
            this.lRolUsuario.Size = new System.Drawing.Size(80, 26);
            this.lRolUsuario.TabIndex = 3;
            this.lRolUsuario.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1064, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(910, 66);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(311, 46);
            this.lNombreApellidos.TabIndex = 1;
            this.lNombreApellidos.Text = "Nombre Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(790, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hola,";
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerfil.Location = new System.Drawing.Point(1343, 170);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(88, 26);
            this.lPerfil.TabIndex = 6;
            this.lPerfil.Text = "Mi perfil";
            // 
            // pbSilueta
            // 
            this.pbSilueta.ImageLocation = "E:\\Fotos\\usuario.PNG";
            this.pbSilueta.Location = new System.Drawing.Point(1307, 9);
            this.pbSilueta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSilueta.Name = "pbSilueta";
            this.pbSilueta.Size = new System.Drawing.Size(153, 159);
            this.pbSilueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSilueta.TabIndex = 5;
            this.pbSilueta.TabStop = false;
            // 
            // pbLogoPcsas
            // 
            this.pbLogoPcsas.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pbLogoPcsas.Location = new System.Drawing.Point(23, 3);
            this.pbLogoPcsas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogoPcsas.Name = "pbLogoPcsas";
            this.pbLogoPcsas.Size = new System.Drawing.Size(244, 217);
            this.pbLogoPcsas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoPcsas.TabIndex = 4;
            this.pbLogoPcsas.TabStop = false;
            this.pbLogoPcsas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.Location = new System.Drawing.Point(1118, 138);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(80, 26);
            this.lUsuario.TabIndex = 3;
            this.lUsuario.Text = "Usuario";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(1064, 138);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(47, 26);
            this.lRol.TabIndex = 2;
            this.lRol.Text = "Rol:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(910, 66);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(311, 46);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre Apellidos";
            // 
            // lHola
            // 
            this.lHola.AutoSize = true;
            this.lHola.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHola.Location = new System.Drawing.Point(790, 66);
            this.lHola.Name = "lHola";
            this.lHola.Size = new System.Drawing.Size(108, 46);
            this.lHola.TabIndex = 0;
            this.lHola.Text = "Hola,";
            this.lHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // lForo
            // 
            this.lForo.AutoSize = true;
            this.lForo.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForo.Location = new System.Drawing.Point(654, 274);
            this.lForo.Name = "lForo";
            this.lForo.Size = new System.Drawing.Size(111, 46);
            this.lForo.TabIndex = 7;
            this.lForo.Text = "FORO";
            // 
            // lDebates
            // 
            this.lDebates.AutoSize = true;
            this.lDebates.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDebates.Location = new System.Drawing.Point(595, 370);
            this.lDebates.Name = "lDebates";
            this.lDebates.Size = new System.Drawing.Size(237, 26);
            this.lDebates.TabIndex = 8;
            this.lDebates.Text = "Debates más recientes...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 466);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(718, 294);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 483);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(193, 224);
            this.dataGridView2.TabIndex = 14;
            // 
            // bAniadirDebate
            // 
            this.bAniadirDebate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAniadirDebate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAniadirDebate.Location = new System.Drawing.Point(22, 722);
            this.bAniadirDebate.Name = "bAniadirDebate";
            this.bAniadirDebate.Size = new System.Drawing.Size(181, 63);
            this.bAniadirDebate.TabIndex = 15;
            this.bAniadirDebate.Text = "Nuevo debate";
            this.bAniadirDebate.UseVisualStyleBackColor = false;
            // 
            // bMisDebatesForo
            // 
            this.bMisDebatesForo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMisDebatesForo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMisDebatesForo.Location = new System.Drawing.Point(22, 403);
            this.bMisDebatesForo.Name = "bMisDebatesForo";
            this.bMisDebatesForo.Size = new System.Drawing.Size(181, 63);
            this.bMisDebatesForo.TabIndex = 16;
            this.bMisDebatesForo.Text = "Mis debates";
            this.bMisDebatesForo.UseVisualStyleBackColor = false;
            // 
            // PantallaPrincipalForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1469, 844);
            this.Controls.Add(this.bMisDebatesForo);
            this.Controls.Add(this.bAniadirDebate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lRolUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lNombreApellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bAniadirDebate;
        private System.Windows.Forms.Button bMisDebatesForo;
    }
}