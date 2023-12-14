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
    public partial class FormRegister : Form
    {

        SqlConnection conn = new SqlConnection
            ("Data Source=DESKTOP-2V35V55\\SQLEXPRESS;Initial Catalog=quizApp;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string query 
                = "INSERT INTO USERS (username, userPassword, email) values (@textBoxUserName, @textBoxPassword, @textUserEmail)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@textBoxUserName", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@textBoxPassword", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("textUserEmail", textUserEmail.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("User registered");

            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
