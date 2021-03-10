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
    public partial class addComponent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\surya\source\repos\WindowsFormsApp1\WindowsFormsApp1\IE_Laboratory.mdf;Integrated Security=True;Connect Timeout=30");

        public addComponent()
        {
            InitializeComponent();
            nudQuantity.Value = 0;
        }

        private void btnAddCom_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into component_info values('"+ tbComName.Text +"','"+ tbComValue.Text + "','" + dtpLastUpdate.Text + "'," + nudQuantity.Value + ")";
            cmd.ExecuteNonQuery();
            con.Close();

            tbComName.Text = "";
            tbComValue.Text = "";
            nudQuantity.Value = 0;


            MessageBox.Show("Component added successfully");
        }

    }
}
