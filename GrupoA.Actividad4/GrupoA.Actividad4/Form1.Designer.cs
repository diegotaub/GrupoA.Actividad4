
namespace GrupoA.Actividad4
{
    partial class Form1
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
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.lbMateriasAprobadas = new System.Windows.Forms.ListBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMateriasAprobadas = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.Location = new System.Drawing.Point(293, 20);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(92, 35);
            this.btnInscripciones.TabIndex = 0;
            this.btnInscripciones.Text = "Inscripciones";
            this.btnInscripciones.UseVisualStyleBackColor = true;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // lbMateriasAprobadas
            // 
            this.lbMateriasAprobadas.FormattingEnabled = true;
            this.lbMateriasAprobadas.Location = new System.Drawing.Point(11, 27);
            this.lbMateriasAprobadas.Name = "lbMateriasAprobadas";
            this.lbMateriasAprobadas.Size = new System.Drawing.Size(299, 251);
            this.lbMateriasAprobadas.TabIndex = 3;
            this.lbMateriasAprobadas.Click += new System.EventHandler(this.lbMateriasAprobadas_SelectedIndexChanged);
            this.lbMateriasAprobadas.SelectedIndexChanged += new System.EventHandler(this.lbMateriasAprobadas_SelectedIndexChanged);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(6, 16);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(301, 37);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "Bienvenido, Alumno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInscripciones);
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú Principal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCarrera);
            this.groupBox2.Controls.Add(this.lblMateriasAprobadas);
            this.groupBox2.Controls.Add(this.lblRanking);
            this.groupBox2.Controls.Add(this.lblPromedio);
            this.groupBox2.Controls.Add(this.lblRegistro);
            this.groupBox2.Controls.Add(this.lblBienvenido);
            this.groupBox2.Location = new System.Drawing.Point(40, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 297);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(7, 188);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(312, 31);
            this.lblCarrera.TabIndex = 9;
            this.lblCarrera.Text = "Carrera: Lic en Sistemas";
            // 
            // lblMateriasAprobadas
            // 
            this.lblMateriasAprobadas.AutoSize = true;
            this.lblMateriasAprobadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriasAprobadas.Location = new System.Drawing.Point(13, 244);
            this.lblMateriasAprobadas.Name = "lblMateriasAprobadas";
            this.lblMateriasAprobadas.Size = new System.Drawing.Size(160, 20);
            this.lblMateriasAprobadas.TabIndex = 8;
            this.lblMateriasAprobadas.Text = "24/34 Materias (70%)";
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.Location = new System.Drawing.Point(13, 103);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(125, 20);
            this.lblRanking.TabIndex = 7;
            this.lblRanking.Text = "Ranking: 176.58";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(13, 140);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(106, 20);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Text = "Promedio: 7.3";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(13, 69);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(131, 20);
            this.lblRegistro.TabIndex = 5;
            this.lblRegistro.Text = "Registro: 890061";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbMateriasAprobadas);
            this.groupBox3.Location = new System.Drawing.Point(396, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 297);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Materias Aprobadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInscripciones;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbMateriasAprobadas;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMateriasAprobadas;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

