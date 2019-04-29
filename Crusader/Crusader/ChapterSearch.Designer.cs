namespace Crusader
{
    partial class ChapterSearch
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
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtBoss = new System.Windows.Forms.TextBox();
            this.txtEnvironment = new System.Windows.Forms.TextBox();
            this.txtChapterName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.DataGridView();
            this.chapterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.environmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhengruiDataSet3 = new Crusader.zhengruiDataSet3();
            this.txtEpisode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chapterTableAdapter = new Crusader.zhengruiDataSet3TableAdapters.ChapterTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhengruiDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtCost, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBoss, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEnvironment, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtChapterName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.results, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtEpisode, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(108, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCost
            // 
            this.txtCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCost.Location = new System.Drawing.Point(3, 111);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(570, 20);
            this.txtCost.TabIndex = 6;
            // 
            // txtBoss
            // 
            this.txtBoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoss.Location = new System.Drawing.Point(3, 84);
            this.txtBoss.Name = "txtBoss";
            this.txtBoss.Size = new System.Drawing.Size(570, 20);
            this.txtBoss.TabIndex = 5;
            // 
            // txtEnvironment
            // 
            this.txtEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnvironment.Location = new System.Drawing.Point(3, 57);
            this.txtEnvironment.Name = "txtEnvironment";
            this.txtEnvironment.Size = new System.Drawing.Size(570, 20);
            this.txtEnvironment.TabIndex = 4;
            // 
            // txtChapterName
            // 
            this.txtChapterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChapterName.Location = new System.Drawing.Point(3, 30);
            this.txtChapterName.Name = "txtChapterName";
            this.txtChapterName.Size = new System.Drawing.Size(570, 20);
            this.txtChapterName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // results
            // 
            this.results.AutoGenerateColumns = false;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chapterIdDataGridViewTextBoxColumn,
            this.episodeDataGridViewTextBoxColumn,
            this.chapterNameDataGridViewTextBoxColumn,
            this.environmentDataGridViewTextBoxColumn,
            this.bossDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.results.DataSource = this.chapterBindingSource;
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results.Location = new System.Drawing.Point(3, 165);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(570, 282);
            this.results.TabIndex = 1;
            // 
            // chapterIdDataGridViewTextBoxColumn
            // 
            this.chapterIdDataGridViewTextBoxColumn.DataPropertyName = "ChapterId";
            this.chapterIdDataGridViewTextBoxColumn.HeaderText = "ChapterId";
            this.chapterIdDataGridViewTextBoxColumn.Name = "chapterIdDataGridViewTextBoxColumn";
            this.chapterIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // episodeDataGridViewTextBoxColumn
            // 
            this.episodeDataGridViewTextBoxColumn.DataPropertyName = "Episode";
            this.episodeDataGridViewTextBoxColumn.HeaderText = "Episode";
            this.episodeDataGridViewTextBoxColumn.Name = "episodeDataGridViewTextBoxColumn";
            // 
            // chapterNameDataGridViewTextBoxColumn
            // 
            this.chapterNameDataGridViewTextBoxColumn.DataPropertyName = "ChapterName";
            this.chapterNameDataGridViewTextBoxColumn.HeaderText = "ChapterName";
            this.chapterNameDataGridViewTextBoxColumn.Name = "chapterNameDataGridViewTextBoxColumn";
            // 
            // environmentDataGridViewTextBoxColumn
            // 
            this.environmentDataGridViewTextBoxColumn.DataPropertyName = "Environment";
            this.environmentDataGridViewTextBoxColumn.HeaderText = "Environment";
            this.environmentDataGridViewTextBoxColumn.Name = "environmentDataGridViewTextBoxColumn";
            // 
            // bossDataGridViewTextBoxColumn
            // 
            this.bossDataGridViewTextBoxColumn.DataPropertyName = "Boss";
            this.bossDataGridViewTextBoxColumn.HeaderText = "Boss";
            this.bossDataGridViewTextBoxColumn.Name = "bossDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // chapterBindingSource
            // 
            this.chapterBindingSource.DataMember = "Chapter";
            this.chapterBindingSource.DataSource = this.zhengruiDataSet3;
            // 
            // zhengruiDataSet3
            // 
            this.zhengruiDataSet3.DataSetName = "zhengruiDataSet3";
            this.zhengruiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEpisode
            // 
            this.txtEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEpisode.Location = new System.Drawing.Point(3, 3);
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.Size = new System.Drawing.Size(570, 20);
            this.txtEpisode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Episode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ChapterName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Environment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Boss:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cost:";
            // 
            // chapterTableAdapter
            // 
            this.chapterTableAdapter.ClearBeforeFill = true;
            // 
            // ChapterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChapterSearch";
            this.Text = "ChapterSearch";
            this.Load += new System.EventHandler(this.ChapterSearch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhengruiDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtBoss;
        private System.Windows.Forms.TextBox txtEnvironment;
        private System.Windows.Forms.TextBox txtChapterName;
        private System.Windows.Forms.TextBox txtEpisode;
        private zhengruiDataSet3 zhengruiDataSet3;
        private System.Windows.Forms.BindingSource chapterBindingSource;
        private zhengruiDataSet3TableAdapters.ChapterTableAdapter chapterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn environmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}