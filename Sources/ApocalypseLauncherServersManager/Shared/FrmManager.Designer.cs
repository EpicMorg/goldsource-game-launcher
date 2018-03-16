namespace ApocalypseLauncherServersManager.Shared
{
    partial class FrmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManager));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxOwnServers = new System.Windows.Forms.ListBox();
            this.buttonDelOwnServers = new System.Windows.Forms.Button();
            this.buttonEditOwnServers = new System.Windows.Forms.Button();
            this.buttonAddOwnServers = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxFriendsServers = new System.Windows.Forms.ListBox();
            this.buttonDelFriendsServers = new System.Windows.Forms.Button();
            this.buttonEditFriendsServers = new System.Windows.Forms.Button();
            this.buttonAddFriendsServers = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonNewFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(510, 408);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxOwnServers);
            this.tabPage1.Controls.Add(this.buttonDelOwnServers);
            this.tabPage1.Controls.Add(this.buttonEditOwnServers);
            this.tabPage1.Controls.Add(this.buttonAddOwnServers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Own List (0)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxOwnServers
            // 
            this.listBoxOwnServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOwnServers.FormattingEnabled = true;
            this.listBoxOwnServers.Location = new System.Drawing.Point(6, 6);
            this.listBoxOwnServers.Name = "listBoxOwnServers";
            this.listBoxOwnServers.Size = new System.Drawing.Size(409, 368);
            this.listBoxOwnServers.TabIndex = 0;
            // 
            // buttonDelOwnServers
            // 
            this.buttonDelOwnServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelOwnServers.Enabled = false;
            this.buttonDelOwnServers.Location = new System.Drawing.Point(421, 64);
            this.buttonDelOwnServers.Name = "buttonDelOwnServers";
            this.buttonDelOwnServers.Size = new System.Drawing.Size(75, 23);
            this.buttonDelOwnServers.TabIndex = 1;
            this.buttonDelOwnServers.Text = "Del";
            this.buttonDelOwnServers.UseVisualStyleBackColor = true;
            this.buttonDelOwnServers.Click += new System.EventHandler(this.buttonDelOwnServers_Click);
            // 
            // buttonEditOwnServers
            // 
            this.buttonEditOwnServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditOwnServers.Enabled = false;
            this.buttonEditOwnServers.Location = new System.Drawing.Point(421, 35);
            this.buttonEditOwnServers.Name = "buttonEditOwnServers";
            this.buttonEditOwnServers.Size = new System.Drawing.Size(75, 23);
            this.buttonEditOwnServers.TabIndex = 1;
            this.buttonEditOwnServers.Text = "Edit";
            this.buttonEditOwnServers.UseVisualStyleBackColor = true;
            this.buttonEditOwnServers.Click += new System.EventHandler(this.buttonEditOwnServers_Click);
            // 
            // buttonAddOwnServers
            // 
            this.buttonAddOwnServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOwnServers.Enabled = false;
            this.buttonAddOwnServers.Location = new System.Drawing.Point(421, 6);
            this.buttonAddOwnServers.Name = "buttonAddOwnServers";
            this.buttonAddOwnServers.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOwnServers.TabIndex = 1;
            this.buttonAddOwnServers.Text = "Add";
            this.buttonAddOwnServers.UseVisualStyleBackColor = true;
            this.buttonAddOwnServers.Click += new System.EventHandler(this.buttonAddOwnServers_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxFriendsServers);
            this.tabPage2.Controls.Add(this.buttonDelFriendsServers);
            this.tabPage2.Controls.Add(this.buttonEditFriendsServers);
            this.tabPage2.Controls.Add(this.buttonAddFriendsServers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Friends List (0)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxFriendsServers
            // 
            this.listBoxFriendsServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFriendsServers.FormattingEnabled = true;
            this.listBoxFriendsServers.Location = new System.Drawing.Point(6, 6);
            this.listBoxFriendsServers.Name = "listBoxFriendsServers";
            this.listBoxFriendsServers.Size = new System.Drawing.Size(409, 368);
            this.listBoxFriendsServers.TabIndex = 2;
            // 
            // buttonDelFriendsServers
            // 
            this.buttonDelFriendsServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelFriendsServers.Enabled = false;
            this.buttonDelFriendsServers.Location = new System.Drawing.Point(421, 64);
            this.buttonDelFriendsServers.Name = "buttonDelFriendsServers";
            this.buttonDelFriendsServers.Size = new System.Drawing.Size(75, 23);
            this.buttonDelFriendsServers.TabIndex = 3;
            this.buttonDelFriendsServers.Text = "Del";
            this.buttonDelFriendsServers.UseVisualStyleBackColor = true;
            // 
            // buttonEditFriendsServers
            // 
            this.buttonEditFriendsServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditFriendsServers.Enabled = false;
            this.buttonEditFriendsServers.Location = new System.Drawing.Point(421, 35);
            this.buttonEditFriendsServers.Name = "buttonEditFriendsServers";
            this.buttonEditFriendsServers.Size = new System.Drawing.Size(75, 23);
            this.buttonEditFriendsServers.TabIndex = 4;
            this.buttonEditFriendsServers.Text = "Edit";
            this.buttonEditFriendsServers.UseVisualStyleBackColor = true;
            // 
            // buttonAddFriendsServers
            // 
            this.buttonAddFriendsServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFriendsServers.Enabled = false;
            this.buttonAddFriendsServers.Location = new System.Drawing.Point(421, 6);
            this.buttonAddFriendsServers.Name = "buttonAddFriendsServers";
            this.buttonAddFriendsServers.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFriendsServers.TabIndex = 5;
            this.buttonAddFriendsServers.Text = "Add";
            this.buttonAddFriendsServers.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Location = new System.Drawing.Point(447, 426);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile.TabIndex = 1;
            this.buttonSaveFile.Text = "Save";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile.Location = new System.Drawing.Point(93, 426);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonNewFile
            // 
            this.buttonNewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewFile.Location = new System.Drawing.Point(12, 426);
            this.buttonNewFile.Name = "buttonNewFile";
            this.buttonNewFile.Size = new System.Drawing.Size(75, 23);
            this.buttonNewFile.TabIndex = 1;
            this.buttonNewFile.Text = "New";
            this.buttonNewFile.UseVisualStyleBackColor = true;
            this.buttonNewFile.Click += new System.EventHandler(this.buttonNewFile_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(366, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Version";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // FrmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.buttonNewFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "FrmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmManager_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonAddOwnServers;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.ListBox listBoxOwnServers;
        private System.Windows.Forms.Button buttonDelOwnServers;
        private System.Windows.Forms.Button buttonEditOwnServers;
        private System.Windows.Forms.ListBox listBoxFriendsServers;
        private System.Windows.Forms.Button buttonDelFriendsServers;
        private System.Windows.Forms.Button buttonEditFriendsServers;
        private System.Windows.Forms.Button buttonAddFriendsServers;
        private System.Windows.Forms.Button buttonNewFile;
        private System.Windows.Forms.Button button1;
    }
}