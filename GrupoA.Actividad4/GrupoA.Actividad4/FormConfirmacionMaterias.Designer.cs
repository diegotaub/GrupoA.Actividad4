
namespace GrupoA.Actividad4
{
    partial class FormConfirmacionMaterias
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
            this.btnAtrasConfirmacionMaterias = new System.Windows.Forms.Button();
            this.btnConfirmarConfirmacionMaterias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sus selecciones fueron:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(256, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 173);
            this.listBox1.TabIndex = 1;
            // 
            // btnAtrasConfirmacionMaterias
            // 
            this.btnAtrasConfirmacionMaterias.Location = new System.Drawing.Point(276, 323);
            this.btnAtrasConfirmacionMaterias.Name = "btnAtrasConfirmacionMaterias";
            this.btnAtrasConfirmacionMaterias.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasConfirmacionMaterias.TabIndex = 2;
            this.btnAtrasConfirmacionMaterias.Text = "Atrás";
            this.btnAtrasConfirmacionMaterias.UseVisualStyleBackColor = true;
            this.btnAtrasConfirmacionMaterias.Click += new System.EventHandler(this.btnAtrasConfirmacionMaterias_Click);
            // 
            // btnConfirmarConfirmacionMaterias
            // 
            this.btnConfirmarConfirmacionMaterias.Location = new System.Drawing.Point(447, 323);
            this.btnConfirmarConfirmacionMaterias.Name = "btnConfirmarConfirmacionMaterias";
            this.btnConfirmarConfirmacionMaterias.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarConfirmacionMaterias.TabIndex = 3;
            this.btnConfirmarConfirmacionMaterias.Text = "Confirmar";
            this.btnConfirmarConfirmacionMaterias.UseVisualStyleBackColor = true;
            this.btnConfirmarConfirmacionMaterias.Click += new System.EventHandler(this.btnConfirmarConfirmacionMaterias_Click);
            // 
            // FormConfirmacionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.btnConfirmarConfirmacionMaterias);
            this.Controls.Add(this.btnAtrasConfirmacionMaterias);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormConfirmacionMaterias";
            this.Text = "FormConfirmacionMaterias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAtrasConfirmacionMaterias;
        private System.Windows.Forms.Button btnConfirmarConfirmacionMaterias;
    }
}