namespace MyAZCopyTool
{
    partial class MyAZCopyTool
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
            this.btnstartcopy = new System.Windows.Forms.Button();
            this.txtbrowse = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.txtStAc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtStKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbContainerName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstartcopy
            // 
            this.btnstartcopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnstartcopy.BackgroundImage = global::MyAZCopyTool.Properties.Resources.copy;
            this.btnstartcopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstartcopy.Location = new System.Drawing.Point(275, 195);
            this.btnstartcopy.Name = "btnstartcopy";
            this.btnstartcopy.Size = new System.Drawing.Size(50, 43);
            this.btnstartcopy.TabIndex = 0;
            this.btnstartcopy.UseVisualStyleBackColor = false;
            this.btnstartcopy.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbrowse
            // 
            this.txtbrowse.Location = new System.Drawing.Point(133, 31);
            this.txtbrowse.Name = "txtbrowse";
            this.txtbrowse.Size = new System.Drawing.Size(276, 20);
            this.txtbrowse.TabIndex = 1;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(446, 29);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 2;
            this.btnbrowse.Text = "Browse ";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtStAc
            // 
            this.txtStAc.Location = new System.Drawing.Point(133, 59);
            this.txtStAc.Name = "txtStAc";
            this.txtStAc.Size = new System.Drawing.Size(276, 20);
            this.txtStAc.TabIndex = 3;
            this.txtStAc.Text = "manasastorage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select On-Premise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Storage Account Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbContainerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnbrowse);
            this.groupBox1.Controls.Add(this.txtbrowse);
            this.groupBox1.Controls.Add(this.txtStAc);
            this.groupBox1.Location = new System.Drawing.Point(38, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtStKey
            // 
            this.txtStKey.Location = new System.Drawing.Point(133, 85);
            this.txtStKey.Name = "txtStKey";
            this.txtStKey.Size = new System.Drawing.Size(388, 20);
            this.txtStKey.TabIndex = 7;
            this.txtStKey.Text = "Qh9w7jHzTtmtOaHytuKhxdAk5PIHhiAyqxP2LQzxRRlYqiABlNpgdAZkfjlecYGW5PWZi+AZAAKgwmnHU" +
    "3KE4Q==";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Storage Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Container Name";
            // 
            // cmbContainerName
            // 
            this.cmbContainerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContainerName.FormattingEnabled = true;
            this.cmbContainerName.Location = new System.Drawing.Point(133, 113);
            this.cmbContainerName.Name = "cmbContainerName";
            this.cmbContainerName.Size = new System.Drawing.Size(276, 21);
            this.cmbContainerName.TabIndex = 11;
            // 
            // MyAZCopyTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyAZCopyTool.Properties.Resources.FormBackgroundImage;
            this.ClientSize = new System.Drawing.Size(613, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstartcopy);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyAZCopyTool";
            this.Text = "MyAZCopyTool";
            this.Load += new System.EventHandler(this.MyAZCopyTool_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstartcopy;
        private System.Windows.Forms.TextBox txtbrowse;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtStAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStKey;
        private System.Windows.Forms.ComboBox cmbContainerName;
    }
}