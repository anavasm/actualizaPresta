namespace actualiza_presta
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnShopFile = new System.Windows.Forms.Button();
            this.btnShopLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathShop = new System.Windows.Forms.TextBox();
            this.gvShop = new System.Windows.Forms.DataGridView();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.gvSup = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtPathSup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSupLoad = new System.Windows.Forms.Button();
            this.btnSupFile = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelShop = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDivisor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSup = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.pBar = new System.Windows.Forms.ToolStripProgressBar();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSup)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnShopFile
            // 
            this.btnShopFile.Location = new System.Drawing.Point(336, 42);
            this.btnShopFile.Name = "btnShopFile";
            this.btnShopFile.Size = new System.Drawing.Size(134, 26);
            this.btnShopFile.TabIndex = 0;
            this.btnShopFile.Text = "Seleccionar archivo";
            this.btnShopFile.UseVisualStyleBackColor = true;
            this.btnShopFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShopLoad
            // 
            this.btnShopLoad.Enabled = false;
            this.btnShopLoad.Location = new System.Drawing.Point(16, 85);
            this.btnShopLoad.Name = "btnShopLoad";
            this.btnShopLoad.Size = new System.Drawing.Size(284, 45);
            this.btnShopLoad.TabIndex = 1;
            this.btnShopLoad.Text = "Leer datos";
            this.btnShopLoad.UseVisualStyleBackColor = true;
            this.btnShopLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tienda";
            // 
            // txtPathShop
            // 
            this.txtPathShop.BackColor = System.Drawing.SystemColors.Window;
            this.txtPathShop.Location = new System.Drawing.Point(16, 47);
            this.txtPathShop.Name = "txtPathShop";
            this.txtPathShop.ReadOnly = true;
            this.txtPathShop.Size = new System.Drawing.Size(284, 20);
            this.txtPathShop.TabIndex = 4;
            this.txtPathShop.Text = "C:\\Users\\TECNICO2\\Downloads\\request_sql_3 (2).csv";
            // 
            // gvShop
            // 
            this.gvShop.AllowUserToAddRows = false;
            this.gvShop.AllowUserToDeleteRows = false;
            this.gvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReference,
            this.colPrice,
            this.colStock});
            this.gvShop.Location = new System.Drawing.Point(16, 156);
            this.gvShop.Name = "gvShop";
            this.gvShop.ReadOnly = true;
            this.gvShop.Size = new System.Drawing.Size(1131, 115);
            this.gvShop.TabIndex = 5;
            // 
            // colReference
            // 
            this.colReference.HeaderText = "Referencia";
            this.colReference.Name = "colReference";
            this.colReference.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Precio";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(16, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1131, 2);
            this.label3.TabIndex = 7;
            // 
            // gvSup
            // 
            this.gvSup.AllowUserToAddRows = false;
            this.gvSup.AllowUserToDeleteRows = false;
            this.gvSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.gvSup.Location = new System.Drawing.Point(16, 465);
            this.gvSup.Name = "gvSup";
            this.gvSup.ReadOnly = true;
            this.gvSup.Size = new System.Drawing.Size(1131, 115);
            this.gvSup.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Stock";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // txtPathSup
            // 
            this.txtPathSup.BackColor = System.Drawing.SystemColors.Window;
            this.txtPathSup.Location = new System.Drawing.Point(16, 356);
            this.txtPathSup.Name = "txtPathSup";
            this.txtPathSup.ReadOnly = true;
            this.txtPathSup.Size = new System.Drawing.Size(284, 20);
            this.txtPathSup.TabIndex = 12;
            this.txtPathSup.Text = "C:\\Users\\TECNICO2\\Downloads\\securimport.csv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Proveedor";
            // 
            // btnSupLoad
            // 
            this.btnSupLoad.Enabled = false;
            this.btnSupLoad.Location = new System.Drawing.Point(16, 400);
            this.btnSupLoad.Name = "btnSupLoad";
            this.btnSupLoad.Size = new System.Drawing.Size(284, 45);
            this.btnSupLoad.TabIndex = 9;
            this.btnSupLoad.Text = "Cargar datos";
            this.btnSupLoad.UseVisualStyleBackColor = true;
            this.btnSupLoad.Click += new System.EventHandler(this.btnSupLoad_Click);
            // 
            // btnSupFile
            // 
            this.btnSupFile.Enabled = false;
            this.btnSupFile.Location = new System.Drawing.Point(336, 351);
            this.btnSupFile.Name = "btnSupFile";
            this.btnSupFile.Size = new System.Drawing.Size(134, 26);
            this.btnSupFile.TabIndex = 8;
            this.btnSupFile.Text = "Seleccionar archivo";
            this.btnSupFile.UseVisualStyleBackColor = true;
            this.btnSupFile.Click += new System.EventHandler(this.btnSupFile_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(16, 620);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(284, 55);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Enabled = false;
            this.btnDeleted.Location = new System.Drawing.Point(445, 620);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(284, 55);
            this.btnDeleted.TabIndex = 16;
            this.btnDeleted.Text = "Ver eliminados";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelShop,
            this.toolStripStatusDivisor,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelSup,
            this.toolStripStatusSeparator,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelResult,
            this.pBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 965);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1159, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "Tienda: ";
            // 
            // toolStripStatusLabelShop
            // 
            this.toolStripStatusLabelShop.Name = "toolStripStatusLabelShop";
            this.toolStripStatusLabelShop.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelShop.Text = "0";
            // 
            // toolStripStatusDivisor
            // 
            this.toolStripStatusDivisor.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusDivisor.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusDivisor.Name = "toolStripStatusDivisor";
            this.toolStripStatusDivisor.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel3.Text = "Proveedor";
            // 
            // toolStripStatusLabelSup
            // 
            this.toolStripStatusLabelSup.Name = "toolStripStatusLabelSup";
            this.toolStripStatusLabelSup.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelSup.Text = "0";
            // 
            // toolStripStatusSeparator
            // 
            this.toolStripStatusSeparator.Name = "toolStripStatusSeparator";
            this.toolStripStatusSeparator.Size = new System.Drawing.Size(939, 17);
            this.toolStripStatusSeparator.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel2.Text = "Resultado: ";
            // 
            // toolStripStatusLabelResult
            // 
            this.toolStripStatusLabelResult.Name = "toolStripStatusLabelResult";
            this.toolStripStatusLabelResult.Size = new System.Drawing.Size(0, 17);
            // 
            // pBar
            // 
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(100, 16);
            this.pBar.Visible = false;
            // 
            // gvResults
            // 
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToDeleteRows = false;
            this.gvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn2});
            this.gvResults.Location = new System.Drawing.Point(16, 748);
            this.gvResults.Name = "gvResults";
            this.gvResults.ReadOnly = true;
            this.gvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResults.Size = new System.Drawing.Size(1131, 115);
            this.gvResults.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Referencia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Stock";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1131, 2);
            this.label2.TabIndex = 20;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(16, 883);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(284, 55);
            this.btnGenerate.TabIndex = 21;
            this.btnGenerate.Text = "Generar CSV";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo CSV (*.csv)|*.csv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 707);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Resultados";
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(863, 620);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(284, 55);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "Detectar nuevos";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 987);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvResults);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gvSup);
            this.Controls.Add(this.txtPathSup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSupLoad);
            this.Controls.Add(this.btnSupFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvShop);
            this.Controls.Add(this.txtPathShop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShopLoad);
            this.Controls.Add(this.btnShopFile);
            this.Name = "Form1";
            this.Text = "Control de inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSup)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnShopFile;
        private System.Windows.Forms.Button btnShopLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathShop;
        private System.Windows.Forms.DataGridView gvShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvSup;
        private System.Windows.Forms.TextBox txtPathSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSupLoad;
        private System.Windows.Forms.Button btnSupFile;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSeparator;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelShop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSup;
        private System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDivisor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ToolStripProgressBar pBar;
        private System.Windows.Forms.Button btnNew;
    }
}

