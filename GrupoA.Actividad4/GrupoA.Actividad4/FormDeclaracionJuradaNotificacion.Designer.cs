
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtrasNotificacionDJ = new System.Windows.Forms.Button();
            this.btnContinuarNotificacionDJ = new System.Windows.Forms.Button();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(235, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 147);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sus selecciones fueron:";
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
            // FormDeclaracionJuradaNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinuarNotificacionDJ);
            this.Controls.Add(this.btnAtrasNotificacionDJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormDeclaracionJuradaNotificacion";
            this.Text = "FormDeclaracionJuradaNotificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtrasNotificacionDJ;
        private System.Windows.Forms.Button btnContinuarNotificacionDJ;
    }
}