using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace FolderVisualizer.Classes
{
    public class FolderDrawer
    {
        private Sizer sizer = new Sizer();
        private PictureBox picturBox;
        private Folder topFolder;
        private UserChoise userChoise;
        private Brush folderColour = Brushes.LightGray;
        private Brush fileColour = Brushes.LightBlue;
        private int width = 120, height = 40;
        private Font font = new Font("Arial", 8);





        //DocumentComponent topFolder;
        public FolderDrawer(PictureBox picturBox, Folder folder, UserChoise userChoise) {
            this.userChoise = userChoise;
            this.picturBox = picturBox;
            this.topFolder = folder;

        }




        public void Draw()
        {

            // Create a new Bitmap for drawing

            if(userChoise == UserChoise.horizontal)
            {
                picturBox.Size = sizer.getHorizontalSize(topFolder);

                Bitmap bitmap = new Bitmap(picturBox.Width, picturBox.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.Clear(Color.Transparent);
                int currentX = 0, currentY = 0;
                visualizeHorizontal(g, currentX, currentY, topFolder);

                picturBox.Image = bitmap;


            }
            else
            {

                picturBox.Size = sizer.GetVerticalSize(topFolder);

                Bitmap bitmap = new Bitmap(picturBox.Width, picturBox.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.Clear(Color.Transparent);
                int currentX = 0, currentY = 0;
                visualizeVertical(g, currentX, currentY, topFolder);

                picturBox.Image = bitmap;
            }





        }

        // shared component rectangle


        private void drawRectangle(int x,int y,String text, Graphics g,Brush brush)
        {
            Pen linePen = new Pen(Color.Black, 2);
            g.FillRectangle(brush, x, y, width, height);
            Rectangle rect = new Rectangle(x, y, width, height);
            PointF textPosition = new PointF(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(text, font, Brushes.Black, textPosition,stringFormat);

        }

        private int visualizeVertical(Graphics graphics, int currentX, int currentY, Folder currentFolder)
        {

            drawRectangle(currentX, currentY, currentFolder.getName(), graphics, folderColour);

            currentX = currentX + width;
            currentY = currentY + height;

            // this counter for removieng aditonal line
            int counter = 0;

            List<DocumentComponent> documentComponents = currentFolder.getDocuments();

            foreach (DocumentComponent documentComponent in documentComponents)
            {
                // drawing vertical line
                int xForVertical = currentX - (width / 2);
                int yForVerticalStart = currentY;
                int yforVerticalEnd = currentY + 80;
                graphics.DrawLine(Pens.Black, xForVertical, yForVerticalStart, xForVertical, yforVerticalEnd);

                // drawing horizntal line
                currentY = yforVerticalEnd;
                int spaceedCurrentX = currentX + 120;
                graphics.DrawLine(Pens.Black, xForVertical, currentY, spaceedCurrentX, currentY);



                counter++;
                if (documentComponent is File)
                {


                    // drawing rectangle for file
                    drawRectangle(spaceedCurrentX, currentY, documentComponent.getName(), graphics, fileColour);


                }
                else 
                {
                    // drawin rectangle for folder

                    Folder newCurrentFolder = (Folder)documentComponent;
                    int locurrentY = visualizeVertical(graphics,spaceedCurrentX,currentY,newCurrentFolder);

                    // if there is another file folder in the current folder draw the line
                    if(currentFolder.getDocuments().Count-counter > 0)
                    {
                        graphics.DrawLine(Pens.Black, xForVertical, yForVerticalStart, xForVertical, locurrentY);
                        currentY = locurrentY;

                    }


                }
            }
            return currentY+80;

        }

        private int visualizeHorizontal(Graphics graphics, int currentX, int currentY, Folder currentFolder)
        {
            drawRectangle(currentX, currentY, currentFolder.getName(), graphics, folderColour);

            currentX = currentX + width;
            currentY = currentY + height / 2;
            int counter = 0;

            List<DocumentComponent> documentComponents = currentFolder.getDocuments();

            foreach (DocumentComponent documentComponent in documentComponents)
            {
                int xForHorizontalStart = currentX;
                int xForHorizontalEnd = currentX + 160;
                int yForHorizontal = currentY;
                graphics.DrawLine(Pens.Black, xForHorizontalStart, yForHorizontal, xForHorizontalEnd, yForHorizontal);
                currentX = xForHorizontalEnd;

                int spaceedCurrentY = currentY + 40;
                graphics.DrawLine(Pens.Black, xForHorizontalEnd, yForHorizontal, currentX, spaceedCurrentY);



                counter++;

                if (documentComponent is File)
                {

                    drawRectangle(currentX, spaceedCurrentY, documentComponent.getName(), graphics, fileColour);
                }
                else
                {
 
                    int locurrentX = visualizeHorizontal(graphics, currentX, spaceedCurrentY, (Folder)documentComponent);

                    if (currentFolder.getDocuments().Count - counter > 0)
                    {
                        graphics.DrawLine(Pens.Black, xForHorizontalStart, yForHorizontal, locurrentX, yForHorizontal);
                        currentX = locurrentX;

                    }


                }
            }
            return currentX+120;
        }









    }
}
