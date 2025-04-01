namespace TshirtOdering
{
    partial class TshirtOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.promotion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.small = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.large = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity : ";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(158, 74);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 1;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // promotion
            // 
            this.promotion.Location = new System.Drawing.Point(164, 124);
            this.promotion.Name = "promotion";
            this.promotion.Size = new System.Drawing.Size(100, 20);
            this.promotion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promotion code :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "GST 9%";
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Location = new System.Drawing.Point(108, 285);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(67, 13);
            this.total_price.TabIndex = 5;
            this.total_price.Text = "Total Price : ";
            this.total_price.Click += new System.EventHandler(this.total_price_Click);
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Location = new System.Drawing.Point(111, 162);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(80, 17);
            this.small.TabIndex = 6;
            this.small.TabStop = true;
            this.small.Text = "Small ( 125)";
            this.small.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(221, 162);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(89, 17);
            this.medium.TabIndex = 7;
            this.medium.TabStop = true;
            this.medium.Text = "Medium (175)";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // large
            // 
            this.large.AutoSize = true;
            this.large.Location = new System.Drawing.Point(338, 162);
            this.large.Name = "large";
            this.large.Size = new System.Drawing.Size(79, 17);
            this.large.TabIndex = 8;
            this.large.TabStop = true;
            this.large.Text = "Large (250)";
            this.large.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(164, 238);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 9;
            this.submit.Text = "Get";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // TshirtOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 364);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.large);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.small);
            this.Controls.Add(this.total_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.promotion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label1);
            this.Name = "TshirtOrder";
            this.Text = " ";
            this.Load += new System.EventHandler(this.TshirtOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox promotion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_price;
        private System.Windows.Forms.RadioButton small;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton large;
        private System.Windows.Forms.Button submit;
    }
}

