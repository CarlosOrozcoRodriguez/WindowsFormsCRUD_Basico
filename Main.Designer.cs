
namespace WindowsFormsAppTestVideo
{
    partial class Main
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
            this.dataGridviewXXX = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAniadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewXXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridviewXXX
            // 
            this.dataGridviewXXX.AutoGenerateColumns = false;
            this.dataGridviewXXX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridviewXXX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dataGridviewXXX.DataSource = this.contactBindingSource;
            this.dataGridviewXXX.Location = new System.Drawing.Point(33, 41);
            this.dataGridviewXXX.Name = "dataGridviewXXX";
            this.dataGridviewXXX.Size = new System.Drawing.Size(755, 397);
            this.dataGridviewXXX.TabIndex = 0;
            this.dataGridviewXXX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridviewXXX_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(WindowsFormsAppTestVideo.Contact);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(91, 14);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(498, 20);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(30, 17);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(40, 13);
            this.labelBuscar.TabIndex = 2;
            this.labelBuscar.Text = "Buscar";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(614, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAniadir
            // 
            this.buttonAniadir.Location = new System.Drawing.Point(713, 12);
            this.buttonAniadir.Name = "buttonAniadir";
            this.buttonAniadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAniadir.TabIndex = 4;
            this.buttonAniadir.Text = "Añadir";
            this.buttonAniadir.UseVisualStyleBackColor = true;
            this.buttonAniadir.Click += new System.EventHandler(this.ButtonAniadir_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAniadir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.dataGridviewXXX);
            this.Name = "Main";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewXXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridviewXXX;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAniadir;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}

