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
            this.Scene = new AdvancedDataGridView.TreeGridColumn();
            this.SystemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExternalLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.treeGridViewScene)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.ExternalLink});
            this.treeGridViewScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeGridViewScene.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.treeGridViewScene.ImageList = null;
            this.treeGridViewScene.Location = new System.Drawing.Point(2, 2);
            this.treeGridViewScene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeGridViewScene.Name = "treeGridViewScene";
            this.treeGridViewScene.Size = new System.Drawing.Size(593, 741);
            this.treeGridViewScene.TabIndex = 0;
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
            this.SystemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SystemName.FillWeight = 80F;
            this.SystemName.HeaderText = "システム名";
            this.SystemName.Name = "SystemName";
            this.SystemName.ReadOnly = true;
            this.SystemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SystemName.Width = 61;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.Depth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.treeGridViewScene, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 745);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SampleSceneTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SampleSceneTree";
            this.Text = "SampleSceneTree";
            this.Load += new System.EventHandler(this.SampleSceneTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeGridViewScene)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
    }
}