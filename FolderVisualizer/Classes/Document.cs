using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public abstract class DocumentCompenent
    {
        private string name;

        public DocumentCompenent(string name)
        {
            this.name = name;

        }


        abstract public double calculateSize();
        abstract public void add(DocumentCompenent documentCompenent);
        abstract public String getExtension();

        public string getName() { return name; }




        

    }
}
