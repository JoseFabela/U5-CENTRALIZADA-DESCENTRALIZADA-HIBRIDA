namespace U5
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
            this.btnCargarArchivos = new System.Windows.Forms.Button();
            this.btnAlmacenar = new System.Windows.Forms.Button();
            this.radioBtnCentralizada = new System.Windows.Forms.RadioButton();
            this.radioBtnDescentralizada = new System.Windows.Forms.RadioButton();
            this.radioBtnHibrida = new System.Windows.Forms.RadioButton();
            this.btnOrganizar = new System.Windows.Forms.Button();
            this.listBoxArchivos = new System.Windows.Forms.ListBox();
            this.radioBtnDescentralizadoHibrido = new System.Windows.Forms.RadioButton();
            this.radioBtnCentralizadoHibrido = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCargarArchivos
            // 
            this.btnCargarArchivos.Location = new System.Drawing.Point(12, 37);
            this.btnCargarArchivos.Name = "btnCargarArchivos";
            this.btnCargarArchivos.Size = new System.Drawing.Size(163, 47);
            this.btnCargarArchivos.TabIndex = 0;
            this.btnCargarArchivos.Text = "CargarArchivos";
            this.btnCargarArchivos.UseVisualStyleBackColor = true;
            this.btnCargarArchivos.Click += new System.EventHandler(this.btnCargarArchivos_Click);
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.Location = new System.Drawing.Point(739, 374);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(163, 47);
            this.btnAlmacenar.TabIndex = 1;
            this.btnAlmacenar.Text = "Almacenar";
            this.btnAlmacenar.UseVisualStyleBackColor = true;
            this.btnAlmacenar.Click += new System.EventHandler(this.btnAlmacenar_Click);
            // 
            // radioBtnCentralizada
            // 
            this.radioBtnCentralizada.AutoSize = true;
            this.radioBtnCentralizada.Location = new System.Drawing.Point(343, 228);
            this.radioBtnCentralizada.Name = "radioBtnCentralizada";
            this.radioBtnCentralizada.Size = new System.Drawing.Size(103, 20);
            this.radioBtnCentralizada.TabIndex = 2;
            this.radioBtnCentralizada.TabStop = true;
            this.radioBtnCentralizada.Text = "Centralizada";
            this.radioBtnCentralizada.UseVisualStyleBackColor = true;
            this.radioBtnCentralizada.CheckedChanged += new System.EventHandler(this.radioBtnCentralizada_CheckedChanged);
            // 
            // radioBtnDescentralizada
            // 
            this.radioBtnDescentralizada.AutoSize = true;
            this.radioBtnDescentralizada.Location = new System.Drawing.Point(526, 228);
            this.radioBtnDescentralizada.Name = "radioBtnDescentralizada";
            this.radioBtnDescentralizada.Size = new System.Drawing.Size(126, 20);
            this.radioBtnDescentralizada.TabIndex = 3;
            this.radioBtnDescentralizada.TabStop = true;
            this.radioBtnDescentralizada.Text = "Descentralizada";
            this.radioBtnDescentralizada.UseVisualStyleBackColor = true;
            this.radioBtnDescentralizada.CheckedChanged += new System.EventHandler(this.radioBtnDescentralizada_CheckedChanged);
            // 
            // radioBtnHibrida
            // 
            this.radioBtnHibrida.AutoSize = true;
            this.radioBtnHibrida.Location = new System.Drawing.Point(739, 228);
            this.radioBtnHibrida.Name = "radioBtnHibrida";
            this.radioBtnHibrida.Size = new System.Drawing.Size(72, 20);
            this.radioBtnHibrida.TabIndex = 4;
            this.radioBtnHibrida.TabStop = true;
            this.radioBtnHibrida.Text = "Hibrida";
            this.radioBtnHibrida.UseVisualStyleBackColor = true;
            this.radioBtnHibrida.CheckedChanged += new System.EventHandler(this.radioBtnHibrida_CheckedChanged);
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Location = new System.Drawing.Point(12, 108);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(163, 47);
            this.btnOrganizar.TabIndex = 5;
            this.btnOrganizar.Text = "Organizar En Carpeta Por Fecha";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // listBoxArchivos
            // 
            this.listBoxArchivos.FormattingEnabled = true;
            this.listBoxArchivos.ItemHeight = 16;
            this.listBoxArchivos.Location = new System.Drawing.Point(328, 14);
            this.listBoxArchivos.Name = "listBoxArchivos";
            this.listBoxArchivos.Size = new System.Drawing.Size(545, 180);
            this.listBoxArchivos.TabIndex = 8;
            // 
            // radioBtnDescentralizadoHibrido
            // 
            this.radioBtnDescentralizadoHibrido.AutoSize = true;
            this.radioBtnDescentralizadoHibrido.Location = new System.Drawing.Point(739, 304);
            this.radioBtnDescentralizadoHibrido.Name = "radioBtnDescentralizadoHibrido";
            this.radioBtnDescentralizadoHibrido.Size = new System.Drawing.Size(170, 20);
            this.radioBtnDescentralizadoHibrido.TabIndex = 9;
            this.radioBtnDescentralizadoHibrido.TabStop = true;
            this.radioBtnDescentralizadoHibrido.Text = "DescentralizadoHibrido";
            this.radioBtnDescentralizadoHibrido.UseVisualStyleBackColor = true;
            this.radioBtnDescentralizadoHibrido.CheckedChanged += new System.EventHandler(this.radioBtnDescentralizadoHibrido_CheckedChanged);
            // 
            // radioBtnCentralizadoHibrido
            // 
            this.radioBtnCentralizadoHibrido.AutoSize = true;
            this.radioBtnCentralizadoHibrido.Location = new System.Drawing.Point(739, 263);
            this.radioBtnCentralizadoHibrido.Name = "radioBtnCentralizadoHibrido";
            this.radioBtnCentralizadoHibrido.Size = new System.Drawing.Size(147, 20);
            this.radioBtnCentralizadoHibrido.TabIndex = 10;
            this.radioBtnCentralizadoHibrido.TabStop = true;
            this.radioBtnCentralizadoHibrido.Text = "CentralizadoHibrido";
            this.radioBtnCentralizadoHibrido.UseVisualStyleBackColor = true;
            this.radioBtnCentralizadoHibrido.CheckedChanged += new System.EventHandler(this.radioBtnCentralizadoHibrido_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 535);
            this.Controls.Add(this.radioBtnCentralizadoHibrido);
            this.Controls.Add(this.radioBtnDescentralizadoHibrido);
            this.Controls.Add(this.listBoxArchivos);
            this.Controls.Add(this.btnOrganizar);
            this.Controls.Add(this.radioBtnHibrida);
            this.Controls.Add(this.radioBtnDescentralizada);
            this.Controls.Add(this.radioBtnCentralizada);
            this.Controls.Add(this.btnAlmacenar);
            this.Controls.Add(this.btnCargarArchivos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarArchivos;
        private System.Windows.Forms.Button btnAlmacenar;
        private System.Windows.Forms.RadioButton radioBtnCentralizada;
        private System.Windows.Forms.RadioButton radioBtnDescentralizada;
        private System.Windows.Forms.RadioButton radioBtnHibrida;
        private System.Windows.Forms.Button btnOrganizar;
        private System.Windows.Forms.ListBox listBoxArchivos;
        private System.Windows.Forms.RadioButton radioBtnDescentralizadoHibrido;
        private System.Windows.Forms.RadioButton radioBtnCentralizadoHibrido;
    }
}

