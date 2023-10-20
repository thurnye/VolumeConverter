﻿namespace VolumeConverter
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
            this.convertClTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertClTitleLabel.Location = new System.Drawing.Point(187, 30);
            this.convertClTitleLabel.Name = "convertClTitleLabel";
            this.convertClTitleLabel.Size = new System.Drawing.Size(318, 46);
            this.convertClTitleLabel.TabIndex = 0;
            this.convertClTitleLabel.Text = "Convert CL to Litre";
            // 
            // clTextBox
            // 
            this.clTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clTextBox.Location = new System.Drawing.Point(219, 145);
            this.clTextBox.Multiline = true;
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(243, 47);
            this.clTextBox.TabIndex = 1;
            this.clTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTextBox.TextChanged += new System.EventHandler(this.clTextBox_TextChanged);
            // 
            // litreTextBox
            // 
            this.litreTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.litreTextBox.Location = new System.Drawing.Point(219, 212);
            this.litreTextBox.Multiline = true;
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(242, 52);
            this.litreTextBox.TabIndex = 2;
            this.litreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(219, 335);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 52);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertButton.Location = new System.Drawing.Point(469, 335);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(115, 52);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clLabel.Location = new System.Drawing.Point(521, 145);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(42, 35);
            this.clLabel.TabIndex = 5;
            this.clLabel.Text = "CL";
            this.clLabel.Click += new System.EventHandler(this.clLabel_Click);
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.litreLabel.Location = new System.Drawing.Point(521, 212);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(63, 35);
            this.litreLabel.TabIndex = 6;
            this.litreLabel.Text = "Litre";
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.clLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.convertClTitleLabel);
            this.MinimizeBox = false;
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