﻿namespace FolderVisualizer
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
            zoomOutButton = new Button();
            zoomInButton = new Button();
            viewStyleComboBox = new ComboBox();
            drawButton = new Button();
            folderSize = new Label();
            folderName = new Label();
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
            uploadPanel.Controls.Add(zoomOutButton);
            uploadPanel.Controls.Add(zoomInButton);
            uploadPanel.Controls.Add(viewStyleComboBox);
            uploadPanel.Controls.Add(drawButton);
            uploadPanel.Controls.Add(folderSize);
            uploadPanel.Controls.Add(folderName);
            uploadPanel.Controls.Add(uploadButton);
            uploadPanel.Location = new Point(12, 12);
            uploadPanel.Name = "uploadPanel";
            uploadPanel.Size = new Size(232, 863);
            uploadPanel.TabIndex = 0;
            // 
            // zoomOutButton
            // 
            zoomOutButton.Location = new Point(124, 356);
            zoomOutButton.Name = "zoomOutButton";
            zoomOutButton.Size = new Size(80, 29);
            zoomOutButton.TabIndex = 4;
            zoomOutButton.Text = "-";
            zoomOutButton.UseVisualStyleBackColor = true;
            zoomOutButton.Click += zoomOutButton_Click;
            // 
            // zoomInButton
            // 
            zoomInButton.Location = new Point(17, 356);
            zoomInButton.Name = "zoomInButton";
            zoomInButton.Size = new Size(78, 29);
            zoomInButton.TabIndex = 1;
            zoomInButton.Text = "+";
            zoomInButton.UseVisualStyleBackColor = true;
            zoomInButton.Click += zoomInButton_Click;
            // 
            // viewStyleComboBox
            // 
            viewStyleComboBox.AutoCompleteCustomSource.AddRange(new string[] { "horizontal", "vertical" });
            viewStyleComboBox.FormattingEnabled = true;
            viewStyleComboBox.Items.AddRange(new object[] { "vertical", "horizontal" });
            viewStyleComboBox.Location = new Point(17, 208);
            viewStyleComboBox.Name = "viewStyleComboBox";
            viewStyleComboBox.Size = new Size(151, 28);
            viewStyleComboBox.TabIndex = 3;
            viewStyleComboBox.Text = "View style";
            viewStyleComboBox.SelectedIndexChanged += viewStyleComboBox_SelectedIndexChanged;
            // 
            // drawButton
            // 
            drawButton.Location = new Point(17, 146);
            drawButton.Name = "drawButton";
            drawButton.Size = new Size(140, 38);
            drawButton.TabIndex = 2;
            drawButton.Text = "View";
            drawButton.UseVisualStyleBackColor = true;
            drawButton.Click += button1_Click;
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
            // folderName
            // 
            folderName.AutoSize = true;
            folderName.Location = new Point(17, 20);
            folderName.Name = "folderName";
            folderName.Size = new Size(92, 20);
            folderName.TabIndex = 1;
            folderName.Text = "Folder name";
            folderName.Click += label1_Click_1;
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(17, 89);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(140, 40);
            uploadButton.TabIndex = 0;
            uploadButton.Text = "Upload Folder";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click_1;
            // 
            // visualizationPanel
            // 
            visualizationPanel.AutoScroll = true;
            visualizationPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            visualizationPanel.Controls.Add(pictureBox1);
            visualizationPanel.Dock = DockStyle.Right;
            visualizationPanel.Location = new Point(310, 0);
            visualizationPanel.Name = "visualizationPanel";
            visualizationPanel.Size = new Size(1120, 762);
            visualizationPanel.TabIndex = 1;
            visualizationPanel.Scroll += visualizationPanel_Scroll;
            visualizationPanel.Paint += visualizationPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1100, 703);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // uploadFolderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 762);
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
        private Label folderName;
        private Label folderSize;
        private Panel visualizationPanel;
        private Button drawButton;
        private PictureBox pictureBox1;
        private ComboBox viewStyleComboBox;
        private Button zoomInButton;
        private Button zoomOutButton;
    }
}