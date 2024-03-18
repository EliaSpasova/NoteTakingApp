using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NotesApplication
{
    public partial class AddingNote : Form
    {
        public AddingNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=NotesApp; Integrated Security=True;");
            cn.Open();
            string Insertquery = "INSERT INTO Note VALUES (@title, @category, @text, @CreatedDate, @LastModifiedDate)";
            SqlCommand insertCmd = new SqlCommand(Insertquery, cn);
            var dateAndTimeOfClick = System.DateTime.Now;
            var LastModifiedDate = System.DateTime.Now;
            insertCmd.Parameters.AddWithValue("@title", titleOfNote.Text);
            insertCmd.Parameters.AddWithValue("@category", categoryOfNote.Text);
            insertCmd.Parameters.AddWithValue("@text", textOfNote.Text);
            insertCmd.Parameters.AddWithValue("@CreatedDate", dateAndTimeOfClick);
            insertCmd.Parameters.AddWithValue("@LastModifiedDate", LastModifiedDate);

            insertCmd.ExecuteNonQuery();

            MessageBox.Show("You successfully saved a note!");
            this.Close();
        }
    }
}
