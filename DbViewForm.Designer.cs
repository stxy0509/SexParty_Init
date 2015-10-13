namespace JqpdInit
{
    partial class DbViewForm
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
            if(disposing && (components != null))
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
            this.dataTable = new System.Windows.Forms.ListView();
            this.clearButton = new System.Windows.Forms.Button();
            this.firstPage = new System.Windows.Forms.Button();
            this.lastPage = new System.Windows.Forms.Button();
            this.prevPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataTable.Location = new System.Drawing.Point(5, 59);
            this.dataTable.Margin = new System.Windows.Forms.Padding(5);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(555, 532);
            this.dataTable.TabIndex = 0;
            this.dataTable.UseCompatibleStateImageBehavior = false;
            // 
            // clearButton
            // 
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(12, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 39);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "清除记录";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // firstPage
            // 
            this.firstPage.Location = new System.Drawing.Point(139, 12);
            this.firstPage.Name = "firstPage";
            this.firstPage.Size = new System.Drawing.Size(79, 39);
            this.firstPage.TabIndex = 2;
            this.firstPage.Text = "第一页";
            this.firstPage.UseVisualStyleBackColor = true;
            this.firstPage.Click += new System.EventHandler(this.firstPage_Click);
            // 
            // lastPage
            // 
            this.lastPage.Location = new System.Drawing.Point(224, 12);
            this.lastPage.Name = "lastPage";
            this.lastPage.Size = new System.Drawing.Size(97, 39);
            this.lastPage.TabIndex = 3;
            this.lastPage.Text = "最后一页";
            this.lastPage.UseVisualStyleBackColor = true;
            this.lastPage.Click += new System.EventHandler(this.lastPage_Click);
            // 
            // prevPage
            // 
            this.prevPage.Location = new System.Drawing.Point(374, 12);
            this.prevPage.Name = "prevPage";
            this.prevPage.Size = new System.Drawing.Size(92, 39);
            this.prevPage.TabIndex = 4;
            this.prevPage.Text = "上一页";
            this.prevPage.UseVisualStyleBackColor = true;
            this.prevPage.Click += new System.EventHandler(this.prevPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(472, 12);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(88, 39);
            this.nextPage.TabIndex = 5;
            this.nextPage.Text = "下一页";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // DbViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 500);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.prevPage);
            this.Controls.Add(this.lastPage);
            this.Controls.Add(this.firstPage);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dataTable);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DbViewForm";
            this.Text = "保存记录";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dataTable;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button firstPage;
        private System.Windows.Forms.Button lastPage;
        private System.Windows.Forms.Button prevPage;
        private System.Windows.Forms.Button nextPage;
    }
}