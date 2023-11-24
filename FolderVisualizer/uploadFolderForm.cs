using System.Windows.Forms;

namespace FolderVisualizer
{
    public partial class uploadFolderForm : Form
    {
        public uploadFolderForm()
        {
            InitializeComponent();



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

            //    pictureBox1.Size = new Size(1000, 30000);



            //    Graphics g = pictureBox1.CreateGraphics();
            //    g.Clear(Color.Red);


            //    Point linePoint1 = new Point(0, 3 * 30 + 25);
            //    Pen GreenPen = new Pen(Color.LightGray);

            //    Rectangle rect = new Rectangle(50, 50, 100, 1000000);
            //    g.FillRectangle(Brushes.Blue, rect);

            //    Point linePoint2 = new Point(1232, 4 * 30 + 25);
            //    g.DrawLine(GreenPen, linePoint1, linePoint2);



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

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path
                string folderPath = folderBrowserDialog.SelectedPath;

                FolderName.Text = folderPath;

                //try
                //{
                //    // Get all files in the selected folder
                //    string[] files = Directory.GetFiles(folderPath);

                //    // Display the file names in a ListBox or any other control

                //    foreach (string folder in files)
                //    {
                //        MessageBox.Show($"Folder Name: {Path.GetFileName(folder)}");
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"An error occurred while reading the folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

        }
    }
}