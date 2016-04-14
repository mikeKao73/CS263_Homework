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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.discountComboBox = new System.Windows.Forms.ComboBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.typeOfTicketLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.numberOfTicketLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeOfTicketComboBox
            // 
            this.typeOfTicketComboBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.typeOfTicketComboBox.FormattingEnabled = true;
            this.typeOfTicketComboBox.Location = new System.Drawing.Point(16, 70);
            this.typeOfTicketComboBox.Name = "typeOfTicketComboBox";
            this.typeOfTicketComboBox.Size = new System.Drawing.Size(218, 42);
            this.typeOfTicketComboBox.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(666, 305);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(695, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // discountComboBox
            // 
            this.discountComboBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discountComboBox.FormattingEnabled = true;
            this.discountComboBox.Location = new System.Drawing.Point(280, 70);
            this.discountComboBox.Name = "discountComboBox";
            this.discountComboBox.Size = new System.Drawing.Size(218, 42);
            this.discountComboBox.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(540, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(138, 42);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // numberOfTicketLabel
            // 
            this.numberOfTicketLabel.AutoSize = true;
            this.numberOfTicketLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberOfTicketLabel.Location = new System.Drawing.Point(536, 43);
            this.numberOfTicketLabel.Name = "numberOfTicketLabel";
            this.numberOfTicketLabel.Size = new System.Drawing.Size(105, 24);
            this.numberOfTicketLabel.TabIndex = 9;
            this.numberOfTicketLabel.Text = "電影票張數";
            this.numberOfTicketLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(695, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 67);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(695, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 101);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 504);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numberOfTicketLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeOfTicketLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.discountComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.typeOfTicketComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeOfTicketComboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox discountComboBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label typeOfTicketLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label numberOfTicketLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

