namespace Jardin
{
    partial class FrmEvaluando
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
            this.lbl_AlumnoEvaluado = new System.Windows.Forms.Label();
            this.lbl_ProfesorEvaluando = new System.Windows.Forms.Label();
            this.rtb_AlumnosAlRecreo = new System.Windows.Forms.RichTextBox();
            this.rtb_AlumnoEvaluado = new System.Windows.Forms.RichTextBox();
            this.lbl_Recreo = new System.Windows.Forms.Label();
            this.rtb_ProfesorEvaluando = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_AlumnoEvaluado
            // 
            this.lbl_AlumnoEvaluado.AutoSize = true;
            this.lbl_AlumnoEvaluado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlumnoEvaluado.Location = new System.Drawing.Point(18, 29);
            this.lbl_AlumnoEvaluado.Name = "lbl_AlumnoEvaluado";
            this.lbl_AlumnoEvaluado.Size = new System.Drawing.Size(271, 16);
            this.lbl_AlumnoEvaluado.TabIndex = 0;
            this.lbl_AlumnoEvaluado.Text = "Alumno/a que esta siendo evaluado/a";
            // 
            // lbl_ProfesorEvaluando
            // 
            this.lbl_ProfesorEvaluando.AutoSize = true;
            this.lbl_ProfesorEvaluando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProfesorEvaluando.Location = new System.Drawing.Point(18, 205);
            this.lbl_ProfesorEvaluando.Name = "lbl_ProfesorEvaluando";
            this.lbl_ProfesorEvaluando.Size = new System.Drawing.Size(223, 16);
            this.lbl_ProfesorEvaluando.TabIndex = 1;
            this.lbl_ProfesorEvaluando.Text = "El docente que esta evaluando";
            // 
            // rtb_AlumnosAlRecreo
            // 
            this.rtb_AlumnosAlRecreo.Location = new System.Drawing.Point(347, 68);
            this.rtb_AlumnosAlRecreo.Name = "rtb_AlumnosAlRecreo";
            this.rtb_AlumnosAlRecreo.Size = new System.Drawing.Size(284, 204);
            this.rtb_AlumnosAlRecreo.TabIndex = 2;
            this.rtb_AlumnosAlRecreo.Text = "";
            // 
            // rtb_AlumnoEvaluado
            // 
            this.rtb_AlumnoEvaluado.Location = new System.Drawing.Point(19, 78);
            this.rtb_AlumnoEvaluado.Name = "rtb_AlumnoEvaluado";
            this.rtb_AlumnoEvaluado.Size = new System.Drawing.Size(233, 33);
            this.rtb_AlumnoEvaluado.TabIndex = 3;
            this.rtb_AlumnoEvaluado.Text = "";
            // 
            // lbl_Recreo
            // 
            this.lbl_Recreo.AutoSize = true;
            this.lbl_Recreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recreo.Location = new System.Drawing.Point(344, 29);
            this.lbl_Recreo.Name = "lbl_Recreo";
            this.lbl_Recreo.Size = new System.Drawing.Size(286, 32);
            this.lbl_Recreo.TabIndex = 4;
            this.lbl_Recreo.Text = "Los alumnos que ya han sido evaluados\r\n y ya pueden ir al recreo ";
            this.lbl_Recreo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtb_ProfesorEvaluando
            // 
            this.rtb_ProfesorEvaluando.Location = new System.Drawing.Point(19, 238);
            this.rtb_ProfesorEvaluando.Name = "rtb_ProfesorEvaluando";
            this.rtb_ProfesorEvaluando.Size = new System.Drawing.Size(233, 34);
            this.rtb_ProfesorEvaluando.TabIndex = 5;
            this.rtb_ProfesorEvaluando.Text = "";
            // 
            // FrmEvaluando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(659, 310);
            this.Controls.Add(this.rtb_ProfesorEvaluando);
            this.Controls.Add(this.lbl_Recreo);
            this.Controls.Add(this.rtb_AlumnoEvaluado);
            this.Controls.Add(this.rtb_AlumnosAlRecreo);
            this.Controls.Add(this.lbl_ProfesorEvaluando);
            this.Controls.Add(this.lbl_AlumnoEvaluado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEvaluando";
            this.Text = "Evaluando";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEvaluando_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AlumnoEvaluado;
        private System.Windows.Forms.Label lbl_ProfesorEvaluando;
        private System.Windows.Forms.RichTextBox rtb_AlumnosAlRecreo;
        private System.Windows.Forms.RichTextBox rtb_AlumnoEvaluado;
        private System.Windows.Forms.Label lbl_Recreo;
        private System.Windows.Forms.RichTextBox rtb_ProfesorEvaluando;
    }
}