namespace ICApiAddin.icAPI_Sample_CS
{
    partial class ICToolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ICToolsForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.buttonStartEvent = new System.Windows.Forms.Button();
            this.buttonStopEvent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(355, 322);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 26);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(147, 5);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(308, 26);
            this.lblDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "現在のファイル:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "現在の情報:";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(24, 69);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(431, 149);
            this.lblResult.TabIndex = 4;
            // 
            // buttonStartEvent
            // 
            this.buttonStartEvent.Location = new System.Drawing.Point(287, 229);
            this.buttonStartEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartEvent.Name = "buttonStartEvent";
            this.buttonStartEvent.Size = new System.Drawing.Size(168, 29);
            this.buttonStartEvent.TabIndex = 6;
            this.buttonStartEvent.Text = "イベントハンドラ登録";
            this.buttonStartEvent.UseVisualStyleBackColor = true;
            this.buttonStartEvent.Click += new System.EventHandler(this.buttonStartEvent_Click);
            // 
            // buttonStopEvent
            // 
            this.buttonStopEvent.Location = new System.Drawing.Point(287, 265);
            this.buttonStopEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStopEvent.Name = "buttonStopEvent";
            this.buttonStopEvent.Size = new System.Drawing.Size(168, 29);
            this.buttonStopEvent.TabIndex = 7;
            this.buttonStopEvent.Text = "イベントハンドラ削除";
            this.buttonStopEvent.UseVisualStyleBackColor = true;
            this.buttonStopEvent.Click += new System.EventHandler(this.buttonStopEvent_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 8;
            // 
            // ICToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 364);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStopEvent);
            this.Controls.Add(this.buttonStartEvent);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.buttonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ICToolsForm";
            this.Text = "IRONCAD Addin Sample CS";
            this.Load += new System.EventHandler(this.ICToolsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button buttonStartEvent;
        private System.Windows.Forms.Button buttonStopEvent;
        private System.Windows.Forms.TextBox textBox1;
    }
}