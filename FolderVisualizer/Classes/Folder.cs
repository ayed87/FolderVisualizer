using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public class Folder : DocumentCompenent
    {
        private List<DocumentCompenent> documentCompenents;
        public Folder(string name) : base(name) {
            documentCompenents = new List<DocumentCompenent>();
        }
        public override void add(DocumentCompenent documentCompenent)
        {
            documentCompenents.Add(documentCompenent);
        }

        public override double calculateSize()
        {
            double size = 0;
            foreach(DocumentCompenent documentCompenent in documentCompenents)
            {
                size += documentCompenent.calculateSize();
            }
            return size;
        }

        public override string getExtension()
        {
            throw new Exception();
        }
        public List<DocumentCompenent> getDocuments()
        {
            return documentCompenents;
        }

   
    }
}
