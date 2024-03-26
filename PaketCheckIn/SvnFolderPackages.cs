using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace PaketCheckIn
{
    internal class SvnFolderPackages
    {
        public ArrayList packageFoldersWithSvnFolder = new ArrayList();
        public ArrayList packageFoldersWithoutSvnFolder = new ArrayList();

        public ArrayList GetPackagesWithSvnFolder()
        {
            Debug.WriteLine("GetPackagesWithSvnFolder");
            string[] packageFolders = Directory.GetDirectories(App.SvnArchivePath);

            foreach (string svnFolder in packageFolders)
            {
                if (Directory.Exists(svnFolder + @"\.svn"))
                {
                    //Only save Package Name and not full Path
                    string packageName = svnFolder.Split("\\").Last();
                    packageFoldersWithSvnFolder.Add(packageName);
                }
            }

            return packageFoldersWithSvnFolder;
        }
    }
}
