namespace NotesApplication
{
    partial class ListOfNotes
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
            dataGridView1 = new DataGridView();
            filterButton = new Button();
            categoryFilter = new ComboBox();
            categoryLabel = new Label();
            clearFilterButton = new Button();
            titleOfNoteInList = new TextBox();
            titleOfNoteLabel = new Label();
            goBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(666, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(546, 400);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(150, 46);
            filterButton.TabIndex = 1;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // categoryFilter
            // 
            categoryFilter.FormattingEnabled = true;
            categoryFilter.Items.AddRange(new object[] { "Category", "school", "work", "calendar", "friends", "interesting facts" });
            categoryFilter.Location = new Point(430, 54);
            categoryFilter.Name = "categoryFilter";
            categoryFilter.Size = new Size(242, 40);
            categoryFilter.TabIndex = 2;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(430, 9);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(110, 32);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category";
            // 
            // clearFilterButton
            // 
            clearFilterButton.Location = new Point(390, 400);
            clearFilterButton.Name = "clearFilterButton";
            clearFilterButton.Size = new Size(150, 46);
            clearFilterButton.TabIndex = 6;
            clearFilterButton.Text = "Clear Filter";
            clearFilterButton.UseVisualStyleBackColor = true;
            clearFilterButton.Click += clearFilterButton_Click;
            // 
            // titleOfNoteInList
            // 
            titleOfNoteInList.Location = new Point(37, 55);
            titleOfNoteInList.Name = "titleOfNoteInList";
            titleOfNoteInList.Size = new Size(200, 39);
            titleOfNoteInList.TabIndex = 7;
            // 
            // titleOfNoteLabel
            // 
            titleOfNoteLabel.AutoSize = true;
            titleOfNoteLabel.Location = new Point(37, 9);
            titleOfNoteLabel.Name = "titleOfNoteLabel";
            titleOfNoteLabel.Size = new Size(65, 32);
            titleOfNoteLabel.TabIndex = 8;
            titleOfNoteLabel.Text = "Title:";
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(37, 400);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(150, 46);
            goBackButton.TabIndex = 9;
            goBackButton.Text = "Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // ListOfNotes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 491);
            Controls.Add(goBackButton);
            Controls.Add(titleOfNoteLabel);
            Controls.Add(titleOfNoteInList);
            Controls.Add(clearFilterButton);
            Controls.Add(categoryLabel);
            Controls.Add(categoryFilter);
            Controls.Add(filterButton);
            Controls.Add(dataGridView1);
            Name = "ListOfNotes";
            Text = "ListOfNotes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button filterButton;
        private ComboBox categoryFilter;
        private Label categoryLabel;
        private Button clearFilterButton;
        private TextBox titleOfNoteInList;
        private Label titleOfNoteLabel;
        private Button goBackButton;
    }
}