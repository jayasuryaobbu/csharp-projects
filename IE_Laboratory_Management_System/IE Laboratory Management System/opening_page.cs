using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class opening_page : Form
    {
        public opening_page()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addComponent ac = new addComponent();
            ac.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            view_components vc = new view_components();
            vc.Show();
        }
    }
}
