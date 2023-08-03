
namespace FactuStock
{
    partial class ConsultarEmpresaGral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEmpresaGral));
            this.pBotones = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BSalir = new System.Windows.Forms.Button();
            this.BImprimir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.iDEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTBISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sloganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.empresaConsultarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factuStockDataSet = new FactuStock.FactuStockDataSet();
            this.empresaConsultarTableAdapter = new FactuStock.FactuStockDataSetTableAdapters.EmpresaConsultarTableAdapter();
            this.pBotones.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaConsultarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factuStockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.SystemColors.Control;
            this.pBotones.Controls.Add(this.panel6);
            this.pBotones.Location = new System.Drawing.Point(0, 384);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(627, 62);
            this.pBotones.TabIndex = 20;
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
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Location = new System.Drawing.Point(-9, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(636, 62);
            this.pTitulo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Empresa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BConsultar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(365, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 25);
            this.panel3.TabIndex = 25;
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
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ingrese el dato a consultar";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(181, 72);
            this.tbBuscar.Multiline = true;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(180, 24);
            this.tbBuscar.TabIndex = 23;
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.AllowUserToOrderColumns = true;
            this.DGVDatos.AutoGenerateColumns = false;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmpresaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.iTBISDataGridViewTextBoxColumn,
            this.sloganDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn});
            this.DGVDatos.DataSource = this.empresaConsultarBindingSource;
            this.DGVDatos.Location = new System.Drawing.Point(16, 106);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.Size = new System.Drawing.Size(587, 262);
            this.DGVDatos.TabIndex = 26;
            // 
            // iDEmpresaDataGridViewTextBoxColumn
            // 
            this.iDEmpresaDataGridViewTextBoxColumn.DataPropertyName = "IDEmpresa";
            this.iDEmpresaDataGridViewTextBoxColumn.HeaderText = "IDEmpresa";
            this.iDEmpresaDataGridViewTextBoxColumn.Name = "iDEmpresaDataGridViewTextBoxColumn";
            this.iDEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "Razon_Social";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "Razon_Social";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTBISDataGridViewTextBoxColumn
            // 
            this.iTBISDataGridViewTextBoxColumn.DataPropertyName = "ITBIS";
            this.iTBISDataGridViewTextBoxColumn.HeaderText = "ITBIS";
            this.iTBISDataGridViewTextBoxColumn.Name = "iTBISDataGridViewTextBoxColumn";
            this.iTBISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sloganDataGridViewTextBoxColumn
            // 
            this.sloganDataGridViewTextBoxColumn.DataPropertyName = "Slogan";
            this.sloganDataGridViewTextBoxColumn.HeaderText = "Slogan";
            this.sloganDataGridViewTextBoxColumn.Name = "sloganDataGridViewTextBoxColumn";
            this.sloganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            // 
            // empresaConsultarBindingSource
            // 
            this.empresaConsultarBindingSource.DataMember = "EmpresaConsultar";
            this.empresaConsultarBindingSource.DataSource = this.factuStockDataSet;
            // 
            // factuStockDataSet
            // 
            this.factuStockDataSet.DataSetName = "FactuStockDataSet";
            this.factuStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaConsultarTableAdapter
            // 
            this.empresaConsultarTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultarEmpresaGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(627, 446);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEmpresaGral";
            this.Text = "ConsultarEmpresaGral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarEmpresaGral_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarEmpresaGral_Load);
            this.pBotones.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaConsultarBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView DGVDatos;
        private FactuStockDataSet factuStockDataSet;
        private System.Windows.Forms.BindingSource empresaConsultarBindingSource;
        private FactuStockDataSetTableAdapters.EmpresaConsultarTableAdapter empresaConsultarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTBISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sloganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
    }
}