namespace Herencia
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
            this.btnLlamarClase = new System.Windows.Forms.Button();
            this.Llamar_clase_perro = new System.Windows.Forms.Button();
            this.LlamarCaballo = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            this.ID_Categories = new System.Windows.Forms.TextBox();
            this.NameCategories = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCategorias_productos = new System.Windows.Forms.DataGridView();
            this.buscarCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategorias_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLlamarClase
            // 
            this.btnLlamarClase.Location = new System.Drawing.Point(29, 29);
            this.btnLlamarClase.Name = "btnLlamarClase";
            this.btnLlamarClase.Size = new System.Drawing.Size(176, 64);
            this.btnLlamarClase.TabIndex = 0;
            this.btnLlamarClase.Text = "Llamar clase Animal";
            this.btnLlamarClase.UseVisualStyleBackColor = true;
            this.btnLlamarClase.Click += new System.EventHandler(this.btnLlamarClase_Click);
            // 
            // Llamar_clase_perro
            // 
            this.Llamar_clase_perro.Location = new System.Drawing.Point(29, 120);
            this.Llamar_clase_perro.Name = "Llamar_clase_perro";
            this.Llamar_clase_perro.Size = new System.Drawing.Size(176, 80);
            this.Llamar_clase_perro.TabIndex = 1;
            this.Llamar_clase_perro.Text = "Llamar al perro";
            this.Llamar_clase_perro.UseVisualStyleBackColor = true;
            this.Llamar_clase_perro.Click += new System.EventHandler(this.Llamar_clase_perro_Click);
            // 
            // LlamarCaballo
            // 
            this.LlamarCaballo.Location = new System.Drawing.Point(29, 242);
            this.LlamarCaballo.Name = "LlamarCaballo";
            this.LlamarCaballo.Size = new System.Drawing.Size(176, 82);
            this.LlamarCaballo.TabIndex = 2;
            this.LlamarCaballo.Text = "Llamar Caballo";
            this.LlamarCaballo.UseVisualStyleBackColor = true;
            this.LlamarCaballo.Click += new System.EventHandler(this.LlamarCaballo_Click);
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(478, 94);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(136, 22);
            this.Conectar.TabIndex = 3;
            this.Conectar.Text = "Guarda info de BD";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // ID_Categories
            // 
            this.ID_Categories.Location = new System.Drawing.Point(421, 28);
            this.ID_Categories.Name = "ID_Categories";
            this.ID_Categories.Size = new System.Drawing.Size(228, 20);
            this.ID_Categories.TabIndex = 4;
            // 
            // NameCategories
            // 
            this.NameCategories.Location = new System.Drawing.Point(421, 68);
            this.NameCategories.Name = "NameCategories";
            this.NameCategories.Size = new System.Drawing.Size(228, 20);
            this.NameCategories.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoría de producto";
            // 
            // dtCategorias_productos
            // 
            this.dtCategorias_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCategorias_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCategorias_productos.Location = new System.Drawing.Point(289, 182);
            this.dtCategorias_productos.Name = "dtCategorias_productos";
            this.dtCategorias_productos.Size = new System.Drawing.Size(480, 214);
            this.dtCategorias_productos.TabIndex = 8;
            // 
            // buscarCategory
            // 
            this.buscarCategory.Location = new System.Drawing.Point(655, 25);
            this.buscarCategory.Name = "buscarCategory";
            this.buscarCategory.Size = new System.Drawing.Size(120, 23);
            this.buscarCategory.TabIndex = 9;
            this.buscarCategory.Text = "Buscar Id Category";
            this.buscarCategory.UseVisualStyleBackColor = true;
            this.buscarCategory.Click += new System.EventHandler(this.buscarCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscarCategory);
            this.Controls.Add(this.dtCategorias_productos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameCategories);
            this.Controls.Add(this.ID_Categories);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.LlamarCaballo);
            this.Controls.Add(this.Llamar_clase_perro);
            this.Controls.Add(this.btnLlamarClase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCategorias_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamarClase;
        private System.Windows.Forms.Button Llamar_clase_perro;
        private System.Windows.Forms.Button LlamarCaballo;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.TextBox ID_Categories;
        private System.Windows.Forms.TextBox NameCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtCategorias_productos;
        private System.Windows.Forms.Button buscarCategory;
    }
}

