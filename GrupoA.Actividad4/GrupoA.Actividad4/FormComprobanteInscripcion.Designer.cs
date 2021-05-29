
namespace GrupoA.Actividad4
{
    partial class FormComprobanteInscripcion
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
            this.lblCodigoInscripcion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Su solicitud de inscripción fue recibida satisfactoriamente";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(222, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 173);
            this.listBox1.TabIndex = 1;
            // 
            // lblCodigoInscripcion
            // 
            this.lblCodigoInscripcion.AutoSize = true;
            this.lblCodigoInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoInscripcion.Location = new System.Drawing.Point(297, 336);
            this.lblCodigoInscripcion.Name = "lblCodigoInscripcion";
            this.lblCodigoInscripcion.Size = new System.Drawing.Size(221, 20);
            this.lblCodigoInscripcion.TabIndex = 2;
            this.lblCodigoInscripcion.Text = "Código de inscripción: 000000";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(369, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormComprobanteInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCodigoInscripcion);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormComprobanteInscripcion";
            this.Text = "FormComprobanteInscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblCodigoInscripcion;
        private System.Windows.Forms.Button btnSalir;
    }
}