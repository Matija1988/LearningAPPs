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
    }
}
