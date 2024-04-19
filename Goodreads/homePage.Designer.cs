namespace Goodreads
{
    partial class homePage
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
            userNameLabel = new Label();
            authorTextBox = new TextBox();
            titleTextBox = new TextBox();
            publishYearComboBox = new ComboBox();
            clearButton = new Button();
            searchButton = new Button();
            welcome = new Label();
            priceRangeComboBox = new ComboBox();
            publisherComboBox = new ComboBox();
            genreComboBox = new ComboBox();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLabel.Location = new Point(198, 31);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(117, 38);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "label1";
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(405, 91);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.PlaceholderText = "Author";
            authorTextBox.Size = new Size(305, 23);
            authorTextBox.TabIndex = 24;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(87, 91);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Title";
            titleTextBox.Size = new Size(305, 23);
            titleTextBox.TabIndex = 23;
            // 
            // publishYearComboBox
            // 
            publishYearComboBox.FormattingEnabled = true;
            publishYearComboBox.Items.AddRange(new object[] { "Published Year", "1800 - 1849", "1850 - 1899", "1900 - 1949", "1950 - 1999", "2000 - 2024" });
            publishYearComboBox.Location = new Point(405, 133);
            publishYearComboBox.Name = "publishYearComboBox";
            publishYearComboBox.Size = new Size(146, 23);
            publishYearComboBox.TabIndex = 22;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(88, 387);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(111, 33);
            clearButton.TabIndex = 20;
            clearButton.Text = "Clear Filters";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click_1;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(214, 387);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(111, 33);
            searchButton.TabIndex = 19;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click_1;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = Color.Transparent;
            welcome.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            welcome.Location = new Point(198, 31);
            welcome.Name = "welcome";
            welcome.Size = new Size(0, 38);
            welcome.TabIndex = 18;
            // 
            // priceRangeComboBox
            // 
            priceRangeComboBox.FormattingEnabled = true;
            priceRangeComboBox.Items.AddRange(new object[] { "Price Range", "0 - 9.99", "10 - 19.99" });
            priceRangeComboBox.Location = new Point(564, 133);
            priceRangeComboBox.Name = "priceRangeComboBox";
            priceRangeComboBox.Size = new Size(146, 23);
            priceRangeComboBox.TabIndex = 17;
            // 
            // publisherComboBox
            // 
            publisherComboBox.FormattingEnabled = true;
            publisherComboBox.Items.AddRange(new object[] { "Publisher", "Penguin Random House", "Simon & Schuster", "Pink Unicorn" });
            publisherComboBox.Location = new Point(246, 133);
            publisherComboBox.Name = "publisherComboBox";
            publisherComboBox.Size = new Size(146, 23);
            publisherComboBox.TabIndex = 16;
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Items.AddRange(new object[] { "Genre", "Fiction", "Romance", "Science Fiction" });
            genreComboBox.Location = new Point(87, 133);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(146, 23);
            genreComboBox.TabIndex = 15;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Window;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(87, 179);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(626, 191);
            dataGridView.TabIndex = 14;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(publishYearComboBox);
            Controls.Add(clearButton);
            Controls.Add(searchButton);
            Controls.Add(welcome);
            Controls.Add(priceRangeComboBox);
            Controls.Add(publisherComboBox);
            Controls.Add(genreComboBox);
            Controls.Add(dataGridView);
            Controls.Add(userNameLabel);
            Name = "homePage";
            Text = "homePage";
            Load += homePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private TextBox authorTextBox;
        private TextBox titleTextBox;
        private ComboBox publishYearComboBox;
        private Button clearButton;
        private Button searchButton;
        private Label welcome;
        private ComboBox priceRangeComboBox;
        private ComboBox publisherComboBox;
        private ComboBox genreComboBox;
        private DataGridView dataGridView;
    }
}