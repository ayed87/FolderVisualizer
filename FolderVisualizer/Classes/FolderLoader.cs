using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public class FolderLoader
    {
        private Folder TopFolder;

        public FolderLoader(String topPath) {
            TopFolder = TraverseDirectory(topPath);
        }

        public Folder TraverseDirectory(string currentTopPath)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(currentTopPath);
            Folder currentTopFolder = new Folder(directoryInfo.Name);
            // normal case
            string[] files = Directory.GetFiles(currentTopPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                DocumentComponent theFile = new File(fileInfo.Name, fileInfo.Length, fileInfo.Extension);
                currentTopFolder.add(theFile);
            }
            // recursive case
            string[] subdirectories = Directory.GetDirectories(currentTopPath);
            foreach (string subdirectory in subdirectories)
            {
                DocumentComponent nextTopFolder = TraverseDirectory(subdirectory);
                currentTopFolder.add(nextTopFolder);
            }

            return currentTopFolder;

        }



        public Folder getTopFolder() {
        
            return TopFolder;
        }
    }
}
