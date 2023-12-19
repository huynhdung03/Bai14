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

namespace Bai14
{
    public partial class GiaoVien : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        public GiaoVien()
        {
            InitializeComponent();
        }
        public GiaoVien(SqlConnection sqlconn)
        {
            conn = sqlconn;
        }
        private void GiaoVien_Load(object sender, EventArgs e)
        {
            ConnectDB conndb = new ConnectDB();
            conn.Open();
            string select = "select *from GIAOVIEN";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Close();


        }
        private void dgv_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCoso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDonVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cbxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void cbxTenDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

