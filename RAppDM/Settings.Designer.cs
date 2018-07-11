namespace RAppDM
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.repoList = new System.Windows.Forms.ListBox();
            this.repoURLlbl = new System.Windows.Forms.Label();
            this.addRepo = new System.Windows.Forms.Button();
            this.remRepo = new System.Windows.Forms.Button();
            this.downloadRepo = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.repoSection = new System.Windows.Forms.GroupBox();
            this.panelWithPercentage = new System.Windows.Forms.Panel();
            this.downloadpercentage = new System.Windows.Forms.Label();
            this.precentagebar = new System.Windows.Forms.ProgressBar();
            this.repoURL = new System.Windows.Forms.TextBox();
            this.downloadStartRepos = new System.Windows.Forms.CheckBox();
            this.askCloseRC = new System.Windows.Forms.CheckBox();
            this.RepoCreator = new System.Windows.Forms.Button();
            this.enableDebugMode = new System.Windows.Forms.CheckBox();
            this.advancedSection = new System.Windows.Forms.GroupBox();
            this.bTime = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.versionLBL = new System.Windows.Forms.Label();
            this.repoSection.SuspendLayout();
            this.panelWithPercentage.SuspendLayout();
            this.advancedSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // repoList
            // 
            this.repoList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repoList.FormattingEnabled = true;
            this.repoList.Location = new System.Drawing.Point(6, 19);
            this.repoList.Name = "repoList";
            this.repoList.Size = new System.Drawing.Size(163, 186);
            this.repoList.TabIndex = 0;
            // 
            // repoURLlbl
            // 
            this.repoURLlbl.AutoSize = true;
            this.repoURLlbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repoURLlbl.Location = new System.Drawing.Point(169, 19);
            this.repoURLlbl.Name = "repoURLlbl";
            this.repoURLlbl.Size = new System.Drawing.Size(88, 13);
            this.repoURLlbl.TabIndex = 1;
            this.repoURLlbl.Text = "Repository URL:";
            // 
            // addRepo
            // 
            this.addRepo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRepo.Location = new System.Drawing.Point(172, 62);
            this.addRepo.Name = "addRepo";
            this.addRepo.Size = new System.Drawing.Size(87, 23);
            this.addRepo.TabIndex = 2;
            this.addRepo.Text = "Add Repo";
            this.addRepo.UseVisualStyleBackColor = true;
            this.addRepo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // remRepo
            // 
            this.remRepo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remRepo.Location = new System.Drawing.Point(265, 62);
            this.remRepo.Name = "remRepo";
            this.remRepo.Size = new System.Drawing.Size(87, 23);
            this.remRepo.TabIndex = 3;
            this.remRepo.Text = "Remove Repo";
            this.remRepo.UseVisualStyleBackColor = true;
            this.remRepo.Click += new System.EventHandler(this.Button2_Click);
            // 
            // downloadRepo
            // 
            this.downloadRepo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadRepo.Location = new System.Drawing.Point(172, 91);
            this.downloadRepo.Name = "downloadRepo";
            this.downloadRepo.Size = new System.Drawing.Size(180, 23);
            this.downloadRepo.TabIndex = 4;
            this.downloadRepo.Text = "Download Repositories";
            this.downloadRepo.UseVisualStyleBackColor = true;
            this.downloadRepo.Click += new System.EventHandler(this.Button3_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.Location = new System.Drawing.Point(316, 184);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(87, 23);
            this.saveChanges.TabIndex = 7;
            this.saveChanges.Text = "Save changes";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.Button4_Click);
            // 
            // repoSection
            // 
            this.repoSection.Controls.Add(this.panelWithPercentage);
            this.repoSection.Controls.Add(this.repoURL);
            this.repoSection.Controls.Add(this.downloadStartRepos);
            this.repoSection.Controls.Add(this.repoList);
            this.repoSection.Controls.Add(this.downloadRepo);
            this.repoSection.Controls.Add(this.saveChanges);
            this.repoSection.Controls.Add(this.repoURLlbl);
            this.repoSection.Controls.Add(this.addRepo);
            this.repoSection.Controls.Add(this.remRepo);
            this.repoSection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repoSection.Location = new System.Drawing.Point(12, 12);
            this.repoSection.Name = "repoSection";
            this.repoSection.Size = new System.Drawing.Size(409, 228);
            this.repoSection.TabIndex = 8;
            this.repoSection.TabStop = false;
            this.repoSection.Text = "Repositories";
            // 
            // panelWithPercentage
            // 
            this.panelWithPercentage.Controls.Add(this.downloadpercentage);
            this.panelWithPercentage.Controls.Add(this.precentagebar);
            this.panelWithPercentage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWithPercentage.Location = new System.Drawing.Point(3, 210);
            this.panelWithPercentage.Name = "panelWithPercentage";
            this.panelWithPercentage.Size = new System.Drawing.Size(403, 15);
            this.panelWithPercentage.TabIndex = 13;
            // 
            // downloadpercentage
            // 
            this.downloadpercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadpercentage.Location = new System.Drawing.Point(349, 0);
            this.downloadpercentage.Name = "downloadpercentage";
            this.downloadpercentage.Size = new System.Drawing.Size(54, 15);
            this.downloadpercentage.TabIndex = 9;
            this.downloadpercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precentagebar
            // 
            this.precentagebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.precentagebar.Location = new System.Drawing.Point(0, 0);
            this.precentagebar.Name = "precentagebar";
            this.precentagebar.Size = new System.Drawing.Size(349, 15);
            this.precentagebar.TabIndex = 8;
            // 
            // repoURL
            // 
            this.repoURL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repoURL.Location = new System.Drawing.Point(175, 34);
            this.repoURL.Name = "repoURL";
            this.repoURL.Size = new System.Drawing.Size(228, 22);
            this.repoURL.TabIndex = 9;
            // 
            // downloadStartRepos
            // 
            this.downloadStartRepos.AutoSize = true;
            this.downloadStartRepos.Checked = true;
            this.downloadStartRepos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downloadStartRepos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadStartRepos.Location = new System.Drawing.Point(172, 120);
            this.downloadStartRepos.Name = "downloadStartRepos";
            this.downloadStartRepos.Size = new System.Drawing.Size(187, 17);
            this.downloadStartRepos.TabIndex = 11;
            this.downloadStartRepos.Text = "Download repos when starting";
            this.downloadStartRepos.UseVisualStyleBackColor = true;
            this.downloadStartRepos.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // askCloseRC
            // 
            this.askCloseRC.AutoSize = true;
            this.askCloseRC.Checked = true;
            this.askCloseRC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.askCloseRC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askCloseRC.Location = new System.Drawing.Point(6, 48);
            this.askCloseRC.Name = "askCloseRC";
            this.askCloseRC.Size = new System.Drawing.Size(182, 17);
            this.askCloseRC.TabIndex = 10;
            this.askCloseRC.Text = "Ask when closing repo creator";
            this.askCloseRC.UseVisualStyleBackColor = true;
            this.askCloseRC.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // RepoCreator
            // 
            this.RepoCreator.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoCreator.Location = new System.Drawing.Point(6, 21);
            this.RepoCreator.Name = "RepoCreator";
            this.RepoCreator.Size = new System.Drawing.Size(175, 23);
            this.RepoCreator.TabIndex = 10;
            this.RepoCreator.Text = "Repository Creator";
            this.RepoCreator.UseVisualStyleBackColor = true;
            this.RepoCreator.Click += new System.EventHandler(this.Button5_Click);
            // 
            // enableDebugMode
            // 
            this.enableDebugMode.AutoSize = true;
            this.enableDebugMode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableDebugMode.Location = new System.Drawing.Point(6, 65);
            this.enableDebugMode.Name = "enableDebugMode";
            this.enableDebugMode.Size = new System.Drawing.Size(132, 17);
            this.enableDebugMode.TabIndex = 9;
            this.enableDebugMode.Text = "Enable Debug Mode";
            this.enableDebugMode.UseVisualStyleBackColor = true;
            this.enableDebugMode.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // advancedSection
            // 
            this.advancedSection.Controls.Add(this.enableDebugMode);
            this.advancedSection.Controls.Add(this.bTime);
            this.advancedSection.Controls.Add(this.RepoCreator);
            this.advancedSection.Controls.Add(this.askCloseRC);
            this.advancedSection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedSection.Location = new System.Drawing.Point(427, 15);
            this.advancedSection.Name = "advancedSection";
            this.advancedSection.Size = new System.Drawing.Size(187, 111);
            this.advancedSection.TabIndex = 12;
            this.advancedSection.TabStop = false;
            this.advancedSection.Text = "Advanced";
            // 
            // bTime
            // 
            this.bTime.AutoSize = true;
            this.bTime.Location = new System.Drawing.Point(3, 85);
            this.bTime.Name = "bTime";
            this.bTime.Size = new System.Drawing.Size(61, 13);
            this.bTime.TabIndex = 14;
            this.bTime.Text = "Boot Time:";
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(518, 209);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(100, 23);
            this.aboutButton.TabIndex = 13;
            this.aboutButton.Text = "About RAppDM";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // versionLBL
            // 
            this.versionLBL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.versionLBL.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLBL.Location = new System.Drawing.Point(0, 235);
            this.versionLBL.Name = "versionLBL";
            this.versionLBL.Size = new System.Drawing.Size(630, 13);
            this.versionLBL.TabIndex = 14;
            this.versionLBL.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 248);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.advancedSection);
            this.Controls.Add(this.repoSection);
            this.Controls.Add(this.versionLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.repoSection.ResumeLayout(false);
            this.repoSection.PerformLayout();
            this.panelWithPercentage.ResumeLayout(false);
            this.advancedSection.ResumeLayout(false);
            this.advancedSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox repoList;
        private System.Windows.Forms.Label repoURLlbl;
        private System.Windows.Forms.Button addRepo;
        private System.Windows.Forms.Button remRepo;
        private System.Windows.Forms.Button downloadRepo;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.GroupBox repoSection;
        private System.Windows.Forms.ProgressBar precentagebar;
        private System.Windows.Forms.TextBox repoURL;
        private System.Windows.Forms.Button RepoCreator;
        private System.Windows.Forms.CheckBox enableDebugMode;
        private System.Windows.Forms.CheckBox askCloseRC;
        private System.Windows.Forms.CheckBox downloadStartRepos;
        private System.Windows.Forms.GroupBox advancedSection;
        private System.Windows.Forms.Label bTime;
        private System.Windows.Forms.Panel panelWithPercentage;
        private System.Windows.Forms.Label downloadpercentage;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label versionLBL;
    }
}