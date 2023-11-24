using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public abstract class DocumentComponent
    {
        private string name;

        public DocumentComponent(string name)
        {
            this.name = name;

        }


        abstract public double calculateSize();
        abstract public void add(DocumentComponent documentComponent);
        abstract public String getExtension();

        public string getName() { return name; }




        

    }
}
