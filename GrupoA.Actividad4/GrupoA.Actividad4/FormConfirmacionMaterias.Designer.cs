
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
            this.btnAtrasConfirmacionMaterias = new System.Windows.Forms.Button();
            this.btnConfirmarConfirmacionMaterias = new System.Windows.Forms.Button();
            this.txtConfirmacionMaterias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, revise sus materias seleccionadas\r\nantes de confirmar la solicitud de " +
    "inscripción\r\n";
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
            // txtConfirmacionMaterias
            // 
            this.txtConfirmacionMaterias.Location = new System.Drawing.Point(201, 97);
            this.txtConfirmacionMaterias.Multiline = true;
            this.txtConfirmacionMaterias.Name = "txtConfirmacionMaterias";
            this.txtConfirmacionMaterias.ReadOnly = true;
            this.txtConfirmacionMaterias.Size = new System.Drawing.Size(422, 158);
            this.txtConfirmacionMaterias.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tenga en cuenta que las materias seleccionadas pueden no llegar a ser asignadas, " +
    "\r\ndependiendo del corte de ranking y de la cantidad de inscriptos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConfirmacionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmacionMaterias);
            this.Controls.Add(this.btnConfirmarConfirmacionMaterias);
            this.Controls.Add(this.btnAtrasConfirmacionMaterias);
            this.Controls.Add(this.label1);
            this.Name = "FormConfirmacionMaterias";
            this.Text = "FormConfirmacionMaterias";
            this.Shown += new System.EventHandler(this.FormConfirmacionMaterias_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtrasConfirmacionMaterias;
        private System.Windows.Forms.Button btnConfirmarConfirmacionMaterias;
        private System.Windows.Forms.TextBox txtConfirmacionMaterias;
        private System.Windows.Forms.Label label2;
    }
}