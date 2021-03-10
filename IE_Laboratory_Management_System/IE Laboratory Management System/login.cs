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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\surya\source\repos\WindowsFormsApp1\WindowsFormsApp1\IE_Laboratory.mdf;Integrated Security=True;Connect Timeout=30");
        int count = 0;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from IE_Laboratory_Admin where Username='"+ tbUsername.Text +"' and Password='"+ tbPassword.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if(count == 0)
            {
                MessageBox.Show("UserName/Password doesn't match");
            }
            else
            {
                this.Hide();
                opening_page op = new opening_page();
                op.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            without_login_view wlv = new without_login_view();
            wlv.Show();
        }
    }
}
