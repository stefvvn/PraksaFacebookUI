namespace Facebook.UI.Winform
{
    partial class Form1
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
            this.LstUsers = new System.Windows.Forms.ListBox();
            this.LstPosts = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LstComments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstUsers
            // 
            this.LstUsers.FormattingEnabled = true;
            this.LstUsers.ItemHeight = 15;
            this.LstUsers.Location = new System.Drawing.Point(12, 12);
            this.LstUsers.Name = "LstUsers";
            this.LstUsers.Size = new System.Drawing.Size(206, 304);
            this.LstUsers.TabIndex = 0;
            this.LstUsers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LstPosts
            // 
            this.LstPosts.FormattingEnabled = true;
            this.LstPosts.ItemHeight = 15;
            this.LstPosts.Location = new System.Drawing.Point(224, 12);
            this.LstPosts.Name = "LstPosts";
            this.LstPosts.Size = new System.Drawing.Size(201, 304);
            this.LstPosts.TabIndex = 1;
            this.LstPosts.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "User operations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LstComments
            // 
            this.LstComments.FormattingEnabled = true;
            this.LstComments.ItemHeight = 15;
            this.LstComments.Location = new System.Drawing.Point(431, 12);
            this.LstComments.Name = "LstComments";
            this.LstComments.Size = new System.Drawing.Size(193, 304);
            this.LstComments.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstComments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LstPosts);
            this.Controls.Add(this.LstUsers);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LstUsers;
        private ListBox LstPosts;
        private Button button1;
        private ListBox LstComments;
    }
}