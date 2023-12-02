using FolderVisualizer.Classes;
using System.Windows.Forms;

namespace FolderVisualizer
{
    public partial class uploadFolderForm : Form
    {
        public uploadFolderForm()
        {
            InitializeComponent();



        }
        private FolderLoader _folderLoader;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uploadFolderForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void visualizationPanel_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                FolderDrawer folderDrawer = new FolderDrawer(pictureBox1, _folderLoader.getTopFolder());
                folderDrawer.Draw();

            }
            catch (Exception ex)
            {
                MessageBox.Show("a warning message.\nYou did not enter a folder path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void uploadPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void uploadFolderForm_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void uploadFolderForm_Resize(object sender, EventArgs e)
        {
            //Invalidate();
        }

        private void visualizationPanel_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void uploadButton_Click_1(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string folderPath;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path
                folderPath = folderBrowserDialog.SelectedPath;

                _folderLoader = new FolderLoader(folderPath);
                folderName.Text = (_folderLoader.getTopFolder().getName());
                double sizeInBytes = _folderLoader.getTopFolder().calculateSize();
                double sizeInKiloBytes = sizeInBytes / 1024;
                double roundedSizeInKiloBytes = Math.Round(sizeInKiloBytes, 2); // Round to 2 decimal 
                folderSize.Text = roundedSizeInKiloBytes + " KB";



            }



        }

        private void viewStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}