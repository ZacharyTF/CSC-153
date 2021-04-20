
namespace MassWeightApplication
{
    partial class MassWeightForm
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
            this.massLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTitleLabel = new System.Windows.Forms.Label();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.calculateWeightButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.heavyIndicatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Location = new System.Drawing.Point(23, 12);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(45, 17);
            this.massLabel.TabIndex = 0;
            this.massLabel.Text = "Mass:";
            // 
            // weightLabel
            // 
            this.weightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightLabel.Location = new System.Drawing.Point(74, 39);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(165, 26);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightTitleLabel
            // 
            this.weightTitleLabel.AutoSize = true;
            this.weightTitleLabel.Location = new System.Drawing.Point(12, 43);
            this.weightTitleLabel.Name = "weightTitleLabel";
            this.weightTitleLabel.Size = new System.Drawing.Size(56, 17);
            this.weightTitleLabel.TabIndex = 2;
            this.weightTitleLabel.Text = "Weight:";
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(74, 12);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(165, 22);
            this.massTextBox.TabIndex = 3;
            // 
            // calculateWeightButton
            // 
            this.calculateWeightButton.Location = new System.Drawing.Point(15, 105);
            this.calculateWeightButton.Name = "calculateWeightButton";
            this.calculateWeightButton.Size = new System.Drawing.Size(82, 26);
            this.calculateWeightButton.TabIndex = 4;
            this.calculateWeightButton.Text = "Calculate";
            this.calculateWeightButton.UseVisualStyleBackColor = true;
            this.calculateWeightButton.Click += new System.EventHandler(this.calculateWeightButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(103, 105);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 26);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(187, 105);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 26);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // heavyIndicatorLabel
            // 
            this.heavyIndicatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heavyIndicatorLabel.Location = new System.Drawing.Point(74, 65);
            this.heavyIndicatorLabel.Name = "heavyIndicatorLabel";
            this.heavyIndicatorLabel.Size = new System.Drawing.Size(165, 37);
            this.heavyIndicatorLabel.TabIndex = 7;
            // 
            // MassWeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 145);
            this.Controls.Add(this.heavyIndicatorLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateWeightButton);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.weightTitleLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.massLabel);
            this.Name = "MassWeightForm";
            this.Text = "Mass_Weight_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label weightTitleLabel;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.Button calculateWeightButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label heavyIndicatorLabel;
    }
}

