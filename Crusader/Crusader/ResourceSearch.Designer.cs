namespace Crusader
{
    partial class ResourceSearch
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAcquisition = new System.Windows.Forms.TextBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtResourceName = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.DataGridView();
            this.resourceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquisitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhengruiDataSet4 = new Crusader.zhengruiDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resourceTableAdapter = new Crusader.zhengruiDataSet4TableAdapters.ResourceTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhengruiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtAcquisition, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUsage, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtResourceName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.results, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(102, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAcquisition
            // 
            this.txtAcquisition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAcquisition.Location = new System.Drawing.Point(3, 84);
            this.txtAcquisition.Name = "txtAcquisition";
            this.txtAcquisition.Size = new System.Drawing.Size(622, 20);
            this.txtAcquisition.TabIndex = 4;
            // 
            // txtUsage
            // 
            this.txtUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsage.Location = new System.Drawing.Point(3, 57);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(622, 20);
            this.txtUsage.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtType.Location = new System.Drawing.Point(3, 30);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(622, 20);
            this.txtType.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtResourceName
            // 
            this.txtResourceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResourceName.Location = new System.Drawing.Point(3, 3);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Size = new System.Drawing.Size(622, 20);
            this.txtResourceName.TabIndex = 1;
            // 
            // results
            // 
            this.results.AutoGenerateColumns = false;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourceIdDataGridViewTextBoxColumn,
            this.resourceNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.usageDataGridViewTextBoxColumn,
            this.acquisitionDataGridViewTextBoxColumn});
            this.results.DataSource = this.resourceBindingSource;
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results.Location = new System.Drawing.Point(3, 138);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(622, 309);
            this.results.TabIndex = 5;
            // 
            // resourceIdDataGridViewTextBoxColumn
            // 
            this.resourceIdDataGridViewTextBoxColumn.DataPropertyName = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.HeaderText = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.Name = "resourceIdDataGridViewTextBoxColumn";
            this.resourceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourceNameDataGridViewTextBoxColumn
            // 
            this.resourceNameDataGridViewTextBoxColumn.DataPropertyName = "ResourceName";
            this.resourceNameDataGridViewTextBoxColumn.HeaderText = "ResourceName";
            this.resourceNameDataGridViewTextBoxColumn.Name = "resourceNameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // usageDataGridViewTextBoxColumn
            // 
            this.usageDataGridViewTextBoxColumn.DataPropertyName = "Usage";
            this.usageDataGridViewTextBoxColumn.HeaderText = "Usage";
            this.usageDataGridViewTextBoxColumn.Name = "usageDataGridViewTextBoxColumn";
            // 
            // acquisitionDataGridViewTextBoxColumn
            // 
            this.acquisitionDataGridViewTextBoxColumn.DataPropertyName = "Acquisition";
            this.acquisitionDataGridViewTextBoxColumn.HeaderText = "Acquisition";
            this.acquisitionDataGridViewTextBoxColumn.Name = "acquisitionDataGridViewTextBoxColumn";
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataMember = "Resource";
            this.resourceBindingSource.DataSource = this.zhengruiDataSet4;
            // 
            // zhengruiDataSet4
            // 
            this.zhengruiDataSet4.DataSetName = "zhengruiDataSet4";
            this.zhengruiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ResourceName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Acquisition:";
            // 
            // resourceTableAdapter
            // 
            this.resourceTableAdapter.ClearBeforeFill = true;
            // 
            // ResourceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResourceSearch";
            this.Text = "ResourceSearch";
            this.Load += new System.EventHandler(this.ResourceSearch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhengruiDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAcquisition;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView results;
        private zhengruiDataSet4 zhengruiDataSet4;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private zhengruiDataSet4TableAdapters.ResourceTableAdapter resourceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acquisitionDataGridViewTextBoxColumn;
    }
}