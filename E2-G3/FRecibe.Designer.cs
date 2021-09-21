namespace E2_G3
{
    partial class FRecibe
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnApellido = new System.Windows.Forms.RadioButton();
            this.rbtnTelefono = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(37, 133);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(621, 213);
            this.dgvInfo.TabIndex = 0;
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(461, 35);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(100, 23);
            this.btnLlenar.TabIndex = 1;
            this.btnLlenar.Text = "Mostrar todo";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.txtdato);
            this.Busqueda.Controls.Add(this.label1);
            this.Busqueda.Controls.Add(this.rbtnTelefono);
            this.Busqueda.Controls.Add(this.rbtnApellido);
            this.Busqueda.Controls.Add(this.rbtnNombre);
            this.Busqueda.Controls.Add(this.btnLlenar);
            this.Busqueda.Location = new System.Drawing.Point(37, 22);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(621, 100);
            this.Busqueda.TabIndex = 2;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "Busqueda";
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(57, 19);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 2;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnApellido
            // 
            this.rbtnApellido.AutoSize = true;
            this.rbtnApellido.Location = new System.Drawing.Point(146, 19);
            this.rbtnApellido.Name = "rbtnApellido";
            this.rbtnApellido.Size = new System.Drawing.Size(62, 17);
            this.rbtnApellido.TabIndex = 3;
            this.rbtnApellido.TabStop = true;
            this.rbtnApellido.Text = "Apellido";
            this.rbtnApellido.UseVisualStyleBackColor = true;
            // 
            // rbtnTelefono
            // 
            this.rbtnTelefono.AutoSize = true;
            this.rbtnTelefono.Location = new System.Drawing.Point(256, 19);
            this.rbtnTelefono.Name = "rbtnTelefono";
            this.rbtnTelefono.Size = new System.Drawing.Size(67, 17);
            this.rbtnTelefono.TabIndex = 4;
            this.rbtnTelefono.TabStop = true;
            this.rbtnTelefono.Text = "Telefono";
            this.rbtnTelefono.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dato de busqueda";
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(164, 59);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(159, 20);
            this.txtdato.TabIndex = 6;
            this.txtdato.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // FRecibe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 376);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.Busqueda);
            this.Name = "FRecibe";
            this.Text = "FRecibe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnTelefono;
        private System.Windows.Forms.RadioButton rbtnApellido;
        private System.Windows.Forms.RadioButton rbtnNombre;
    }
}