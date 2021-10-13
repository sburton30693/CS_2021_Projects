
namespace Personal_Hello
{
    partial class Hello_Form
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
            this.ClickHere_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickHere_Button
            // 
            this.ClickHere_Button.Location = new System.Drawing.Point(151, 86);
            this.ClickHere_Button.Name = "ClickHere_Button";
            this.ClickHere_Button.Size = new System.Drawing.Size(75, 23);
            this.ClickHere_Button.TabIndex = 0;
            this.ClickHere_Button.Text = "Click Here";
            this.ClickHere_Button.UseVisualStyleBackColor = true;
            this.ClickHere_Button.Click += new System.EventHandler(this.ClickHere_Button_Click);
            // 
            // Hello_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 200);
            this.Controls.Add(this.ClickHere_Button);
            this.Name = "Hello_Form";
            this.Text = "Personal Hello";
            this.Load += new System.EventHandler(this.Hello_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClickHere_Button;
    }
}

