namespace ICApiAddin.icAPI_Sample_CS
{
    partial class SampleSceneTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleSceneTree));
            this.treeGridViewScene = new AdvancedDataGridView.TreeGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Scene = new AdvancedDataGridView.TreeGridColumn();
            this.SystemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExternalLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BomPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BomDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOutputCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treeGridViewScene)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeGridViewScene
            // 
            this.treeGridViewScene.AllowUserToAddRows = false;
            this.treeGridViewScene.AllowUserToDeleteRows = false;
            this.treeGridViewScene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.treeGridViewScene.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.treeGridViewScene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Scene,
            this.SystemName,
            this.ID,
            this.DataType,
            this.Depth,
            this.ExternalLink,
            this.BomPartNumber,
            this.BomDescription});
            this.treeGridViewScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeGridViewScene.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.treeGridViewScene.ImageList = null;
            this.treeGridViewScene.Location = new System.Drawing.Point(2, 2);
            this.treeGridViewScene.Margin = new System.Windows.Forms.Padding(2);
            this.treeGridViewScene.Name = "treeGridViewScene";
            this.treeGridViewScene.Size = new System.Drawing.Size(700, 741);
            this.treeGridViewScene.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.treeGridViewScene, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 745);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Scene
            // 
            this.Scene.DefaultNodeImage = null;
            this.Scene.HeaderText = "シーン";
            this.Scene.Name = "Scene";
            this.Scene.ReadOnly = true;
            this.Scene.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SystemName
            // 
            this.SystemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SystemName.FillWeight = 80F;
            this.SystemName.HeaderText = "システム名";
            this.SystemName.Name = "SystemName";
            this.SystemName.ReadOnly = true;
            this.SystemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SystemName.Width = 61;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 22;
            // 
            // DataType
            // 
            this.DataType.FillWeight = 80F;
            this.DataType.HeaderText = "データ種別";
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Depth
            // 
            this.Depth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Depth.FillWeight = 30F;
            this.Depth.HeaderText = "深さ";
            this.Depth.Name = "Depth";
            this.Depth.ReadOnly = true;
            this.Depth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Depth.Width = 31;
            // 
            // ExternalLink
            // 
            this.ExternalLink.FillWeight = 80F;
            this.ExternalLink.HeaderText = "外部リンク";
            this.ExternalLink.Name = "ExternalLink";
            this.ExternalLink.ReadOnly = true;
            this.ExternalLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BomPartNumber
            // 
            this.BomPartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BomPartNumber.HeaderText = "パーツ番号";
            this.BomPartNumber.Name = "BomPartNumber";
            this.BomPartNumber.ReadOnly = true;
            this.BomPartNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BomPartNumber.Width = 64;
            // 
            // BomDescription
            // 
            this.BomDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BomDescription.HeaderText = "説明";
            this.BomDescription.Name = "BomDescription";
            this.BomDescription.ReadOnly = true;
            this.BomDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BomDescription.Width = 35;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonOutputCSV, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(707, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonOutputCSV
            // 
            this.buttonOutputCSV.Location = new System.Drawing.Point(3, 3);
            this.buttonOutputCSV.Name = "buttonOutputCSV";
            this.buttonOutputCSV.Size = new System.Drawing.Size(118, 30);
            this.buttonOutputCSV.TabIndex = 0;
            this.buttonOutputCSV.Text = "CSVファイルへ出力";
            this.buttonOutputCSV.UseVisualStyleBackColor = true;
            this.buttonOutputCSV.Click += new System.EventHandler(this.buttonOutputCSV_Click);
            // 
            // SampleSceneTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SampleSceneTree";
            this.Text = "SampleSceneTree";
            this.Load += new System.EventHandler(this.SampleSceneTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeGridViewScene)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdvancedDataGridView.TreeGridView treeGridViewScene;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AdvancedDataGridView.TreeGridColumn Scene;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExternalLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn BomPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BomDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonOutputCSV;
    }
}