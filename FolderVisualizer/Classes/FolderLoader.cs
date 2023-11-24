using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public class FolderLoader
    {
        private DocumentCompenent TopFolder;

        public FolderLoader(String topPath) {
            TopFolder = TraverseDirectory(topPath);
        }

        public DocumentCompenent TraverseDirectory(string currentTopPath)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(currentTopPath);
            DocumentCompenent currentTopFolder = new Folder(directoryInfo.Name);

            string[] files = Directory.GetFiles(currentTopPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                DocumentCompenent theFile = new File(fileInfo.Name, fileInfo.Length, fileInfo.Extension);
                currentTopFolder.add(theFile);
            }

            string[] subdirectories = Directory.GetDirectories(currentTopPath);
            foreach (string subdirectory in subdirectories)
            {
                DocumentCompenent nextTopFolder = TraverseDirectory(subdirectory);
                currentTopFolder.add(nextTopFolder);
            }

            return currentTopFolder;

        }

        public DocumentCompenent getTopFolder() {
        
            return TopFolder;
        }
    }
}
