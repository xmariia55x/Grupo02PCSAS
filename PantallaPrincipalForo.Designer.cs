
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
            this.lForo = new System.Windows.Forms.Label();
            this.lDebates = new System.Windows.Forms.Label();
            this.dgvDebatesRecientes = new System.Windows.Forms.DataGridView();
            this.dgvMisDebates = new System.Windows.Forms.DataGridView();
            this.bAniadirDebate = new System.Windows.Forms.Button();
            this.bMisDebatesForo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombreApellidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebatesRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisDebates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lForo
            // 
            this.lForo.AutoSize = true;
            this.lForo.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForo.Location = new System.Drawing.Point(700, 251);
            this.lForo.Name = "lForo";
            this.lForo.Size = new System.Drawing.Size(111, 46);
            this.lForo.TabIndex = 7;
            this.lForo.Text = "FORO";
            // 
            // lDebates
            // 
            this.lDebates.AutoSize = true;
            this.lDebates.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDebates.Location = new System.Drawing.Point(640, 347);
            this.lDebates.Name = "lDebates";
            this.lDebates.Size = new System.Drawing.Size(237, 26);
            this.lDebates.TabIndex = 8;
            this.lDebates.Text = "Debates más recientes...";
            // 
            // dgvDebatesRecientes
            // 
            this.dgvDebatesRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebatesRecientes.Location = new System.Drawing.Point(403, 448);
            this.dgvDebatesRecientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDebatesRecientes.Name = "dgvDebatesRecientes";
            this.dgvDebatesRecientes.RowHeadersWidth = 62;
            this.dgvDebatesRecientes.RowTemplate.Height = 28;
            this.dgvDebatesRecientes.Size = new System.Drawing.Size(718, 294);
            this.dgvDebatesRecientes.TabIndex = 9;
            // 
            // dgvMisDebates
            // 
            this.dgvMisDebates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisDebates.Location = new System.Drawing.Point(14, 483);
            this.dgvMisDebates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisDebates.Name = "dgvMisDebates";
            this.dgvMisDebates.RowHeadersWidth = 62;
            this.dgvMisDebates.RowTemplate.Height = 28;
            this.dgvMisDebates.Size = new System.Drawing.Size(193, 224);
            this.dgvMisDebates.TabIndex = 14;
            this.dgvMisDebates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.bAniadirDebate.Click += new System.EventHandler(this.bAniadirDebate_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(101, 270);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lNombreApellidos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 177);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1153, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mi perfil";
            this.label5.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1135, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(551, 116);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(63, 26);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol: ";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(621, 39);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(346, 44);
            this.lNombreApellidos.TabIndex = 3;
            this.lNombreApellidos.Text = "Nombre y apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hola,";
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // PantallaPrincipalForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1302, 819);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bMisDebatesForo);
            this.Controls.Add(this.bAniadirDebate);
            this.Controls.Add(this.dgvMisDebates);
            this.Controls.Add(this.dgvDebatesRecientes);
            this.Controls.Add(this.lDebates);
            this.Controls.Add(this.lForo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrincipalForo";
            this.Text = "PantallaBorrarCurso";
            this.Load += new System.EventHandler(this.PantallaBorrarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebatesRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisDebates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lForo;
        private System.Windows.Forms.Label lDebates;
        private System.Windows.Forms.DataGridView dgvDebatesRecientes;
        private System.Windows.Forms.DataGridView dgvMisDebates;
        private System.Windows.Forms.Button bAniadirDebate;
        private System.Windows.Forms.Button bMisDebatesForo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombreApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}