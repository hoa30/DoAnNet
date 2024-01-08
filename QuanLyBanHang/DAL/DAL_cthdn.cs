using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.DAL
{
    class DAL_cthdn
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemChiTietHoaDonNhap(string maHDNhap, string maH, string soLuong, string donGia, string thanhTien)
        {
            string sql = "INSERT INTO CTHDNhap (MaHDNhap, MaH, SoLuong, DonGia, ThanhTien) " +
                         "VALUES (N'" + maHDNhap + "', N'" + maH + "', " + soLuong + ", " + donGia + ", " + thanhTien + ")";
            return lopchung.ThemSuaXoa(sql);
        }

        public int SuaChiTietHoaDonNhap(string maCTHDNhap, string maHDNhap, string maH, string soLuong, string donGia, string thanhTien)
        {
            string sql = "UPDATE CTHDNhap " +
                         "SET SoLuong = " + soLuong + ", DonGia = " + donGia + ", ThanhTien = " + thanhTien + " " +
                         "WHERE MaCTHDNhap = N'" + maCTHDNhap + "' AND MaHDNhap = N'" + maHDNhap + "' AND MaH = N'" + maH + "'";
            return lopchung.ThemSuaXoa(sql);
        }


        public int XoaChiTietHoaDonNhap(string maCTHDNhap)
        {
            string sql = "DELETE FROM CTHDNhap " +
                         "WHERE MaCTHDNhap = N'" + maCTHDNhap + "'";
            return lopchung.ThemSuaXoa(sql);
        }


        public DataTable Loadctdonnhap()
        {
            string sql = "Select * from CTHDNhap";
            return lopchung.LoadDuLieu(sql);
        }

        public DataTable LoadctdonnhapR(string id)
        {
            string sql = "Select * from CTHDNhap where MaHDNhap = '" + id + "'";
            return lopchung.LoadDuLieu(sql);
        }
    }
}
