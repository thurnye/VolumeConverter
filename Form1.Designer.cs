namespace VolumeConverter
{
    partial class volumeConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.convertClTitleLabel = new System.Windows.Forms.Label();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.litreTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.clLabel = new System.Windows.Forms.Label();
            this.litreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertClTitleLabel
            // 
            this.convertClTitleLabel.AutoSize = true;
            this.convertClTitleLabel.Location = new System.Drawing.Point(336, 65);
            this.convertClTitleLabel.Name = "convertClTitleLabel";
            this.convertClTitleLabel.Size = new System.Drawing.Size(131, 20);
            this.convertClTitleLabel.TabIndex = 0;
            this.convertClTitleLabel.Text = "Convert CL to Litre";
            // 
            // clTextBox
            // 
            this.clTextBox.Location = new System.Drawing.Point(337, 145);
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(125, 27);
            this.clTextBox.TabIndex = 1;
            // 
            // litreTextBox
            // 
            this.litreTextBox.Location = new System.Drawing.Point(336, 212);
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(125, 27);
            this.litreTextBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(336, 288);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(468, 288);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(94, 29);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Location = new System.Drawing.Point(512, 145);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(25, 20);
            this.clLabel.TabIndex = 5;
            this.clLabel.Text = "CL";
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Location = new System.Drawing.Point(512, 212);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(38, 20);
            this.litreLabel.TabIndex = 6;
            this.litreLabel.Text = "Litre";
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.clLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.convertClTitleLabel);
            this.Name = "volumeConverter";
            this.Text = "Volume Converter CL to Litre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label convertClTitleLabel;
        private TextBox clTextBox;
        private TextBox litreTextBox;
        private Button cancelButton;
        private Button convertButton;
        private Label clLabel;
        private Label litreLabel;
    }
}