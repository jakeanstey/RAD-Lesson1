namespace Lesson2
{
    partial class InvoiceTotalForm
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
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentTextbox = new System.Windows.Forms.TextBox();
            this.discountAmountTextbox = new System.Windows.Forms.TextBox();
            this.totalTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(73, 13);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Location = new System.Drawing.Point(31, 65);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(88, 13);
            this.discountAmountLabel.TabIndex = 1;
            this.discountAmountLabel.Text = "Discount Amount";
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.AutoSize = true;
            this.discountPercentLabel.Location = new System.Drawing.Point(31, 39);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(89, 13);
            this.discountPercentLabel.TabIndex = 2;
            this.discountPercentLabel.Text = "Discount Percent";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(88, 91);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(125, 10);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalTextBox.TabIndex = 4;
            // 
            // discountPercentTextbox
            // 
            this.discountPercentTextbox.BackColor = System.Drawing.Color.White;
            this.discountPercentTextbox.Location = new System.Drawing.Point(125, 36);
            this.discountPercentTextbox.Name = "discountPercentTextbox";
            this.discountPercentTextbox.ReadOnly = true;
            this.discountPercentTextbox.Size = new System.Drawing.Size(100, 20);
            this.discountPercentTextbox.TabIndex = 5;
            // 
            // discountAmountTextbox
            // 
            this.discountAmountTextbox.BackColor = System.Drawing.Color.White;
            this.discountAmountTextbox.Location = new System.Drawing.Point(125, 62);
            this.discountAmountTextbox.Name = "discountAmountTextbox";
            this.discountAmountTextbox.ReadOnly = true;
            this.discountAmountTextbox.Size = new System.Drawing.Size(100, 20);
            this.discountAmountTextbox.TabIndex = 6;
            // 
            // totalTextbox
            // 
            this.totalTextbox.BackColor = System.Drawing.Color.White;
            this.totalTextbox.Location = new System.Drawing.Point(125, 88);
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.ReadOnly = true;
            this.totalTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalTextbox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(69, 126);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(150, 126);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InvoiceTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.totalTextbox);
            this.Controls.Add(this.discountAmountTextbox);
            this.Controls.Add(this.discountPercentTextbox);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.discountPercentLabel);
            this.Controls.Add(this.discountAmountLabel);
            this.Controls.Add(this.subtotalLabel);
            this.MaximizeBox = false;
            this.Name = "InvoiceTotalForm";
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.InvoiceTotalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label discountPercentLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox discountPercentTextbox;
        private System.Windows.Forms.TextBox discountAmountTextbox;
        private System.Windows.Forms.TextBox totalTextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

