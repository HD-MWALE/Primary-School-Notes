namespace Primary_School_Notes
{
    partial class Home
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("pdf", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("PDF", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.flpSide = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStandard8 = new System.Windows.Forms.Button();
            this.btnStandard7 = new System.Windows.Forms.Button();
            this.btnStandard6 = new System.Windows.Forms.Button();
            this.btnStandard5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDocumentName = new System.Windows.Forms.Label();
            this.flpSide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSide
            // 
            this.flpSide.AutoScroll = true;
            this.flpSide.Controls.Add(this.label1);
            this.flpSide.Controls.Add(this.treeView1);
            this.flpSide.Controls.Add(this.label2);
            this.flpSide.Controls.Add(this.btnStandard8);
            this.flpSide.Controls.Add(this.btnStandard7);
            this.flpSide.Controls.Add(this.btnStandard6);
            this.flpSide.Controls.Add(this.btnStandard5);
            this.flpSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSide.Location = new System.Drawing.Point(0, 25);
            this.flpSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpSide.Name = "flpSide";
            this.flpSide.Size = new System.Drawing.Size(240, 394);
            this.flpSide.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Documents";
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(4, 26);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Node2";
            treeNode8.Name = "Node1";
            treeNode8.Text = "pdf";
            treeNode9.Name = "Node0";
            treeNode9.Text = "PDF";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(213, 300);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notes";
            // 
            // btnStandard8
            // 
            this.btnStandard8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStandard8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStandard8.Location = new System.Drawing.Point(4, 354);
            this.btnStandard8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStandard8.Name = "btnStandard8";
            this.btnStandard8.Size = new System.Drawing.Size(213, 58);
            this.btnStandard8.TabIndex = 2;
            this.btnStandard8.Text = "Standard 8 Notes";
            this.btnStandard8.UseVisualStyleBackColor = false;
            this.btnStandard8.Click += new System.EventHandler(this.btnStandard8_Click);
            // 
            // btnStandard7
            // 
            this.btnStandard7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStandard7.Location = new System.Drawing.Point(4, 416);
            this.btnStandard7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStandard7.Name = "btnStandard7";
            this.btnStandard7.Size = new System.Drawing.Size(213, 58);
            this.btnStandard7.TabIndex = 5;
            this.btnStandard7.Text = "Standard 7 Notes";
            this.btnStandard7.UseVisualStyleBackColor = true;
            this.btnStandard7.Click += new System.EventHandler(this.btnStandard7_Click);
            // 
            // btnStandard6
            // 
            this.btnStandard6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStandard6.Location = new System.Drawing.Point(4, 478);
            this.btnStandard6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStandard6.Name = "btnStandard6";
            this.btnStandard6.Size = new System.Drawing.Size(213, 58);
            this.btnStandard6.TabIndex = 6;
            this.btnStandard6.Text = "Standard 6 Notes";
            this.btnStandard6.UseVisualStyleBackColor = true;
            this.btnStandard6.Click += new System.EventHandler(this.btnStandard6_Click);
            // 
            // btnStandard5
            // 
            this.btnStandard5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStandard5.Location = new System.Drawing.Point(4, 540);
            this.btnStandard5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStandard5.Name = "btnStandard5";
            this.btnStandard5.Size = new System.Drawing.Size(213, 58);
            this.btnStandard5.TabIndex = 7;
            this.btnStandard5.Text = "Standard 5 Notes";
            this.btnStandard5.UseVisualStyleBackColor = true;
            this.btnStandard5.Click += new System.EventHandler(this.btnStandard5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(240, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 394);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(860, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDocumentName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 32);
            this.panel2.TabIndex = 1;
            // 
            // lblDocumentName
            // 
            this.lblDocumentName.AutoSize = true;
            this.lblDocumentName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentName.Location = new System.Drawing.Point(4, 5);
            this.lblDocumentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentName.Name = "lblDocumentName";
            this.lblDocumentName.Size = new System.Drawing.Size(86, 20);
            this.lblDocumentName.TabIndex = 4;
            this.lblDocumentName.Text = "Documents";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpSide);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primary School Notes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.flpSide.ResumeLayout(false);
            this.flpSide.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpSide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStandard8;
        private System.Windows.Forms.Button btnStandard7;
        private System.Windows.Forms.Button btnStandard6;
        private System.Windows.Forms.Button btnStandard5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDocumentName;
    }
}