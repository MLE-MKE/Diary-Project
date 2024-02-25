namespace Diary_Project
{
    partial class Form1
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
            this.Journal = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.styleOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontStyleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Journal
            // 
            this.Journal.Location = new System.Drawing.Point(13, 32);
            this.Journal.Multiline = true;
            this.Journal.Name = "Journal";
            this.Journal.Size = new System.Drawing.Size(775, 406);
            this.Journal.TabIndex = 0;
            this.Journal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(621, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(702, 3);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // styleOptionsToolStripMenuItem
            // 
            this.styleOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackgroundColorMenuItem,
            this.textBoxColorToolStripMenuItem,
            this.FontColorMenuItem,
            this.FontStyleMenuItem});
            this.styleOptionsToolStripMenuItem.Name = "styleOptionsToolStripMenuItem";
            this.styleOptionsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.styleOptionsToolStripMenuItem.Text = "Style Options";
            // 
            // BackgroundColorMenuItem
            // 
            this.BackgroundColorMenuItem.Name = "BackgroundColorMenuItem";
            this.BackgroundColorMenuItem.Size = new System.Drawing.Size(170, 22);
            this.BackgroundColorMenuItem.Text = "Background Color";
            this.BackgroundColorMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // textBoxColorToolStripMenuItem
            // 
            this.textBoxColorToolStripMenuItem.Name = "textBoxColorToolStripMenuItem";
            this.textBoxColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.textBoxColorToolStripMenuItem.Text = "Text Box Color";
            this.textBoxColorToolStripMenuItem.Click += new System.EventHandler(this.textBoxColorToolStripMenuItem_Click);
            // 
            // FontColorMenuItem
            // 
            this.FontColorMenuItem.Name = "FontColorMenuItem";
            this.FontColorMenuItem.Size = new System.Drawing.Size(170, 22);
            this.FontColorMenuItem.Text = "Font Color";
            this.FontColorMenuItem.Click += new System.EventHandler(this.FontColorMenuItem_Click);
            // 
            // FontStyleMenuItem
            // 
            this.FontStyleMenuItem.Name = "FontStyleMenuItem";
            this.FontStyleMenuItem.Size = new System.Drawing.Size(170, 22);
            this.FontStyleMenuItem.Text = "Font Style";
            this.FontStyleMenuItem.Click += new System.EventHandler(this.FontStyleMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Journal);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Journal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Journal;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem styleOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackgroundColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontStyleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBoxColorToolStripMenuItem;
    }
}

