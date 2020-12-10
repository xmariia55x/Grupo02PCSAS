
namespace Grupo02PCSAS
{
    partial class fStartAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStartAplicacion));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bAlumno = new System.Windows.Forms.Button();
            this.bProfesor = new System.Windows.Forms.Button();
            this.bEntidad = new System.Windows.Forms.Button();
            this.bAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(106, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Regístrate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.pcsas;
            this.pictureBox1.Location = new System.Drawing.Point(62, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bAlumno
            // 
            this.bAlumno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAlumno.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlumno.Location = new System.Drawing.Point(520, 110);
            this.bAlumno.Name = "bAlumno";
            this.bAlumno.Size = new System.Drawing.Size(159, 49);
            this.bAlumno.TabIndex = 3;
            this.bAlumno.Text = "Alumno";
            this.bAlumno.UseVisualStyleBackColor = false;
            this.bAlumno.Click += new System.EventHandler(this.bAlumno_Click);
            // 
            // bProfesor
            // 
            this.bProfesor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bProfesor.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProfesor.Location = new System.Drawing.Point(520, 206);
            this.bProfesor.Name = "bProfesor";
            this.bProfesor.Size = new System.Drawing.Size(159, 49);
            this.bProfesor.TabIndex = 4;
            this.bProfesor.Text = "Profesor";
            this.bProfesor.UseVisualStyleBackColor = false;
            this.bProfesor.Click += new System.EventHandler(this.bProfesor_Click);
            // 
            // bEntidad
            // 
            this.bEntidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEntidad.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEntidad.Location = new System.Drawing.Point(520, 291);
            this.bEntidad.Name = "bEntidad";
            this.bEntidad.Size = new System.Drawing.Size(159, 49);
            this.bEntidad.TabIndex = 5;
            this.bEntidad.Text = "Entidad";
            this.bEntidad.UseVisualStyleBackColor = false;
            this.bEntidad.Click += new System.EventHandler(this.bEntidad_Click);
            // 
            // bAdmin
            // 
            this.bAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAdmin.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdmin.Location = new System.Drawing.Point(520, 384);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(159, 49);
            this.bAdmin.TabIndex = 6;
            this.bAdmin.Text = "Admin";
            this.bAdmin.UseVisualStyleBackColor = false;
            this.bAdmin.Click += new System.EventHandler(this.bAdmin_Click);
            // 
            // fStartAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(816, 581);
            this.Controls.Add(this.bAdmin);
            this.Controls.Add(this.bEntidad);
            this.Controls.Add(this.bProfesor);
            this.Controls.Add(this.bAlumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStartAplicacion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bAlumno;
        private System.Windows.Forms.Button bProfesor;
        private System.Windows.Forms.Button bEntidad;
        private System.Windows.Forms.Button bAdmin;
    }
}

