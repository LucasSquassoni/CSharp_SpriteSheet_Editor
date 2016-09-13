namespace IntroductionToCSharp
{
    partial class SpriteEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpriteViewerLabel = new System.Windows.Forms.Label();
            this.SpriteViewer = new System.Windows.Forms.PictureBox();
            this.SpriteMenuPanel = new System.Windows.Forms.Panel();
            this.ExportToXMLButton = new System.Windows.Forms.Button();
            this.SpriteListViewer = new System.Windows.Forms.ListBox();
            this.DrawCheck = new System.Windows.Forms.CheckBox();
            this.SaveSpriteButton = new System.Windows.Forms.Button();
            this.SpriteQueueLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.HLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WidthText = new System.Windows.Forms.TextBox();
            this.XPosText = new System.Windows.Forms.TextBox();
            this.YPosText = new System.Windows.Forms.TextBox();
            this.SpriteName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteViewer)).BeginInit();
            this.SpriteMenuPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.spriteViewerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(129, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.importFileToolStripMenuItem,
            this.exportAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importImageToolStripMenuItem
            // 
            this.importImageToolStripMenuItem.Name = "importImageToolStripMenuItem";
            this.importImageToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.importImageToolStripMenuItem.Text = "Import Image";
            this.importImageToolStripMenuItem.Click += new System.EventHandler(this.importImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.importFileToolStripMenuItem.Text = "Import File...";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exportAsToolStripMenuItem.Text = "Export As...";
            this.exportAsToolStripMenuItem.Click += new System.EventHandler(this.exportAsToolStripMenuItem_Click);
            // 
            // spriteViewerToolStripMenuItem
            // 
            this.spriteViewerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearViewerToolStripMenuItem});
            this.spriteViewerToolStripMenuItem.Name = "spriteViewerToolStripMenuItem";
            this.spriteViewerToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.spriteViewerToolStripMenuItem.Text = "SpriteViewer";
            // 
            // clearViewerToolStripMenuItem
            // 
            this.clearViewerToolStripMenuItem.Name = "clearViewerToolStripMenuItem";
            this.clearViewerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearViewerToolStripMenuItem.Text = "Clear Viewer";
            this.clearViewerToolStripMenuItem.Click += new System.EventHandler(this.clearViewerToolStripMenuItem_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.BackColor = System.Drawing.Color.LightGray;
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.Controls.Add(this.menuStrip1);
            this.MenuPanel.Location = new System.Drawing.Point(0, -6);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1668, 38);
            this.MenuPanel.TabIndex = 2;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // SpriteViewerLabel
            // 
            this.SpriteViewerLabel.AutoSize = true;
            this.SpriteViewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpriteViewerLabel.Location = new System.Drawing.Point(345, 55);
            this.SpriteViewerLabel.Name = "SpriteViewerLabel";
            this.SpriteViewerLabel.Size = new System.Drawing.Size(128, 25);
            this.SpriteViewerLabel.TabIndex = 4;
            this.SpriteViewerLabel.Text = "Sprite Viewer";
            // 
            // SpriteViewer
            // 
            this.SpriteViewer.BackColor = System.Drawing.Color.Gainsboro;
            this.SpriteViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpriteViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpriteViewer.Location = new System.Drawing.Point(0, 0);
            this.SpriteViewer.Margin = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.SpriteViewer.Name = "SpriteViewer";
            this.SpriteViewer.Size = new System.Drawing.Size(1467, 793);
            this.SpriteViewer.TabIndex = 3;
            this.SpriteViewer.TabStop = false;
            this.SpriteViewer.Paint += new System.Windows.Forms.PaintEventHandler(this.SpriteViewer_Paint);
            this.SpriteViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpriteViewer_MouseClick);
            this.SpriteViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpriteViewer_MouseDown);
            this.SpriteViewer.MouseEnter += new System.EventHandler(this.SpriteViewer_MouseEnter);
            this.SpriteViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SpriteViewer_MouseMove);
            this.SpriteViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpriteViewer_MouseUp);
            // 
            // SpriteMenuPanel
            // 
            this.SpriteMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SpriteMenuPanel.BackColor = System.Drawing.Color.White;
            this.SpriteMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SpriteMenuPanel.BackgroundImage")));
            this.SpriteMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpriteMenuPanel.Controls.Add(this.ExportToXMLButton);
            this.SpriteMenuPanel.Controls.Add(this.SpriteListViewer);
            this.SpriteMenuPanel.Controls.Add(this.DrawCheck);
            this.SpriteMenuPanel.Controls.Add(this.SaveSpriteButton);
            this.SpriteMenuPanel.Controls.Add(this.SpriteQueueLabel);
            this.SpriteMenuPanel.Controls.Add(this.WLabel);
            this.SpriteMenuPanel.Controls.Add(this.HLabel);
            this.SpriteMenuPanel.Controls.Add(this.YLabel);
            this.SpriteMenuPanel.Controls.Add(this.XLabel);
            this.SpriteMenuPanel.Controls.Add(this.PositionLabel);
            this.SpriteMenuPanel.Controls.Add(this.NameLabel);
            this.SpriteMenuPanel.Controls.Add(this.HeightText);
            this.SpriteMenuPanel.Controls.Add(this.WidthText);
            this.SpriteMenuPanel.Controls.Add(this.XPosText);
            this.SpriteMenuPanel.Controls.Add(this.YPosText);
            this.SpriteMenuPanel.Controls.Add(this.SpriteName);
            this.SpriteMenuPanel.Location = new System.Drawing.Point(0, 9);
            this.SpriteMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SpriteMenuPanel.Name = "SpriteMenuPanel";
            this.SpriteMenuPanel.Size = new System.Drawing.Size(330, 905);
            this.SpriteMenuPanel.TabIndex = 1;
            // 
            // ExportToXMLButton
            // 
            this.ExportToXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportToXMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToXMLButton.Location = new System.Drawing.Point(149, 775);
            this.ExportToXMLButton.Name = "ExportToXMLButton";
            this.ExportToXMLButton.Size = new System.Drawing.Size(134, 33);
            this.ExportToXMLButton.TabIndex = 16;
            this.ExportToXMLButton.Text = "Export to XML";
            this.ExportToXMLButton.UseVisualStyleBackColor = true;
            this.ExportToXMLButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExportToXMLButton_MouseClick);
            // 
            // SpriteListViewer
            // 
            this.SpriteListViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SpriteListViewer.FormattingEnabled = true;
            this.SpriteListViewer.Location = new System.Drawing.Point(123, 498);
            this.SpriteListViewer.Name = "SpriteListViewer";
            this.SpriteListViewer.Size = new System.Drawing.Size(160, 251);
            this.SpriteListViewer.TabIndex = 15;
            this.SpriteListViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpriteListViewer_MouseClick);
            // 
            // DrawCheck
            // 
            this.DrawCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.DrawCheck.BackColor = System.Drawing.Color.Transparent;
            this.DrawCheck.BackgroundImage = global::IntroductionToCSharp.Properties.Resources.design_marquee_select_graphic_tool_512;
            this.DrawCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DrawCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawCheck.Location = new System.Drawing.Point(238, 221);
            this.DrawCheck.Name = "DrawCheck";
            this.DrawCheck.Size = new System.Drawing.Size(45, 45);
            this.DrawCheck.TabIndex = 14;
            this.DrawCheck.UseVisualStyleBackColor = false;
            this.DrawCheck.CheckedChanged += new System.EventHandler(this.DrawCheck_CheckedChanged);
            // 
            // SaveSpriteButton
            // 
            this.SaveSpriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSpriteButton.Location = new System.Drawing.Point(40, 443);
            this.SaveSpriteButton.Name = "SaveSpriteButton";
            this.SaveSpriteButton.Size = new System.Drawing.Size(134, 33);
            this.SaveSpriteButton.TabIndex = 13;
            this.SaveSpriteButton.Text = "Save Selection";
            this.SaveSpriteButton.UseVisualStyleBackColor = true;
            this.SaveSpriteButton.Click += new System.EventHandler(this.SaveSpriteButton_Click);
            // 
            // SpriteQueueLabel
            // 
            this.SpriteQueueLabel.AutoSize = true;
            this.SpriteQueueLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpriteQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpriteQueueLabel.Location = new System.Drawing.Point(14, 498);
            this.SpriteQueueLabel.Name = "SpriteQueueLabel";
            this.SpriteQueueLabel.Size = new System.Drawing.Size(103, 20);
            this.SpriteQueueLabel.TabIndex = 12;
            this.SpriteQueueLabel.Text = "Sprite Queue";
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.BackColor = System.Drawing.Color.Transparent;
            this.WLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLabel.Location = new System.Drawing.Point(14, 403);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(24, 20);
            this.WLabel.TabIndex = 10;
            this.WLabel.Text = "W";
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.BackColor = System.Drawing.Color.Transparent;
            this.HLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HLabel.Location = new System.Drawing.Point(157, 403);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(21, 20);
            this.HLabel.TabIndex = 9;
            this.HLabel.Text = "H";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.BackColor = System.Drawing.Color.Transparent;
            this.YLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.Location = new System.Drawing.Point(157, 358);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(20, 20);
            this.YLabel.TabIndex = 8;
            this.YLabel.Text = "Y";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.BackColor = System.Drawing.Color.Transparent;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(14, 358);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(20, 20);
            this.XLabel.TabIndex = 7;
            this.XLabel.Text = "X";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(49, 322);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(65, 20);
            this.PositionLabel.TabIndex = 6;
            this.PositionLabel.Text = "Position";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(49, 287);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(183, 403);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(100, 20);
            this.HeightText.TabIndex = 4;
            // 
            // WidthText
            // 
            this.WidthText.Location = new System.Drawing.Point(40, 403);
            this.WidthText.Name = "WidthText";
            this.WidthText.Size = new System.Drawing.Size(100, 20);
            this.WidthText.TabIndex = 3;
            // 
            // XPosText
            // 
            this.XPosText.Location = new System.Drawing.Point(40, 358);
            this.XPosText.Name = "XPosText";
            this.XPosText.Size = new System.Drawing.Size(100, 20);
            this.XPosText.TabIndex = 1;
            // 
            // YPosText
            // 
            this.YPosText.Location = new System.Drawing.Point(183, 358);
            this.YPosText.Name = "YPosText";
            this.YPosText.Size = new System.Drawing.Size(100, 20);
            this.YPosText.TabIndex = 2;
            // 
            // SpriteName
            // 
            this.SpriteName.Location = new System.Drawing.Point(118, 287);
            this.SpriteName.Name = "SpriteName";
            this.SpriteName.Size = new System.Drawing.Size(165, 20);
            this.SpriteName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(350, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1306, 812);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SpriteViewer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1298, 786);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1298, 786);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SpriteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1668, 907);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SpriteViewerLabel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.SpriteMenuPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpriteEditor";
            this.Text = "Sprite Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpriteViewer)).EndInit();
            this.SpriteMenuPanel.ResumeLayout(false);
            this.SpriteMenuPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel SpriteMenuPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox SpriteViewer;
        private System.Windows.Forms.ToolStripMenuItem importImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.Label HLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label SpriteQueueLabel;
        private System.Windows.Forms.Label SpriteViewerLabel;
        private System.Windows.Forms.Button SaveSpriteButton;
        public System.Windows.Forms.TextBox SpriteName;
        public System.Windows.Forms.TextBox HeightText;
        public System.Windows.Forms.TextBox WidthText;
        public System.Windows.Forms.TextBox XPosText;
        public System.Windows.Forms.TextBox YPosText;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.CheckBox DrawCheck;
        private System.Windows.Forms.ListBox SpriteListViewer;
        private System.Windows.Forms.ToolStripMenuItem spriteViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearViewerToolStripMenuItem;
        private System.Windows.Forms.Button ExportToXMLButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

