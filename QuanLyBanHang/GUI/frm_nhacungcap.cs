﻿using QuanLyBanHang.DAL;
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
    public partial class frm_nhacungcap : Form
    {
        BLL.BLL_nhacungcap bllncc;
        Lopdungchung lopchung = new Lopdungchung();
        public frm_nhacungcap()
        {
            InitializeComponent();
            bllncc = new BLL.BLL_nhacungcap(this);
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            bllncc.Themncc();
            bllncc.Loadncc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllncc.Suancc();
                bllncc.Loadncc();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllncc.Xoancc();
                bllncc.Loadncc();
            }
        }

        private void frm_nhacungcap_Load(object sender, EventArgs e)
        {
            bllncc.Loadncc();
        }
            
        private void dtv_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = dtv_nhacungcap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txt_tenncc.Text = dtv_nhacungcap.CurrentRow.Cells["TenNCC"].Value.ToString();           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();               
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((txt_tenncc.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập tên nhà cung cấp cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "SELECT * from NhaCungCap WHERE 1=1";
            if (txt_tenncc.Text != "")
                sql += " AND TenNCC LIKE N'%" + txt_tenncc.Text + "%'";
            DataTable dt = lopchung.LoadDuLieu(sql);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có tên nhà cung cấp cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dt.Rows.Count + " nhà cung cấp thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_nhacungcap.DataSource = dt;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            bllncc.Loadncc();
        }
    }
}
