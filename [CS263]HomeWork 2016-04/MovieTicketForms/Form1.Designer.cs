namespace MovieTicketForms
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.typeOfTicketComboBox = new System.Windows.Forms.ComboBox();
            this.detailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.discountLabel = new System.Windows.Forms.Label();
            this.typeOfTicketLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.numberOfTicketLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.numberOfTicketComboBox = new System.Windows.Forms.ComboBox();
            this.discountComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // typeOfTicketComboBox
            // 
            this.typeOfTicketComboBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.typeOfTicketComboBox.FormattingEnabled = true;
            this.typeOfTicketComboBox.Items.AddRange(new object[] {
            "全票",
            "學生票",
            "兒童票"});
            this.typeOfTicketComboBox.Location = new System.Drawing.Point(16, 70);
            this.typeOfTicketComboBox.Name = "typeOfTicketComboBox";
            this.typeOfTicketComboBox.Size = new System.Drawing.Size(218, 38);
            this.typeOfTicketComboBox.TabIndex = 1;
            this.typeOfTicketComboBox.SelectedIndexChanged += new System.EventHandler(this.typeOfTicketComboBox_SelectedIndexChanged);
            // 
            // detailRichTextBox
            // 
            this.detailRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.detailRichTextBox.Location = new System.Drawing.Point(12, 187);
            this.detailRichTextBox.Name = "detailRichTextBox";
            this.detailRichTextBox.Size = new System.Drawing.Size(666, 305);
            this.detailRichTextBox.TabIndex = 2;
            this.detailRichTextBox.Text = "";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(695, 187);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 67);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "加入清單";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discountLabel.Location = new System.Drawing.Point(286, 43);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(105, 24);
            this.discountLabel.TabIndex = 5;
            this.discountLabel.Text = "電影票折扣";
            // 
            // typeOfTicketLabel
            // 
            this.typeOfTicketLabel.AutoSize = true;
            this.typeOfTicketLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.typeOfTicketLabel.Location = new System.Drawing.Point(12, 43);
            this.typeOfTicketLabel.Name = "typeOfTicketLabel";
            this.typeOfTicketLabel.Size = new System.Drawing.Size(105, 24);
            this.typeOfTicketLabel.TabIndex = 6;
            this.typeOfTicketLabel.Text = "電影票類型";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.detailLabel.Location = new System.Drawing.Point(12, 147);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(86, 24);
            this.detailLabel.TabIndex = 7;
            this.detailLabel.Text = "訂票明細";
            // 
            // numberOfTicketLabel
            // 
            this.numberOfTicketLabel.AutoSize = true;
            this.numberOfTicketLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberOfTicketLabel.Location = new System.Drawing.Point(563, 43);
            this.numberOfTicketLabel.Name = "numberOfTicketLabel";
            this.numberOfTicketLabel.Size = new System.Drawing.Size(105, 24);
            this.numberOfTicketLabel.TabIndex = 9;
            this.numberOfTicketLabel.Text = "電影票張數";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(695, 282);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 67);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "清空清單";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orderButton.Location = new System.Drawing.Point(695, 372);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(150, 120);
            this.orderButton.TabIndex = 11;
            this.orderButton.Text = "確定購票";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // numberOfTicketComboBox
            // 
            this.numberOfTicketComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberOfTicketComboBox.FormattingEnabled = true;
            this.numberOfTicketComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.numberOfTicketComboBox.Location = new System.Drawing.Point(567, 70);
            this.numberOfTicketComboBox.Name = "numberOfTicketComboBox";
            this.numberOfTicketComboBox.Size = new System.Drawing.Size(111, 32);
            this.numberOfTicketComboBox.TabIndex = 12;
            // 
            // discountComboBox
            // 
            this.discountComboBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discountComboBox.FormattingEnabled = true;
            this.discountComboBox.Location = new System.Drawing.Point(290, 70);
            this.discountComboBox.Name = "discountComboBox";
            this.discountComboBox.Size = new System.Drawing.Size(218, 38);
            this.discountComboBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 504);
            this.Controls.Add(this.discountComboBox);
            this.Controls.Add(this.numberOfTicketComboBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.numberOfTicketLabel);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.typeOfTicketLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.detailRichTextBox);
            this.Controls.Add(this.typeOfTicketComboBox);
            this.Name = "Form1";
            this.Text = "電影訂票系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeOfTicketComboBox;
        private System.Windows.Forms.RichTextBox detailRichTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label typeOfTicketLabel;
        private System.Windows.Forms.Label numberOfTicketLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ComboBox numberOfTicketComboBox;
        private System.Windows.Forms.ComboBox discountComboBox;
    }
}

