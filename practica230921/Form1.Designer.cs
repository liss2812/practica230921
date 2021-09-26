
namespace practica230921
{
    partial class Form1
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
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtdocumento = new System.Windows.Forms.Label();
            this.txtDocumentoId = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.txtcontenido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(483, 235);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtdocumento
            // 
            this.txtdocumento.AutoSize = true;
            this.txtdocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtdocumento.Location = new System.Drawing.Point(12, 98);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(73, 15);
            this.txtdocumento.TabIndex = 1;
            this.txtdocumento.Text = "DocumentoId";
            // 
            // txtDocumentoId
            // 
            this.txtDocumentoId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDocumentoId.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentoId.Location = new System.Drawing.Point(113, 98);
            this.txtDocumentoId.Name = "txtDocumentoId";
            this.txtDocumentoId.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentoId.TabIndex = 2;
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.Silver;
            this.Datos.FormattingEnabled = true;
            this.Datos.Location = new System.Drawing.Point(230, 88);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(669, 108);
            this.Datos.TabIndex = 3;
            this.Datos.SelectedIndexChanged += new System.EventHandler(this.Datos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Fuchsia;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Fuchsia;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Fuchsia;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(4, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "FechaCreacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Fuchsia;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contenido";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTitulo.Location = new System.Drawing.Point(113, 132);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtdescripcion.Location = new System.Drawing.Point(113, 169);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 9;
            // 
            // txtfechacreacion
            // 
            this.txtfechacreacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtfechacreacion.Location = new System.Drawing.Point(113, 209);
            this.txtfechacreacion.Name = "txtfechacreacion";
            this.txtfechacreacion.Size = new System.Drawing.Size(100, 20);
            this.txtfechacreacion.TabIndex = 10;
            // 
            // txtcontenido
            // 
            this.txtcontenido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcontenido.Location = new System.Drawing.Point(113, 238);
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(100, 20);
            this.txtcontenido.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(245, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 38);
            this.label6.TabIndex = 20;
            this.label6.Text = "Datos De Documentos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.txtDocumentoId);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.btnAñadir);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label txtdocumento;
        private System.Windows.Forms.TextBox txtDocumentoId;
        private System.Windows.Forms.ListBox Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtfechacreacion;
        private System.Windows.Forms.TextBox txtcontenido;
        private System.Windows.Forms.Label label6;
    }
}

