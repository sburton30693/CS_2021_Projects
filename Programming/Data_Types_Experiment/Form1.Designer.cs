﻿
namespace Data_Types_Experiment
{
    partial class DataType_Form
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
            this.NumericButton = new System.Windows.Forms.Button();
            this.BoolButton = new System.Windows.Forms.Button();
            this.ConstantButton = new System.Windows.Forms.Button();
            this.StringButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumericButton
            // 
            this.NumericButton.Location = new System.Drawing.Point(154, 29);
            this.NumericButton.Name = "NumericButton";
            this.NumericButton.Size = new System.Drawing.Size(97, 23);
            this.NumericButton.TabIndex = 0;
            this.NumericButton.Text = "Numeric Data";
            this.NumericButton.UseVisualStyleBackColor = true;
            this.NumericButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // BoolButton
            // 
            this.BoolButton.Location = new System.Drawing.Point(154, 76);
            this.BoolButton.Name = "BoolButton";
            this.BoolButton.Size = new System.Drawing.Size(97, 23);
            this.BoolButton.TabIndex = 1;
            this.BoolButton.Text = "Bool Data";
            this.BoolButton.UseVisualStyleBackColor = true;
            this.BoolButton.Click += new System.EventHandler(this.BoolButton_Click);
            // 
            // ConstantButton
            // 
            this.ConstantButton.Location = new System.Drawing.Point(154, 128);
            this.ConstantButton.Name = "ConstantButton";
            this.ConstantButton.Size = new System.Drawing.Size(97, 23);
            this.ConstantButton.TabIndex = 2;
            this.ConstantButton.Text = "Constant Data";
            this.ConstantButton.UseVisualStyleBackColor = true;
            this.ConstantButton.Click += new System.EventHandler(this.ConstantButton_Click);
            // 
            // StringButton
            // 
            this.StringButton.Location = new System.Drawing.Point(154, 182);
            this.StringButton.Name = "StringButton";
            this.StringButton.Size = new System.Drawing.Size(97, 23);
            this.StringButton.TabIndex = 3;
            this.StringButton.Text = "String Data";
            this.StringButton.UseVisualStyleBackColor = true;
            this.StringButton.Click += new System.EventHandler(this.StringButton_Click);
            // 
            // DataType_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 275);
            this.Controls.Add(this.StringButton);
            this.Controls.Add(this.ConstantButton);
            this.Controls.Add(this.BoolButton);
            this.Controls.Add(this.NumericButton);
            this.Name = "DataType_Form";
            this.Text = "Data Type Experiments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NumericButton;
        private System.Windows.Forms.Button BoolButton;
        private System.Windows.Forms.Button ConstantButton;
        private System.Windows.Forms.Button StringButton;
    }
}

