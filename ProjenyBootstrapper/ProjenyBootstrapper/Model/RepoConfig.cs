using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace ProjenyBootstrapper.Model
{
	[Serializable]
	class RepoConfig
	{
		public RepoConfig(PathVars pathVars, ReleaseSource[] releaseSources)
		{
			this.PathVars = pathVars;
			this.ReleaseSources = releaseSources;
		}

		public PathVars PathVars { get; set; }
		public ReleaseSource[] ReleaseSources { get; set; }
	}

	/// <summary>
	/// This is a collection of paths that are used by projeny
	/// You can also define your own variables here and use them in any of the config files
	/// Note also that you can use environment variables here the same way eg: [SOME_ENVIRONMENT_VARIABLE]
	/// </summary>
	[Serializable]
	class PathVars
	{
		/// <summary>
		/// This setting is required
		/// This will determine where projeny looks for the unity projects
		/// </summary>
		public string UnityProjectsDir { get; set; }

		//Shared between the projects in the projeny repo
		public string SharedUnityPackagesDir { get; set; }

		//Separate from any repo
		public string ProjenyPackagesDir { get; set; }

		/// <summary>
		/// This value will determine where the `prj` command outputs 
		/// detailed logging information
		/// </summary>
		public string LogPath { get; set; }

		/// <summary>
		/// This setting is necessary for many different Projeny operations 
		/// so that Projeny knows how to run Unity. By default it will 
		/// guess the following pathts
		/// </summary>
		public string UnityExePath { get; set; }

		/// <summary>
		/// This value is used when using the command line options `-b` or 
		/// `bf` or `bcs` (see command line reference section for details on these)
		/// It is used to build visual studio solution files
		/// By default it will assume the following path unless you specify it yourself
		/// </summary>
		public string MsBuildExePath { get; set; }

		/// <summary>
		/// This value is required when UseDevenv setting (see below) is set to true
		/// </summary>
		public string VisualStudioCommandLinePath { get; set; }

		/// <summary>
		/// This value is required for the button "Open Solution" in package manager,
		/// or the equivalent command line option `prj -ocs`
		/// </summary>
		public string VisualStudioIdePath { get; set; }
	}

	/// <summary>
	/// Custom release sources can also be specified in `Projeny.yaml` if 
	/// you want the Releases list to contain more than just items from the asset store cache
	/// </summary>
	public class ReleaseSource
	{

	}

	[Serializable]
	public class FileServerReleaseSource : ReleaseSource
	{
		public FileServerReleaseSource(string manifestURL)
		{
			this.FileServer = new URL(manifestURL);
		}

		public URL FileServer { get; set; }

		[Serializable]
		public class URL
		{
			public URL(string manifestUrl)
			{
				this.ManifestUrl = manifestUrl;
			}
			public string ManifestUrl { get; set; }
		}	
	}

	[Serializable]
	public class PathReleaseSource : ReleaseSource
	{
		public PathReleaseSource(string path)
		{
			this.LocalFolder = new LocalPath(path);
		}

		public LocalPath LocalFolder { get; set; }

		[Serializable]
		public class LocalPath
		{
			public LocalPath(string path)
			{
				this.Path = path;
			}
			public string Path { get; set; }
		}	
	}

	/*
		Unmapped Config Options:

		Compilation:
			# This value is used when using the command line options `-b` or `bf` 
			# or `bcs` (see command line reference section for details on these)
			# By default, Projeny will use MsBuild (using the MsBuildExePath 
			# defined above) to build the visual studio solution. However, some 
			# people may prefer to use devenv.exe instead, since unlike msbuild 
			# this is guaranteed to produce identical behaviour to building using 
			# the Visual Studio GUI.  So if you want to use devenv.exe instead, 
			# set this to true and then make sure to specify the path variable
			# 'VisualStudioCommandLinePath' as well in the PathVars section above
			UseDevenv: False

		SolutionGeneration:
			# This will be used in the "DefaultNamespace" field for generated visual studio projects
			RootNamespace: MyCompanyName

		Unity:
			# Include this option to default new projects to use 64 bit windows for their builds rather 
			# than 32 bit
			Win64IsDefault: True	
	*/
}
