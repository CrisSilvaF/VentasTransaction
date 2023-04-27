namespace VentasTransaction
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
            this.components = new System.ComponentModel.Container();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.borrarCliente = new System.Windows.Forms.Button();
            this.ClientesGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.actualizarProducto = new System.Windows.Forms.Button();
            this.borrarProducto = new System.Windows.Forms.Button();
            this.agregarProducto = new System.Windows.Forms.Button();
            this.priceText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductosGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.actualizarCliente = new System.Windows.Forms.Button();
            this.ProductoExistenciaGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ExistenciasGrid = new System.Windows.Forms.DataGridView();
            this.EditarExistencia = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoExistenciaGrid)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExistenciasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1153, 636);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Folios";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.actualizarCliente);
            this.tabPage3.Controls.Add(this.borrarCliente);
            this.tabPage3.Controls.Add(this.ClientesGrid);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1153, 636);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clientes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // borrarCliente
            // 
            this.borrarCliente.Location = new System.Drawing.Point(970, 106);
            this.borrarCliente.Name = "borrarCliente";
            this.borrarCliente.Size = new System.Drawing.Size(180, 36);
            this.borrarCliente.TabIndex = 4;
            this.borrarCliente.Text = "Borrar";
            this.borrarCliente.UseVisualStyleBackColor = true;
            this.borrarCliente.Click += new System.EventHandler(this.borrarCliente_Click);
            // 
            // ClientesGrid
            // 
            this.ClientesGrid.AllowUserToAddRows = false;
            this.ClientesGrid.AllowUserToDeleteRows = false;
            this.ClientesGrid.AutoGenerateColumns = false;
            this.ClientesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn});
            this.ClientesGrid.DataSource = this.clientesBindingSource;
            this.ClientesGrid.Location = new System.Drawing.Point(4, 9);
            this.ClientesGrid.MultiSelect = false;
            this.ClientesGrid.Name = "ClientesGrid";
            this.ClientesGrid.ReadOnly = true;
            this.ClientesGrid.RowHeadersWidth = 62;
            this.ClientesGrid.RowTemplate.Height = 28;
            this.ClientesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesGrid.Size = new System.Drawing.Size(956, 575);
            this.ClientesGrid.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(970, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(966, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(970, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 26);
            this.textBox2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.actualizarProducto);
            this.tabPage2.Controls.Add(this.borrarProducto);
            this.tabPage2.Controls.Add(this.agregarProducto);
            this.tabPage2.Controls.Add(this.priceText);
            this.tabPage2.Controls.Add(this.descriptionText);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ProductosGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1153, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // actualizarProducto
            // 
            this.actualizarProducto.Location = new System.Drawing.Point(903, 204);
            this.actualizarProducto.Name = "actualizarProducto";
            this.actualizarProducto.Size = new System.Drawing.Size(244, 36);
            this.actualizarProducto.TabIndex = 7;
            this.actualizarProducto.Text = "Actualizar";
            this.actualizarProducto.UseVisualStyleBackColor = true;
            // 
            // borrarProducto
            // 
            this.borrarProducto.Location = new System.Drawing.Point(903, 161);
            this.borrarProducto.Name = "borrarProducto";
            this.borrarProducto.Size = new System.Drawing.Size(244, 36);
            this.borrarProducto.TabIndex = 6;
            this.borrarProducto.Text = "Borrar";
            this.borrarProducto.UseVisualStyleBackColor = true;
            this.borrarProducto.Click += new System.EventHandler(this.borrarProducto_Click);
            // 
            // agregarProducto
            // 
            this.agregarProducto.Location = new System.Drawing.Point(903, 119);
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.Size = new System.Drawing.Size(244, 36);
            this.agregarProducto.TabIndex = 5;
            this.agregarProducto.Text = "Agregar";
            this.agregarProducto.UseVisualStyleBackColor = true;
            this.agregarProducto.Click += new System.EventHandler(this.agregarProducto_Click);
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(903, 86);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(244, 26);
            this.priceText.TabIndex = 4;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(903, 29);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(244, 26);
            this.descriptionText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(903, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio Unitario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(899, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto";
            // 
            // ProductosGrid
            // 
            this.ProductosGrid.AllowUserToAddRows = false;
            this.ProductosGrid.AllowUserToDeleteRows = false;
            this.ProductosGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductosGrid.AutoGenerateColumns = false;
            this.ProductosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ProductosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.ProductosGrid.DataSource = this.productosBindingSource;
            this.ProductosGrid.Location = new System.Drawing.Point(6, 31);
            this.ProductosGrid.MultiSelect = false;
            this.ProductosGrid.Name = "ProductosGrid";
            this.ProductosGrid.ReadOnly = true;
            this.ProductosGrid.RowHeadersWidth = 62;
            this.ProductosGrid.RowTemplate.Height = 28;
            this.ProductosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosGrid.Size = new System.Drawing.Size(887, 575);
            this.ProductosGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ProductoExistenciaGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1153, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 672);
            this.tabControl1.TabIndex = 1;
            // 
            // actualizarCliente
            // 
            this.actualizarCliente.Location = new System.Drawing.Point(970, 148);
            this.actualizarCliente.Name = "actualizarCliente";
            this.actualizarCliente.Size = new System.Drawing.Size(180, 36);
            this.actualizarCliente.TabIndex = 5;
            this.actualizarCliente.Text = "Actualizar";
            this.actualizarCliente.UseVisualStyleBackColor = true;
            this.actualizarCliente.Click += new System.EventHandler(this.actualizarCliente_Click);
            // 
            // ProductoExistenciaGrid
            // 
            this.ProductoExistenciaGrid.AllowUserToAddRows = false;
            this.ProductoExistenciaGrid.AllowUserToDeleteRows = false;
            this.ProductoExistenciaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoExistenciaGrid.Location = new System.Drawing.Point(6, 30);
            this.ProductoExistenciaGrid.Name = "ProductoExistenciaGrid";
            this.ProductoExistenciaGrid.ReadOnly = true;
            this.ProductoExistenciaGrid.RowHeadersWidth = 62;
            this.ProductoExistenciaGrid.RowTemplate.Height = 28;
            this.ProductoExistenciaGrid.Size = new System.Drawing.Size(625, 479);
            this.ProductoExistenciaGrid.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Productos";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.EditarExistencia);
            this.tabPage5.Controls.Add(this.ExistenciasGrid);
            this.tabPage5.Location = new System.Drawing.Point(4, 32);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1153, 636);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Existencias";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ExistenciasGrid
            // 
            this.ExistenciasGrid.AllowUserToAddRows = false;
            this.ExistenciasGrid.AllowUserToDeleteRows = false;
            this.ExistenciasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExistenciasGrid.Location = new System.Drawing.Point(6, 6);
            this.ExistenciasGrid.Name = "ExistenciasGrid";
            this.ExistenciasGrid.ReadOnly = true;
            this.ExistenciasGrid.RowHeadersWidth = 62;
            this.ExistenciasGrid.RowTemplate.Height = 28;
            this.ExistenciasGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExistenciasGrid.Size = new System.Drawing.Size(1141, 582);
            this.ExistenciasGrid.TabIndex = 0;
            // 
            // EditarExistencia
            // 
            this.EditarExistencia.Location = new System.Drawing.Point(6, 594);
            this.EditarExistencia.Name = "EditarExistencia";
            this.EditarExistencia.Size = new System.Drawing.Size(162, 36);
            this.EditarExistencia.TabIndex = 1;
            this.EditarExistencia.Text = "Editar Existencia";
            this.EditarExistencia.UseVisualStyleBackColor = true;
            this.EditarExistencia.Click += new System.EventHandler(this.EditarExistencia_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 59;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 128;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 144;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(AccesoDatos.Entidades.Productos);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(AccesoDatos.Entidades.Clientes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1185, 696);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = " ";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoExistenciaGrid)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExistenciasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ClientesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button actualizarProducto;
        private System.Windows.Forms.Button borrarProducto;
        private System.Windows.Forms.Button agregarProducto;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button borrarCliente;
        private System.Windows.Forms.Button actualizarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ProductoExistenciaGrid;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView ExistenciasGrid;
        private System.Windows.Forms.Button EditarExistencia;
    }
}

