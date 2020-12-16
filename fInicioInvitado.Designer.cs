
namespace Grupo02PCSAS
{
    partial class fInicioInvitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInicioInvitado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lError = new System.Windows.Forms.Label();
            this.bRegistrate = new System.Windows.Forms.Button();
            this.bIniciarSesión = new System.Windows.Forms.Button();
            this.lTienesCuenta = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bInfoCurso = new System.Windows.Forms.Button();
            this.bInfoActividad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lError);
            this.panel1.Controls.Add(this.bRegistrate);
            this.panel1.Controls.Add(this.bIniciarSesión);
            this.panel1.Controls.Add(this.lTienesCuenta);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 177);
            this.panel1.TabIndex = 7;
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lError.ForeColor = System.Drawing.Color.Red;
            this.lError.Location = new System.Drawing.Point(574, 127);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(0, 29);
            this.lError.TabIndex = 13;
            // 
            // bRegistrate
            // 
            this.bRegistrate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRegistrate.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistrate.Location = new System.Drawing.Point(1202, 112);
            this.bRegistrate.Name = "bRegistrate";
            this.bRegistrate.Size = new System.Drawing.Size(238, 73);
            this.bRegistrate.TabIndex = 12;
            this.bRegistrate.Text = "Regístrate";
            this.bRegistrate.UseVisualStyleBackColor = false;
            this.bRegistrate.Click += new System.EventHandler(this.bRegistrate_Click);
            // 
            // bIniciarSesión
            // 
            this.bIniciarSesión.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bIniciarSesión.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIniciarSesión.Location = new System.Drawing.Point(1202, 33);
            this.bIniciarSesión.Name = "bIniciarSesión";
            this.bIniciarSesión.Size = new System.Drawing.Size(238, 73);
            this.bIniciarSesión.TabIndex = 11;
            this.bIniciarSesión.Text = "Iniciar sesión";
            this.bIniciarSesión.UseVisualStyleBackColor = false;
            this.bIniciarSesión.Click += new System.EventHandler(this.bIniciarSesión_Click);
            // 
            // lTienesCuenta
            // 
            this.lTienesCuenta.AutoSize = true;
            this.lTienesCuenta.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTienesCuenta.Location = new System.Drawing.Point(856, 105);
            this.lTienesCuenta.Name = "lTienesCuenta";
            this.lTienesCuenta.Size = new System.Drawing.Size(179, 26);
            this.lTienesCuenta.TabIndex = 10;
            this.lTienesCuenta.Text = "¿No tienes cuenta?";
            this.lTienesCuenta.Click += new System.EventHandler(this.bRegistrate_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(851, 44);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(334, 40);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.Text = "Password";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(511, 44);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(334, 40);
            this.tbUsuario.TabIndex = 8;
            this.tbUsuario.Text = "Usuario";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "¿Quiénes somos?";
            // 
            // lDescripcion
            // 
            this.lDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(35, 341);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(387, 231);
            this.lDescripcion.TabIndex = 14;
            this.lDescripcion.Text = resources.GetString("lDescripcion.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nuestros cursos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(520, 400);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidth = 62;
            this.dgvCursos.RowTemplate.Height = 28;
            this.dgvCursos.Size = new System.Drawing.Size(666, 193);
            this.dgvCursos.TabIndex = 15;
            this.dgvCursos.SelectionChanged += new System.EventHandler(this.dgvCursos_SelectionChanged);
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(520, 718);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.RowHeadersWidth = 62;
            this.dgvActividades.RowTemplate.Height = 28;
            this.dgvActividades.Size = new System.Drawing.Size(666, 193);
            this.dgvActividades.TabIndex = 17;
            this.dgvActividades.SelectionChanged += new System.EventHandler(this.dgvActividades_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nuestras Actividades";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources.logo_uma;
            this.pictureBox3.Location = new System.Drawing.Point(39, 683);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(357, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.Logo_Informatica;
            this.pictureBox2.Location = new System.Drawing.Point(78, 594);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // bInfoCurso
            // 
            this.bInfoCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfoCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfoCurso.Location = new System.Drawing.Point(1232, 426);
            this.bInfoCurso.Name = "bInfoCurso";
            this.bInfoCurso.Size = new System.Drawing.Size(157, 88);
            this.bInfoCurso.TabIndex = 20;
            this.bInfoCurso.Text = "Informacion del curso";
            this.bInfoCurso.UseVisualStyleBackColor = false;
            this.bInfoCurso.Click += new System.EventHandler(this.bInfoCurso_Click);
            // 
            // bInfoActividad
            // 
            this.bInfoActividad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfoActividad.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfoActividad.Location = new System.Drawing.Point(1232, 771);
            this.bInfoActividad.Name = "bInfoActividad";
            this.bInfoActividad.Size = new System.Drawing.Size(157, 110);
            this.bInfoActividad.TabIndex = 21;
            this.bInfoActividad.Text = "Informacion de la Actividad";
            this.bInfoActividad.UseVisualStyleBackColor = false;
            this.bInfoActividad.Click += new System.EventHandler(this.bInfoActividad_Click);
            // 
            // fInicioInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1465, 1024);
            this.Controls.Add(this.bInfoActividad);
            this.Controls.Add(this.bInfoCurso);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fInicioInvitado";
            this.Text = "InicioInvitado";
            this.Load += new System.EventHandler(this.fInicioInvitado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRegistrate;
        private System.Windows.Forms.Button bIniciarSesión;
        private System.Windows.Forms.Label lTienesCuenta;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.Button bInfoCurso;
        private System.Windows.Forms.Button bInfoActividad;
    }
}