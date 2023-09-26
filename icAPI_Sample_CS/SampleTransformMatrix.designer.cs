namespace ICApiAddin.icAPI_Sample_CS
{
    partial class SampleTransformMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleTransformMatrix));
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarAngleX = new System.Windows.Forms.TrackBar();
            this.buttonSetTransform = new System.Windows.Forms.Button();
            this.buttonResetAngleZ = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAngleX = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMatrix44_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix43_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix42_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix41_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix34_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix33_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix32_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix31_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix24_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix23_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix22_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix21_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix14_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix13_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix12_1 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix11_1 = new System.Windows.Forms.TextBox();
            this.buttonResetAngleY = new System.Windows.Forms.Button();
            this.textBoxAngleY = new System.Windows.Forms.TextBox();
            this.buttonResetAngleX = new System.Windows.Forms.Button();
            this.trackBarAngleY = new System.Windows.Forms.TrackBar();
            this.trackBarAngleZ = new System.Windows.Forms.TrackBar();
            this.textBoxAngleZ = new System.Windows.Forms.TextBox();
            this.buttonGetCurrentMatrix = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMatrix44 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix43 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix42 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix41 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix34 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix33 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix32 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix31 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix24 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix23 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix22 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix21 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix14 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix13 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix12 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix11 = new System.Windows.Forms.TextBox();
            this.buttonResetRotate = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleX)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleZ)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(537, 523);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 21);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(7, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(614, 510);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.buttonGetCurrentMatrix);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(606, 484);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "MatrixSample";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonResetRotate);
            this.groupBox1.Controls.Add(this.trackBarAngleX);
            this.groupBox1.Controls.Add(this.buttonSetTransform);
            this.groupBox1.Controls.Add(this.buttonResetAngleZ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxAngleX);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.buttonResetAngleY);
            this.groupBox1.Controls.Add(this.textBoxAngleY);
            this.groupBox1.Controls.Add(this.buttonResetAngleX);
            this.groupBox1.Controls.Add(this.trackBarAngleY);
            this.groupBox1.Controls.Add(this.trackBarAngleZ);
            this.groupBox1.Controls.Add(this.textBoxAngleZ);
            this.groupBox1.Location = new System.Drawing.Point(27, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 266);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "変更後の情報";
            // 
            // trackBarAngleX
            // 
            this.trackBarAngleX.Location = new System.Drawing.Point(225, 29);
            this.trackBarAngleX.Maximum = 180;
            this.trackBarAngleX.Minimum = -180;
            this.trackBarAngleX.Name = "trackBarAngleX";
            this.trackBarAngleX.Size = new System.Drawing.Size(216, 45);
            this.trackBarAngleX.TabIndex = 11;
            this.trackBarAngleX.TickFrequency = 15;
            this.trackBarAngleX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarAngleX.Scroll += new System.EventHandler(this.trackBarAngle_Scroll);
            // 
            // buttonSetTransform
            // 
            this.buttonSetTransform.Location = new System.Drawing.Point(372, 215);
            this.buttonSetTransform.Name = "buttonSetTransform";
            this.buttonSetTransform.Size = new System.Drawing.Size(134, 33);
            this.buttonSetTransform.TabIndex = 9;
            this.buttonSetTransform.Text = "変更後のMatrixを適用";
            this.buttonSetTransform.UseVisualStyleBackColor = true;
            this.buttonSetTransform.Click += new System.EventHandler(this.buttonSetTransform_Click);
            // 
            // buttonResetAngleZ
            // 
            this.buttonResetAngleZ.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonResetAngleZ.Location = new System.Drawing.Point(447, 182);
            this.buttonResetAngleZ.Name = "buttonResetAngleZ";
            this.buttonResetAngleZ.Size = new System.Drawing.Size(59, 19);
            this.buttonResetAngleZ.TabIndex = 20;
            this.buttonResetAngleZ.Text = "0にリセット";
            this.buttonResetAngleZ.UseVisualStyleBackColor = true;
            this.buttonResetAngleZ.Click += new System.EventHandler(this.buttonResetAngleZ_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "変更後のMatrix";
            // 
            // textBoxAngleX
            // 
            this.textBoxAngleX.Location = new System.Drawing.Point(447, 29);
            this.textBoxAngleX.Name = "textBoxAngleX";
            this.textBoxAngleX.Size = new System.Drawing.Size(59, 19);
            this.textBoxAngleX.TabIndex = 4;
            this.textBoxAngleX.Text = "0";
            this.textBoxAngleX.TextChanged += new System.EventHandler(this.textBoxAngleX_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix44_1, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix43_1, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix42_1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix41_1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix34_1, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix33_1, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix32_1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix31_1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix24_1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix23_1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix22_1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix21_1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix14_1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix13_1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix12_1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMatrix11_1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 140);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // textBoxMatrix44_1
            // 
            this.textBoxMatrix44_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix44_1.Location = new System.Drawing.Point(155, 113);
            this.textBoxMatrix44_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix44_1.Name = "textBoxMatrix44_1";
            this.textBoxMatrix44_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix44_1.TabIndex = 15;
            // 
            // textBoxMatrix43_1
            // 
            this.textBoxMatrix43_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix43_1.Location = new System.Drawing.Point(105, 113);
            this.textBoxMatrix43_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix43_1.Name = "textBoxMatrix43_1";
            this.textBoxMatrix43_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix43_1.TabIndex = 14;
            // 
            // textBoxMatrix42_1
            // 
            this.textBoxMatrix42_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix42_1.Location = new System.Drawing.Point(55, 113);
            this.textBoxMatrix42_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix42_1.Name = "textBoxMatrix42_1";
            this.textBoxMatrix42_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix42_1.TabIndex = 13;
            // 
            // textBoxMatrix41_1
            // 
            this.textBoxMatrix41_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix41_1.Location = new System.Drawing.Point(5, 113);
            this.textBoxMatrix41_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix41_1.Name = "textBoxMatrix41_1";
            this.textBoxMatrix41_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix41_1.TabIndex = 12;
            // 
            // textBoxMatrix34_1
            // 
            this.textBoxMatrix34_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix34_1.Location = new System.Drawing.Point(155, 78);
            this.textBoxMatrix34_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix34_1.Name = "textBoxMatrix34_1";
            this.textBoxMatrix34_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix34_1.TabIndex = 11;
            // 
            // textBoxMatrix33_1
            // 
            this.textBoxMatrix33_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix33_1.Location = new System.Drawing.Point(105, 78);
            this.textBoxMatrix33_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix33_1.Name = "textBoxMatrix33_1";
            this.textBoxMatrix33_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix33_1.TabIndex = 10;
            // 
            // textBoxMatrix32_1
            // 
            this.textBoxMatrix32_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix32_1.Location = new System.Drawing.Point(55, 78);
            this.textBoxMatrix32_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix32_1.Name = "textBoxMatrix32_1";
            this.textBoxMatrix32_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix32_1.TabIndex = 9;
            // 
            // textBoxMatrix31_1
            // 
            this.textBoxMatrix31_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix31_1.Location = new System.Drawing.Point(5, 78);
            this.textBoxMatrix31_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix31_1.Name = "textBoxMatrix31_1";
            this.textBoxMatrix31_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix31_1.TabIndex = 8;
            // 
            // textBoxMatrix24_1
            // 
            this.textBoxMatrix24_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix24_1.Location = new System.Drawing.Point(155, 43);
            this.textBoxMatrix24_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix24_1.Name = "textBoxMatrix24_1";
            this.textBoxMatrix24_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix24_1.TabIndex = 7;
            // 
            // textBoxMatrix23_1
            // 
            this.textBoxMatrix23_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix23_1.Location = new System.Drawing.Point(105, 43);
            this.textBoxMatrix23_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix23_1.Name = "textBoxMatrix23_1";
            this.textBoxMatrix23_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix23_1.TabIndex = 6;
            // 
            // textBoxMatrix22_1
            // 
            this.textBoxMatrix22_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix22_1.Location = new System.Drawing.Point(55, 43);
            this.textBoxMatrix22_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix22_1.Name = "textBoxMatrix22_1";
            this.textBoxMatrix22_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix22_1.TabIndex = 5;
            // 
            // textBoxMatrix21_1
            // 
            this.textBoxMatrix21_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix21_1.Location = new System.Drawing.Point(5, 43);
            this.textBoxMatrix21_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix21_1.Name = "textBoxMatrix21_1";
            this.textBoxMatrix21_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix21_1.TabIndex = 4;
            // 
            // textBoxMatrix14_1
            // 
            this.textBoxMatrix14_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix14_1.Location = new System.Drawing.Point(155, 8);
            this.textBoxMatrix14_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix14_1.Name = "textBoxMatrix14_1";
            this.textBoxMatrix14_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix14_1.TabIndex = 3;
            // 
            // textBoxMatrix13_1
            // 
            this.textBoxMatrix13_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix13_1.Location = new System.Drawing.Point(105, 8);
            this.textBoxMatrix13_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix13_1.Name = "textBoxMatrix13_1";
            this.textBoxMatrix13_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix13_1.TabIndex = 2;
            // 
            // textBoxMatrix12_1
            // 
            this.textBoxMatrix12_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix12_1.Location = new System.Drawing.Point(55, 8);
            this.textBoxMatrix12_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix12_1.Name = "textBoxMatrix12_1";
            this.textBoxMatrix12_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix12_1.TabIndex = 1;
            // 
            // textBoxMatrix11_1
            // 
            this.textBoxMatrix11_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix11_1.Location = new System.Drawing.Point(5, 8);
            this.textBoxMatrix11_1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix11_1.Name = "textBoxMatrix11_1";
            this.textBoxMatrix11_1.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix11_1.TabIndex = 0;
            // 
            // buttonResetAngleY
            // 
            this.buttonResetAngleY.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonResetAngleY.Location = new System.Drawing.Point(447, 118);
            this.buttonResetAngleY.Name = "buttonResetAngleY";
            this.buttonResetAngleY.Size = new System.Drawing.Size(59, 19);
            this.buttonResetAngleY.TabIndex = 19;
            this.buttonResetAngleY.Text = "0にリセット";
            this.buttonResetAngleY.UseVisualStyleBackColor = true;
            this.buttonResetAngleY.Click += new System.EventHandler(this.buttonResetAngleY_Click);
            // 
            // textBoxAngleY
            // 
            this.textBoxAngleY.Location = new System.Drawing.Point(447, 92);
            this.textBoxAngleY.Name = "textBoxAngleY";
            this.textBoxAngleY.Size = new System.Drawing.Size(59, 19);
            this.textBoxAngleY.TabIndex = 12;
            this.textBoxAngleY.Text = "0";
            this.textBoxAngleY.TextChanged += new System.EventHandler(this.textBoxAngleY_TextChanged);
            // 
            // buttonResetAngleX
            // 
            this.buttonResetAngleX.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonResetAngleX.Location = new System.Drawing.Point(447, 55);
            this.buttonResetAngleX.Name = "buttonResetAngleX";
            this.buttonResetAngleX.Size = new System.Drawing.Size(59, 19);
            this.buttonResetAngleX.TabIndex = 18;
            this.buttonResetAngleX.Text = "0にリセット";
            this.buttonResetAngleX.UseVisualStyleBackColor = true;
            this.buttonResetAngleX.Click += new System.EventHandler(this.buttonResetAngleX_Click);
            // 
            // trackBarAngleY
            // 
            this.trackBarAngleY.Location = new System.Drawing.Point(225, 92);
            this.trackBarAngleY.Maximum = 180;
            this.trackBarAngleY.Minimum = -180;
            this.trackBarAngleY.Name = "trackBarAngleY";
            this.trackBarAngleY.Size = new System.Drawing.Size(216, 45);
            this.trackBarAngleY.TabIndex = 14;
            this.trackBarAngleY.TickFrequency = 15;
            this.trackBarAngleY.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarAngleY.Scroll += new System.EventHandler(this.trackBarAngleY_Scroll);
            // 
            // trackBarAngleZ
            // 
            this.trackBarAngleZ.Location = new System.Drawing.Point(225, 157);
            this.trackBarAngleZ.Maximum = 180;
            this.trackBarAngleZ.Minimum = -180;
            this.trackBarAngleZ.Name = "trackBarAngleZ";
            this.trackBarAngleZ.Size = new System.Drawing.Size(216, 45);
            this.trackBarAngleZ.TabIndex = 17;
            this.trackBarAngleZ.TickFrequency = 15;
            this.trackBarAngleZ.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarAngleZ.Scroll += new System.EventHandler(this.trackBarAngleZ_Scroll);
            // 
            // textBoxAngleZ
            // 
            this.textBoxAngleZ.Location = new System.Drawing.Point(447, 157);
            this.textBoxAngleZ.Name = "textBoxAngleZ";
            this.textBoxAngleZ.Size = new System.Drawing.Size(59, 19);
            this.textBoxAngleZ.TabIndex = 15;
            this.textBoxAngleZ.Text = "0";
            this.textBoxAngleZ.TextChanged += new System.EventHandler(this.textBoxAngleZ_TextChanged);
            // 
            // buttonGetCurrentMatrix
            // 
            this.buttonGetCurrentMatrix.Location = new System.Drawing.Point(252, 31);
            this.buttonGetCurrentMatrix.Name = "buttonGetCurrentMatrix";
            this.buttonGetCurrentMatrix.Size = new System.Drawing.Size(117, 35);
            this.buttonGetCurrentMatrix.TabIndex = 2;
            this.buttonGetCurrentMatrix.Text = "現在のMatrixを取得";
            this.buttonGetCurrentMatrix.UseVisualStyleBackColor = true;
            this.buttonGetCurrentMatrix.Click += new System.EventHandler(this.buttonGetCurrentMatrix_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "現在のMatrix";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix44, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix43, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix42, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix41, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix34, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix33, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix32, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix31, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix24, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix23, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix22, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix21, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix14, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrix11, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxMatrix44
            // 
            this.textBoxMatrix44.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix44.Location = new System.Drawing.Point(155, 113);
            this.textBoxMatrix44.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix44.Name = "textBoxMatrix44";
            this.textBoxMatrix44.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix44.TabIndex = 15;
            // 
            // textBoxMatrix43
            // 
            this.textBoxMatrix43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix43.Location = new System.Drawing.Point(105, 113);
            this.textBoxMatrix43.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix43.Name = "textBoxMatrix43";
            this.textBoxMatrix43.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix43.TabIndex = 14;
            // 
            // textBoxMatrix42
            // 
            this.textBoxMatrix42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix42.Location = new System.Drawing.Point(55, 113);
            this.textBoxMatrix42.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix42.Name = "textBoxMatrix42";
            this.textBoxMatrix42.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix42.TabIndex = 13;
            // 
            // textBoxMatrix41
            // 
            this.textBoxMatrix41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix41.Location = new System.Drawing.Point(5, 113);
            this.textBoxMatrix41.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix41.Name = "textBoxMatrix41";
            this.textBoxMatrix41.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix41.TabIndex = 12;
            // 
            // textBoxMatrix34
            // 
            this.textBoxMatrix34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix34.Location = new System.Drawing.Point(155, 78);
            this.textBoxMatrix34.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix34.Name = "textBoxMatrix34";
            this.textBoxMatrix34.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix34.TabIndex = 11;
            // 
            // textBoxMatrix33
            // 
            this.textBoxMatrix33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix33.Location = new System.Drawing.Point(105, 78);
            this.textBoxMatrix33.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix33.Name = "textBoxMatrix33";
            this.textBoxMatrix33.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix33.TabIndex = 10;
            // 
            // textBoxMatrix32
            // 
            this.textBoxMatrix32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix32.Location = new System.Drawing.Point(55, 78);
            this.textBoxMatrix32.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix32.Name = "textBoxMatrix32";
            this.textBoxMatrix32.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix32.TabIndex = 9;
            // 
            // textBoxMatrix31
            // 
            this.textBoxMatrix31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix31.Location = new System.Drawing.Point(5, 78);
            this.textBoxMatrix31.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix31.Name = "textBoxMatrix31";
            this.textBoxMatrix31.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix31.TabIndex = 8;
            // 
            // textBoxMatrix24
            // 
            this.textBoxMatrix24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix24.Location = new System.Drawing.Point(155, 43);
            this.textBoxMatrix24.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix24.Name = "textBoxMatrix24";
            this.textBoxMatrix24.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix24.TabIndex = 7;
            // 
            // textBoxMatrix23
            // 
            this.textBoxMatrix23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix23.Location = new System.Drawing.Point(105, 43);
            this.textBoxMatrix23.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix23.Name = "textBoxMatrix23";
            this.textBoxMatrix23.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix23.TabIndex = 6;
            // 
            // textBoxMatrix22
            // 
            this.textBoxMatrix22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix22.Location = new System.Drawing.Point(55, 43);
            this.textBoxMatrix22.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix22.Name = "textBoxMatrix22";
            this.textBoxMatrix22.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix22.TabIndex = 5;
            // 
            // textBoxMatrix21
            // 
            this.textBoxMatrix21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix21.Location = new System.Drawing.Point(5, 43);
            this.textBoxMatrix21.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix21.Name = "textBoxMatrix21";
            this.textBoxMatrix21.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix21.TabIndex = 4;
            // 
            // textBoxMatrix14
            // 
            this.textBoxMatrix14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix14.Location = new System.Drawing.Point(155, 8);
            this.textBoxMatrix14.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix14.Name = "textBoxMatrix14";
            this.textBoxMatrix14.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix14.TabIndex = 3;
            // 
            // textBoxMatrix13
            // 
            this.textBoxMatrix13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix13.Location = new System.Drawing.Point(105, 8);
            this.textBoxMatrix13.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix13.Name = "textBoxMatrix13";
            this.textBoxMatrix13.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix13.TabIndex = 2;
            // 
            // textBoxMatrix12
            // 
            this.textBoxMatrix12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix12.Location = new System.Drawing.Point(55, 8);
            this.textBoxMatrix12.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix12.Name = "textBoxMatrix12";
            this.textBoxMatrix12.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix12.TabIndex = 1;
            // 
            // textBoxMatrix11
            // 
            this.textBoxMatrix11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatrix11.Location = new System.Drawing.Point(5, 8);
            this.textBoxMatrix11.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMatrix11.Name = "textBoxMatrix11";
            this.textBoxMatrix11.Size = new System.Drawing.Size(40, 19);
            this.textBoxMatrix11.TabIndex = 0;
            // 
            // buttonResetRotate
            // 
            this.buttonResetRotate.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonResetRotate.Location = new System.Drawing.Point(127, 182);
            this.buttonResetRotate.Name = "buttonResetRotate";
            this.buttonResetRotate.Size = new System.Drawing.Size(81, 19);
            this.buttonResetRotate.TabIndex = 21;
            this.buttonResetRotate.Text = "回転をリセット";
            this.buttonResetRotate.UseVisualStyleBackColor = true;
            this.buttonResetRotate.Click += new System.EventHandler(this.buttonResetRotate_Click);
            // 
            // SampleTransformMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 560);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.buttonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SampleTransformMatrix";
            this.Text = "SampleTransformMatrix";
            this.TopMost = true;
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleX)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleZ)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxMatrix44;
        private System.Windows.Forms.TextBox textBoxMatrix43;
        private System.Windows.Forms.TextBox textBoxMatrix42;
        private System.Windows.Forms.TextBox textBoxMatrix41;
        private System.Windows.Forms.TextBox textBoxMatrix34;
        private System.Windows.Forms.TextBox textBoxMatrix33;
        private System.Windows.Forms.TextBox textBoxMatrix32;
        private System.Windows.Forms.TextBox textBoxMatrix31;
        private System.Windows.Forms.TextBox textBoxMatrix24;
        private System.Windows.Forms.TextBox textBoxMatrix23;
        private System.Windows.Forms.TextBox textBoxMatrix22;
        private System.Windows.Forms.TextBox textBoxMatrix21;
        private System.Windows.Forms.TextBox textBoxMatrix14;
        private System.Windows.Forms.TextBox textBoxMatrix13;
        private System.Windows.Forms.TextBox textBoxMatrix12;
        private System.Windows.Forms.TextBox textBoxMatrix11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGetCurrentMatrix;
        private System.Windows.Forms.TextBox textBoxAngleX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxMatrix44_1;
        private System.Windows.Forms.TextBox textBoxMatrix43_1;
        private System.Windows.Forms.TextBox textBoxMatrix42_1;
        private System.Windows.Forms.TextBox textBoxMatrix41_1;
        private System.Windows.Forms.TextBox textBoxMatrix34_1;
        private System.Windows.Forms.TextBox textBoxMatrix33_1;
        private System.Windows.Forms.TextBox textBoxMatrix32_1;
        private System.Windows.Forms.TextBox textBoxMatrix31_1;
        private System.Windows.Forms.TextBox textBoxMatrix24_1;
        private System.Windows.Forms.TextBox textBoxMatrix23_1;
        private System.Windows.Forms.TextBox textBoxMatrix22_1;
        private System.Windows.Forms.TextBox textBoxMatrix21_1;
        private System.Windows.Forms.TextBox textBoxMatrix14_1;
        private System.Windows.Forms.TextBox textBoxMatrix13_1;
        private System.Windows.Forms.TextBox textBoxMatrix12_1;
        private System.Windows.Forms.TextBox textBoxMatrix11_1;
        private System.Windows.Forms.Button buttonSetTransform;
        private System.Windows.Forms.TrackBar trackBarAngleX;
        private System.Windows.Forms.TrackBar trackBarAngleZ;
        private System.Windows.Forms.TextBox textBoxAngleZ;
        private System.Windows.Forms.TrackBar trackBarAngleY;
        private System.Windows.Forms.TextBox textBoxAngleY;
        private System.Windows.Forms.Button buttonResetAngleZ;
        private System.Windows.Forms.Button buttonResetAngleY;
        private System.Windows.Forms.Button buttonResetAngleX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonResetRotate;
    }
}