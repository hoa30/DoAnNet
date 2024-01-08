
namespace QuanLyBanHang.GUI
{
    partial class frm_HDNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.btn_hienthihd = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_mahang = new System.Windows.Forms.ComboBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.VNĐ = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_mancc = new System.Windows.Forms.ComboBox();
            this.btnxoahd = new System.Windows.Forms.Button();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.btnsuahd = new System.Windows.Forms.Button();
            this.btnaddhd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dt_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.btn_timkiemnv = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_madn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_macthd = new System.Windows.Forms.TextBox();
            this.dtv_cthdn = new System.Windows.Forms.DataGridView();
            this.dtv_hdn = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_cthdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hdn)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(746, 619);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(129, 25);
            this.txt_tongtien.TabIndex = 74;
            // 
            // btn_hienthihd
            // 
            this.btn_hienthihd.BackColor = System.Drawing.Color.Transparent;
            this.btn_hienthihd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthihd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_hienthihd.Location = new System.Drawing.Point(13, 161);
            this.btn_hienthihd.Margin = new System.Windows.Forms.Padding(5);
            this.btn_hienthihd.Name = "btn_hienthihd";
            this.btn_hienthihd.Size = new System.Drawing.Size(149, 27);
            this.btn_hienthihd.TabIndex = 102;
            this.btn_hienthihd.Text = "Tìm kiếm tất cả hóa đơn";
            this.btn_hienthihd.UseVisualStyleBackColor = false;
            this.btn_hienthihd.Click += new System.EventHandler(this.btn_hienthihd_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Image = global::QuanLyBanHang.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(283, 114);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 37);
            this.btn_delete.TabIndex = 101;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.Image = global::QuanLyBanHang.Properties.Resources.Exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(759, 114);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(117, 37);
            this.btn_Exit.TabIndex = 100;
            this.btn_Exit.Text = "Đóng";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Image = global::QuanLyBanHang.Properties.Resources.update;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(501, 114);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(113, 37);
            this.btn_update.TabIndex = 99;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Image = global::QuanLyBanHang.Properties.Resources.add1;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(47, 114);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 37);
            this.btn_add.TabIndex = 98;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_mahang
            // 
            this.cb_mahang.FormattingEnabled = true;
            this.cb_mahang.Location = new System.Drawing.Point(102, 23);
            this.cb_mahang.Margin = new System.Windows.Forms.Padding(5);
            this.cb_mahang.Name = "cb_mahang";
            this.cb_mahang.Size = new System.Drawing.Size(140, 25);
            this.cb_mahang.TabIndex = 97;
            this.cb_mahang.SelectedIndexChanged += new System.EventHandler(this.cb_mahang_SelectedIndexChanged);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(759, 22);
            this.txt_thanhtien.Margin = new System.Windows.Forms.Padding(5);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(140, 25);
            this.txt_thanhtien.TabIndex = 96;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(650, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 22);
            this.label13.TabIndex = 95;
            this.label13.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 22);
            this.label11.TabIndex = 94;
            this.label11.Text = "Mã hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(342, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 93;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 92;
            this.label8.Text = "Tên hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(652, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 91;
            this.label7.Text = "Đơn giá";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(759, 64);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(5);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(140, 25);
            this.txt_dongia.TabIndex = 90;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(487, 64);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(5);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(104, 25);
            this.txt_soluong.TabIndex = 89;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(102, 66);
            this.txt_tenhang.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(140, 25);
            this.txt_tenhang.TabIndex = 88;
            // 
            // VNĐ
            // 
            this.VNĐ.AutoSize = true;
            this.VNĐ.Location = new System.Drawing.Point(881, 624);
            this.VNĐ.Name = "VNĐ";
            this.VNĐ.Size = new System.Drawing.Size(41, 17);
            this.VNĐ.TabIndex = 75;
            this.VNĐ.Text = "VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cb_mancc);
            this.groupBox1.Controls.Add(this.btnxoahd);
            this.groupBox1.Controls.Add(this.txt_tenncc);
            this.groupBox1.Controls.Add(this.btnsuahd);
            this.groupBox1.Controls.Add(this.btnaddhd);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dt_ngaynhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_manv);
            this.groupBox1.Controls.Add(this.btn_timkiemnv);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_madn);
            this.groupBox1.Location = new System.Drawing.Point(36, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(935, 189);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cb_mancc
            // 
            this.cb_mancc.FormattingEnabled = true;
            this.cb_mancc.Location = new System.Drawing.Point(598, 31);
            this.cb_mancc.Margin = new System.Windows.Forms.Padding(5);
            this.cb_mancc.Name = "cb_mancc";
            this.cb_mancc.Size = new System.Drawing.Size(186, 25);
            this.cb_mancc.TabIndex = 108;
            this.cb_mancc.SelectedIndexChanged += new System.EventHandler(this.cb_mancc_SelectedIndexChanged);
            // 
            // btnxoahd
            // 
            this.btnxoahd.BackColor = System.Drawing.Color.White;
            this.btnxoahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoahd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnxoahd.Image = global::QuanLyBanHang.Properties.Resources.delete;
            this.btnxoahd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoahd.Location = new System.Drawing.Point(557, 124);
            this.btnxoahd.Margin = new System.Windows.Forms.Padding(5);
            this.btnxoahd.Name = "btnxoahd";
            this.btnxoahd.Size = new System.Drawing.Size(107, 37);
            this.btnxoahd.TabIndex = 107;
            this.btnxoahd.Text = "Xóa";
            this.btnxoahd.UseVisualStyleBackColor = false;
            this.btnxoahd.Click += new System.EventHandler(this.btnsuahd_Click);
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(599, 76);
            this.txt_tenncc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(185, 25);
            this.txt_tenncc.TabIndex = 94;
            // 
            // btnsuahd
            // 
            this.btnsuahd.BackColor = System.Drawing.Color.White;
            this.btnsuahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuahd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsuahd.Image = global::QuanLyBanHang.Properties.Resources.update;
            this.btnsuahd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuahd.Location = new System.Drawing.Point(775, 124);
            this.btnsuahd.Margin = new System.Windows.Forms.Padding(5);
            this.btnsuahd.Name = "btnsuahd";
            this.btnsuahd.Size = new System.Drawing.Size(113, 37);
            this.btnsuahd.TabIndex = 106;
            this.btnsuahd.Text = "Sửa";
            this.btnsuahd.UseVisualStyleBackColor = false;
            this.btnsuahd.Click += new System.EventHandler(this.btnxoahd_Click);
            // 
            // btnaddhd
            // 
            this.btnaddhd.BackColor = System.Drawing.Color.White;
            this.btnaddhd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddhd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaddhd.Image = global::QuanLyBanHang.Properties.Resources.add1;
            this.btnaddhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddhd.Location = new System.Drawing.Point(321, 124);
            this.btnaddhd.Margin = new System.Windows.Forms.Padding(5);
            this.btnaddhd.Name = "btnaddhd";
            this.btnaddhd.Size = new System.Drawing.Size(110, 37);
            this.btnaddhd.TabIndex = 105;
            this.btnaddhd.Text = "Thêm";
            this.btnaddhd.UseVisualStyleBackColor = false;
            this.btnaddhd.Click += new System.EventHandler(this.btnaddhd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(6, 111);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 22);
            this.label14.TabIndex = 89;
            this.label14.Text = "Mã nhân viên";
            // 
            // dt_ngaynhap
            // 
            this.dt_ngaynhap.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaynhap.Location = new System.Drawing.Point(133, 73);
            this.dt_ngaynhap.Margin = new System.Windows.Forms.Padding(5);
            this.dt_ngaynhap.Name = "dt_ngaynhap";
            this.dt_ngaynhap.Size = new System.Drawing.Size(140, 25);
            this.dt_ngaynhap.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(445, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 92;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(133, 111);
            this.cb_manv.Margin = new System.Windows.Forms.Padding(5);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(140, 25);
            this.cb_manv.TabIndex = 73;
            this.cb_manv.SelectedIndexChanged += new System.EventHandler(this.cb_manv_SelectedIndexChanged);
            // 
            // btn_timkiemnv
            // 
            this.btn_timkiemnv.BackColor = System.Drawing.Color.White;
            this.btn_timkiemnv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemnv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiemnv.Location = new System.Drawing.Point(307, 34);
            this.btn_timkiemnv.Margin = new System.Windows.Forms.Padding(5);
            this.btn_timkiemnv.Name = "btn_timkiemnv";
            this.btn_timkiemnv.Size = new System.Drawing.Size(94, 26);
            this.btn_timkiemnv.TabIndex = 86;
            this.btn_timkiemnv.Text = "Tìm kiếm";
            this.btn_timkiemnv.UseVisualStyleBackColor = false;
            this.btn_timkiemnv.Click += new System.EventHandler(this.btn_timkiemnv_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(445, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 22);
            this.label15.TabIndex = 91;
            this.label15.Text = "Mã nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(5, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã đơn nhập";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(133, 154);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(140, 25);
            this.txt_tennv.TabIndex = 61;
            // 
            // txt_madn
            // 
            this.txt_madn.Location = new System.Drawing.Point(133, 33);
            this.txt_madn.Margin = new System.Windows.Forms.Padding(5);
            this.txt_madn.Name = "txt_madn";
            this.txt_madn.Size = new System.Drawing.Size(140, 25);
            this.txt_madn.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_macthd);
            this.groupBox2.Controls.Add(this.dtv_cthdn);
            this.groupBox2.Controls.Add(this.dtv_hdn);
            this.groupBox2.Controls.Add(this.btn_hienthihd);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.cb_mahang);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_tenhang);
            this.groupBox2.Location = new System.Drawing.Point(36, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 397);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(343, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 106;
            this.label2.Text = "Mã CT hóa đơn";
            // 
            // txt_macthd
            // 
            this.txt_macthd.Enabled = false;
            this.txt_macthd.Location = new System.Drawing.Point(487, 26);
            this.txt_macthd.Margin = new System.Windows.Forms.Padding(5);
            this.txt_macthd.Name = "txt_macthd";
            this.txt_macthd.Size = new System.Drawing.Size(104, 25);
            this.txt_macthd.TabIndex = 105;
            // 
            // dtv_cthdn
            // 
            this.dtv_cthdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtv_cthdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_cthdn.Location = new System.Drawing.Point(477, 199);
            this.dtv_cthdn.Name = "dtv_cthdn";
            this.dtv_cthdn.RowHeadersWidth = 51;
            this.dtv_cthdn.RowTemplate.Height = 24;
            this.dtv_cthdn.Size = new System.Drawing.Size(453, 196);
            this.dtv_cthdn.TabIndex = 104;
            this.dtv_cthdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_cthdn_CellClick);
            // 
            // dtv_hdn
            // 
            this.dtv_hdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtv_hdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_hdn.Location = new System.Drawing.Point(6, 201);
            this.dtv_hdn.Name = "dtv_hdn";
            this.dtv_hdn.RowHeadersWidth = 51;
            this.dtv_hdn.RowTemplate.Height = 24;
            this.dtv_hdn.Size = new System.Drawing.Size(465, 196);
            this.dtv_hdn.TabIndex = 103;
            this.dtv_hdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_hdn_CellClick);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(297, -2);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(462, 47);
            this.label17.TabIndex = 72;
            this.label17.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(654, 620);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 107;
            this.label4.Text = "Tổng";
            // 
            // frm_HDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 649);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.VNĐ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_HDNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HDNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_HDNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_cthdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hdn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Button btn_hienthihd;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.ComboBox cb_mahang;
        public System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_dongia;
        public System.Windows.Forms.TextBox txt_soluong;
        public System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Label VNĐ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker dt_ngaynhap;
        public System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Button btn_timkiemnv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_tennv;
        public System.Windows.Forms.TextBox txt_madn;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnxoahd;
        private System.Windows.Forms.Button btnsuahd;
        private System.Windows.Forms.Button btnaddhd;
        public System.Windows.Forms.DataGridView dtv_cthdn;
        public System.Windows.Forms.DataGridView dtv_hdn;
        public System.Windows.Forms.ComboBox cb_mancc;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_macthd;
        private System.Windows.Forms.Label label4;
    }
}