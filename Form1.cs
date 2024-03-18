namespace NotesApplication
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer colorTransitionTimer;
        private List<Color> colors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        private int currentColorIndex = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeColorTransitionForLabel(welcomeLabel);
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            using (AddingNote addNote = new AddingNote())
            {

                addNote.ShowDialog();

            }
        }

        private void allNotesButton_Click(object sender, EventArgs e)
        {
            using (ListOfNotes listOfNotes = new ListOfNotes())
            {
                this.Hide();
                listOfNotes.ShowDialog();

            }
        }
        private void InitializeColorTransitionForLabel(Label labelToAnimate)
        {
            if (colorTransitionTimer == null)
            {
                colorTransitionTimer = new System.Windows.Forms.Timer();
                colorTransitionTimer.Interval = 1000; // Change color every 1000 milliseconds (1 second)
                colorTransitionTimer.Tick += (sender, e) =>
                {
                    labelToAnimate.ForeColor = colors[currentColorIndex]; // Change the label's text color
                    currentColorIndex++;

                    if (currentColorIndex >= colors.Count)
                    {
                        currentColorIndex = 0; // Reset the index to loop through the colors again
                    }
                };
            }

            colorTransitionTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}