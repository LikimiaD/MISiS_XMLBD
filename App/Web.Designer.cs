namespace App
{
    partial class Web
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
            this.news = new System.Windows.Forms.RichTextBox();
            this.read_db = new System.Windows.Forms.Button();
            this.write_db = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.view_db = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // news
            // 
            this.news.Location = new System.Drawing.Point(12, 12);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(776, 426);
            this.news.TabIndex = 0;
            this.news.Text = "";
            // 
            // read_db
            // 
            this.read_db.Location = new System.Drawing.Point(12, 444);
            this.read_db.Name = "read_db";
            this.read_db.Size = new System.Drawing.Size(96, 38);
            this.read_db.TabIndex = 1;
            this.read_db.Text = "Read RSS Web";
            this.read_db.UseVisualStyleBackColor = true;
            // 
            // write_db
            // 
            this.write_db.Location = new System.Drawing.Point(114, 444);
            this.write_db.Name = "write_db";
            this.write_db.Size = new System.Drawing.Size(96, 38);
            this.write_db.TabIndex = 2;
            this.write_db.Text = "Write RSS Web";
            this.write_db.UseVisualStyleBackColor = true;
            this.write_db.Click += new System.EventHandler(this.write_db_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(318, 444);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(96, 38);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset TextBox";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // view_db
            // 
            this.view_db.Location = new System.Drawing.Point(216, 444);
            this.view_db.Name = "view_db";
            this.view_db.Size = new System.Drawing.Size(96, 38);
            this.view_db.TabIndex = 4;
            this.view_db.Text = "View DataGrid";
            this.view_db.UseVisualStyleBackColor = true;
            this.view_db.Click += new System.EventHandler(this.view_db_Click);
            // 
            // Web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.view_db);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.write_db);
            this.Controls.Add(this.read_db);
            this.Controls.Add(this.news);
            this.Name = "Web";
            this.Text = "Web";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox news;
        private Button read_db;
        private Button write_db;
        private Button reset;
        private Button view_db;
    }
}