
namespace exercise_crud_041
{
    partial class Form3
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
            this.exercise_pabdDataSet = new exercise_crud_041.exercise_pabdDataSet();
            this.exercisepabdDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pegawaiTableAdapter = new exercise_crud_041.exercise_pabdDataSetTableAdapters.PegawaiTableAdapter();
            this.idpegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorindukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmanagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstatuskawinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercise_pabdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisepabdDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpegawaiDataGridViewTextBoxColumn,
            this.nomorindukDataGridViewTextBoxColumn,
            this.namapegawaiDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.idmanagerDataGridViewTextBoxColumn,
            this.idstatuskawinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pegawaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(122, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // exercise_pabdDataSet
            // 
            this.exercise_pabdDataSet.DataSetName = "exercise_pabdDataSet";
            this.exercise_pabdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exercisepabdDataSetBindingSource
            // 
            this.exercisepabdDataSetBindingSource.DataSource = this.exercise_pabdDataSet;
            this.exercisepabdDataSetBindingSource.Position = 0;
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "Pegawai";
            this.pegawaiBindingSource.DataSource = this.exercisepabdDataSetBindingSource;
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // idpegawaiDataGridViewTextBoxColumn
            // 
            this.idpegawaiDataGridViewTextBoxColumn.DataPropertyName = "id_pegawai";
            this.idpegawaiDataGridViewTextBoxColumn.HeaderText = "id_pegawai";
            this.idpegawaiDataGridViewTextBoxColumn.Name = "idpegawaiDataGridViewTextBoxColumn";
            // 
            // nomorindukDataGridViewTextBoxColumn
            // 
            this.nomorindukDataGridViewTextBoxColumn.DataPropertyName = "nomor_induk";
            this.nomorindukDataGridViewTextBoxColumn.HeaderText = "nomor_induk";
            this.nomorindukDataGridViewTextBoxColumn.Name = "nomorindukDataGridViewTextBoxColumn";
            // 
            // namapegawaiDataGridViewTextBoxColumn
            // 
            this.namapegawaiDataGridViewTextBoxColumn.DataPropertyName = "nama_pegawai";
            this.namapegawaiDataGridViewTextBoxColumn.HeaderText = "nama_pegawai";
            this.namapegawaiDataGridViewTextBoxColumn.Name = "namapegawaiDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // idmanagerDataGridViewTextBoxColumn
            // 
            this.idmanagerDataGridViewTextBoxColumn.DataPropertyName = "id_manager";
            this.idmanagerDataGridViewTextBoxColumn.HeaderText = "id_manager";
            this.idmanagerDataGridViewTextBoxColumn.Name = "idmanagerDataGridViewTextBoxColumn";
            // 
            // idstatuskawinDataGridViewTextBoxColumn
            // 
            this.idstatuskawinDataGridViewTextBoxColumn.DataPropertyName = "id_status_kawin";
            this.idstatuskawinDataGridViewTextBoxColumn.HeaderText = "id_status_kawin";
            this.idstatuskawinDataGridViewTextBoxColumn.Name = "idstatuskawinDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercise_pabdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisepabdDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource exercisepabdDataSetBindingSource;
        private exercise_pabdDataSet exercise_pabdDataSet;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private exercise_pabdDataSetTableAdapters.PegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorindukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmanagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatuskawinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}