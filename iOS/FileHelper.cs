//
// FileHelper.cs
//
// Author: Dheeraj Kumar Gunti <dheeraj.gunti@neudesic.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.IO;
using Xamarin.Forms;
using SampleForms.iOS;

[assembly: Dependency(typeof(FileHelper))]

namespace SampleForms.iOS
{
	public class FileHelper : IFileHelper
	{
		public string GetLocalFilePath(string filename)
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

			if (!Directory.Exists(libFolder))
			{
				Directory.CreateDirectory(libFolder);
			}

			return Path.Combine(libFolder, filename);
		}
	}
}