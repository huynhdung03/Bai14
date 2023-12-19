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
    public partial class ConnectDB : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public ConnectDB()
        {
            InitializeComponent();
        }
        private void txtTenMay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenCSDL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=A209PC34;Initial Catalog=GIAOVIEN;Integrated Security=True");
            try
            {
                conn.Open();
                string User = txtUser.Text;
                string Password = txtPassword.Text;
                string sql = "select *from CONNECTDB where USER = '"+User+"' and PASSWORD = '"+Password+"'";
                MessageBox.Show("Kết nối thành công!");
                conn.Close();
                GiaoVien gv = new GiaoVien();
                gv.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối không thành công!");
            }
         
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
                if(dg == DialogResult.OK) {
                    Application.Exit();
                }
        }
    }
}

