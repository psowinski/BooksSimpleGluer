namespace BooksSimpleGluer
{
    partial class MainForm
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
            this.bookText = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookText
            // 
            this.bookText.AcceptsReturn = true;
            this.bookText.AcceptsTab = true;
            this.bookText.Location = new System.Drawing.Point(12, 12);
            this.bookText.MaxLength = 0;
            this.bookText.Multiline = true;
            this.bookText.Name = "bookText";
            this.bookText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bookText.Size = new System.Drawing.Size(758, 502);
            this.bookText.TabIndex = 0;
            this.bookText.WordWrap = false;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(695, 520);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 1;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.bookText);
            this.Name = "MainForm";
            this.Text = "Books Simple Gluer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookText;
        private System.Windows.Forms.Button processButton;
    }
}

