using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class frm_dangnhap : Form
    {
        Lopdungchung lopchung = new Lopdungchung();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int dem = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from TAIKHOAN where TK = '" + txt_taikhoan.Text.ToUpper() + "'and MK = '" + txt_matkhau.Text.ToUpper() + "'";
            int kq = (int)lopchung.ExcuteScalar(sql);
            if (kq >= 1)
            {
                menu mn = new menu();
                mn.Show();
                this.Hide();
            }
            else
            {
                dem++;
                MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }
            }
        }

        private void frm_dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}
