namespace Biblioteca
{
    partial class frmMostrarLibro
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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Genero,
            this.Autor,
            this.Editorial,
            this.Cantidad});
            this.dgvTabla.Location = new System.Drawing.Point(12, 96);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(632, 227);
            this.dgvTabla.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Editorial
            // 
            this.Editorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnAgregarL
            // 
            this.btnAgregarL.Location = new System.Drawing.Point(12, 56);
            this.btnAgregarL.Name = "btnAgregarL";
            this.btnAgregarL.Size = new System.Drawing.Size(84, 23);
            this.btnAgregarL.TabIndex = 1;
            this.btnAgregarL.Text = "Agregar Libro";
            this.btnAgregarL.UseVisualStyleBackColor = true;
            this.btnAgregarL.Click += new System.EventHandler(this.btnAgregarL_Click);
            // 
            // frmMostrarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 335);
            this.Controls.Add(this.btnAgregarL);
            this.Controls.Add(this.dgvTabla);
            this.Name = "frmMostrarLibro";
            this.Text = "Mostrar Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnAgregarL;
    }
}