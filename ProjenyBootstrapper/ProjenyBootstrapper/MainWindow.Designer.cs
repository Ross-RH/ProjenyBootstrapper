namespace ProjenyBootstrapper
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBrowseCommonPackages = new System.Windows.Forms.Button();
			this.txtCommonPackages = new System.Windows.Forms.TextBox();
			this.lblCommonPackages = new System.Windows.Forms.Label();
			this.btnCreateRepo = new System.Windows.Forms.Button();
			this.panelProjectConfig = new System.Windows.Forms.Panel();
			this.ckUsePackageServer = new System.Windows.Forms.CheckBox();
			this.lblPackageServer = new System.Windows.Forms.Label();
			this.txtPackageServerPort = new System.Windows.Forms.TextBox();
			this.lblPackageServerPort = new System.Windows.Forms.Label();
			this.txtPackageServerIP = new System.Windows.Forms.TextBox();
			this.lblPackageServerIP = new System.Windows.Forms.Label();
			this.panelProjectDirectory = new System.Windows.Forms.Panel();
			this.btnBrowseProjectDirectory = new System.Windows.Forms.Button();
			this.txtProjectDirectory = new System.Windows.Forms.TextBox();
			this.lblProjectDirectory = new System.Windows.Forms.Label();
			this.lbProjenySettings = new System.Windows.Forms.Label();
			this.panelUnityEXE = new System.Windows.Forms.Panel();
			this.btnBrowseUnityEXE = new System.Windows.Forms.Button();
			this.txtBrowseUntiyEXE = new System.Windows.Forms.TextBox();
			this.lblUnityEXE = new System.Windows.Forms.Label();
			this.projectSettingsPanel = new System.Windows.Forms.Panel();
			this.btnCreateUpdate = new System.Windows.Forms.Button();
			this.ckOpenProject = new System.Windows.Forms.CheckBox();
			this.panelProjectName = new System.Windows.Forms.Panel();
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.lblProjectName = new System.Windows.Forms.Label();
			this.lblProjectSettings = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnReleaseFolder = new System.Windows.Forms.Button();
			this.txtReleaseFolder = new System.Windows.Forms.TextBox();
			this.lblReleaseFolder = new System.Windows.Forms.Label();
			this.flowLayoutPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelProjectConfig.SuspendLayout();
			this.panelProjectDirectory.SuspendLayout();
			this.panelUnityEXE.SuspendLayout();
			this.projectSettingsPanel.SuspendLayout();
			this.panelProjectName.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.Controls.Add(this.panel1);
			this.flowLayoutPanel.Controls.Add(this.projectSettingsPanel);
			this.flowLayoutPanel.Location = new System.Drawing.Point(7, 12);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(600, 350);
			this.flowLayoutPanel.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnCreateRepo);
			this.panel1.Controls.Add(this.panelProjectConfig);
			this.panel1.Controls.Add(this.panelProjectDirectory);
			this.panel1.Controls.Add(this.lbProjenySettings);
			this.panel1.Controls.Add(this.panelUnityEXE);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(597, 246);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnBrowseCommonPackages);
			this.panel2.Controls.Add(this.txtCommonPackages);
			this.panel2.Controls.Add(this.lblCommonPackages);
			this.panel2.Location = new System.Drawing.Point(34, 90);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(563, 31);
			this.panel2.TabIndex = 4;
			// 
			// btnBrowseCommonPackages
			// 
			this.btnBrowseCommonPackages.Location = new System.Drawing.Point(477, 4);
			this.btnBrowseCommonPackages.Name = "btnBrowseCommonPackages";
			this.btnBrowseCommonPackages.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseCommonPackages.TabIndex = 5;
			this.btnBrowseCommonPackages.Text = "Browse";
			this.btnBrowseCommonPackages.UseVisualStyleBackColor = true;
			this.btnBrowseCommonPackages.Click += new System.EventHandler(this.btnBrowseCommonPackagesClick);
			// 
			// txtCommonPackages
			// 
			this.txtCommonPackages.Location = new System.Drawing.Point(107, 6);
			this.txtCommonPackages.Name = "txtCommonPackages";
			this.txtCommonPackages.Size = new System.Drawing.Size(364, 20);
			this.txtCommonPackages.TabIndex = 1;
			// 
			// lblCommonPackages
			// 
			this.lblCommonPackages.AutoSize = true;
			this.lblCommonPackages.Location = new System.Drawing.Point(9, 9);
			this.lblCommonPackages.Name = "lblCommonPackages";
			this.lblCommonPackages.Size = new System.Drawing.Size(92, 13);
			this.lblCommonPackages.TabIndex = 0;
			this.lblCommonPackages.Text = "Shared Packages";
			// 
			// btnCreateRepo
			// 
			this.btnCreateRepo.Location = new System.Drawing.Point(490, 220);
			this.btnCreateRepo.Name = "btnCreateRepo";
			this.btnCreateRepo.Size = new System.Drawing.Size(96, 23);
			this.btnCreateRepo.TabIndex = 6;
			this.btnCreateRepo.Text = "Create  Repo";
			this.btnCreateRepo.UseVisualStyleBackColor = true;
			this.btnCreateRepo.Click += new System.EventHandler(this.btnCreateRepoClick);
			// 
			// panelProjectConfig
			// 
			this.panelProjectConfig.Controls.Add(this.ckUsePackageServer);
			this.panelProjectConfig.Controls.Add(this.lblPackageServer);
			this.panelProjectConfig.Controls.Add(this.txtPackageServerPort);
			this.panelProjectConfig.Controls.Add(this.lblPackageServerPort);
			this.panelProjectConfig.Controls.Add(this.txtPackageServerIP);
			this.panelProjectConfig.Controls.Add(this.lblPackageServerIP);
			this.panelProjectConfig.Location = new System.Drawing.Point(34, 155);
			this.panelProjectConfig.Name = "panelProjectConfig";
			this.panelProjectConfig.Size = new System.Drawing.Size(563, 60);
			this.panelProjectConfig.TabIndex = 0;
			// 
			// ckUsePackageServer
			// 
			this.ckUsePackageServer.AutoSize = true;
			this.ckUsePackageServer.Location = new System.Drawing.Point(44, 32);
			this.ckUsePackageServer.Name = "ckUsePackageServer";
			this.ckUsePackageServer.Size = new System.Drawing.Size(79, 17);
			this.ckUsePackageServer.TabIndex = 11;
			this.ckUsePackageServer.Text = "Use Server";
			this.ckUsePackageServer.UseVisualStyleBackColor = true;
			this.ckUsePackageServer.CheckedChanged += new System.EventHandler(this.ckUsePackageServerCheckedChanged);
			// 
			// lblPackageServer
			// 
			this.lblPackageServer.AutoSize = true;
			this.lblPackageServer.Location = new System.Drawing.Point(17, 10);
			this.lblPackageServer.Name = "lblPackageServer";
			this.lblPackageServer.Size = new System.Drawing.Size(84, 13);
			this.lblPackageServer.TabIndex = 4;
			this.lblPackageServer.Text = "Package Server";
			// 
			// txtPackageServerPort
			// 
			this.txtPackageServerPort.Location = new System.Drawing.Point(472, 30);
			this.txtPackageServerPort.Name = "txtPackageServerPort";
			this.txtPackageServerPort.Size = new System.Drawing.Size(80, 20);
			this.txtPackageServerPort.TabIndex = 3;
			// 
			// lblPackageServerPort
			// 
			this.lblPackageServerPort.AutoSize = true;
			this.lblPackageServerPort.Location = new System.Drawing.Point(445, 33);
			this.lblPackageServerPort.Name = "lblPackageServerPort";
			this.lblPackageServerPort.Size = new System.Drawing.Size(26, 13);
			this.lblPackageServerPort.TabIndex = 2;
			this.lblPackageServerPort.Text = "Port";
			// 
			// txtPackageServerIP
			// 
			this.txtPackageServerIP.Location = new System.Drawing.Point(201, 30);
			this.txtPackageServerIP.Name = "txtPackageServerIP";
			this.txtPackageServerIP.Size = new System.Drawing.Size(233, 20);
			this.txtPackageServerIP.TabIndex = 1;
			// 
			// lblPackageServerIP
			// 
			this.lblPackageServerIP.AutoSize = true;
			this.lblPackageServerIP.Location = new System.Drawing.Point(145, 33);
			this.lblPackageServerIP.Name = "lblPackageServerIP";
			this.lblPackageServerIP.Size = new System.Drawing.Size(50, 13);
			this.lblPackageServerIP.TabIndex = 0;
			this.lblPackageServerIP.Text = "IP / URL";
			// 
			// panelProjectDirectory
			// 
			this.panelProjectDirectory.Controls.Add(this.btnBrowseProjectDirectory);
			this.panelProjectDirectory.Controls.Add(this.txtProjectDirectory);
			this.panelProjectDirectory.Controls.Add(this.lblProjectDirectory);
			this.panelProjectDirectory.Location = new System.Drawing.Point(34, 26);
			this.panelProjectDirectory.Name = "panelProjectDirectory";
			this.panelProjectDirectory.Size = new System.Drawing.Size(563, 31);
			this.panelProjectDirectory.TabIndex = 0;
			// 
			// btnBrowseProjectDirectory
			// 
			this.btnBrowseProjectDirectory.Location = new System.Drawing.Point(477, 3);
			this.btnBrowseProjectDirectory.Name = "btnBrowseProjectDirectory";
			this.btnBrowseProjectDirectory.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseProjectDirectory.TabIndex = 2;
			this.btnBrowseProjectDirectory.Text = "Browse";
			this.btnBrowseProjectDirectory.UseVisualStyleBackColor = true;
			this.btnBrowseProjectDirectory.Click += new System.EventHandler(this.btnBrowseProjectDirectoryClick);
			// 
			// txtProjectDirectory
			// 
			this.txtProjectDirectory.Location = new System.Drawing.Point(107, 6);
			this.txtProjectDirectory.Name = "txtProjectDirectory";
			this.txtProjectDirectory.Size = new System.Drawing.Size(364, 20);
			this.txtProjectDirectory.TabIndex = 1;
			// 
			// lblProjectDirectory
			// 
			this.lblProjectDirectory.AutoSize = true;
			this.lblProjectDirectory.Location = new System.Drawing.Point(11, 9);
			this.lblProjectDirectory.Name = "lblProjectDirectory";
			this.lblProjectDirectory.Size = new System.Drawing.Size(90, 13);
			this.lblProjectDirectory.TabIndex = 0;
			this.lblProjectDirectory.Text = "Projects Directory";
			// 
			// lbProjenySettings
			// 
			this.lbProjenySettings.AutoSize = true;
			this.lbProjenySettings.Location = new System.Drawing.Point(9, 10);
			this.lbProjenySettings.Name = "lbProjenySettings";
			this.lbProjenySettings.Size = new System.Drawing.Size(112, 13);
			this.lbProjenySettings.TabIndex = 5;
			this.lbProjenySettings.Text = "Projeny Repo Settings";
			// 
			// panelUnityEXE
			// 
			this.panelUnityEXE.Controls.Add(this.btnBrowseUnityEXE);
			this.panelUnityEXE.Controls.Add(this.txtBrowseUntiyEXE);
			this.panelUnityEXE.Controls.Add(this.lblUnityEXE);
			this.panelUnityEXE.Location = new System.Drawing.Point(34, 58);
			this.panelUnityEXE.Name = "panelUnityEXE";
			this.panelUnityEXE.Size = new System.Drawing.Size(563, 31);
			this.panelUnityEXE.TabIndex = 2;
			// 
			// btnBrowseUnityEXE
			// 
			this.btnBrowseUnityEXE.Location = new System.Drawing.Point(477, 4);
			this.btnBrowseUnityEXE.Name = "btnBrowseUnityEXE";
			this.btnBrowseUnityEXE.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseUnityEXE.TabIndex = 4;
			this.btnBrowseUnityEXE.Text = "Browse";
			this.btnBrowseUnityEXE.UseVisualStyleBackColor = true;
			this.btnBrowseUnityEXE.Click += new System.EventHandler(this.btnBrowseUnityEXEClick);
			// 
			// txtBrowseUntiyEXE
			// 
			this.txtBrowseUntiyEXE.Location = new System.Drawing.Point(107, 6);
			this.txtBrowseUntiyEXE.Name = "txtBrowseUntiyEXE";
			this.txtBrowseUntiyEXE.Size = new System.Drawing.Size(364, 20);
			this.txtBrowseUntiyEXE.TabIndex = 3;
			// 
			// lblUnityEXE
			// 
			this.lblUnityEXE.AutoSize = true;
			this.lblUnityEXE.Location = new System.Drawing.Point(14, 9);
			this.lblUnityEXE.Name = "lblUnityEXE";
			this.lblUnityEXE.Size = new System.Drawing.Size(87, 13);
			this.lblUnityEXE.TabIndex = 0;
			this.lblUnityEXE.Text = "Unity Executable";
			// 
			// projectSettingsPanel
			// 
			this.projectSettingsPanel.Controls.Add(this.btnCreateUpdate);
			this.projectSettingsPanel.Controls.Add(this.ckOpenProject);
			this.projectSettingsPanel.Controls.Add(this.panelProjectName);
			this.projectSettingsPanel.Controls.Add(this.lblProjectSettings);
			this.projectSettingsPanel.Location = new System.Drawing.Point(3, 255);
			this.projectSettingsPanel.Name = "projectSettingsPanel";
			this.projectSettingsPanel.Size = new System.Drawing.Size(597, 89);
			this.projectSettingsPanel.TabIndex = 0;
			// 
			// btnCreateUpdate
			// 
			this.btnCreateUpdate.Location = new System.Drawing.Point(490, 62);
			this.btnCreateUpdate.Name = "btnCreateUpdate";
			this.btnCreateUpdate.Size = new System.Drawing.Size(96, 23);
			this.btnCreateUpdate.TabIndex = 1;
			this.btnCreateUpdate.Text = "Create  Project";
			this.btnCreateUpdate.UseVisualStyleBackColor = true;
			this.btnCreateUpdate.Click += new System.EventHandler(this.btnCreateUpdateClick);
			// 
			// ckOpenProject
			// 
			this.ckOpenProject.AutoSize = true;
			this.ckOpenProject.Location = new System.Drawing.Point(345, 66);
			this.ckOpenProject.Name = "ckOpenProject";
			this.ckOpenProject.Size = new System.Drawing.Size(139, 17);
			this.ckOpenProject.TabIndex = 10;
			this.ckOpenProject.Text = "Open Project On Create";
			this.ckOpenProject.UseVisualStyleBackColor = true;
			// 
			// panelProjectName
			// 
			this.panelProjectName.Controls.Add(this.txtProjectName);
			this.panelProjectName.Controls.Add(this.lblProjectName);
			this.panelProjectName.Location = new System.Drawing.Point(34, 25);
			this.panelProjectName.Name = "panelProjectName";
			this.panelProjectName.Size = new System.Drawing.Size(563, 31);
			this.panelProjectName.TabIndex = 1;
			// 
			// txtProjectName
			// 
			this.txtProjectName.Location = new System.Drawing.Point(107, 6);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(445, 20);
			this.txtProjectName.TabIndex = 1;
			// 
			// lblProjectName
			// 
			this.lblProjectName.AutoSize = true;
			this.lblProjectName.Location = new System.Drawing.Point(30, 9);
			this.lblProjectName.Name = "lblProjectName";
			this.lblProjectName.Size = new System.Drawing.Size(71, 13);
			this.lblProjectName.TabIndex = 0;
			this.lblProjectName.Text = "Project Name";
			// 
			// lblProjectSettings
			// 
			this.lblProjectSettings.AutoSize = true;
			this.lblProjectSettings.Location = new System.Drawing.Point(9, 9);
			this.lblProjectSettings.Name = "lblProjectSettings";
			this.lblProjectSettings.Size = new System.Drawing.Size(81, 13);
			this.lblProjectSettings.TabIndex = 3;
			this.lblProjectSettings.Text = "Project Settings";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnReleaseFolder);
			this.panel3.Controls.Add(this.txtReleaseFolder);
			this.panel3.Controls.Add(this.lblReleaseFolder);
			this.panel3.Location = new System.Drawing.Point(34, 122);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(563, 31);
			this.panel3.TabIndex = 6;
			// 
			// btnReleaseFolder
			// 
			this.btnReleaseFolder.Location = new System.Drawing.Point(477, 4);
			this.btnReleaseFolder.Name = "btnReleaseFolder";
			this.btnReleaseFolder.Size = new System.Drawing.Size(75, 23);
			this.btnReleaseFolder.TabIndex = 5;
			this.btnReleaseFolder.Text = "Browse";
			this.btnReleaseFolder.UseVisualStyleBackColor = true;
			this.btnReleaseFolder.Click += new System.EventHandler(this.btnReleaseFolderClick);
			// 
			// txtReleaseFolder
			// 
			this.txtReleaseFolder.Location = new System.Drawing.Point(107, 6);
			this.txtReleaseFolder.Name = "txtReleaseFolder";
			this.txtReleaseFolder.Size = new System.Drawing.Size(364, 20);
			this.txtReleaseFolder.TabIndex = 1;
			// 
			// lblReleaseFolder
			// 
			this.lblReleaseFolder.AutoSize = true;
			this.lblReleaseFolder.Location = new System.Drawing.Point(9, 9);
			this.lblReleaseFolder.Name = "lblReleaseFolder";
			this.lblReleaseFolder.Size = new System.Drawing.Size(78, 13);
			this.lblReleaseFolder.TabIndex = 0;
			this.lblReleaseFolder.Text = "Release Folder";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 365);
			this.Controls.Add(this.flowLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(627, 404);
			this.MinimumSize = new System.Drawing.Size(627, 404);
			this.Name = "MainWindow";
			this.Text = "Projeny Bootstrapper";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.flowLayoutPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panelProjectConfig.ResumeLayout(false);
			this.panelProjectConfig.PerformLayout();
			this.panelProjectDirectory.ResumeLayout(false);
			this.panelProjectDirectory.PerformLayout();
			this.panelUnityEXE.ResumeLayout(false);
			this.panelUnityEXE.PerformLayout();
			this.projectSettingsPanel.ResumeLayout(false);
			this.projectSettingsPanel.PerformLayout();
			this.panelProjectName.ResumeLayout(false);
			this.panelProjectName.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion



		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.Panel projectSettingsPanel;
		private System.Windows.Forms.Panel panelProjectName;
		private System.Windows.Forms.Panel panelUnityEXE;

		private System.Windows.Forms.TextBox txtProjectName;
		private System.Windows.Forms.Label lblProjectName;

		private System.Windows.Forms.Label lblUnityEXE;
		private System.Windows.Forms.Label lblProjectSettings;

		private System.Windows.Forms.Button btnCreateUpdate;
		private System.Windows.Forms.Button btnBrowseUnityEXE;
		private System.Windows.Forms.TextBox txtBrowseUntiyEXE;
		private System.Windows.Forms.CheckBox ckOpenProject;
		private System.Windows.Forms.Panel panelProjectConfig;
		private System.Windows.Forms.TextBox txtPackageServerPort;
		private System.Windows.Forms.Label lblPackageServerPort;
		private System.Windows.Forms.TextBox txtPackageServerIP;
		private System.Windows.Forms.Label lblPackageServerIP;
		private System.Windows.Forms.Panel panelProjectDirectory;
		private System.Windows.Forms.Button btnBrowseProjectDirectory;
		private System.Windows.Forms.TextBox txtProjectDirectory;
		private System.Windows.Forms.Label lblProjectDirectory;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbProjenySettings;
		private System.Windows.Forms.Button btnCreateRepo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBrowseCommonPackages;
		private System.Windows.Forms.TextBox txtCommonPackages;
		private System.Windows.Forms.Label lblCommonPackages;
		private System.Windows.Forms.CheckBox ckUsePackageServer;
		private System.Windows.Forms.Label lblPackageServer;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnReleaseFolder;
		private System.Windows.Forms.TextBox txtReleaseFolder;
		private System.Windows.Forms.Label lblReleaseFolder;
	}
}

