
namespace GrupoA.Actividad4
{
    partial class FormDeclaracionJuradaNotificacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotificacionDJ = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtrasNotificacionDJ = new System.Windows.Forms.Button();
            this.btnContinuarNotificacionDJ = new System.Windows.Forms.Button();
            this.lblMarcoCuatroUltimas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lbNotificacionDJ
            // 
            this.lbNotificacionDJ.FormattingEnabled = true;
            this.lbNotificacionDJ.Location = new System.Drawing.Point(235, 115);
            this.lbNotificacionDJ.Name = "lbNotificacionDJ";
            this.lbNotificacionDJ.Size = new System.Drawing.Size(317, 147);
            this.lbNotificacionDJ.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comprobante de Declaración Jurada:";
            // 
            // btnAtrasNotificacionDJ
            // 
            this.btnAtrasNotificacionDJ.Location = new System.Drawing.Point(275, 348);
            this.btnAtrasNotificacionDJ.Name = "btnAtrasNotificacionDJ";
            this.btnAtrasNotificacionDJ.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasNotificacionDJ.TabIndex = 3;
            this.btnAtrasNotificacionDJ.Text = "Atrás";
            this.btnAtrasNotificacionDJ.UseVisualStyleBackColor = true;
            this.btnAtrasNotificacionDJ.Click += new System.EventHandler(this.btnAtrasNotificacionDJ_Click);
            // 
            // btnContinuarNotificacionDJ
            // 
            this.btnContinuarNotificacionDJ.Location = new System.Drawing.Point(426, 348);
            this.btnContinuarNotificacionDJ.Name = "btnContinuarNotificacionDJ";
            this.btnContinuarNotificacionDJ.Size = new System.Drawing.Size(75, 23);
            this.btnContinuarNotificacionDJ.TabIndex = 4;
            this.btnContinuarNotificacionDJ.Text = "Continuar";
            this.btnContinuarNotificacionDJ.UseVisualStyleBackColor = true;
            this.btnContinuarNotificacionDJ.Click += new System.EventHandler(this.btnContinuarNotificacionDJ_Click);
            // 
            // lblMarcoCuatroUltimas
            // 
            this.lblMarcoCuatroUltimas.AutoSize = true;
            this.lblMarcoCuatroUltimas.Location = new System.Drawing.Point(260, 291);
            this.lblMarcoCuatroUltimas.Name = "lblMarcoCuatroUltimas";
            this.lblMarcoCuatroUltimas.Size = new System.Drawing.Size(35, 13);
            this.lblMarcoCuatroUltimas.TabIndex = 5;
            this.lblMarcoCuatroUltimas.Text = "label3";
            this.lblMarcoCuatroUltimas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDeclaracionJuradaNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMarcoCuatroUltimas);
            this.Controls.Add(this.btnContinuarNotificacionDJ);
            this.Controls.Add(this.btnAtrasNotificacionDJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNotificacionDJ);
            this.Controls.Add(this.label1);
            this.Name = "FormDeclaracionJuradaNotificacion";
            this.Text = "FormDeclaracionJuradaNotificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbNotificacionDJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtrasNotificacionDJ;
        private System.Windows.Forms.Button btnContinuarNotificacionDJ;
        private System.Windows.Forms.Label lblMarcoCuatroUltimas;
    }
}