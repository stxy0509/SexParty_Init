namespace JqpdInit
{
    partial class TX_Form
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
            this.saveButton = new System.Windows.Forms.Button();
            this.typeButton = new System.Windows.Forms.Button();
            this.ln1Button = new System.Windows.Forms.Button();
            this.mn1Button = new System.Windows.Forms.Button();
            this.ln2Button = new System.Windows.Forms.Button();
            this.ln3Button = new System.Windows.Forms.Button();
            this.mn2Button = new System.Windows.Forms.Button();
            this.mn3Button = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.startNumTB = new System.Windows.Forms.TextBox();
            this.decButton = new System.Windows.Forms.Button();
            this.currentNumLabel = new System.Windows.Forms.Label();
            this.startNumLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.timeList = new System.Windows.Forms.ComboBox();
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
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.ForeColor = System.Drawing.Color.Blue;
            this.saveButton.Location = new System.Drawing.Point(107, 253);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 64);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            // ln1Button
            // 
            this.ln1Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln1Button.Location = new System.Drawing.Point(108, 144);
            this.ln1Button.Margin = new System.Windows.Forms.Padding(4);
            this.ln1Button.Name = "ln1Button";
            this.ln1Button.Size = new System.Drawing.Size(43, 43);
            this.ln1Button.TabIndex = 8;
            this.ln1Button.Text = "1";
            this.ln1Button.UseVisualStyleBackColor = true;
            this.ln1Button.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // mn1Button
            // 
            this.mn1Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn1Button.Location = new System.Drawing.Point(107, 201);
            this.mn1Button.Margin = new System.Windows.Forms.Padding(4);
            this.mn1Button.Name = "mn1Button";
            this.mn1Button.Size = new System.Drawing.Size(43, 43);
            this.mn1Button.TabIndex = 11;
            this.mn1Button.Text = "1";
            this.mn1Button.UseVisualStyleBackColor = true;
            this.mn1Button.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // ln2Button
            // 
            this.ln2Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln2Button.Location = new System.Drawing.Point(164, 143);
            this.ln2Button.Margin = new System.Windows.Forms.Padding(4);
            this.ln2Button.Name = "ln2Button";
            this.ln2Button.Size = new System.Drawing.Size(43, 43);
            this.ln2Button.TabIndex = 8;
            this.ln2Button.Text = "0";
            this.ln2Button.UseVisualStyleBackColor = true;
            this.ln2Button.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // ln3Button
            // 
            this.ln3Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln3Button.Location = new System.Drawing.Point(221, 143);
            this.ln3Button.Margin = new System.Windows.Forms.Padding(4);
            this.ln3Button.Name = "ln3Button";
            this.ln3Button.Size = new System.Drawing.Size(43, 43);
            this.ln3Button.TabIndex = 8;
            this.ln3Button.Text = "0";
            this.ln3Button.UseVisualStyleBackColor = true;
            this.ln3Button.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // mn2Button
            // 
            this.mn2Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn2Button.Location = new System.Drawing.Point(164, 199);
            this.mn2Button.Margin = new System.Windows.Forms.Padding(4);
            this.mn2Button.Name = "mn2Button";
            this.mn2Button.Size = new System.Drawing.Size(43, 43);
            this.mn2Button.TabIndex = 11;
            this.mn2Button.Text = "2";
            this.mn2Button.UseVisualStyleBackColor = true;
            this.mn2Button.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // mn3Button
            // 
            this.mn3Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn3Button.Location = new System.Drawing.Point(221, 199);
            this.mn3Button.Margin = new System.Windows.Forms.Padding(4);
            this.mn3Button.Name = "mn3Button";
            this.mn3Button.Size = new System.Drawing.Size(43, 43);
            this.mn3Button.TabIndex = 11;
            this.mn3Button.Text = " 3";
            this.mn3Button.UseVisualStyleBackColor = true;
            this.mn3Button.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(298, 253);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(129, 64);
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
            // decButton
            // 
            this.decButton.Location = new System.Drawing.Point(484, 82);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(61, 39);
            this.decButton.TabIndex = 17;
            this.decButton.Text = "减一";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.MinusOneButton_Click);
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
            // TX_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(557, 373);
            this.Controls.Add(this.timeList);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.startNumTB);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.mn2Button);
            this.Controls.Add(this.mn3Button);
            this.Controls.Add(this.mn1Button);
            this.Controls.Add(this.ln3Button);
            this.Controls.Add(this.ln2Button);
            this.Controls.Add(this.ln1Button);
            this.Controls.Add(this.typeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.currentNumLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.startNumLabel);
            this.Controls.Add(this.machineNumLabel);
            this.Controls.Add(this.lineNumLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.typeLabel);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TX_Form";
            this.Text = "激情派对初始化";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TxForm_Closed);
            this.Load += new System.EventHandler(this.TxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label lineNumLabel;
        private System.Windows.Forms.Label machineNumLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button typeButton;
        private System.Windows.Forms.Button ln1Button;
        private System.Windows.Forms.Button mn1Button;
        private System.Windows.Forms.Button ln2Button;
        private System.Windows.Forms.Button ln3Button;
        private System.Windows.Forms.Button mn2Button;
        private System.Windows.Forms.Button mn3Button;
        private System.Windows.Forms.Button viewButton;
        public System.Windows.Forms.TextBox startNumTB;
        private System.Windows.Forms.Button decButton;
        public System.Windows.Forms.Label currentNumLabel;
        private System.Windows.Forms.Label startNumLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.ComboBox timeList;
    }
}

