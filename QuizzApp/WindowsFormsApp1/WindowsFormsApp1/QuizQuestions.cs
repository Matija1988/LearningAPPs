using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        private SqlConnection conn;
        //       SqlCommand cmd;
        //       SqlDataReader rdr = null;
        //       SqlDataAdapter adapter;


        public QuizQuestions()
        {
            InitializeComponent();
            conn = new SqlConnection
 ("Data Source=DESKTOP-2V35V55\\SQLEXPRESS;Initial Catalog=quizApp;Integrated Security=True");

            try
            {

                conn.Open ();
                LoadData();
                LoadAnswers();
            }
            catch (Exception ex)  
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error");

            }

        }

        private void LoadData()
        {
            string query = "select description from questions";

            using(SqlCommand cmd = new SqlCommand(query, conn)) 
            { 
                try
                {
                    object result = cmd.ExecuteScalar();

                    if(result != null)
                    {

                        rtbQuestions.Text = result.ToString();
                        
                    }
                    else
                    {
                        rtbQuestions.Text = "No data found"; 
                    }
                }   catch (Exception ex) 
                {
                    MessageBox.Show($"Error executing query: {ex.Message}", "Error"); 
                }
            
            }

        }
        
        private void LoadAnswers ()
        {
            int answerID = 1;
            string query = "select text from answers where id =" + answerID;

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {

                        button1.Text = result.ToString();

                    }
                    else
                    {
                        rtbQuestions.Text = "No data found";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}", "Error");
                }

            }
        }
    }
}
