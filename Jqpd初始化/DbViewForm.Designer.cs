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
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataTable.Location = new System.Drawing.Point(5, 5);
            this.dataTable.Margin = new System.Windows.Forms.Padding(5);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(758, 586);
            this.dataTable.TabIndex = 0;
            this.dataTable.UseCompatibleStateImageBehavior = false;
            this.dataTable.SelectedIndexChanged += new System.EventHandler(this.DataTable_SelectedIndexChanged);
            // 
            // DbViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 464);
            this.Controls.Add(this.dataTable);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DbViewForm";
            this.Text = "保存记录";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dataTable;
    }
}