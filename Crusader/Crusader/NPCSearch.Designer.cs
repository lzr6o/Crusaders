namespace Crusader
{
    partial class NPCSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNPCName = new System.Windows.Forms.TextBox();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFaction = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.DataGridView();
            this.nPCIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhengruiDataSet1 = new Crusader.zhengruiDataSet1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nPCTableAdapter = new Crusader.zhengruiDataSet1TableAdapters.NPCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhengruiDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NPCName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skill:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Faction:";
            // 
            // txtNPCName
            // 
            this.txtNPCName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNPCName.Location = new System.Drawing.Point(3, 3);
            this.txtNPCName.Name = "txtNPCName";
            this.txtNPCName.Size = new System.Drawing.Size(455, 20);
            this.txtNPCName.TabIndex = 5;
            // 
            // txtSkill
            // 
            this.txtSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSkill.Location = new System.Drawing.Point(3, 32);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.Size = new System.Drawing.Size(455, 20);
            this.txtSkill.TabIndex = 6;
            // 
            // txtType
            // 
            this.txtType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtType.Location = new System.Drawing.Point(3, 61);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(455, 20);
            this.txtType.TabIndex = 7;
            // 
            // txtFaction
            // 
            this.txtFaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaction.Location = new System.Drawing.Point(3, 90);
            this.txtFaction.Name = "txtFaction";
            this.txtFaction.Size = new System.Drawing.Size(455, 20);
            this.txtFaction.TabIndex = 8;
            // 
            // results
            // 
            this.results.AutoGenerateColumns = false;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nPCIdDataGridViewTextBoxColumn,
            this.nPCNameDataGridViewTextBoxColumn,
            this.skillDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.factionDataGridViewTextBoxColumn});
            this.results.DataSource = this.nPCBindingSource;
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results.Location = new System.Drawing.Point(3, 148);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(455, 439);
            this.results.TabIndex = 9;
            // 
            // nPCIdDataGridViewTextBoxColumn
            // 
            this.nPCIdDataGridViewTextBoxColumn.DataPropertyName = "NPCId";
            this.nPCIdDataGridViewTextBoxColumn.HeaderText = "NPCId";
            this.nPCIdDataGridViewTextBoxColumn.Name = "nPCIdDataGridViewTextBoxColumn";
            this.nPCIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nPCNameDataGridViewTextBoxColumn
            // 
            this.nPCNameDataGridViewTextBoxColumn.DataPropertyName = "NPCName";
            this.nPCNameDataGridViewTextBoxColumn.HeaderText = "NPCName";
            this.nPCNameDataGridViewTextBoxColumn.Name = "nPCNameDataGridViewTextBoxColumn";
            // 
            // skillDataGridViewTextBoxColumn
            // 
            this.skillDataGridViewTextBoxColumn.DataPropertyName = "Skill";
            this.skillDataGridViewTextBoxColumn.HeaderText = "Skill";
            this.skillDataGridViewTextBoxColumn.Name = "skillDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // factionDataGridViewTextBoxColumn
            // 
            this.factionDataGridViewTextBoxColumn.DataPropertyName = "Faction";
            this.factionDataGridViewTextBoxColumn.HeaderText = "Faction";
            this.factionDataGridViewTextBoxColumn.Name = "factionDataGridViewTextBoxColumn";
            // 
            // nPCBindingSource
            // 
            this.nPCBindingSource.DataMember = "NPC";
            this.nPCBindingSource.DataSource = this.zhengruiDataSet1;
            // 
            // zhengruiDataSet1
            // 
            this.zhengruiDataSet1.DataSetName = "zhengruiDataSet1";
            this.zhengruiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtNPCName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSkill, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFaction, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.results, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 590);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // nPCTableAdapter
            // 
            this.nPCTableAdapter.ClearBeforeFill = true;
            // 
            // NPCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NPCSearch";
            this.Text = "NPCSearch";
            this.Load += new System.EventHandler(this.NPCSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhengruiDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNPCName;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtFaction;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private zhengruiDataSet1 zhengruiDataSet1;
        private System.Windows.Forms.BindingSource nPCBindingSource;
        private zhengruiDataSet1TableAdapters.NPCTableAdapter nPCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPCIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn;
    }
}