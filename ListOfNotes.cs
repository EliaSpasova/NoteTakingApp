using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotesApplication
{
    public partial class ListOfNotes : Form
    {
        public ListOfNotes()
        {
            InitializeComponent();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=NotesApp; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT * FROM Note WHERE 1 = 1";

                List<string> conditions = new List<string>();

                if (categoryFilter.SelectedItem != null)
                    conditions.Add("category = @category");

                if (titleOfNoteInList.Text != String.Empty)
                    conditions.Add("title = @title");


                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                if (categoryFilter.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@category", categoryFilter.SelectedItem.ToString());

                if (!string.IsNullOrEmpty(titleOfNoteInList.Text))
                    cmd.Parameters.AddWithValue("@title", titleOfNoteInList.Text);


                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            categoryFilter.SelectedIndex = 0;
            titleOfNoteInList.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0))
            {
                Note note = new Note();
                note.Title = dataGridView1.CurrentCell.Value.ToString();

                SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=NotesApp; Integrated Security=True;");
                sqlCon.Open();
                string query = "select textOfNotes from Note where title='" + note.Title + "'";
                SqlCommand cmd = new SqlCommand(query, sqlCon); ;

                SqlDataReader dr;
                cmd = new SqlCommand(query, sqlCon);
                dr = cmd.ExecuteReader();
                dr.Read();
                dr.Close();
                var text = cmd.ExecuteScalar().ToString();
                note.Text = text;
                NoteLook welcome = new NoteLook(note);
                this.Hide();
                welcome.Show();

            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1 homne = new Form1())
            {
                homne.ShowDialog();
            }
        }
    }
}
