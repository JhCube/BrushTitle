namespace BrushTitle
{
    partial class AddQuestion
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
            this.txtShow = new System.Windows.Forms.TextBox();
            this.gboxType = new System.Windows.Forms.GroupBox();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.gboxIsDrop = new System.Windows.Forms.GroupBox();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnT = new System.Windows.Forms.RadioButton();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gboxName = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.gboxType.SuspendLayout();
            this.gboxIsDrop.SuspendLayout();
            this.gboxName.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShow.Location = new System.Drawing.Point(12, 69);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShow.Size = new System.Drawing.Size(663, 505);
            this.txtShow.TabIndex = 0;
            this.txtShow.Text = "操作步骤：\r\n1.选择所要添加的题型\r\n2.将所要添加的题库复制到此处\r\n3.格式化，并检查题库是否有误";
            // 
            // gboxType
            // 
            this.gboxType.BackColor = System.Drawing.SystemColors.Control;
            this.gboxType.Controls.Add(this.rbtn3);
            this.gboxType.Controls.Add(this.rbtn2);
            this.gboxType.Controls.Add(this.rbtn1);
            this.gboxType.Location = new System.Drawing.Point(12, 12);
            this.gboxType.Name = "gboxType";
            this.gboxType.Size = new System.Drawing.Size(191, 51);
            this.gboxType.TabIndex = 1;
            this.gboxType.TabStop = false;
            this.gboxType.Text = "题型";
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(128, 21);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(47, 16);
            this.rbtn3.TabIndex = 2;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "判断";
            this.rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(75, 21);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(47, 16);
            this.rbtn2.TabIndex = 1;
            this.rbtn2.Text = "多选";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Checked = true;
            this.rbtn1.Location = new System.Drawing.Point(22, 21);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(47, 16);
            this.rbtn1.TabIndex = 0;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "单选";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // gboxIsDrop
            // 
            this.gboxIsDrop.Controls.Add(this.rbtnF);
            this.gboxIsDrop.Controls.Add(this.rbtnT);
            this.gboxIsDrop.Location = new System.Drawing.Point(227, 12);
            this.gboxIsDrop.Name = "gboxIsDrop";
            this.gboxIsDrop.Size = new System.Drawing.Size(104, 51);
            this.gboxIsDrop.TabIndex = 2;
            this.gboxIsDrop.TabStop = false;
            this.gboxIsDrop.Text = "是否去掉序号";
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Checked = true;
            this.rbtnF.Location = new System.Drawing.Point(48, 21);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(35, 16);
            this.rbtnF.TabIndex = 1;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "否";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // rbtnT
            // 
            this.rbtnT.AutoSize = true;
            this.rbtnT.Location = new System.Drawing.Point(7, 21);
            this.rbtnT.Name = "rbtnT";
            this.rbtnT.Size = new System.Drawing.Size(35, 16);
            this.rbtnT.TabIndex = 0;
            this.rbtnT.Text = "是";
            this.rbtnT.UseVisualStyleBackColor = true;
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(285, 586);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(75, 23);
            this.btnFormat.TabIndex = 3;
            this.btnFormat.Text = "格式化";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(161, 586);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(405, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gboxName
            // 
            this.gboxName.Controls.Add(this.textBox1);
            this.gboxName.Controls.Add(this.lblMsg);
            this.gboxName.Location = new System.Drawing.Point(12, 12);
            this.gboxName.Name = "gboxName";
            this.gboxName.Size = new System.Drawing.Size(663, 50);
            this.gboxName.TabIndex = 6;
            this.gboxName.TabStop = false;
            this.gboxName.Text = "输入题库名称";
            this.gboxName.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 21);
            this.textBox1.TabIndex = 1;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(234, 30);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(53, 12);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "请检查！";
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 621);
            this.Controls.Add(this.gboxName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.gboxIsDrop);
            this.Controls.Add(this.gboxType);
            this.Controls.Add(this.txtShow);
            this.Name = "AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天天刷题-增加题库";
            this.gboxType.ResumeLayout(false);
            this.gboxType.PerformLayout();
            this.gboxIsDrop.ResumeLayout(false);
            this.gboxIsDrop.PerformLayout();
            this.gboxName.ResumeLayout(false);
            this.gboxName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.GroupBox gboxType;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.GroupBox gboxIsDrop;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.RadioButton rbtnT;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gboxName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMsg;
    }
}