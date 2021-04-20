
namespace Sales_Analysis
{
    partial class Form1
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
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.averageTitleLabel = new System.Windows.Forms.Label();
            this.maximumTitleLabel = new System.Windows.Forms.Label();
            this.minimumTitleLabel = new System.Windows.Forms.Label();
            this.sumTitleLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(91, 175);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(83, 32);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(180, 175);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 16;
            this.displayListBox.Location = new System.Drawing.Point(12, 12);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(98, 148);
            this.displayListBox.TabIndex = 2;
            // 
            // averageTitleLabel
            // 
            this.averageTitleLabel.AutoSize = true;
            this.averageTitleLabel.Location = new System.Drawing.Point(127, 12);
            this.averageTitleLabel.Name = "averageTitleLabel";
            this.averageTitleLabel.Size = new System.Drawing.Size(65, 17);
            this.averageTitleLabel.TabIndex = 3;
            this.averageTitleLabel.Text = "Average:";
            // 
            // maximumTitleLabel
            // 
            this.maximumTitleLabel.AutoSize = true;
            this.maximumTitleLabel.Location = new System.Drawing.Point(122, 53);
            this.maximumTitleLabel.Name = "maximumTitleLabel";
            this.maximumTitleLabel.Size = new System.Drawing.Size(70, 17);
            this.maximumTitleLabel.TabIndex = 4;
            this.maximumTitleLabel.Text = "Maximum:";
            // 
            // minimumTitleLabel
            // 
            this.minimumTitleLabel.AutoSize = true;
            this.minimumTitleLabel.Location = new System.Drawing.Point(125, 92);
            this.minimumTitleLabel.Name = "minimumTitleLabel";
            this.minimumTitleLabel.Size = new System.Drawing.Size(67, 17);
            this.minimumTitleLabel.TabIndex = 5;
            this.minimumTitleLabel.Text = "Minimum:";
            // 
            // sumTitleLabel
            // 
            this.sumTitleLabel.AutoSize = true;
            this.sumTitleLabel.Location = new System.Drawing.Point(152, 134);
            this.sumTitleLabel.Name = "sumTitleLabel";
            this.sumTitleLabel.Size = new System.Drawing.Size(40, 17);
            this.sumTitleLabel.TabIndex = 6;
            this.sumTitleLabel.Text = "Sum:";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageLabel.Location = new System.Drawing.Point(213, 12);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(130, 26);
            this.averageLabel.TabIndex = 7;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maximumLabel
            // 
            this.maximumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maximumLabel.Location = new System.Drawing.Point(213, 53);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(130, 26);
            this.maximumLabel.TabIndex = 8;
            this.maximumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimumLabel
            // 
            this.minimumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minimumLabel.Location = new System.Drawing.Point(213, 92);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(130, 26);
            this.minimumLabel.TabIndex = 9;
            this.minimumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumLabel
            // 
            this.sumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumLabel.Location = new System.Drawing.Point(213, 134);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(130, 26);
            this.sumLabel.TabIndex = 10;
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 221);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.minimumLabel);
            this.Controls.Add(this.maximumLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.sumTitleLabel);
            this.Controls.Add(this.minimumTitleLabel);
            this.Controls.Add(this.maximumTitleLabel);
            this.Controls.Add(this.averageTitleLabel);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Label averageTitleLabel;
        private System.Windows.Forms.Label maximumTitleLabel;
        private System.Windows.Forms.Label minimumTitleLabel;
        private System.Windows.Forms.Label sumTitleLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.Label minimumLabel;
        private System.Windows.Forms.Label sumLabel;
    }
}

