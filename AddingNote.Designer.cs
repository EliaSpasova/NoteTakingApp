namespace NotesApplication
{
    partial class AddingNote
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
            button1 = new Button();
            titleOfNote = new TextBox();
            categoryOfNote = new ComboBox();
            textOfNote = new RichTextBox();
            titleOfNoteLabel = new Label();
            categoryOfNoteLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(356, 480);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // titleOfNote
            // 
            titleOfNote.Location = new Point(12, 52);
            titleOfNote.Name = "titleOfNote";
            titleOfNote.Size = new Size(200, 39);
            titleOfNote.TabIndex = 1;
            // 
            // categoryOfNote
            // 
            categoryOfNote.FormattingEnabled = true;
            categoryOfNote.Items.AddRange(new object[] { "school", "work", "calendar", "friends", "interesting facts" });
            categoryOfNote.Location = new Point(264, 44);
            categoryOfNote.Name = "categoryOfNote";
            categoryOfNote.Size = new Size(242, 40);
            categoryOfNote.TabIndex = 2;
            // 
            // textOfNote
            // 
            textOfNote.Location = new Point(24, 119);
            textOfNote.Name = "textOfNote";
            textOfNote.Size = new Size(482, 344);
            textOfNote.TabIndex = 3;
            textOfNote.Text = "";
            // 
            // titleOfNoteLabel
            // 
            titleOfNoteLabel.AutoSize = true;
            titleOfNoteLabel.Location = new Point(12, 9);
            titleOfNoteLabel.Name = "titleOfNoteLabel";
            titleOfNoteLabel.Size = new Size(65, 32);
            titleOfNoteLabel.TabIndex = 4;
            titleOfNoteLabel.Text = "Title:";
            // 
            // categoryOfNoteLabel
            // 
            categoryOfNoteLabel.AutoSize = true;
            categoryOfNoteLabel.Location = new Point(268, 9);
            categoryOfNoteLabel.Name = "categoryOfNoteLabel";
            categoryOfNoteLabel.Size = new Size(115, 32);
            categoryOfNoteLabel.TabIndex = 5;
            categoryOfNoteLabel.Text = "Category:";
            // 
            // AddingNote
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 565);
            Controls.Add(categoryOfNoteLabel);
            Controls.Add(titleOfNoteLabel);
            Controls.Add(textOfNote);
            Controls.Add(categoryOfNote);
            Controls.Add(titleOfNote);
            Controls.Add(button1);
            Name = "AddingNote";
            Text = "AddingNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox titleOfNote;
        private ComboBox categoryOfNote;
        private RichTextBox textOfNote;
        private Label titleOfNoteLabel;
        private Label categoryOfNoteLabel;
    }
}