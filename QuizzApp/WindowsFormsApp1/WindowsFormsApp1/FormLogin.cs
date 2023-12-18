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

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection
            ("Data Source=DESKTOP-2V35V55\\SQLEXPRESS;Initial Catalog=quizApp;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader rdr = null;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from users where username=@username and userPassword=@userPassword", conn);
            cmd.Parameters.AddWithValue("@username", textBoxLoginUsername.Text);
            cmd.Parameters.AddWithValue("@userPassword", textBoxLoginPassword.Text);

            conn.Open();

            rdr = cmd.ExecuteReader();

            if (rdr.HasRows) 
            {
                Hide();
                QuizQuestions formQuiz = new QuizQuestions();
                formQuiz.Show();    
            
            } 
            else 
            {
                MessageBox.Show("Loggin failed");
            }

            conn.Close();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            Hide();
            FormRegister registerForm = new FormRegister(); 
            registerForm.Show();    

        }
    }
}
