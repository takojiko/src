namespace Hoimi
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTableReadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReaderReadButton = new System.Windows.Forms.Button();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.InsertCommandButton = new System.Windows.Forms.Button();
            this.UpdateCommandButton = new System.Windows.Forms.Button();
            this.DeleteCommandButton = new System.Windows.Forms.Button();
            this.DapperReadButton = new System.Windows.Forms.Button();
            this.DapperInsertButton = new System.Windows.Forms.Button();
            this.EFReadButton = new System.Windows.Forms.Button();
            this.EFInsertButton = new System.Windows.Forms.Button();
            this.EFUpdateButton = new System.Windows.Forms.Button();
            this.EFDeleteButton = new System.Windows.Forms.Button();
            this.Create50000Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableReadButton
            // 
            this.DataTableReadButton.Location = new System.Drawing.Point(12, 12);
            this.DataTableReadButton.Name = "DataTableReadButton";
            this.DataTableReadButton.Size = new System.Drawing.Size(113, 23);
            this.DataTableReadButton.TabIndex = 0;
            this.DataTableReadButton.Text = "DataTable read";
            this.DataTableReadButton.UseVisualStyleBackColor = true;
            this.DataTableReadButton.Click += new System.EventHandler(this.DataTableReadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(358, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReaderReadButton
            // 
            this.ReaderReadButton.Location = new System.Drawing.Point(12, 82);
            this.ReaderReadButton.Name = "ReaderReadButton";
            this.ReaderReadButton.Size = new System.Drawing.Size(113, 23);
            this.ReaderReadButton.TabIndex = 2;
            this.ReaderReadButton.Text = "Reader read";
            this.ReaderReadButton.UseVisualStyleBackColor = true;
            this.ReaderReadButton.Click += new System.EventHandler(this.ReaderReadButton_Click);
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Location = new System.Drawing.Point(307, 21);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(100, 19);
            this.ProductIdTextBox.TabIndex = 3;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(413, 21);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(100, 19);
            this.ProductNameTextBox.TabIndex = 4;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(519, 21);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 19);
            this.PriceTextBox.TabIndex = 5;
            // 
            // InsertCommandButton
            // 
            this.InsertCommandButton.Location = new System.Drawing.Point(12, 111);
            this.InsertCommandButton.Name = "InsertCommandButton";
            this.InsertCommandButton.Size = new System.Drawing.Size(113, 23);
            this.InsertCommandButton.TabIndex = 6;
            this.InsertCommandButton.Text = "Insert command";
            this.InsertCommandButton.UseVisualStyleBackColor = true;
            this.InsertCommandButton.Click += new System.EventHandler(this.InsertCommandButton_Click);
            // 
            // UpdateCommandButton
            // 
            this.UpdateCommandButton.Location = new System.Drawing.Point(12, 140);
            this.UpdateCommandButton.Name = "UpdateCommandButton";
            this.UpdateCommandButton.Size = new System.Drawing.Size(113, 23);
            this.UpdateCommandButton.TabIndex = 7;
            this.UpdateCommandButton.Text = "Update command";
            this.UpdateCommandButton.UseVisualStyleBackColor = true;
            this.UpdateCommandButton.Click += new System.EventHandler(this.UpdateCommandButton_Click);
            // 
            // DeleteCommandButton
            // 
            this.DeleteCommandButton.Location = new System.Drawing.Point(12, 169);
            this.DeleteCommandButton.Name = "DeleteCommandButton";
            this.DeleteCommandButton.Size = new System.Drawing.Size(113, 23);
            this.DeleteCommandButton.TabIndex = 8;
            this.DeleteCommandButton.Text = "Delete command";
            this.DeleteCommandButton.UseVisualStyleBackColor = true;
            this.DeleteCommandButton.Click += new System.EventHandler(this.DeleteCommandButton_Click);
            // 
            // DapperReadButton
            // 
            this.DapperReadButton.Location = new System.Drawing.Point(12, 231);
            this.DapperReadButton.Name = "DapperReadButton";
            this.DapperReadButton.Size = new System.Drawing.Size(113, 23);
            this.DapperReadButton.TabIndex = 9;
            this.DapperReadButton.Text = "Dapper read";
            this.DapperReadButton.UseVisualStyleBackColor = true;
            this.DapperReadButton.Click += new System.EventHandler(this.DapperReadButton_Click);
            // 
            // DapperInsertButton
            // 
            this.DapperInsertButton.Location = new System.Drawing.Point(12, 260);
            this.DapperInsertButton.Name = "DapperInsertButton";
            this.DapperInsertButton.Size = new System.Drawing.Size(113, 23);
            this.DapperInsertButton.TabIndex = 10;
            this.DapperInsertButton.Text = "Dapper insert";
            this.DapperInsertButton.UseVisualStyleBackColor = true;
            this.DapperInsertButton.Click += new System.EventHandler(this.DapperInsertButton_Click);
            // 
            // EFReadButton
            // 
            this.EFReadButton.Location = new System.Drawing.Point(146, 12);
            this.EFReadButton.Name = "EFReadButton";
            this.EFReadButton.Size = new System.Drawing.Size(113, 23);
            this.EFReadButton.TabIndex = 11;
            this.EFReadButton.Text = "EF read";
            this.EFReadButton.UseVisualStyleBackColor = true;
            this.EFReadButton.Click += new System.EventHandler(this.EFReadButton_Click);
            // 
            // EFInsertButton
            // 
            this.EFInsertButton.Location = new System.Drawing.Point(146, 41);
            this.EFInsertButton.Name = "EFInsertButton";
            this.EFInsertButton.Size = new System.Drawing.Size(113, 23);
            this.EFInsertButton.TabIndex = 12;
            this.EFInsertButton.Text = "EF insert";
            this.EFInsertButton.UseVisualStyleBackColor = true;
            this.EFInsertButton.Click += new System.EventHandler(this.EFInsertButton_Click);
            // 
            // EFUpdateButton
            // 
            this.EFUpdateButton.Location = new System.Drawing.Point(146, 70);
            this.EFUpdateButton.Name = "EFUpdateButton";
            this.EFUpdateButton.Size = new System.Drawing.Size(113, 23);
            this.EFUpdateButton.TabIndex = 13;
            this.EFUpdateButton.Text = "EF update";
            this.EFUpdateButton.UseVisualStyleBackColor = true;
            this.EFUpdateButton.Click += new System.EventHandler(this.EFUpdateButton_Click);
            // 
            // EFDeleteButton
            // 
            this.EFDeleteButton.Location = new System.Drawing.Point(146, 99);
            this.EFDeleteButton.Name = "EFDeleteButton";
            this.EFDeleteButton.Size = new System.Drawing.Size(113, 23);
            this.EFDeleteButton.TabIndex = 14;
            this.EFDeleteButton.Text = "EF delete";
            this.EFDeleteButton.UseVisualStyleBackColor = true;
            this.EFDeleteButton.Click += new System.EventHandler(this.EFDeleteButton_Click);
            // 
            // Create50000Button
            // 
            this.Create50000Button.Location = new System.Drawing.Point(158, 231);
            this.Create50000Button.Name = "Create50000Button";
            this.Create50000Button.Size = new System.Drawing.Size(113, 23);
            this.Create50000Button.TabIndex = 15;
            this.Create50000Button.Text = "create 50000";
            this.Create50000Button.UseVisualStyleBackColor = true;
            this.Create50000Button.Click += new System.EventHandler(this.Create50000Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 376);
            this.Controls.Add(this.Create50000Button);
            this.Controls.Add(this.EFDeleteButton);
            this.Controls.Add(this.EFUpdateButton);
            this.Controls.Add(this.EFInsertButton);
            this.Controls.Add(this.EFReadButton);
            this.Controls.Add(this.DapperInsertButton);
            this.Controls.Add(this.DapperReadButton);
            this.Controls.Add(this.DeleteCommandButton);
            this.Controls.Add(this.UpdateCommandButton);
            this.Controls.Add(this.InsertCommandButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.ReaderReadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DataTableReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DataTableReadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReaderReadButton;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button InsertCommandButton;
        private System.Windows.Forms.Button UpdateCommandButton;
        private System.Windows.Forms.Button DeleteCommandButton;
        private System.Windows.Forms.Button DapperReadButton;
        private System.Windows.Forms.Button DapperInsertButton;
        private System.Windows.Forms.Button EFReadButton;
        private System.Windows.Forms.Button EFInsertButton;
        private System.Windows.Forms.Button EFUpdateButton;
        private System.Windows.Forms.Button EFDeleteButton;
        private System.Windows.Forms.Button Create50000Button;
    }
}

