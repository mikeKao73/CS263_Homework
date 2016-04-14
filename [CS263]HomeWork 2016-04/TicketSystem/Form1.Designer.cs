namespace TicketSystem
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
            this.components = new System.ComponentModel.Container();
            this.discountComboBox = new System.Windows.Forms.ComboBox();
            this.iDiscountableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.babyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.babyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // discountComboBox
            // 
            this.discountComboBox.DataSource = this.iDiscountableBindingSource;
            this.discountComboBox.FormattingEnabled = true;
            this.discountComboBox.IntegralHeight = false;
            this.discountComboBox.Location = new System.Drawing.Point(401, 60);
            this.discountComboBox.Name = "discountComboBox";
            this.discountComboBox.Size = new System.Drawing.Size(120, 20);
            this.discountComboBox.TabIndex = 0;
            // 
            // iDiscountableBindingSource
            // 
            this.iDiscountableBindingSource.DataSource = typeof(DiscountLibrary.IDiscountable);
            // 
            // babyBindingSource
            // 
            this.babyBindingSource.DataSource = typeof(DiscountLibrary.Baby);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 429);
            this.Controls.Add(this.discountComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.babyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox discountComboBox;
        private System.Windows.Forms.BindingSource iDiscountableBindingSource;
        private System.Windows.Forms.BindingSource babyBindingSource;
    }
}

