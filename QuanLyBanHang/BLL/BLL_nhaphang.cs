using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.BLL
{
    class BLL_nhaphang
    {
        DAL.DAL_nhaphang dAL_nh = new DAL.DAL_nhaphang();
        GUI.frm_HDNhap frm_nh;
        GUI.frm_hoadon frm_hoadon;
        GUI.frm_nhacungcap frm_ncc;
        public BLL_nhaphang(GUI.frm_HDNhap f)
        {
            frm_nh = f;
        }
        public BLL_nhaphang(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }
        public BLL_nhaphang(GUI.frm_nhacungcap f)
        {
            frm_ncc = f;
        }
        public void themdn()
        {
            int ketqua = dAL_nh.ThemHoaDonNhap(frm_nh.txt_madn.Text, frm_nh.dt_ngaynhap.Value.ToString(), frm_nh.cb_mancc.SelectedValue.ToString(), frm_nh.cb_manv.SelectedValue.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

        }
        public void suadn()
        {
            int ketqua = dAL_nh.SuaHoaDonNhap(frm_nh.txt_madn.Text, frm_nh.dt_ngaynhap.Value.ToString(), frm_nh.cb_mancc.SelectedValue.ToString(), frm_nh.cb_manv.SelectedValue.ToString());
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void xoadn()
        {
            int ketqua = dAL_nh.XoaHoaDonNhap(frm_nh.txt_madn.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }
        public void loadnh()
        {
            frm_nh.dtv_hdn.DataSource = dAL_nh.Loaddonnhap();
        }
        public void loadnhR(string id)
        {
            frm_nh.dtv_hdn.DataSource = dAL_nh.LoaddonnhapR(id);
        }
    }
}
