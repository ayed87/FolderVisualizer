using FolderVisualizer.Classes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FolderVisualizer
{
    public partial class uploadFolderForm : Form
    {
        private int zoomFactor = 120;
        float constant = 1.7f;
        private FolderLoader _folderLoader;


        public uploadFolderForm()
        {
            InitializeComponent();

            this.KeyPreview = true;


            this.KeyDown += Form1_KeyPress;


            visualizationPanel.Controls.Add(pictureBox1);


            pictureBox1.MouseWheel += pictureBox1_MouseWheel;






        }
        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {

            // Handle key events here

            if (e.KeyCode == Keys.Oemplus)
            {

                pictureBox1.Height += Convert.ToInt32(zoomFactor / constant);
                pictureBox1.Width += zoomFactor;

            }
            else if (e.KeyCode == Keys.OemMinus)
            {

                pictureBox1.Height -= Convert.ToInt32(zoomFactor / constant);
                pictureBox1.Width -= zoomFactor;
            }

        }

        private void pictureBox1_MouseWheel (object sender, MouseEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Control)
            {

                if (e.Delta > 0)
                {
                    pictureBox1.Height += Convert.ToInt32(zoomFactor / constant);
                    pictureBox1.Width += zoomFactor;
                }
                else
                {
                    pictureBox1.Height -= Convert.ToInt32(zoomFactor / constant);
                    pictureBox1.Width -= zoomFactor;
                }
            }

        }


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

                FolderDrawer folderDrawer;
                String userSelection = viewStyleComboBox.SelectedItem.ToString();


                if (userSelection.Equals("horizontal"))
                {

                    folderDrawer = new FolderDrawer(pictureBox1, _folderLoader.getTopFolder(), UserChoise.horizontal);
                    folderDrawer.Draw();

                }
                else
                {
                    folderDrawer = new FolderDrawer(pictureBox1, _folderLoader.getTopFolder(), UserChoise.vertical);
                    folderDrawer.Draw();


                }


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
            //pictureBox1.Invalidate();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += Convert.ToInt32(zoomFactor / constant);
            pictureBox1.Width += zoomFactor;

        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= Convert.ToInt32(zoomFactor / constant);
            pictureBox1.Width -= zoomFactor;
        }
    }
}