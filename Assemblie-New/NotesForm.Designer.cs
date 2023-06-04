namespace Assemblie_New
{
    partial class NotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.EmmMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MaximizeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmmMenu.SuspendLayout();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmmMenu
            // 
            this.EmmMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmmMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(17)))));
            this.EmmMenu.Controls.Add(this.MinimizeButton);
            this.EmmMenu.Controls.Add(this.ExitButton);
            this.EmmMenu.Controls.Add(this.MaximizeButton);
            this.EmmMenu.Location = new System.Drawing.Point(637, 0);
            this.EmmMenu.Name = "EmmMenu";
            this.EmmMenu.Size = new System.Drawing.Size(125, 32);
            this.EmmMenu.TabIndex = 7;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.MinimizeButton.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.MinimizeButton.ImageRotate = 0F;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(16, 16);
            this.MinimizeButton.Location = new System.Drawing.Point(0, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.MinimizeButton.Size = new System.Drawing.Size(50, 31);
            this.MinimizeButton.TabIndex = 8;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.ExitButton.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.ExitButton.ImageRotate = 0F;
            this.ExitButton.ImageSize = new System.Drawing.Size(16, 16);
            this.ExitButton.Location = new System.Drawing.Point(85, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.ExitButton.Size = new System.Drawing.Size(40, 32);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.MaximizeButton.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.MaximizeButton.Image = global::Assemblie_New.Properties.Resources.maximize;
            this.MaximizeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.MaximizeButton.ImageRotate = 0F;
            this.MaximizeButton.ImageSize = new System.Drawing.Size(16, 16);
            this.MaximizeButton.Location = new System.Drawing.Point(46, 1);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.MaximizeButton.Size = new System.Drawing.Size(39, 31);
            this.MaximizeButton.TabIndex = 6;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBarPanel.BackColor = System.Drawing.Color.White;
            this.TopBarPanel.Controls.Add(this.EmmMenu);
            this.TopBarPanel.Location = new System.Drawing.Point(-1, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(762, 68);
            this.TopBarPanel.TabIndex = 8;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            this.TopBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 561);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.EmmMenu.ResumeLayout(false);
            this.TopBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel EmmMenu;
        private Guna.UI2.WinForms.Guna2ImageButton ExitButton;
        private Guna.UI2.WinForms.Guna2ImageButton MaximizeButton;
        private Panel TopBarPanel;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizeButton;
        private ToolStripMenuItem fileToolStripMenuItem;
    }
}