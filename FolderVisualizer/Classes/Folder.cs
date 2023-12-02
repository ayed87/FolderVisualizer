using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public class Folder : DocumentComponent
    {
        private List<DocumentComponent> documentComponents;
        public Folder(string name) : base(name) {
            documentComponents = new List<DocumentComponent>();
        }
        public override void add(DocumentComponent documentComponent)
        {
            documentComponents.Add(documentComponent);
        }

        public override double calculateSize()
        {
            double size = 0;
            foreach(DocumentComponent documentComponent in documentComponents)
            {
                size += documentComponent.calculateSize();
            }
            return size;
        }

        public override string getExtension()
        {
            throw new Exception();
        }

        public List<DocumentComponent> getDocuments()
        {
            return documentComponents;
        }

        public override string ToString()
        {
            return getName();
        }


    }
}
