namespace OOPLB15
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фотоальбомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.берсеркToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.піксельАртToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фотоальбомToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фотоальбомToolStripMenuItem
            // 
            this.фотоальбомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.берсеркToolStripMenuItem,
            this.мемToolStripMenuItem,
            this.піксельАртToolStripMenuItem});
            this.фотоальбомToolStripMenuItem.Name = "фотоальбомToolStripMenuItem";
            this.фотоальбомToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.фотоальбомToolStripMenuItem.Text = "Фотоальбом";
            // 
            // берсеркToolStripMenuItem
            // 
            this.берсеркToolStripMenuItem.Name = "берсеркToolStripMenuItem";
            this.берсеркToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.берсеркToolStripMenuItem.Text = "Берсерк";
            this.берсеркToolStripMenuItem.Click += new System.EventHandler(this.берсеркToolStripMenuItem_Click);
            // 
            // мемToolStripMenuItem
            // 
            this.мемToolStripMenuItem.Name = "мемToolStripMenuItem";
            this.мемToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.мемToolStripMenuItem.Text = "Мем";
            this.мемToolStripMenuItem.Click += new System.EventHandler(this.мемToolStripMenuItem_Click);
            // 
            // піксельАртToolStripMenuItem
            // 
            this.піксельАртToolStripMenuItem.Name = "піксельАртToolStripMenuItem";
            this.піксельАртToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.піксельАртToolStripMenuItem.Text = "Піксель арт";
            this.піксельАртToolStripMenuItem.Click += new System.EventHandler(this.піксельАртToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem фотоальбомToolStripMenuItem;
        private ToolStripMenuItem берсеркToolStripMenuItem;
        private ToolStripMenuItem мемToolStripMenuItem;
        private ToolStripMenuItem піксельАртToolStripMenuItem;
    }
}