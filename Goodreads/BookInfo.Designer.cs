namespace Goodreads
{
    partial class BookInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bookPictureBox = new PictureBox();
            titleLabel = new Label();
            authorLabel = new Label();
            dataGridViewReviews = new DataGridView();
            reviewRichTextBox = new RichTextBox();
            deleteButton = new Button();
            openButton = new Button();
            saveButton = new Button();
            newButton = new Button();
            genreLabel = new Label();
            publishYearLabel = new Label();
            publisherLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).BeginInit();
            SuspendLayout();
            // 
            // bookPictureBox
            // 
            bookPictureBox.Location = new Point(40, 33);
            bookPictureBox.Name = "bookPictureBox";
            bookPictureBox.Size = new Size(127, 174);
            bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            bookPictureBox.TabIndex = 0;
            bookPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(192, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 24);
            titleLabel.TabIndex = 1;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            authorLabel.Location = new Point(192, 76);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(0, 23);
            authorLabel.TabIndex = 2;
            // 
            // dataGridViewReviews
            // 
            dataGridViewReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReviews.Location = new Point(40, 235);
            dataGridViewReviews.Name = "dataGridViewReviews";
            dataGridViewReviews.RowTemplate.Height = 25;
            dataGridViewReviews.Size = new Size(124, 109);
            dataGridViewReviews.TabIndex = 19;
            // 
            // reviewRichTextBox
            // 
            reviewRichTextBox.Location = new Point(192, 235);
            reviewRichTextBox.Name = "reviewRichTextBox";
            reviewRichTextBox.Size = new Size(297, 142);
            reviewRichTextBox.TabIndex = 20;
            reviewRichTextBox.Text = "";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(40, 387);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(124, 23);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // openButton
            // 
            openButton.Location = new Point(40, 354);
            openButton.Name = "openButton";
            openButton.Size = new Size(124, 23);
            openButton.TabIndex = 24;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(365, 387);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(124, 23);
            saveButton.TabIndex = 23;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // newButton
            // 
            newButton.Location = new Point(192, 387);
            newButton.Name = "newButton";
            newButton.Size = new Size(124, 23);
            newButton.TabIndex = 22;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            genreLabel.Location = new Point(192, 113);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(0, 19);
            genreLabel.TabIndex = 27;
            // 
            // publishYearLabel
            // 
            publishYearLabel.AutoSize = true;
            publishYearLabel.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            publishYearLabel.Location = new Point(192, 146);
            publishYearLabel.Name = "publishYearLabel";
            publishYearLabel.Size = new Size(0, 19);
            publishYearLabel.TabIndex = 28;
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            publisherLabel.Location = new Point(192, 179);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(0, 19);
            publisherLabel.TabIndex = 29;
            // 
            // BookInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 442);
            Controls.Add(publisherLabel);
            Controls.Add(publishYearLabel);
            Controls.Add(genreLabel);
            Controls.Add(deleteButton);
            Controls.Add(openButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(reviewRichTextBox);
            Controls.Add(dataGridViewReviews);
            Controls.Add(authorLabel);
            Controls.Add(titleLabel);
            Controls.Add(bookPictureBox);
            Name = "BookInfo";
            Text = "BookInfo";
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bookPictureBox;
        private Label titleLabel;
        private Label authorLabel;
        private Label genreLabel;
        private Label publishYearLabel;
        private Label publisherLabel;
        private DataGridView dataGridViewReviews;
        private RichTextBox reviewRichTextBox;
        private Button deleteButton;
        private Button openButton;
        private Button saveButton;
        private Button newButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}