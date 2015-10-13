namespace JqpdInit
{
    partial class Init_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.typeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.lineNumLabel = new System.Windows.Forms.Label();
            this.machineNumLabel = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.typeButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.startNumTB = new System.Windows.Forms.TextBox();
            this.currentNumLabel = new System.Windows.Forms.Label();
            this.startNumLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.timeList = new System.Windows.Forms.ComboBox();
            this.cbLN1 = new System.Windows.Forms.ComboBox();
            this.cbLN2 = new System.Windows.Forms.ComboBox();
            this.cbLN3 = new System.Windows.Forms.ComboBox();
            this.cbMN1 = new System.Windows.Forms.ComboBox();
            this.cbMN2 = new System.Windows.Forms.ComboBox();
            this.cbMN3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeLabel.Location = new System.Drawing.Point(21, 33);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(72, 16);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "产品类别";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(21, 94);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(72, 16);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "打码时间";
            // 
            // lineNumLabel
            // 
            this.lineNumLabel.AutoSize = true;
            this.lineNumLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineNumLabel.Location = new System.Drawing.Point(50, 156);
            this.lineNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineNumLabel.Name = "lineNumLabel";
            this.lineNumLabel.Size = new System.Drawing.Size(40, 16);
            this.lineNumLabel.TabIndex = 2;
            this.lineNumLabel.Text = "线号";
            // 
            // machineNumLabel
            // 
            this.machineNumLabel.AutoSize = true;
            this.machineNumLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.machineNumLabel.Location = new System.Drawing.Point(18, 212);
            this.machineNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineNumLabel.Name = "machineNumLabel";
            this.machineNumLabel.Size = new System.Drawing.Size(72, 16);
            this.machineNumLabel.TabIndex = 2;
            this.machineNumLabel.Text = "机台号码";
            // 
            // writeButton
            // 
            this.writeButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.writeButton.ForeColor = System.Drawing.Color.Blue;
            this.writeButton.Location = new System.Drawing.Point(107, 253);
            this.writeButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(121, 50);
            this.writeButton.TabIndex = 4;
            this.writeButton.Text = "写入数据";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // typeButton
            // 
            this.typeButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeButton.Location = new System.Drawing.Point(107, 15);
            this.typeButton.Margin = new System.Windows.Forms.Padding(4);
            this.typeButton.Name = "typeButton";
            this.typeButton.Size = new System.Drawing.Size(120, 53);
            this.typeButton.TabIndex = 6;
            this.typeButton.Text = "公司台";
            this.typeButton.UseVisualStyleBackColor = true;
            this.typeButton.Click += new System.EventHandler(this.SaleTypeButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewButton.Location = new System.Drawing.Point(298, 253);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(114, 50);
            this.viewButton.TabIndex = 12;
            this.viewButton.Text = "查看记录";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.DbViewButton_Click);
            // 
            // startNumTB
            // 
            this.startNumTB.Location = new System.Drawing.Point(386, 30);
            this.startNumTB.Name = "startNumTB";
            this.startNumTB.Size = new System.Drawing.Size(100, 26);
            this.startNumTB.TabIndex = 14;
            this.startNumTB.TextChanged += new System.EventHandler(this.StartNum_TextChanged);
            // 
            // currentNumLabel
            // 
            this.currentNumLabel.AutoSize = true;
            this.currentNumLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentNumLabel.Location = new System.Drawing.Point(383, 93);
            this.currentNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentNumLabel.Name = "currentNumLabel";
            this.currentNumLabel.Size = new System.Drawing.Size(16, 16);
            this.currentNumLabel.TabIndex = 2;
            this.currentNumLabel.Text = "0";
            // 
            // startNumLabel
            // 
            this.startNumLabel.AutoSize = true;
            this.startNumLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startNumLabel.Location = new System.Drawing.Point(295, 33);
            this.startNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startNumLabel.Name = "startNumLabel";
            this.startNumLabel.Size = new System.Drawing.Size(72, 16);
            this.startNumLabel.TabIndex = 2;
            this.startNumLabel.Text = "起始号码";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentLabel.Location = new System.Drawing.Point(295, 94);
            this.currentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(72, 16);
            this.currentLabel.TabIndex = 2;
            this.currentLabel.Text = "当前号码";
            // 
            // timeList
            // 
            this.timeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeList.FormattingEnabled = true;
            this.timeList.Items.AddRange(new object[] {
            "20小时",
            "30小时",
            "40小时",
            "50小时",
            "60小时",
            "80小时",
            "100小时",
            "120小时",
            "150小时",
            "180小时"});
            this.timeList.Location = new System.Drawing.Point(107, 91);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(121, 24);
            this.timeList.TabIndex = 18;
            this.timeList.SelectedIndexChanged += new System.EventHandler(this.TimeList_SelectedIndexChanged);
            // 
            // cbLN1
            // 
            this.cbLN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLN1.FormattingEnabled = true;
            this.cbLN1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbLN1.Location = new System.Drawing.Point(107, 153);
            this.cbLN1.Name = "cbLN1";
            this.cbLN1.Size = new System.Drawing.Size(36, 24);
            this.cbLN1.TabIndex = 19;
            this.cbLN1.SelectedIndexChanged += new System.EventHandler(this.lineNumberChanged);
            // 
            // cbLN2
            // 
            this.cbLN2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLN2.FormattingEnabled = true;
            this.cbLN2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbLN2.Location = new System.Drawing.Point(149, 153);
            this.cbLN2.Name = "cbLN2";
            this.cbLN2.Size = new System.Drawing.Size(36, 24);
            this.cbLN2.TabIndex = 19;
            // 
            // cbLN3
            // 
            this.cbLN3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLN3.FormattingEnabled = true;
            this.cbLN3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbLN3.Location = new System.Drawing.Point(191, 153);
            this.cbLN3.Name = "cbLN3";
            this.cbLN3.Size = new System.Drawing.Size(36, 24);
            this.cbLN3.TabIndex = 19;
            // 
            // cbMN1
            // 
            this.cbMN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMN1.FormattingEnabled = true;
            this.cbMN1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbMN1.Location = new System.Drawing.Point(107, 209);
            this.cbMN1.Name = "cbMN1";
            this.cbMN1.Size = new System.Drawing.Size(36, 24);
            this.cbMN1.TabIndex = 19;
            this.cbMN1.SelectedIndexChanged += new System.EventHandler(this.machineNumberChanged);
            // 
            // cbMN2
            // 
            this.cbMN2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMN2.FormattingEnabled = true;
            this.cbMN2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbMN2.Location = new System.Drawing.Point(150, 209);
            this.cbMN2.Name = "cbMN2";
            this.cbMN2.Size = new System.Drawing.Size(36, 24);
            this.cbMN2.TabIndex = 19;
            // 
            // cbMN3
            // 
            this.cbMN3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMN3.FormattingEnabled = true;
            this.cbMN3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbMN3.Location = new System.Drawing.Point(192, 209);
            this.cbMN3.Name = "cbMN3";
            this.cbMN3.Size = new System.Drawing.Size(36, 24);
            this.cbMN3.TabIndex = 19;
            // 
            // Init_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(557, 373);
            this.Controls.Add(this.cbMN3);
            this.Controls.Add(this.cbLN3);
            this.Controls.Add(this.cbMN2);
            this.Controls.Add(this.cbMN1);
            this.Controls.Add(this.cbLN2);
            this.Controls.Add(this.cbLN1);
            this.Controls.Add(this.timeList);
            this.Controls.Add(this.startNumTB);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.typeButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.currentNumLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.startNumLabel);
            this.Controls.Add(this.machineNumLabel);
            this.Controls.Add(this.lineNumLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.typeLabel);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Init_Form";
            this.Text = "激情派对初始化";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InitForm_Closed);
            this.Load += new System.EventHandler(this.TxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label lineNumLabel;
        private System.Windows.Forms.Label machineNumLabel;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button typeButton;
        private System.Windows.Forms.Button viewButton;
        public System.Windows.Forms.TextBox startNumTB;
        public System.Windows.Forms.Label currentNumLabel;
        private System.Windows.Forms.Label startNumLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.ComboBox timeList;
        private System.Windows.Forms.ComboBox cbLN1;
        private System.Windows.Forms.ComboBox cbLN2;
        private System.Windows.Forms.ComboBox cbLN3;
        private System.Windows.Forms.ComboBox cbMN1;
        private System.Windows.Forms.ComboBox cbMN2;
        private System.Windows.Forms.ComboBox cbMN3;
    }
}

