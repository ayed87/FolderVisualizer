using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Classes
{
    public class Sizer
    {
        private static Size currentSize = new Size(0,0);
        private static int width = 120, height = 40;


        private static void calculateVerticalSize(Folder currentTopFolder)
        {

            currentSize.Width += width;
            currentSize.Height += height;

            List<DocumentComponent> documentComponents = currentTopFolder.getDocuments();

            foreach (DocumentComponent documentComponent in documentComponents)
            {
                if (documentComponent is File)
                {


                    int xForVertical = currentSize.Width - (width / 2);
                    int yForVerticalStart = currentSize.Height;
                    int yforVerticalEnd = currentSize.Height + 80;

                    currentSize.Height = yforVerticalEnd;
                    int spaceedCurrentX = currentSize.Width + 20;
                    ;


                }
                else
                {

                    int xForVertical = currentSize.Width - (width / 2);
                    int yForVerticalStart = currentSize.Height;
                    int yforVerticalEnd = currentSize.Height + 80;

                    currentSize.Height = yforVerticalEnd;
                    int spaceedCurrentX = currentSize.Width + 20;
                    Folder newCurrentFolder = (Folder)documentComponent;
                    currentSize.Width = spaceedCurrentX;
                    calculateVerticalSize(newCurrentFolder);

                }
            }
        }
        private static void resetSize()
        {
            currentSize = new Size(0, 0);
        }

        public Size GetVerticalSize(Folder topfolder)
        {
            resetSize();
            calculateVerticalSize(topfolder);
            int additionSpaceX = 350;
            int additionSpaceY = 160;
            // adding aditional space to make it more readable
            return new Size(currentSize.Width+additionSpaceX,currentSize.Height+additionSpaceY);
        }

        public Size getHorizontalSize(Folder topfolder)
        {
            resetSize();
            calculateHorizontalSize(topfolder);
            // adding aditional space to make it more readable
            int additionSpaceX = 240;
            int additionSpaceY = 440;
            return new Size(currentSize.Width + additionSpaceX, currentSize.Height + additionSpaceY);

        }


        private void calculateHorizontalSize(Folder currentFolder)
        {

            currentSize.Width +=  width;
            currentSize.Height =+ height / 2;

            List<DocumentComponent> documentComponents = currentFolder.getDocuments();

            foreach (DocumentComponent documentComponent in documentComponents)
            {

                if (documentComponent is File)
                {
                    int xForHorizontalStart = currentSize.Width;
                    int xForHorizontalEnd = currentSize.Width + 160;
                    int yForHorizontal = currentSize.Height;
                    currentSize.Width = xForHorizontalEnd;

                    int spaceedCurrentY = currentSize.Height + 40;
                }
                else
                {
                    int xForHorizontalStart = currentSize.Width;
                    int xForHorizontalEnd = currentSize.Width + 160;
                    int yForHorizontal = currentSize.Height;
                    currentSize.Width = xForHorizontalEnd;

                    int spaceedCurrentY = currentSize.Height + 40;
                    calculateHorizontalSize((Folder)documentComponent);

 

                }
            }
        }



    }
}
