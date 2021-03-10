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
    public partial class view_components : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\surya\source\repos\WindowsFormsApp1\WindowsFormsApp1\IE_Laboratory.mdf;Integrated Security=True;Connect Timeout=30");

        public view_components()
        {
            InitializeComponent();
        }

        private void view_components_Load(object sender, EventArgs e)
        {
            disp_components();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from component_info where component_name like('%" + tbComName.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                dgvViewComponents.DataSource = dt;
                con.Close();

                if(i==0)
                {
                    MessageBox.Show("No Components Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbComName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from component_info where component_name like('%" + tbComName.Text + "%')";
                cmd.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewComponents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvViewComponents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlEdit.Visible = true;

            int i;
            i = Convert.ToInt32(dgvViewComponents.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from component_info where id="+i+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    tbName.Text = dr["component_name"].ToString();
                    tbValue.Text = dr["component_value"].ToString();
                    tbQuantity.Text = dr["component_quantity"].ToString();
                    dtpLastUpdate.Value = Convert.ToDateTime(dr["component_last_update"].ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dgvViewComponents.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update component_info set component_name='"+ tbName.Text +"',component_value='"+ tbValue.Text +"',component_last_update='"+ dtpLastUpdate.Value +"',component_quantity="+ tbQuantity.Text +" where id="+i+"";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_components();
                MessageBox.Show("Component Updated Succesfully");
                pnlEdit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void disp_components()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from component_info";
                cmd.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewComponents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
