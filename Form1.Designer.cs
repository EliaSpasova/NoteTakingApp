namespace NotesApplication
{
    partial class Form1
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
            AddNoteButton = new Button();
            allNotesButton = new Button();
            welcomeLabel = new Label();
            information = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // AddNoteButton
            // 
            AddNoteButton.Location = new Point(29, 466);
            AddNoteButton.Name = "AddNoteButton";
            AddNoteButton.Size = new Size(150, 46);
            AddNoteButton.TabIndex = 0;
            AddNoteButton.Text = "Add a Note";
            AddNoteButton.UseVisualStyleBackColor = true;
            AddNoteButton.Click += AddNoteButton_Click;
            // 
            // allNotesButton
            // 
            allNotesButton.Location = new Point(220, 466);
            allNotesButton.Name = "allNotesButton";
            allNotesButton.Size = new Size(150, 46);
            allNotesButton.TabIndex = 1;
            allNotesButton.Text = "All Notes";
            allNotesButton.UseVisualStyleBackColor = true;
            allNotesButton.Click += allNotesButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(112, 77);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(200, 50);
            welcomeLabel.TabIndex = 2;
            welcomeLabel.Text = "Welcome!";
            // 
            // information
            // 
            information.AutoSize = true;
            information.Location = new Point(147, 138);
            information.Name = "information";
            information.Size = new Size(109, 32);
            information.TabIndex = 3;
            information.Text = "Features:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 198);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 4;
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(69, 186);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(269, 181);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "Effortless Note-Taking\nEdit with Ease\nStay Updated\nOrganize Effortlessly";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 565);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(information);
            Controls.Add(welcomeLabel);
            Controls.Add(allNotesButton);
            Controls.Add(AddNoteButton);
            Name = "Form1";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddNoteButton;
        private Button allNotesButton;
        private Label welcomeLabel;
        private Label information;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}