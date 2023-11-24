namespace FolderVisualizer
{
    partial class uploadFolderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uploadPanel = new Panel();
            button1 = new Button();
            folderSize = new Label();
            FolderName = new Label();
            uploadButton = new Button();
            visualizationPanel = new Panel();
            pictureBox1 = new PictureBox();
            uploadPanel.SuspendLayout();
            visualizationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uploadPanel
            // 
            uploadPanel.BackColor = SystemColors.HighlightText;
            uploadPanel.Controls.Add(button1);
            uploadPanel.Controls.Add(folderSize);
            uploadPanel.Controls.Add(FolderName);
            uploadPanel.Controls.Add(uploadButton);
            uploadPanel.Location = new Point(12, 12);
            uploadPanel.Name = "uploadPanel";
            uploadPanel.Size = new Size(232, 656);
            uploadPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(42, 150);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // folderSize
            // 
            folderSize.AutoSize = true;
            folderSize.Location = new Point(17, 50);
            folderSize.Name = "folderSize";
            folderSize.Size = new Size(78, 20);
            folderSize.TabIndex = 1;
            folderSize.Text = "folder size";
            folderSize.Click += label2_Click;
            // 
            // FolderName
            // 
            FolderName.AutoSize = true;
            FolderName.Location = new Point(17, 20);
            FolderName.Name = "FolderName";
            FolderName.Size = new Size(92, 20);
            FolderName.TabIndex = 1;
            FolderName.Text = "Folder name";
            FolderName.Click += label1_Click_1;
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(17, 89);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(140, 40);
            uploadButton.TabIndex = 0;
            uploadButton.Text = "upload Folder";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click_1;
            // 
            // visualizationPanel
            // 
            visualizationPanel.AutoScroll = true;
            visualizationPanel.Controls.Add(pictureBox1);
            visualizationPanel.Dock = DockStyle.Right;
            visualizationPanel.Location = new Point(292, 0);
            visualizationPanel.Name = "visualizationPanel";
            visualizationPanel.Size = new Size(1138, 704);
            visualizationPanel.TabIndex = 1;
            visualizationPanel.Scroll += visualizationPanel_Scroll;
            visualizationPanel.Paint += visualizationPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1097, 674);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uploadFolderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 704);
            Controls.Add(visualizationPanel);
            Controls.Add(uploadPanel);
            Name = "uploadFolderForm";
            Text = "Folder viewer";
            Load += uploadFolderForm_Load;
            ResizeEnd += uploadFolderForm_ResizeEnd;
            Resize += uploadFolderForm_Resize;
            uploadPanel.ResumeLayout(false);
            uploadPanel.PerformLayout();
            visualizationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel uploadPanel;
        private Button uploadButton;
        private Label FolderName;
        private Label folderSize;
        private Panel visualizationPanel;
        private Button button1;
        private PictureBox pictureBox1;
    }
}