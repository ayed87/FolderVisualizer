using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FolderVisualizer.Classes
{
    public class File : DocumentComponent

    {

        private double size;
        private string extension;
        public File(string name, double size, string extension) : base(name) {
       
            this.size = size;
            this.extension = extension;
        }
        

        public override void add(DocumentComponent documentComponent)
        {
            throw new Exception();
        }

        public override double calculateSize()
        {
            return size;
        }

        public override string getExtension()
        {
            return extension;
        }
    }
}
