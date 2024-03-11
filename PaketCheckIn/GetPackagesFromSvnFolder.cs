using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PaketCheckIn
{
    internal class GetPackagesFromSvnFolder
    {
        public string[] packageFolders = Directory.GetDirectories(App.SvnArchivePath);
        public ArrayList packageFoldersWithSvnFolder = new ArrayList();
        public ArrayList packageFoldersWithoutSvnFolder = new ArrayList();

         ArrayList GetPackagesWithSvnFolder() 
        {
            foreach (string svnFolder in packageFolders)
            {
                if(Directory.Exists(svnFolder + @"\.svn"))
                {
                    packageFoldersWithSvnFolder.Add(svnFolder);
                }
            }

            return packageFoldersWithSvnFolder; 
        }
    }
}
