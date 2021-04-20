
namespace CToFTable
{
    partial class TempChangeForm
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
            this.celsiusListBox = new System.Windows.Forms.ListBox();
            this.DisplayTableButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.fahrenheitListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // celsiusListBox
            // 
            this.celsiusListBox.FormattingEnabled = true;
            this.celsiusListBox.ItemHeight = 16;
            this.celsiusListBox.Location = new System.Drawing.Point(12, 39);
            this.celsiusListBox.Name = "celsiusListBox";
            this.celsiusListBox.Size = new System.Drawing.Size(110, 340);
            this.celsiusListBox.TabIndex = 0;
            // 
            // DisplayTableButton
            // 
            this.DisplayTableButton.Location = new System.Drawing.Point(12, 385);
            this.DisplayTableButton.Name = "DisplayTableButton";
            this.DisplayTableButton.Size = new System.Drawing.Size(70, 32);
            this.DisplayTableButton.TabIndex = 1;
            this.DisplayTableButton.Text = "Display";
            this.DisplayTableButton.UseVisualStyleBackColor = true;
            this.DisplayTableButton.Click += new System.EventHandler(this.DisplayTableButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(188, 385);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(68, 32);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Location = new System.Drawing.Point(9, 9);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(53, 17);
            this.celsiusLabel.TabIndex = 3;
            this.celsiusLabel.Text = "Celsius";
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.AutoSize = true;
            this.fahrenheitLabel.Location = new System.Drawing.Point(125, 9);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(76, 17);
            this.fahrenheitLabel.TabIndex = 4;
            this.fahrenheitLabel.Text = "Fahrenheit";
            // 
            // fahrenheitListBox
            // 
            this.fahrenheitListBox.FormattingEnabled = true;
            this.fahrenheitListBox.ItemHeight = 16;
            this.fahrenheitListBox.Location = new System.Drawing.Point(128, 39);
            this.fahrenheitListBox.Name = "fahrenheitListBox";
            this.fahrenheitListBox.Size = new System.Drawing.Size(128, 340);
            this.fahrenheitListBox.TabIndex = 5;
            // 
            // TempChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 421);
            this.Controls.Add(this.fahrenheitListBox);
            this.Controls.Add(this.fahrenheitLabel);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayTableButton);
            this.Controls.Add(this.celsiusListBox);
            this.Name = "TempChangeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox celsiusListBox;
        private System.Windows.Forms.Button DisplayTableButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label celsiusLabel;
        private System.Windows.Forms.Label fahrenheitLabel;
        private System.Windows.Forms.ListBox fahrenheitListBox;
    }
}

