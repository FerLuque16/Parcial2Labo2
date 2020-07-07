namespace Jardin
{
    partial class FrmMostrarProximo
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
            this.lbl_Tiempo = new System.Windows.Forms.Label();
            this.lbl_Proximo = new System.Windows.Forms.Label();
            this.rtb_ProximoAEvaluar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_Tiempo
            // 
            this.lbl_Tiempo.AutoSize = true;
            this.lbl_Tiempo.Location = new System.Drawing.Point(223, 13);
            this.lbl_Tiempo.Name = "lbl_Tiempo";
            this.lbl_Tiempo.Size = new System.Drawing.Size(42, 13);
            this.lbl_Tiempo.TabIndex = 2;
            this.lbl_Tiempo.Text = "Tiempo";
            // 
            // lbl_Proximo
            // 
            this.lbl_Proximo.AutoSize = true;
            this.lbl_Proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proximo.Location = new System.Drawing.Point(21, 62);
            this.lbl_Proximo.Name = "lbl_Proximo";
            this.lbl_Proximo.Size = new System.Drawing.Size(215, 32);
            this.lbl_Proximo.TabIndex = 3;
            this.lbl_Proximo.Text = "El/la proximo/a alumno/a que \r\nsera evaluado/a";
            this.lbl_Proximo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtb_ProximoAEvaluar
            // 
            this.rtb_ProximoAEvaluar.Location = new System.Drawing.Point(24, 105);
            this.rtb_ProximoAEvaluar.Name = "rtb_ProximoAEvaluar";
            this.rtb_ProximoAEvaluar.Size = new System.Drawing.Size(241, 43);
            this.rtb_ProximoAEvaluar.TabIndex = 4;
            this.rtb_ProximoAEvaluar.Text = "";
            // 
            // FrmMostrarProximo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(290, 255);
            this.Controls.Add(this.rtb_ProximoAEvaluar);
            this.Controls.Add(this.lbl_Proximo);
            this.Controls.Add(this.lbl_Tiempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMostrarProximo";
            this.Text = "Proximo Alumno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Tiempo;
        private System.Windows.Forms.Label lbl_Proximo;
        private System.Windows.Forms.RichTextBox rtb_ProximoAEvaluar;
    }
}