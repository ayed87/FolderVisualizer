using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public class FolderLoader
    {
        private DocumentComponent TopFolder;

        public FolderLoader(String topPath) {
            TopFolder = TraverseDirectory(topPath);
        }

        public DocumentComponent TraverseDirectory(string currentTopPath)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(currentTopPath);
            DocumentComponent currentTopFolder = new Folder(directoryInfo.Name);

            string[] files = Directory.GetFiles(currentTopPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                DocumentComponent theFile = new File(fileInfo.Name, fileInfo.Length, fileInfo.Extension);
                currentTopFolder.add(theFile);
            }

            string[] subdirectories = Directory.GetDirectories(currentTopPath);
            foreach (string subdirectory in subdirectories)
            {
                DocumentComponent nextTopFolder = TraverseDirectory(subdirectory);
                currentTopFolder.add(nextTopFolder);
            }

            return currentTopFolder;

        }

        public DocumentComponent getTopFolder() {
        
            return TopFolder;
        }
    }
}
