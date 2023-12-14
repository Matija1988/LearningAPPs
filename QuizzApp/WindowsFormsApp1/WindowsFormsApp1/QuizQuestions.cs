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

namespace WindowsFormsApp1
{
    public partial class QuizQuestions : Form
    {
        SqlConnection conn = new SqlConnection
 ("Data Source=DESKTOP-2V35V55\\SQLEXPRESS;Initial Catalog=quizApp;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader rdr = null;
        SqlDataAdapter adapter;

        //void GetData()
        //{
        //    string query = "Select * from questions";
        //    conn.Open();
        //    adapter = new SqlDataAdapter(query, conn);
        //    RichTextBox questionTextBox = new RichTextBox();
        //    adapter.Fill(questionTextBox); 
        //}

        public QuizQuestions()
        {
            InitializeComponent();
        }

        private void rtbQuestions_TextChanged(object sender, EventArgs e)
        {
   
           cmd = new SqlCommand("select description from questions", conn);
           rdr = cmd.ExecuteReader();
           conn.Open();

                    while (rdr.Read())
                    {
                        rtbQuestions.Text = rdr.GetValue(0).ToString();
                        textBox1.Text = rdr.GetValue(1).ToString();
                    }

           conn.Close();
         }
     }
}
