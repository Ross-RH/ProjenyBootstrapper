using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using ProjenyBootstrapper.Properties;
using YamlDotNet.Serialization;

namespace ProjenyBootstrapper
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			//Load up settings here
			txtProjectDirectory.Text = Settings.Default.DefaultProjectDirectory;
			txtBrowseUntiyEXE.Text = Settings.Default.DefaultUnityExePath;
			txtPackageServerIP.Text = Settings.Default.DefaultPackageServerIP;
			txtPackageServerPort.Text = Settings.Default.DefaultPackageServerPort;
			txtCommonPackages.Text = Settings.Default.DefaultPackageCommonDirectory;
			txtReleaseFolder.Text = Settings.Default.DefaultReleaseFolderDirectory;
			ckUsePackageServer.Checked = Settings.Default.DefaultUsePackageServer;

			ValidateProjenyInstall();
		}

		private void UpdateRepoSettings()
		{
			Settings.Default.DefaultProjectDirectory = txtProjectDirectory.Text;
			Settings.Default.DefaultUnityExePath = txtBrowseUntiyEXE.Text;
			Settings.Default.DefaultPackageServerIP = txtPackageServerIP.Text;
			Settings.Default.DefaultPackageServerPort = txtPackageServerPort.Text;
			Settings.Default.DefaultPackageCommonDirectory = txtCommonPackages.Text;
			Settings.Default.DefaultReleaseFolderDirectory = txtReleaseFolder.Text;
			Settings.Default.DefaultUsePackageServer = ckUsePackageServer.Checked;
			Settings.Default.Save();
		}

		private string GetBrowsedFolderPath(string description, string startPath = "")
		{
			string path = string.Empty;

			CommonOpenFileDialog dialog = new CommonOpenFileDialog();

			dialog.InitialDirectory = startPath;

			dialog.Title = description;
			dialog.RestoreDirectory = true;
			dialog.Multiselect = false;
			dialog.IsFolderPicker = true;

			CommonFileDialogResult result = dialog.ShowDialog();
			if(result == CommonFileDialogResult.Ok)
			{
				path = dialog.FileName;
			}
			return path;
		}

		private string GetBrowsedFilePath(string description, string startPath = "")
		{
			string path = string.Empty;

			OpenFileDialog dialog = new OpenFileDialog();

			dialog.InitialDirectory = startPath;

			dialog.Title = description;
			dialog.RestoreDirectory = true;
			dialog.CheckFileExists = true;
			dialog.CheckPathExists = true;
			dialog.AddExtension = true;
			dialog.DereferenceLinks = true;
			dialog.Multiselect = false;
			dialog.Filter = "Executable | *.exe";

			DialogResult result = dialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				path = dialog.FileName;
			}
			return path;
		}

		private void btnBrowseProjectDirectoryClick(object sender, EventArgs e)
		{
			string directoryPath = GetBrowsedFolderPath("Select your project's directory.", Settings.Default.DefaultProjectDirectory);
			if (directoryPath != string.Empty)
			{
				txtProjectDirectory.Text = directoryPath;
			}	
		}

		private void btnBrowseUnityEXEClick(object sender, EventArgs e)
		{
			string filePath = GetBrowsedFilePath("Select your Unity editor.", Settings.Default.DefaultUnityExePath);
			if(filePath != string.Empty)
			{
				txtBrowseUntiyEXE.Text = filePath;
			}			
		}

		private void btnBrowseCommonPackagesClick(object sender, EventArgs e)
		{
			string filePath = GetBrowsedFolderPath("Select a folder for packages shared across all repo's.", Settings.Default.DefaultPackageCommonDirectory);
			if (filePath != string.Empty)
			{
				txtCommonPackages.Text = filePath;
			}
		}


		private void btnReleaseFolderClick(object sender, EventArgs e)
		{
			string filePath = GetBrowsedFolderPath("Select a folder for release sources", Settings.Default.DefaultReleaseFolderDirectory);
			if (filePath != string.Empty)
			{
				txtReleaseFolder.Text = filePath;
			}
		}

		private void ckUsePackageServerCheckedChanged(object sender, EventArgs e)
		{
			if (ckUsePackageServer.Checked)
			{
				txtPackageServerIP.Enabled = true;
				txtPackageServerPort.Enabled = true;
			}
			else
			{
				txtPackageServerIP.Enabled = false;
				txtPackageServerPort.Enabled = false;
			}
		}

		private bool ValidateRepoInput()
		{
			bool valid = ValidateProjenyInstall() && ValidateRepoDirectory() && ValidateUnityExePath();
			if(ckUsePackageServer.Checked)
			{
				return valid && ValidateServerPort() && ValidatePackageServer();
			}
			else
			{
				return valid;
			}
		}

		private bool ValidateProjectInput()
		{
			return ValidateRepoInput() && ValidateProjectLocation();
		}

		private bool ValidateProjectExists()
		{
			if (Directory.Exists(txtProjectDirectory.Text + "/" + txtProjectName.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool ValidateRepoExists()
		{
			if (File.Exists(txtProjectDirectory.Text + "/Projeny.yaml"))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool ValidateRepoDirectory()
		{
			bool projectDirPathValid = true;
			try
			{
				Path.GetFullPath(txtProjectDirectory.Text);
			}
			catch (Exception e)
			{
				projectDirPathValid = false;
			}

			if (!projectDirPathValid || !Path.IsPathRooted(txtProjectDirectory.Text) || txtProjectDirectory.Text == string.Empty)
			{
				MessageBox.Show("Project directory invalid.", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return true;
			}
			return projectDirPathValid;
		}

		private bool ValidateProjectLocation()
		{
			if(!ValidateRepoDirectory())
			{
				return false;
			}

			bool projectFolderValid = true;
			try
			{
				Path.GetFullPath(txtProjectDirectory.Text + "\\" + txtProjectName.Text);
			}
			catch (Exception e)
			{
				projectFolderValid = false;
			}

			if (!projectFolderValid || !Path.IsPathRooted(txtProjectDirectory.Text + "\\" + txtProjectName.Text) || txtProjectName.Text == string.Empty)
			{
				MessageBox.Show("Project name invalid.", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			return projectFolderValid;
		}

		private bool ValidateUnityExePath()
		{
			bool exePathValid = true;
			try
			{
				Path.GetFullPath(txtBrowseUntiyEXE.Text);
			}
			catch (Exception e)
			{
				exePathValid = false;
			}

			if (!exePathValid || !Path.IsPathRooted(txtBrowseUntiyEXE.Text) || txtBrowseUntiyEXE.Text == string.Empty)
			{
				MessageBox.Show("Unity Executable invalid", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			return exePathValid;
		}

		private bool ValidatePackageServer()
		{
			try
			{
				using (var client = new TcpClient(txtPackageServerIP.Text, int.Parse(txtPackageServerPort.Text)))
				{	
					return true;
				}
			}
			catch (SocketException e)
			{
				MessageBox.Show("Cant connect to package server:" + e.Message + "("+e.GetBaseException()+")", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
		}

		private bool ValidateServerPort()
		{
			bool portValid = true;
			try
			{
				int.Parse(txtPackageServerPort.Text);
			}
			catch (Exception e)
			{
				MessageBox.Show("Package server port not valid: " + e.Message, "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				portValid =  false;
			}
			return portValid;
		}

		private void btnCreateRepoClick(object sender, EventArgs e)
		{
			if (!ValidateRepoInput())
			{
				return;
			}
			else if(ValidateRepoExists())
			{
				MessageBox.Show("Repo already exists.", "Repo Exists", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else
			{
				UpdateRepoSettings();
				CreateRepo();
			}
		}

		private void btnCreateUpdateClick(object sender, EventArgs e)
		{
			if(!ValidateProjectInput())
			{
				return;
			}
			else if (!ValidateRepoExists())
			{
				MessageBox.Show("Cant find repo. Please make sure it exists and is referenced before creating a project.", "Missing Repo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else if(ValidateProjectExists())
			{
				MessageBox.Show("Project already exists.", "Project Exists", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else
			{
				CreateProject();
			}
		}

		private bool ValidateProjenyInstall()
		{
			string path = Environment.GetEnvironmentVariable("PATH");
			foreach(string s in path.Split(';'))
			{
				if(File.Exists(s + "\\" + "Prj.bat"))
				{
					return true;
				}
			}

			MessageBox.Show("Please ensure Projeny is installed and '[InstallDir]/Bin' is added to your PATH before proceeding.", "Missing dependencies", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			System.Diagnostics.Process.Start("https://github.com/modesttree/projeny/releases");
			return false;
		}

		private void CreateRepo()
		{
			//Create project directory
			try
			{
				System.IO.Directory.CreateDirectory(txtProjectDirectory.Text);
			}
			catch (Exception e)
			{
				MessageBox.Show("Failed to create project directory: " + e.Message, "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			//Create projeny project
			try
			{
				using (Process process = new Process())
				{

						process.StartInfo.WorkingDirectory = txtProjectDirectory.Text;
						process.StartInfo.FileName = "prj";
						process.StartInfo.Arguments = "-cc";

						process.Start();

						if (!process.WaitForExit(10000)) //timeout after 10 seconds
						{
							process.Kill();
							throw new Exception("Process timed while creating repo.");
						}

						CreateProjenyRepoConfig("http://" + txtPackageServerIP.Text + ":" + txtPackageServerPort.Text,
												txtBrowseUntiyEXE.Text, txtProjectDirectory.Text, txtCommonPackages.Text);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Error while creating repo: " + e.Message, "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}

		}

		private void CreateProject()
		{
			bool success = true;
			//Create projeny project
			try
			{
				using (Process process = new Process())
				{
					process.StartInfo.WorkingDirectory = txtProjectDirectory.Text;
					process.StartInfo.FileName = "prj";
					process.StartInfo.Arguments = "--project " + txtProjectName.Text + " --createProject"; 

					process.Start();

					if (!process.WaitForExit(10000)) //timeout after 10 seconds
					{
						process.Kill();
						throw new Exception("Process timed out while creating project.");
					}
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Error while creating project: " + e.Message, "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				success = false;
			}

			//TODO: fill in config.. default works ok for now
			CreateProjenyProjectConfig();

			if(success)
			{
				MessageBox.Show("Project Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}		

			//Open unity
			if (ckOpenProject.Checked)
			{
				string projectPath = txtProjectDirectory.Text + "\\UnityProjects\\" + txtProjectName.Text + "\\" + txtProjectName.Text + "-Windows"; 
				try
				{
					bool started = false;
					using (Process process = new Process())
					{
						process.StartInfo.FileName = txtBrowseUntiyEXE.Text;
						process.StartInfo.Arguments = "-projectPath " + projectPath;

						if (!process.Start())
						{
							MessageBox.Show("Failed to start unity. \nProject exists at:" + projectPath, "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						}
					}
				}
				catch (Exception e)
				{
					MessageBox.Show("Failed to start unity: " + e.Message + " \nProject exists at:" + projectPath, "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
		}

		private void CreateProjenyRepoConfig(string fileServerURL, string unityExePath, string projectDir, string commonPackagesDir)
		{
			//Construct object graph
			Model.PathVars pathVars = new Model.PathVars();
			pathVars.UnityExePath = unityExePath.Replace('\\', '/');

			if(!commonPackagesDir.Equals(string.Empty))
			{
				pathVars.ProjenyPackagesDir = commonPackagesDir.Replace('\\', '/');
			}
			
			pathVars.UnityProjectsDir = "[ConfigDir]/UnityProjects";
			pathVars.SharedUnityPackagesDir = "[ConfigDir]/UnityPackages";
			pathVars.LogPath = "[ConfigDir]/PrjLog.txt";

			List<Model.ReleaseSource> releaseSources = new List<Model.ReleaseSource>();
			if (ckUsePackageServer.Checked)
			{
				releaseSources.Add(new Model.FileServerReleaseSource(fileServerURL + "/ProjenyReleaseManifest.txt")); 
			}

			if (!txtReleaseFolder.Text.Equals(string.Empty))
			{
				releaseSources.Add(new Model.PathReleaseSource(txtReleaseFolder.Text));
			}

			Model.RepoConfig config = new Model.RepoConfig(pathVars, releaseSources.ToArray());

			//Serialize
			Serializer serializer = new SerializerBuilder().Build();
			string yaml = serializer.Serialize(config);

			// Write the string to a file.
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(projectDir + "/Projeny.yaml"))
			{
				file.WriteLine(yaml);
				file.Close();
			}

			MessageBox.Show("Projeny Repo Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CreateProjenyProjectConfig()
		{
			//Default config is fine for now
		}

	}
}
