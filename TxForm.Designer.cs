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
            this.type = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.lineNum = new System.Windows.Forms.Label();
            this.machineNum = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.typeStr = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Button();
            this.ln1 = new System.Windows.Forms.Button();
            this.mn1 = new System.Windows.Forms.Button();
            this.ln2 = new System.Windows.Forms.Button();
            this.ln3 = new System.Windows.Forms.Button();
            this.mn2 = new System.Windows.Forms.Button();
            this.mn3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Num_Start = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Num_Current = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.Location = new System.Drawing.Point(21, 33);
            this.type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(72, 16);
            this.type.TabIndex = 2;
            this.type.Text = "产品类别";
            this.type.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.Location = new System.Drawing.Point(21, 94);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(72, 16);
            this.time.TabIndex = 2;
            this.time.Text = "打码时间";
            this.time.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // lineNum
            // 
            this.lineNum.AutoSize = true;
            this.lineNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineNum.Location = new System.Drawing.Point(50, 156);
            this.lineNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(40, 16);
            this.lineNum.TabIndex = 2;
            this.lineNum.Text = "线号";
            this.lineNum.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // machineNum
            // 
            this.machineNum.AutoSize = true;
            this.machineNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.machineNum.Location = new System.Drawing.Point(18, 212);
            this.machineNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineNum.Name = "machineNum";
            this.machineNum.Size = new System.Drawing.Size(72, 16);
            this.machineNum.TabIndex = 2;
            this.machineNum.Text = "机台号码";
            this.machineNum.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.ForeColor = System.Drawing.Color.Blue;
            this.save.Location = new System.Drawing.Point(107, 253);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 64);
            this.save.TabIndex = 4;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // typeStr
            // 
            this.typeStr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeStr.Location = new System.Drawing.Point(107, 15);
            this.typeStr.Margin = new System.Windows.Forms.Padding(4);
            this.typeStr.Name = "typeStr";
            this.typeStr.Size = new System.Drawing.Size(120, 53);
            this.typeStr.TabIndex = 6;
            this.typeStr.Text = "公司台";
            this.typeStr.UseVisualStyleBackColor = true;
            this.typeStr.Click += new System.EventHandler(this.SaleTypeButton_Click);
            // 
            // t
            // 
            this.t.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t.Location = new System.Drawing.Point(108, 82);
            this.t.Margin = new System.Windows.Forms.Padding(4);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(120, 41);
            this.t.TabIndex = 7;
            this.t.Text = "20小时";
            this.t.UseVisualStyleBackColor = true;
            this.t.Click += new System.EventHandler(this.CodeTimeButton_Click);
            // 
            // ln1
            // 
            this.ln1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln1.Location = new System.Drawing.Point(108, 144);
            this.ln1.Margin = new System.Windows.Forms.Padding(4);
            this.ln1.Name = "ln1";
            this.ln1.Size = new System.Drawing.Size(43, 43);
            this.ln1.TabIndex = 8;
            this.ln1.Text = "1";
            this.ln1.UseVisualStyleBackColor = true;
            this.ln1.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // mn1
            // 
            this.mn1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn1.Location = new System.Drawing.Point(107, 201);
            this.mn1.Margin = new System.Windows.Forms.Padding(4);
            this.mn1.Name = "mn1";
            this.mn1.Size = new System.Drawing.Size(43, 43);
            this.mn1.TabIndex = 11;
            this.mn1.Text = "1";
            this.mn1.UseVisualStyleBackColor = true;
            this.mn1.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // ln2
            // 
            this.ln2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln2.Location = new System.Drawing.Point(164, 143);
            this.ln2.Margin = new System.Windows.Forms.Padding(4);
            this.ln2.Name = "ln2";
            this.ln2.Size = new System.Drawing.Size(43, 43);
            this.ln2.TabIndex = 8;
            this.ln2.Text = "0";
            this.ln2.UseVisualStyleBackColor = true;
            this.ln2.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // ln3
            // 
            this.ln3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln3.Location = new System.Drawing.Point(221, 143);
            this.ln3.Margin = new System.Windows.Forms.Padding(4);
            this.ln3.Name = "ln3";
            this.ln3.Size = new System.Drawing.Size(43, 43);
            this.ln3.TabIndex = 8;
            this.ln3.Text = "0";
            this.ln3.UseVisualStyleBackColor = true;
            this.ln3.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // mn2
            // 
            this.mn2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn2.Location = new System.Drawing.Point(164, 199);
            this.mn2.Margin = new System.Windows.Forms.Padding(4);
            this.mn2.Name = "mn2";
            this.mn2.Size = new System.Drawing.Size(43, 43);
            this.mn2.TabIndex = 11;
            this.mn2.Text = "2";
            this.mn2.UseVisualStyleBackColor = true;
            this.mn2.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // mn3
            // 
            this.mn3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn3.Location = new System.Drawing.Point(221, 199);
            this.mn3.Margin = new System.Windows.Forms.Padding(4);
            this.mn3.Name = "mn3";
            this.mn3.Size = new System.Drawing.Size(43, 43);
            this.mn3.TabIndex = 11;
            this.mn3.Text = " 3";
            this.mn3.UseVisualStyleBackColor = true;
            this.mn3.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "查看记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DbViewButton_Click);
            // 
            // Num_Start
            // 
            this.Num_Start.Location = new System.Drawing.Point(386, 30);
            this.Num_Start.Name = "Num_Start";
            this.Num_Start.Size = new System.Drawing.Size(100, 26);
            this.Num_Start.TabIndex = 14;
            this.Num_Start.TextChanged += new System.EventHandler(this.StartNum_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "减一";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MinusOneButton_Click);
            // 
            // Num_Current
            // 
            this.Num_Current.AutoSize = true;
            this.Num_Current.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num_Current.Location = new System.Drawing.Point(383, 93);
            this.Num_Current.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num_Current.Name = "Num_Current";
            this.Num_Current.Size = new System.Drawing.Size(16, 16);
            this.Num_Current.TabIndex = 2;
            this.Num_Current.Text = "0";
            this.Num_Current.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(295, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始号码";
            this.label1.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(295, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前号码";
            this.label2.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // TX_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(557, 373);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Num_Start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mn2);
            this.Controls.Add(this.mn3);
            this.Controls.Add(this.mn1);
            this.Controls.Add(this.ln3);
            this.Controls.Add(this.ln2);
            this.Controls.Add(this.ln1);
            this.Controls.Add(this.t);
            this.Controls.Add(this.typeStr);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Num_Current);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machineNum);
            this.Controls.Add(this.lineNum);
            this.Controls.Add(this.time);
            this.Controls.Add(this.type);
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

        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label lineNum;
        private System.Windows.Forms.Label machineNum;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button typeStr;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button ln1;
        private System.Windows.Forms.Button mn1;
        private System.Windows.Forms.Button ln2;
        private System.Windows.Forms.Button ln3;
        private System.Windows.Forms.Button mn2;
        private System.Windows.Forms.Button mn3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Num_Start;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label Num_Current;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

