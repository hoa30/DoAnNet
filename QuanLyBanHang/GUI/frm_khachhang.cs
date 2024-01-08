using QuanLyBanHang.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class frm_khachhang : Form
    {
        BLL.BLL_khachhang bllkh;
        Lopdungchung lopchung = new Lopdungchung();
        public frm_khachhang()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            bllkh.loadkh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bllkh.Luukh();
            bllkh.loadkh();
        }
      
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllkh.suakh();
                bllkh.loadkh();
            }       
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllkh.xoakh();
                bllkh.loadkh();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_makh.Text = dtv_khachhang.Rows[numrow].Cells[0].Value.ToString();
            txt_tenkh.Text = dtv_khachhang.Rows[numrow].Cells[1].Value.ToString();
            dt_namsinh.Value = Convert.ToDateTime(dtv_khachhang.Rows[numrow].Cells[2].Value);
            cb_gioitinh.Text = dtv_khachhang.Rows[numrow].Cells[3].Value.ToString();
            txt_diachi.Text = dtv_khachhang.Rows[numrow].Cells[4].Value.ToString();
            txt_sdt.Text = dtv_khachhang.Rows[numrow].Cells[5].Value.ToString();
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if ((txt_tenkh.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập tên khách hàng cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "SELECT * from KhachHang WHERE 1=1";
            if (txt_tenkh.Text != "")
                sql += " AND TenKH LIKE N'%" + txt_tenkh.Text + "%'";
            DataTable dt = lopchung.LoadDuLieu(sql);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có tên khách hàng cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dt.Rows.Count + " khách hàng thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_khachhang.DataSource = dt;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            bllkh.loadkh();
        }

        private void txt_tenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự không phải là chữ cái hoặc khoảng trắng được nhập vào textbox
            }
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự không phải là chữ cái hoặc khoảng trắng được nhập vào textbox
            }
        }
    }
}
