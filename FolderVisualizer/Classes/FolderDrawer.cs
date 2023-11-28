using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public class FolderDrawer
    {
        PictureBox panel;
        //DocumentComponent topFolder;
        public FolderDrawer(PictureBox panel ) { 
            this.panel = panel;
            //this.topFolder = documentComponent;

        }

        public void Draw()
        {
            Graphics g = panel.CreateGraphics();

            // Set the pen color and width
            Pen pen = new Pen(Color.Blue, 2);

            // Draw a line from (10, 10) to (300, 300)
            g.DrawLine(pen, 10, 10, 300, 300);

            // Dispose of the pen to free resources
            pen.Dispose();
        }
    }
}
