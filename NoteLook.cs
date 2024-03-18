using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApplication
{
    public partial class NoteLook : Form
    {
        public Note currentNote;
        public NoteLook(Note note)
        {
            InitializeComponent();
            currentNote = note;

            titleOfNote.Text = currentNote.Title;
            textBoxForNote.Text = currentNote.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=NotesApp; Integrated Security=True;");
            conn.Open();
            string sql = "select CreatedDate, LastModifiedDate from Note where title = '" + currentNote.Title + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    DateTime createdDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                    DateTime? lastModifiedDate = null;

                    if (!reader.IsDBNull(reader.GetOrdinal("LastModifiedDate")))
                    {
                        lastModifiedDate = reader.GetDateTime(reader.GetOrdinal("LastModifiedDate"));
                    }

                    // Call the method to update the timestamp label
                    UpdateTimestampLabel(createdDate, lastModifiedDate);
                }
            }
            conn.Close();
        }

        private void UpdateTimestampLabel(DateTime createdDate, DateTime? lastModifiedDate)
        {
            if (lastModifiedDate.HasValue)
            {
                timestampLabel.Text = $"Last Modified: {lastModifiedDate.Value.ToString()}";
            }
            else
            {
                timestampLabel.Text = $"Created: {createdDate.ToString()}";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=NotesApp; Integrated Security=True;");
            conn.Open();
            string query = "DELETE FROM Note WHERE title ='" + currentNote.Title + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("You successfully deleted this note!", "Deletion", MessageBoxButtons.OK);

            conn.Close();
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1 homne = new Form1())
            {
                homne.ShowDialog();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the note's text in the application's memory
                currentNote.Text = textBoxForNote.Text;

                using (SqlConnection conn = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=NotesApp; Integrated Security=True;"))
                {
                    conn.Open();

                    string query = "UPDATE Note SET textOfNotes = @text, LastModifiedDate = GETDATE() WHERE title = @title";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@text", currentNote.Text);
                        cmd.Parameters.AddWithValue("@title", currentNote.Title);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("The note has been updated successfully!", "Update", MessageBoxButtons.OK);

                    // Optionally, refresh the timestampLabel to show the new LastModifiedDate
                    timestampLabel.Text = "Last Modified: " + DateTime.Now.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxForNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void timestampLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
