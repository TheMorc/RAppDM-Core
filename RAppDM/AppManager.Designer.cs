namespace RAppDM
{
    partial class AppManager
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Audio & Video", 4, 4);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Development", 3, 3);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Drivers", 8, 8);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Internet & Network", 6, 6);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Games", 9, 9);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Graphics", 5, 5);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Libraries", 8, 8);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Office", 11, 11);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Tools", 7, 7);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Other", 10, 10);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Categories", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Installed", 2, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppManager));
            this.apps = new System.Windows.Forms.ListBox();
            this.nameLBL = new System.Windows.Forms.Label();
            this.installBTN = new System.Windows.Forms.Button();
            this.iconurls = new System.Windows.Forms.ListBox();
            this.downloadurls = new System.Windows.Forms.ListBox();
            this.categories = new System.Windows.Forms.ListBox();
            this.descLBL = new System.Windows.Forms.Label();
            this.silentargs = new System.Windows.Forms.ListBox();
            this.descs = new System.Windows.Forms.ListBox();
            this.tempApps = new System.Windows.Forms.ListBox();
            this.tempCategories = new System.Windows.Forms.ListBox();
            this.tempIndexes = new System.Windows.Forms.ListBox();
            this.versions = new System.Windows.Forms.ListBox();
            this.versionLBL = new System.Windows.Forms.Label();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.categoriesAndApps = new System.Windows.Forms.TreeView();
            this.helpForTreeView = new System.Windows.Forms.ImageList(this.components);
            this.uninstallBTN = new System.Windows.Forms.Button();
            this.settingsBTN = new System.Windows.Forms.PictureBox();
            this.sizes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // apps
            // 
            this.apps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apps.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apps.FormattingEnabled = true;
            this.apps.ItemHeight = 15;
            this.apps.Location = new System.Drawing.Point(207, 73);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(87, 120);
            this.apps.TabIndex = 0;
            this.apps.Visible = false;
            this.apps.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.Location = new System.Drawing.Point(268, 50);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(0, 25);
            this.nameLBL.TabIndex = 2;
            // 
            // installBTN
            // 
            this.installBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installBTN.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installBTN.Image = global::RAppDM.Properties.Resources.package_add;
            this.installBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.installBTN.Location = new System.Drawing.Point(206, 271);
            this.installBTN.Name = "installBTN";
            this.installBTN.Size = new System.Drawing.Size(92, 36);
            this.installBTN.TabIndex = 3;
            this.installBTN.Text = "Install";
            this.installBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.installBTN.UseVisualStyleBackColor = true;
            this.installBTN.Visible = false;
            this.installBTN.Click += new System.EventHandler(this.Button1_Click);
            // 
            // iconurls
            // 
            this.iconurls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconurls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iconurls.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconurls.FormattingEnabled = true;
            this.iconurls.Location = new System.Drawing.Point(579, 199);
            this.iconurls.Name = "iconurls";
            this.iconurls.Size = new System.Drawing.Size(87, 117);
            this.iconurls.TabIndex = 5;
            this.iconurls.Visible = false;
            // 
            // downloadurls
            // 
            this.downloadurls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadurls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.downloadurls.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadurls.FormattingEnabled = true;
            this.downloadurls.Location = new System.Drawing.Point(486, 199);
            this.downloadurls.Name = "downloadurls";
            this.downloadurls.Size = new System.Drawing.Size(87, 117);
            this.downloadurls.TabIndex = 6;
            this.downloadurls.Visible = false;
            // 
            // categories
            // 
            this.categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categories.Cursor = System.Windows.Forms.Cursors.Default;
            this.categories.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories.FormattingEnabled = true;
            this.categories.ItemHeight = 15;
            this.categories.Items.AddRange(new object[] {
            "Audio & Video",
            "Development",
            "Drivers",
            "Internet & Network",
            "Games",
            "Graphics",
            "Libraries",
            "Office",
            "Tools",
            "Other"});
            this.categories.Location = new System.Drawing.Point(207, 199);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(87, 120);
            this.categories.TabIndex = 7;
            this.categories.Visible = false;
            // 
            // descLBL
            // 
            this.descLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descLBL.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLBL.Location = new System.Drawing.Point(205, 76);
            this.descLBL.Name = "descLBL";
            this.descLBL.Size = new System.Drawing.Size(449, 192);
            this.descLBL.TabIndex = 8;
            this.descLBL.UseCompatibleTextRendering = true;
            // 
            // silentargs
            // 
            this.silentargs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.silentargs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.silentargs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silentargs.FormattingEnabled = true;
            this.silentargs.Location = new System.Drawing.Point(300, 199);
            this.silentargs.Name = "silentargs";
            this.silentargs.Size = new System.Drawing.Size(87, 117);
            this.silentargs.TabIndex = 10;
            this.silentargs.Visible = false;
            // 
            // descs
            // 
            this.descs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.descs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descs.FormattingEnabled = true;
            this.descs.Location = new System.Drawing.Point(393, 199);
            this.descs.Name = "descs";
            this.descs.Size = new System.Drawing.Size(87, 117);
            this.descs.TabIndex = 9;
            this.descs.Visible = false;
            // 
            // tempApps
            // 
            this.tempApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tempApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempApps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempApps.FormattingEnabled = true;
            this.tempApps.Location = new System.Drawing.Point(393, 72);
            this.tempApps.Name = "tempApps";
            this.tempApps.Size = new System.Drawing.Size(87, 117);
            this.tempApps.TabIndex = 12;
            this.tempApps.Visible = false;
            // 
            // tempCategories
            // 
            this.tempCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tempCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempCategories.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempCategories.FormattingEnabled = true;
            this.tempCategories.Location = new System.Drawing.Point(486, 72);
            this.tempCategories.Name = "tempCategories";
            this.tempCategories.Size = new System.Drawing.Size(87, 117);
            this.tempCategories.TabIndex = 13;
            this.tempCategories.Visible = false;
            // 
            // tempIndexes
            // 
            this.tempIndexes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tempIndexes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempIndexes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempIndexes.FormattingEnabled = true;
            this.tempIndexes.Location = new System.Drawing.Point(579, 72);
            this.tempIndexes.Name = "tempIndexes";
            this.tempIndexes.Size = new System.Drawing.Size(87, 117);
            this.tempIndexes.TabIndex = 14;
            this.tempIndexes.Visible = false;
            // 
            // versions
            // 
            this.versions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.versions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versions.FormattingEnabled = true;
            this.versions.Location = new System.Drawing.Point(300, 72);
            this.versions.Name = "versions";
            this.versions.Size = new System.Drawing.Size(87, 117);
            this.versions.TabIndex = 15;
            this.versions.Visible = false;
            // 
            // versionLBL
            // 
            this.versionLBL.AutoSize = true;
            this.versionLBL.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLBL.Location = new System.Drawing.Point(270, 35);
            this.versionLBL.Name = "versionLBL";
            this.versionLBL.Size = new System.Drawing.Size(0, 17);
            this.versionLBL.TabIndex = 16;
            // 
            // appIcon
            // 
            this.appIcon.ErrorImage = null;
            this.appIcon.InitialImage = null;
            this.appIcon.Location = new System.Drawing.Point(206, 9);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(64, 64);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appIcon.TabIndex = 18;
            this.appIcon.TabStop = false;
            this.appIcon.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PictureBox1_LoadCompleted);
            // 
            // categoriesAndApps
            // 
            this.categoriesAndApps.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoriesAndApps.ImageIndex = 0;
            this.categoriesAndApps.ImageList = this.helpForTreeView;
            this.categoriesAndApps.Indent = 19;
            this.categoriesAndApps.ItemHeight = 16;
            this.categoriesAndApps.Location = new System.Drawing.Point(0, 0);
            this.categoriesAndApps.Name = "categoriesAndApps";
            treeNode13.ImageIndex = 4;
            treeNode13.Name = "Node1";
            treeNode13.SelectedImageIndex = 4;
            treeNode13.Text = "Audio & Video";
            treeNode14.ImageIndex = 3;
            treeNode14.Name = "Node2";
            treeNode14.SelectedImageIndex = 3;
            treeNode14.Text = "Development";
            treeNode15.ImageIndex = 8;
            treeNode15.Name = "Node3";
            treeNode15.SelectedImageIndex = 8;
            treeNode15.Text = "Drivers";
            treeNode16.ImageIndex = 6;
            treeNode16.Name = "Node4";
            treeNode16.SelectedImageIndex = 6;
            treeNode16.Text = "Internet & Network";
            treeNode17.ImageIndex = 9;
            treeNode17.Name = "Node5";
            treeNode17.SelectedImageIndex = 9;
            treeNode17.Text = "Games";
            treeNode18.ImageIndex = 5;
            treeNode18.Name = "Node8";
            treeNode18.SelectedImageIndex = 5;
            treeNode18.Text = "Graphics";
            treeNode19.ImageIndex = 8;
            treeNode19.Name = "Node9";
            treeNode19.SelectedImageIndex = 8;
            treeNode19.Text = "Libraries";
            treeNode20.ImageIndex = 11;
            treeNode20.Name = "Node10";
            treeNode20.SelectedImageIndex = 11;
            treeNode20.Text = "Office";
            treeNode21.ImageIndex = 7;
            treeNode21.Name = "Node11";
            treeNode21.SelectedImageIndex = 7;
            treeNode21.Text = "Tools";
            treeNode22.ImageIndex = 10;
            treeNode22.Name = "Node12";
            treeNode22.SelectedImageIndex = 10;
            treeNode22.Text = "Other";
            treeNode23.ImageIndex = 1;
            treeNode23.Name = "Node0";
            treeNode23.SelectedImageIndex = 1;
            treeNode23.Text = "Categories";
            treeNode24.ImageIndex = 2;
            treeNode24.Name = "Node7";
            treeNode24.SelectedImageIndex = 2;
            treeNode24.Text = "Installed";
            this.categoriesAndApps.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            this.categoriesAndApps.SelectedImageIndex = 0;
            this.categoriesAndApps.Size = new System.Drawing.Size(196, 319);
            this.categoriesAndApps.TabIndex = 19;
            this.categoriesAndApps.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // helpForTreeView
            // 
            this.helpForTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("helpForTreeView.ImageStream")));
            this.helpForTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.helpForTreeView.Images.SetKeyName(0, "package.png");
            this.helpForTreeView.Images.SetKeyName(1, "text_list_bullets.png");
            this.helpForTreeView.Images.SetKeyName(2, "application_double.png");
            this.helpForTreeView.Images.SetKeyName(3, "application_xp_terminal.png");
            this.helpForTreeView.Images.SetKeyName(4, "film.png");
            this.helpForTreeView.Images.SetKeyName(5, "paintbrush.png");
            this.helpForTreeView.Images.SetKeyName(6, "world.png");
            this.helpForTreeView.Images.SetKeyName(7, "wrench.png");
            this.helpForTreeView.Images.SetKeyName(8, "plugin.png");
            this.helpForTreeView.Images.SetKeyName(9, "ruby.png");
            this.helpForTreeView.Images.SetKeyName(10, "shape_move_forwards.png");
            this.helpForTreeView.Images.SetKeyName(11, "page_word.png");
            // 
            // uninstallBTN
            // 
            this.uninstallBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uninstallBTN.Enabled = false;
            this.uninstallBTN.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallBTN.Image = global::RAppDM.Properties.Resources.package_delete;
            this.uninstallBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uninstallBTN.Location = new System.Drawing.Point(304, 271);
            this.uninstallBTN.Name = "uninstallBTN";
            this.uninstallBTN.Size = new System.Drawing.Size(92, 36);
            this.uninstallBTN.TabIndex = 20;
            this.uninstallBTN.Text = "Uninstall";
            this.uninstallBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uninstallBTN.UseVisualStyleBackColor = true;
            this.uninstallBTN.Visible = false;
            // 
            // settingsBTN
            // 
            this.settingsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBTN.Image = global::RAppDM.Properties.Resources.cog;
            this.settingsBTN.Location = new System.Drawing.Point(634, 0);
            this.settingsBTN.Name = "settingsBTN";
            this.settingsBTN.Size = new System.Drawing.Size(32, 32);
            this.settingsBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsBTN.TabIndex = 4;
            this.settingsBTN.TabStop = false;
            this.settingsBTN.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // sizes
            // 
            this.sizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sizes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizes.FormattingEnabled = true;
            this.sizes.Location = new System.Drawing.Point(300, 0);
            this.sizes.Name = "sizes";
            this.sizes.Size = new System.Drawing.Size(87, 65);
            this.sizes.TabIndex = 21;
            this.sizes.Visible = false;
            // 
            // AppManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(666, 319);
            this.Controls.Add(this.sizes);
            this.Controls.Add(this.uninstallBTN);
            this.Controls.Add(this.categoriesAndApps);
            this.Controls.Add(this.appIcon);
            this.Controls.Add(this.settingsBTN);
            this.Controls.Add(this.installBTN);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.versionLBL);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.downloadurls);
            this.Controls.Add(this.tempIndexes);
            this.Controls.Add(this.tempCategories);
            this.Controls.Add(this.tempApps);
            this.Controls.Add(this.silentargs);
            this.Controls.Add(this.descs);
            this.Controls.Add(this.iconurls);
            this.Controls.Add(this.apps);
            this.Controls.Add(this.versions);
            this.Controls.Add(this.descLBL);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 285);
            this.Name = "AppManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppManager_FormClosing);
            this.Load += new System.EventHandler(this.AppManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox apps;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Button installBTN;
        private System.Windows.Forms.PictureBox settingsBTN;
        private System.Windows.Forms.ListBox iconurls;
        private System.Windows.Forms.ListBox downloadurls;
        private System.Windows.Forms.ListBox categories;
        private System.Windows.Forms.Label descLBL;
        private System.Windows.Forms.ListBox silentargs;
        private System.Windows.Forms.ListBox descs;
        private System.Windows.Forms.ListBox tempApps;
        private System.Windows.Forms.ListBox tempCategories;
        private System.Windows.Forms.ListBox tempIndexes;
        private System.Windows.Forms.ListBox versions;
        private System.Windows.Forms.Label versionLBL;
        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.TreeView categoriesAndApps;
        private System.Windows.Forms.ImageList helpForTreeView;
        private System.Windows.Forms.Button uninstallBTN;
        private System.Windows.Forms.ListBox sizes;
    }
}