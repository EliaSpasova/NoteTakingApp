namespace NotesApplication
{
    partial class NoteLook
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
            titleOfNote = new Label();
            deleteButton = new Button();
            backHome = new Button();
            textBoxForNote = new RichTextBox();
            updateButton = new Button();
            timestampLabel = new Label();
            SuspendLayout();
            // 
            // titleOfNote
            // 
            titleOfNote.AutoSize = true;
            titleOfNote.Location = new Point(229, 26);
            titleOfNote.Name = "titleOfNote";
            titleOfNote.Size = new Size(78, 32);
            titleOfNote.TabIndex = 0;
            titleOfNote.Text = "label1";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(229, 433);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 76);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete Note";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // backHome
            // 
            backHome.Location = new Point(12, 445);
            backHome.Name = "backHome";
            backHome.Size = new Size(150, 46);
            backHome.TabIndex = 3;
            backHome.Text = "Back";
            backHome.UseVisualStyleBackColor = true;
            backHome.Click += backHome_Click;
            // 
            // textBoxForNote
            // 
            textBoxForNote.Location = new Point(40, 77);
            textBoxForNote.Name = "textBoxForNote";
            textBoxForNote.Size = new Size(495, 337);
            textBoxForNote.TabIndex = 4;
            textBoxForNote.Text = "";
            textBoxForNote.TextChanged += textBoxForNote_TextChanged;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(400, 433);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(150, 76);
            updateButton.TabIndex = 5;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // timestampLabel
            // 
            timestampLabel.AutoSize = true;
            timestampLabel.Location = new Point(12, 524);
            timestampLabel.Name = "timestampLabel";
            timestampLabel.Size = new Size(127, 32);
            timestampLabel.TabIndex = 6;
            timestampLabel.Text = "timestamp";
            timestampLabel.Click += timestampLabel_Click;
            // 
            // NoteLook
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 565);
            Controls.Add(timestampLabel);
            Controls.Add(updateButton);
            Controls.Add(textBoxForNote);
            Controls.Add(backHome);
            Controls.Add(deleteButton);
            Controls.Add(titleOfNote);
            Name = "NoteLook";
            Text = "NoteLook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleOfNote;
        private Label textOfNote;
        private Button deleteButton;
        private Button backHome;
        private RichTextBox textBoxForNote;
        private Button updateButton;
        private Label timestampLabel;
    }
}