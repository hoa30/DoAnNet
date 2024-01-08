using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.DAL
{
    class DAL_nhaphang
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemHoaDonNhap(string mahdn, string ngaynhap, string mancc, string manv)
        {
            string sql = "INSERT INTO HOADONNHAP (MaHDNhap, NgayNhap, MaNCC, MaNV) " +
                         "VALUES (N'" + mahdn + "', N'" + ngaynhap + "', N'" + mancc + "', N'" + manv + "')";
            return lopchung.ThemSuaXoa(sql);
        }

        public int SuaHoaDonNhap(string mahdn, string ngaynhap, string mancc, string manv)
        {
            string sql = "UPDATE HOADONNHAP " +
                         "SET NgayNhap = N'" + ngaynhap + "', MaNCC = N'" + mancc + "', MaNV = N'" + manv + "' " +
                         "WHERE MaHDNhap = N'" + mahdn + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        public int XoaHoaDonNhap(string mahdn)
        {
            string sql = "DELETE FROM HOADONNHAP WHERE MaHDNhap = N'" + mahdn + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        public DataTable Loaddonnhap()
        {
            string sql = "Select * from HOADONNHAP";
            return lopchung.LoadDuLieu(sql);

        }

        public DataTable LoaddonnhapR(string id)
        {
            string sql = "Select * from HOADONNHAP where MaHDNhap = '" + id + "'";
            return lopchung.LoadDuLieu(sql);

        }
    }
}
