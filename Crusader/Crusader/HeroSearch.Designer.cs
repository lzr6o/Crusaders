namespace Crusader
{
    partial class HeroSearch
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
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtFaction = new System.Windows.Forms.TextBox();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.txtSoulboundWeapon = new System.Windows.Forms.TextBox();
            this.txtATK = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtHeroName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.DataGridView();
            this.heroIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heroNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soulboundWeaponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhengruiDataSet2 = new Crusader.zhengruiDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.heroTableAdapter = new Crusader.zhengruiDataSet2TableAdapters.HeroTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhengruiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtClass, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFaction, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtContract, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSoulboundWeapon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtATK, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHeroName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.results, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(113, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtClass
            // 
            this.txtClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClass.Location = new System.Drawing.Point(3, 165);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(531, 20);
            this.txtClass.TabIndex = 6;
            // 
            // txtFaction
            // 
            this.txtFaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaction.Location = new System.Drawing.Point(3, 138);
            this.txtFaction.Name = "txtFaction";
            this.txtFaction.Size = new System.Drawing.Size(531, 20);
            this.txtFaction.TabIndex = 5;
            // 
            // txtContract
            // 
            this.txtContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContract.Location = new System.Drawing.Point(3, 111);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(531, 20);
            this.txtContract.TabIndex = 4;
            // 
            // txtSoulboundWeapon
            // 
            this.txtSoulboundWeapon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoulboundWeapon.Location = new System.Drawing.Point(3, 84);
            this.txtSoulboundWeapon.Name = "txtSoulboundWeapon";
            this.txtSoulboundWeapon.Size = new System.Drawing.Size(531, 20);
            this.txtSoulboundWeapon.TabIndex = 3;
            // 
            // txtATK
            // 
            this.txtATK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtATK.Location = new System.Drawing.Point(3, 57);
            this.txtATK.Name = "txtATK";
            this.txtATK.Size = new System.Drawing.Size(531, 20);
            this.txtATK.TabIndex = 2;
            // 
            // txtHP
            // 
            this.txtHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHP.Location = new System.Drawing.Point(3, 30);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(531, 20);
            this.txtHP.TabIndex = 1;
            // 
            // txtHeroName
            // 
            this.txtHeroName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHeroName.Location = new System.Drawing.Point(3, 3);
            this.txtHeroName.Name = "txtHeroName";
            this.txtHeroName.Size = new System.Drawing.Size(531, 20);
            this.txtHeroName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // results
            // 
            this.results.AutoGenerateColumns = false;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heroIdDataGridViewTextBoxColumn,
            this.heroNameDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.aTKDataGridViewTextBoxColumn,
            this.soulboundWeaponDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn,
            this.factionDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.results.DataSource = this.heroBindingSource;
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results.Location = new System.Drawing.Point(3, 219);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(531, 228);
            this.results.TabIndex = 8;
            // 
            // heroIdDataGridViewTextBoxColumn
            // 
            this.heroIdDataGridViewTextBoxColumn.DataPropertyName = "HeroId";
            this.heroIdDataGridViewTextBoxColumn.HeaderText = "HeroId";
            this.heroIdDataGridViewTextBoxColumn.Name = "heroIdDataGridViewTextBoxColumn";
            this.heroIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heroNameDataGridViewTextBoxColumn
            // 
            this.heroNameDataGridViewTextBoxColumn.DataPropertyName = "HeroName";
            this.heroNameDataGridViewTextBoxColumn.HeaderText = "HeroName";
            this.heroNameDataGridViewTextBoxColumn.Name = "heroNameDataGridViewTextBoxColumn";
            // 
            // hPDataGridViewTextBoxColumn
            // 
            this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
            this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
            // 
            // aTKDataGridViewTextBoxColumn
            // 
            this.aTKDataGridViewTextBoxColumn.DataPropertyName = "ATK";
            this.aTKDataGridViewTextBoxColumn.HeaderText = "ATK";
            this.aTKDataGridViewTextBoxColumn.Name = "aTKDataGridViewTextBoxColumn";
            // 
            // soulboundWeaponDataGridViewTextBoxColumn
            // 
            this.soulboundWeaponDataGridViewTextBoxColumn.DataPropertyName = "SoulboundWeapon";
            this.soulboundWeaponDataGridViewTextBoxColumn.HeaderText = "SoulboundWeapon";
            this.soulboundWeaponDataGridViewTextBoxColumn.Name = "soulboundWeaponDataGridViewTextBoxColumn";
            // 
            // contractDataGridViewTextBoxColumn
            // 
            this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
            this.contractDataGridViewTextBoxColumn.HeaderText = "Contract";
            this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
            // 
            // factionDataGridViewTextBoxColumn
            // 
            this.factionDataGridViewTextBoxColumn.DataPropertyName = "Faction";
            this.factionDataGridViewTextBoxColumn.HeaderText = "Faction";
            this.factionDataGridViewTextBoxColumn.Name = "factionDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataMember = "Hero";
            this.heroBindingSource.DataSource = this.zhengruiDataSet2;
            // 
            // zhengruiDataSet2
            // 
            this.zhengruiDataSet2.DataSetName = "zhengruiDataSet2";
            this.zhengruiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HeroName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SoulboundWeapon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ATK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-231, -130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contract:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Faction:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Class:";
            // 
            // heroTableAdapter
            // 
            this.heroTableAdapter.ClearBeforeFill = true;
            // 
            // HeroSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HeroSearch";
            this.Text = "HeroSearch";
            this.Load += new System.EventHandler(this.HeroSearch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhengruiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtFaction;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.TextBox txtSoulboundWeapon;
        private System.Windows.Forms.TextBox txtATK;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtHeroName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView results;
        private zhengruiDataSet2 zhengruiDataSet2;
        private System.Windows.Forms.BindingSource heroBindingSource;
        private zhengruiDataSet2TableAdapters.HeroTableAdapter heroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn heroIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heroNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soulboundWeaponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
    }
}