
namespace FactuStock
{
    partial class ConsultarProveedorGral
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProveedorGral));
            this.pBotones = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BSalir = new System.Windows.Forms.Button();
            this.BImprimir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BPrimero = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BUltimo = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LCantProveedores = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorConsultarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factuStockDataSet = new FactuStock.FactuStockDataSet();
            this.proveedorConsultarTableAdapter = new FactuStock.FactuStockDataSetTableAdapters.ProveedorConsultarTableAdapter();
            this.pBotones.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorConsultarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factuStockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.SystemColors.Control;
            this.pBotones.Controls.Add(this.panel6);
            this.pBotones.Controls.Add(this.panel5);
            this.pBotones.Controls.Add(this.panel4);
            this.pBotones.Location = new System.Drawing.Point(-1, 384);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(627, 62);
            this.pBotones.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BSalir);
            this.panel6.Controls.Add(this.BImprimir);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(426, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(201, 62);
            this.panel6.TabIndex = 19;
            // 
            // BSalir
            // 
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSalir.Location = new System.Drawing.Point(114, 13);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(43, 36);
            this.BSalir.TabIndex = 19;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BImprimir
            // 
            this.BImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BImprimir.BackgroundImage")));
            this.BImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BImprimir.Location = new System.Drawing.Point(9, 14);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(43, 36);
            this.BImprimir.TabIndex = 18;
            this.BImprimir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Imprimir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salir";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BPrimero);
            this.panel5.Controls.Add(this.BAnterior);
            this.panel5.Controls.Add(this.BUltimo);
            this.panel5.Controls.Add(this.BSiguiente);
            this.panel5.Location = new System.Drawing.Point(9, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 36);
            this.panel5.TabIndex = 18;
            // 
            // BPrimero
            // 
            this.BPrimero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BPrimero.BackgroundImage")));
            this.BPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BPrimero.Location = new System.Drawing.Point(1, 0);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(39, 36);
            this.BPrimero.TabIndex = 15;
            this.BPrimero.UseVisualStyleBackColor = true;
            // 
            // BAnterior
            // 
            this.BAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BAnterior.BackgroundImage")));
            this.BAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAnterior.Location = new System.Drawing.Point(42, 0);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(39, 36);
            this.BAnterior.TabIndex = 14;
            this.BAnterior.UseVisualStyleBackColor = true;
            // 
            // BUltimo
            // 
            this.BUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUltimo.BackgroundImage")));
            this.BUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BUltimo.Location = new System.Drawing.Point(127, 0);
            this.BUltimo.Name = "BUltimo";
            this.BUltimo.Size = new System.Drawing.Size(39, 36);
            this.BUltimo.TabIndex = 13;
            this.BUltimo.UseVisualStyleBackColor = true;
            // 
            // BSiguiente
            // 
            this.BSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSiguiente.BackgroundImage")));
            this.BSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSiguiente.Location = new System.Drawing.Point(84, 0);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(39, 36);
            this.BSiguiente.TabIndex = 12;
            this.BSiguiente.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.LCantProveedores);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(201, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 36);
            this.panel4.TabIndex = 13;
            // 
            // LCantProveedores
            // 
            this.LCantProveedores.AutoSize = true;
            this.LCantProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantProveedores.Location = new System.Drawing.Point(167, 9);
            this.LCantProveedores.Name = "LCantProveedores";
            this.LCantProveedores.Size = new System.Drawing.Size(16, 16);
            this.LCantProveedores.TabIndex = 13;
            this.LCantProveedores.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad de Proveedores:";
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Location = new System.Drawing.Point(-10, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(636, 62);
            this.pTitulo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Proveedores";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BConsultar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(365, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 25);
            this.panel3.TabIndex = 19;
            // 
            // BConsultar
            // 
            this.BConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BConsultar.BackgroundImage")));
            this.BConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BConsultar.Location = new System.Drawing.Point(0, 0);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(27, 25);
            this.BConsultar.TabIndex = 11;
            this.BConsultar.UseVisualStyleBackColor = true;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Consultar Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese el dato a consultar";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(181, 74);
            this.tbBuscar.Multiline = true;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(180, 24);
            this.tbBuscar.TabIndex = 17;
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.AllowUserToOrderColumns = true;
            this.DGVDatos.AutoGenerateColumns = false;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProveedorDataGridViewTextBoxColumn,
            this.nombreEmpresaDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.representanteDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.DGVDatos.DataSource = this.proveedorConsultarBindingSource;
            this.DGVDatos.Location = new System.Drawing.Point(16, 114);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.Size = new System.Drawing.Size(587, 251);
            this.DGVDatos.TabIndex = 20;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            this.nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpresa";
            this.nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "NombreEmpresa";
            this.nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            this.nombreEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            this.fechaRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // representanteDataGridViewTextBoxColumn
            // 
            this.representanteDataGridViewTextBoxColumn.DataPropertyName = "Representante";
            this.representanteDataGridViewTextBoxColumn.HeaderText = "Representante";
            this.representanteDataGridViewTextBoxColumn.Name = "representanteDataGridViewTextBoxColumn";
            this.representanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorConsultarBindingSource
            // 
            this.proveedorConsultarBindingSource.DataMember = "ProveedorConsultar";
            this.proveedorConsultarBindingSource.DataSource = this.factuStockDataSet;
            // 
            // factuStockDataSet
            // 
            this.factuStockDataSet.DataSetName = "FactuStockDataSet";
            this.factuStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorConsultarTableAdapter
            // 
            this.proveedorConsultarTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultarProveedorGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(624, 446);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarProveedorGral";
            this.Text = "ConsultarProveedorGral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarProveedorGral_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarProveedorGral_Load);
            this.pBotones.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorConsultarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factuStockDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BImprimir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.Button BUltimo;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LCantProveedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proveedorConsultarBindingSource;
        private FactuStockDataSet factuStockDataSet;
        private FactuStockDataSetTableAdapters.ProveedorConsultarTableAdapter proveedorConsultarTableAdapter;
    }
}