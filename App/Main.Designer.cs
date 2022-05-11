namespace App
{
    partial class Main
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
            this.url_textbox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.web_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // url_textbox
            // 
            this.url_textbox.Location = new System.Drawing.Point(2, 2);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(528, 21);
            this.url_textbox.TabIndex = 0;
            this.url_textbox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Read URL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // web_open
            // 
            this.web_open.Location = new System.Drawing.Point(536, 29);
            this.web_open.Name = "web_open";
            this.web_open.Size = new System.Drawing.Size(83, 21);
            this.web_open.TabIndex = 2;
            this.web_open.Text = "View RSS";
            this.web_open.UseVisualStyleBackColor = true;
            this.web_open.Click += new System.EventHandler(this.web_open_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 57);
            this.Controls.Add(this.web_open);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.url_textbox);
            this.Name = "Main";
            this.Text = "Read URL";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox url_textbox;
        private Button button1;
        private Button web_open;
    }
}