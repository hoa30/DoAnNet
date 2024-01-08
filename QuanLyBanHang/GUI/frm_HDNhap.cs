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

namespace QuanLyBanHang.GUI
{
    public partial class frm_HDNhap : Form
    {
        Lopdungchung lopchung = new Lopdungchung();
        BLL.BLL_nhaphang BLL_nh;
        BLL.BLL_nhanvien BLL_nv;
        BLL.BLL_nhacungcap BLL_ncc;
        BLL.BLL_hanghoa BLL_hh;
        BLL.BLL_cthdn BLL_cthd;
        DataTable dthd;
        SqlConnection con;
        SqlCommand comm;
        public frm_HDNhap()
        {
            InitializeComponent();
            BLL_nh = new BLL.BLL_nhaphang(this);
            BLL_nv = new BLL.BLL_nhanvien(this);
            BLL_ncc = new BLL.BLL_nhacungcap(this);
            BLL_hh = new BLL.BLL_hanghoa(this);
            BLL_cthd = new BLL.BLL_cthdn(this);
        }

        private void btnaddhd_Click(object sender, EventArgs e)
        {
            BLL_nh.themdn();
            BLL_nh.loadnh();
            dtv_cthdn.DataSource = null;
        }

        private void btnsuahd_Click(object sender, EventArgs e)
        {
            BLL_nh.xoadn();
            BLL_nh.loadnh();
            dtv_cthdn.DataSource = null;
        }

        private void btnxoahd_Click(object sender, EventArgs e)
        {
            
            BLL_nh.suadn();
            BLL_nh.loadnh();
            dtv_cthdn.DataSource = null;
        }

        private void frm_HDNhap_Load(object sender, EventArgs e)
        {
            BLL_nv.LayDSNV_NH();
            BLL_ncc.LayDSNCC_NH();
            BLL_hh.LayDSHH_NH();
            BLL_nh.loadnh();
        }

        private void cb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from NHANVIEN where MaNV = '" + cb_manv.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tennv.Text = reader.GetString(1).ToString();
            }
        }

        private void cb_mancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from NHACUNGCAP where MaNCC = '" + cb_mancc.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenncc.Text = reader.GetString(1).ToString();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from HANGHOA where MaH = '" + cb_mahang.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenhang.Text = reader.GetString(1).ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BLL_cthd.themctdn();
            BLL_cthd.loadctnh();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            BLL_cthd.xoactdn();
            BLL_cthd.loadctnh();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            BLL_cthd.suactdn();
            BLL_cthd.loadctnh();
        }

        private void btn_hienthihd_Click(object sender, EventArgs e)
        {
            BLL_nh.loadnh();
        }

        private void dtv_hdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra người dùng đã chọn một hàng hợp lệ hay không
            {
                DataGridViewRow selectedRow = dtv_hdn.Rows[e.RowIndex];
                string invoiceID = selectedRow.Cells["MaHDNhap"].Value.ToString();
                //Lấy dữ liệu từ 
                DataTable detailDataTable = BLL_cthd.loadctnhR(invoiceID);
                int tong = 0;
                if (detailDataTable != null)
                {
                    // Hiển thị dữ liệu chi tiết trong DataGridView dtv_cthdb
                    dtv_cthdn.DataSource = detailDataTable;

                    // Gán các giá trị từ hàng được chọn trong dtv_hd1 vào các thành phần UI khác
                    txt_madn.Text = selectedRow.Cells["MaHDNhap"].Value.ToString();
                    cb_manv.SelectedValue = selectedRow.Cells["MaNV"].Value;
                    dt_ngaynhap.Value = Convert.ToDateTime(selectedRow.Cells["NgayNhap"].Value);
                    cb_mancc.SelectedValue = selectedRow.Cells["MaNCC"].Value;
                    foreach (DataRow row in detailDataTable.Rows)
                    {
                        tong += Convert.ToInt32(row["ThanhTien"]);
                        // Xử lý giá trị từng ô trong cột ở đây (ví dụ: in ra console)
                    }
                    txt_tongtien.Text = tong.ToString();
                }
                else
                {
                    dtv_cthdn.DataSource = null;

                    MessageBox.Show("Không tìm thấy dữ liệu chi tiết cho hóa đơn này.");
                }
            }
        }

        private void dtv_cthdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dtv_cthdn.Rows[e.RowIndex];
                
                    txt_macthd.Text = selectedRow.Cells["MaCTHDNhap"].Value.ToString();
                    cb_mahang.SelectedValue = selectedRow.Cells["MaH"].Value;
                    txt_soluong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                    txt_dongia.Text = selectedRow.Cells["DonGia"].Value.ToString();
                    txt_thanhtien.Text = selectedRow.Cells["ThanhTien"].Value.ToString();
            }
        }

        private void btn_timkiemnv_Click(object sender, EventArgs e)
        {
            BLL_nh.loadnhR(txt_madn.Text);
        }
    }
}
