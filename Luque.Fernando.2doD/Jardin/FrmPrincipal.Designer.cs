namespace Jardin
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Alumnos = new System.Windows.Forms.Label();
            this.lbl_Docentes = new System.Windows.Forms.Label();
            this.btn_IniciarJornada = new System.Windows.Forms.Button();
            this.rtb_Alumnos = new System.Windows.Forms.RichTextBox();
            this.rtb_Docentes = new System.Windows.Forms.RichTextBox();
            this.lbl_Tiempo = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.timer_Evaluando = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_Alumnos
            // 
            this.lbl_Alumnos.AutoSize = true;
            this.lbl_Alumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alumnos.Location = new System.Drawing.Point(35, 81);
            this.lbl_Alumnos.Name = "lbl_Alumnos";
            this.lbl_Alumnos.Size = new System.Drawing.Size(239, 25);
            this.lbl_Alumnos.TabIndex = 1;
            this.lbl_Alumnos.Text = "Alumnos/as del jardin";
            // 
            // lbl_Docentes
            // 
            this.lbl_Docentes.AutoSize = true;
            this.lbl_Docentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Docentes.Location = new System.Drawing.Point(538, 68);
            this.lbl_Docentes.Name = "lbl_Docentes";
            this.lbl_Docentes.Size = new System.Drawing.Size(216, 25);
            this.lbl_Docentes.TabIndex = 3;
            this.lbl_Docentes.Text = "Docentes del jardín";
            // 
            // btn_IniciarJornada
            // 
            this.btn_IniciarJornada.Location = new System.Drawing.Point(387, 161);
            this.btn_IniciarJornada.Name = "btn_IniciarJornada";
            this.btn_IniciarJornada.Size = new System.Drawing.Size(96, 49);
            this.btn_IniciarJornada.TabIndex = 4;
            this.btn_IniciarJornada.Text = "Iniciar Evaluaciones";
            this.btn_IniciarJornada.UseVisualStyleBackColor = true;
            this.btn_IniciarJornada.Click += new System.EventHandler(this.btn_IniciarJornada_Click);
            // 
            // rtb_Alumnos
            // 
            this.rtb_Alumnos.Location = new System.Drawing.Point(37, 115);
            this.rtb_Alumnos.Name = "rtb_Alumnos";
            this.rtb_Alumnos.ReadOnly = true;
            this.rtb_Alumnos.Size = new System.Drawing.Size(315, 139);
            this.rtb_Alumnos.TabIndex = 5;
            this.rtb_Alumnos.Text = "";
            // 
            // rtb_Docentes
            // 
            this.rtb_Docentes.Location = new System.Drawing.Point(531, 115);
            this.rtb_Docentes.Name = "rtb_Docentes";
            this.rtb_Docentes.ReadOnly = true;
            this.rtb_Docentes.Size = new System.Drawing.Size(315, 139);
            this.rtb_Docentes.TabIndex = 6;
            this.rtb_Docentes.Text = "";
            // 
            // lbl_Tiempo
            // 
            this.lbl_Tiempo.AutoSize = true;
            this.lbl_Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tiempo.Location = new System.Drawing.Point(34, 16);
            this.lbl_Tiempo.Name = "lbl_Tiempo";
            this.lbl_Tiempo.Size = new System.Drawing.Size(0, 16);
            this.lbl_Tiempo.TabIndex = 7;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(372, 9);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(0, 25);
            this.lbl_Estado.TabIndex = 8;
            // 
            // timer_Evaluando
            // 
            this.timer_Evaluando.Interval = 1000;
            this.timer_Evaluando.Tick += new System.EventHandler(this.timer_Evaluando_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(906, 307);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_Tiempo);
            this.Controls.Add(this.rtb_Docentes);
            this.Controls.Add(this.rtb_Alumnos);
            this.Controls.Add(this.btn_IniciarJornada);
            this.Controls.Add(this.lbl_Docentes);
            this.Controls.Add(this.lbl_Alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.Text = "JardinUtn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JardinUtn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Alumnos;
        private System.Windows.Forms.Label lbl_Docentes;
        private System.Windows.Forms.Button btn_IniciarJornada;
        private System.Windows.Forms.RichTextBox rtb_Alumnos;
        private System.Windows.Forms.RichTextBox rtb_Docentes;
        private System.Windows.Forms.Label lbl_Tiempo;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Timer timer_Evaluando;
    }
}

