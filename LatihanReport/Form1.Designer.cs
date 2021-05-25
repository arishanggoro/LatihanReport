namespace LatihanReport
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.msmhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa_P5DataSet = new LatihanReport.Mahasiswa_P5DataSet();
            this.msmhsTableAdapter = new LatihanReport.Mahasiswa_P5DataSetTableAdapters.msmhsTableAdapter();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.myPracticeDataSet = new LatihanReport.MyPracticeDataSet();
            this.tBMPRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_M_PRODUCTTableAdapter = new LatihanReport.MyPracticeDataSetTableAdapters.TB_M_PRODUCTTableAdapter();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmhsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa_P5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMPRODUCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.tgllahirDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn,
            this.idprodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.msmhsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(637, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // msmhsBindingSource
            // 
            this.msmhsBindingSource.DataMember = "msmhs";
            this.msmhsBindingSource.DataSource = this.mahasiswa_P5DataSet;
            // 
            // mahasiswa_P5DataSet
            // 
            this.mahasiswa_P5DataSet.DataSetName = "Mahasiswa_P5DataSet";
            this.mahasiswa_P5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // msmhsTableAdapter
            // 
            this.msmhsTableAdapter.ClearBeforeFill = true;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Location = new System.Drawing.Point(188, 34);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(117, 39);
            this.btnExportPdf.TabIndex = 1;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(375, 34);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(117, 39);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // myPracticeDataSet
            // 
            this.myPracticeDataSet.DataSetName = "MyPracticeDataSet";
            this.myPracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBMPRODUCTBindingSource
            // 
            this.tBMPRODUCTBindingSource.DataMember = "TB_M_PRODUCT";
            this.tBMPRODUCTBindingSource.DataSource = this.myPracticeDataSet;
            // 
            // tB_M_PRODUCTTableAdapter
            // 
            this.tB_M_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "nim";
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // tgllahirDataGridViewTextBoxColumn
            // 
            this.tgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.Name = "tgllahirDataGridViewTextBoxColumn";
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "telepon";
            this.teleponDataGridViewTextBoxColumn.HeaderText = "telepon";
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Export in to PDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmhsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa_P5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMPRODUCTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Mahasiswa_P5DataSet mahasiswa_P5DataSet;
        private System.Windows.Forms.BindingSource msmhsBindingSource;
        private Mahasiswa_P5DataSetTableAdapters.msmhsTableAdapter msmhsTableAdapter;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Button btnExportExcel;
        private MyPracticeDataSet myPracticeDataSet;
        private System.Windows.Forms.BindingSource tBMPRODUCTBindingSource;
        private MyPracticeDataSetTableAdapters.TB_M_PRODUCTTableAdapter tB_M_PRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
    }
}

