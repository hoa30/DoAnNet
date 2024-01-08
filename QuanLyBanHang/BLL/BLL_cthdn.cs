using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace QuanLyBanHang.BLL
{
    class BLL_cthdn
    {
        DAL.DAL_cthdn dAL_ctnh = new DAL.DAL_cthdn();
        GUI.frm_HDNhap frm_nh;
        GUI.frm_hoadon frm_hoadon;
        GUI.frm_nhacungcap frm_ncc;
        public BLL_cthdn(GUI.frm_HDNhap f)
        {
            frm_nh = f;
        }
        public BLL_cthdn(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }
        public BLL_cthdn(GUI.frm_nhacungcap f)
        {
            frm_ncc = f;
        }

        public void themctdn()
        {
            int ketqua = dAL_ctnh.ThemChiTietHoaDonNhap(frm_nh.txt_madn.Text  ,frm_nh.cb_mahang.SelectedValue.ToString(), frm_nh.txt_soluong.Text, frm_nh.txt_dongia.Text, frm_nh.txt_thanhtien.Text);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

        }
        public void suactdn()
        {
            int ketqua = dAL_ctnh.SuaChiTietHoaDonNhap(frm_nh.txt_macthd.Text ,frm_nh.txt_madn.Text, frm_nh.cb_mahang.SelectedValue.ToString(), frm_nh.txt_soluong.Text, frm_nh.txt_dongia.Text, frm_nh.txt_thanhtien.Text);
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void xoactdn()
        {
            int ketqua = dAL_ctnh.XoaChiTietHoaDonNhap(frm_nh.txt_macthd.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }

        public void loadctnh()
        {
            frm_nh.dtv_cthdn.DataSource =  dAL_ctnh.Loadctdonnhap();
        }

        public DataTable loadctnhR(string id)
        {
            return dAL_ctnh.LoadctdonnhapR(id);
        }
    }
}
