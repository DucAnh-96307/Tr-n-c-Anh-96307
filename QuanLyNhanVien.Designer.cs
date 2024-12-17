namespace ViDuSQLNangCao
{
    partial class QuanLyNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.tboDiaChi = new System.Windows.Forms.TextBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.cbbPhongBan = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbPhongBanTimKiem = new System.Windows.Forms.ComboBox();
            this.cbbChucVuTimKiem = new System.Windows.Forms.ComboBox();
            this.tboDiaChiTimKiem = new System.Windows.Forms.TextBox();
            this.cbbGioiTinhTimKiem = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinhTimKiem = new System.Windows.Forms.DateTimePicker();
            this.tboHoTenTimKiem = new System.Windows.Forms.TextBox();
            this.chbHoTen = new System.Windows.Forms.CheckBox();
            this.chbNgaySinh = new System.Windows.Forms.CheckBox();
            this.chbDiaChi = new System.Windows.Forms.CheckBox();
            this.chbGioiTinh = new System.Windows.Forms.CheckBox();
            this.chbChucVu = new System.Windows.Forms.CheckBox();
            this.chbPhongBan = new System.Windows.Forms.CheckBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.chbMaNhanVien = new System.Windows.Forms.CheckBox();
            this.nudMaNhanVienTimKiem = new System.Windows.Forms.NumericUpDown();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaNhanVienTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbPhongBan);
            this.groupBox1.Controls.Add(this.cbbChucVu);
            this.groupBox1.Controls.Add(this.tboDiaChi);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.tboHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(592, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNhanVien);
            this.groupBox3.Location = new System.Drawing.Point(3, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1118, 373);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Nhân Viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(740, 287);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(878, 287);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1004, 287);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức Vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phòng Ban";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tboHoTen
            // 
            this.tboHoTen.Location = new System.Drawing.Point(105, 33);
            this.tboHoTen.Name = "tboHoTen";
            this.tboHoTen.Size = new System.Drawing.Size(209, 22);
            this.tboHoTen.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(105, 74);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(209, 22);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(105, 140);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(209, 24);
            this.cbbGioiTinh.TabIndex = 8;
            // 
            // tboDiaChi
            // 
            this.tboDiaChi.Location = new System.Drawing.Point(105, 112);
            this.tboDiaChi.Name = "tboDiaChi";
            this.tboDiaChi.Size = new System.Drawing.Size(209, 22);
            this.tboDiaChi.TabIndex = 9;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DisplayMember = "TenChucVu";
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(105, 178);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(209, 24);
            this.cbbChucVu.TabIndex = 10;
            this.cbbChucVu.ValueMember = "MaChucVu";
            // 
            // cbbPhongBan
            // 
            this.cbbPhongBan.DisplayMember = "TenPhongBan";
            this.cbbPhongBan.FormattingEnabled = true;
            this.cbbPhongBan.Location = new System.Drawing.Point(105, 216);
            this.cbbPhongBan.Name = "cbbPhongBan";
            this.cbbPhongBan.Size = new System.Drawing.Size(209, 24);
            this.cbbPhongBan.TabIndex = 11;
            this.cbbPhongBan.ValueMember = "MaPhongBan";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(578, 287);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 35);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm KIếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMaNhanVienTimKiem);
            this.groupBox2.Controls.Add(this.chbMaNhanVien);
            this.groupBox2.Controls.Add(this.chbPhongBan);
            this.groupBox2.Controls.Add(this.chbChucVu);
            this.groupBox2.Controls.Add(this.chbGioiTinh);
            this.groupBox2.Controls.Add(this.chbDiaChi);
            this.groupBox2.Controls.Add(this.chbNgaySinh);
            this.groupBox2.Controls.Add(this.chbHoTen);
            this.groupBox2.Controls.Add(this.cbbPhongBanTimKiem);
            this.groupBox2.Controls.Add(this.cbbChucVuTimKiem);
            this.groupBox2.Controls.Add(this.tboDiaChiTimKiem);
            this.groupBox2.Controls.Add(this.cbbGioiTinhTimKiem);
            this.groupBox2.Controls.Add(this.dtpNgaySinhTimKiem);
            this.groupBox2.Controls.Add(this.tboHoTenTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 332);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm KIếm Nhân Viên";
            // 
            // cbbPhongBanTimKiem
            // 
            this.cbbPhongBanTimKiem.DisplayMember = "TenPhongBan";
            this.cbbPhongBanTimKiem.FormattingEnabled = true;
            this.cbbPhongBanTimKiem.Location = new System.Drawing.Point(134, 289);
            this.cbbPhongBanTimKiem.Name = "cbbPhongBanTimKiem";
            this.cbbPhongBanTimKiem.Size = new System.Drawing.Size(209, 24);
            this.cbbPhongBanTimKiem.TabIndex = 11;
            this.cbbPhongBanTimKiem.ValueMember = "MaPhongBan";
            // 
            // cbbChucVuTimKiem
            // 
            this.cbbChucVuTimKiem.DisplayMember = "TenChucVu";
            this.cbbChucVuTimKiem.FormattingEnabled = true;
            this.cbbChucVuTimKiem.Location = new System.Drawing.Point(134, 225);
            this.cbbChucVuTimKiem.Name = "cbbChucVuTimKiem";
            this.cbbChucVuTimKiem.Size = new System.Drawing.Size(209, 24);
            this.cbbChucVuTimKiem.TabIndex = 10;
            this.cbbChucVuTimKiem.ValueMember = "MaChucVu";
            // 
            // tboDiaChiTimKiem
            // 
            this.tboDiaChiTimKiem.Location = new System.Drawing.Point(134, 119);
            this.tboDiaChiTimKiem.Name = "tboDiaChiTimKiem";
            this.tboDiaChiTimKiem.Size = new System.Drawing.Size(209, 22);
            this.tboDiaChiTimKiem.TabIndex = 9;
            // 
            // cbbGioiTinhTimKiem
            // 
            this.cbbGioiTinhTimKiem.FormattingEnabled = true;
            this.cbbGioiTinhTimKiem.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinhTimKiem.Location = new System.Drawing.Point(134, 168);
            this.cbbGioiTinhTimKiem.Name = "cbbGioiTinhTimKiem";
            this.cbbGioiTinhTimKiem.Size = new System.Drawing.Size(209, 24);
            this.cbbGioiTinhTimKiem.TabIndex = 8;
            // 
            // dtpNgaySinhTimKiem
            // 
            this.dtpNgaySinhTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhTimKiem.Location = new System.Drawing.Point(134, 79);
            this.dtpNgaySinhTimKiem.Name = "dtpNgaySinhTimKiem";
            this.dtpNgaySinhTimKiem.Size = new System.Drawing.Size(209, 22);
            this.dtpNgaySinhTimKiem.TabIndex = 7;
            // 
            // tboHoTenTimKiem
            // 
            this.tboHoTenTimKiem.Location = new System.Drawing.Point(134, 47);
            this.tboHoTenTimKiem.Name = "tboHoTenTimKiem";
            this.tboHoTenTimKiem.Size = new System.Drawing.Size(209, 22);
            this.tboHoTenTimKiem.TabIndex = 6;
            // 
            // chbHoTen
            // 
            this.chbHoTen.AutoSize = true;
            this.chbHoTen.Location = new System.Drawing.Point(6, 47);
            this.chbHoTen.Name = "chbHoTen";
            this.chbHoTen.Size = new System.Drawing.Size(74, 20);
            this.chbHoTen.TabIndex = 12;
            this.chbHoTen.Text = "Họ Tên";
            this.chbHoTen.UseVisualStyleBackColor = true;
            // 
            // chbNgaySinh
            // 
            this.chbNgaySinh.AutoSize = true;
            this.chbNgaySinh.Location = new System.Drawing.Point(3, 81);
            this.chbNgaySinh.Name = "chbNgaySinh";
            this.chbNgaySinh.Size = new System.Drawing.Size(91, 20);
            this.chbNgaySinh.TabIndex = 13;
            this.chbNgaySinh.Text = "Ngày Sinh";
            this.chbNgaySinh.UseVisualStyleBackColor = true;
            // 
            // chbDiaChi
            // 
            this.chbDiaChi.AutoSize = true;
            this.chbDiaChi.Location = new System.Drawing.Point(6, 123);
            this.chbDiaChi.Name = "chbDiaChi";
            this.chbDiaChi.Size = new System.Drawing.Size(71, 20);
            this.chbDiaChi.TabIndex = 14;
            this.chbDiaChi.Text = "Địa Chỉ";
            this.chbDiaChi.UseVisualStyleBackColor = true;
            // 
            // chbGioiTinh
            // 
            this.chbGioiTinh.AutoSize = true;
            this.chbGioiTinh.Location = new System.Drawing.Point(9, 173);
            this.chbGioiTinh.Name = "chbGioiTinh";
            this.chbGioiTinh.Size = new System.Drawing.Size(82, 20);
            this.chbGioiTinh.TabIndex = 15;
            this.chbGioiTinh.Text = "Giới Tính";
            this.chbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // chbChucVu
            // 
            this.chbChucVu.AutoSize = true;
            this.chbChucVu.Location = new System.Drawing.Point(9, 229);
            this.chbChucVu.Name = "chbChucVu";
            this.chbChucVu.Size = new System.Drawing.Size(78, 20);
            this.chbChucVu.TabIndex = 16;
            this.chbChucVu.Text = "Chức Vụ";
            this.chbChucVu.UseVisualStyleBackColor = true;
            // 
            // chbPhongBan
            // 
            this.chbPhongBan.AutoSize = true;
            this.chbPhongBan.Location = new System.Drawing.Point(9, 290);
            this.chbPhongBan.Name = "chbPhongBan";
            this.chbPhongBan.Size = new System.Drawing.Size(95, 20);
            this.chbPhongBan.TabIndex = 17;
            this.chbPhongBan.Text = "Phòng Ban";
            this.chbPhongBan.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhanVien,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colGioiTinh,
            this.colTenChucVu,
            this.colTenPhongBan});
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 21);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1109, 349);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_RowEnter);
            // 
            // chbMaNhanVien
            // 
            this.chbMaNhanVien.AutoSize = true;
            this.chbMaNhanVien.Location = new System.Drawing.Point(6, 21);
            this.chbMaNhanVien.Name = "chbMaNhanVien";
            this.chbMaNhanVien.Size = new System.Drawing.Size(113, 20);
            this.chbMaNhanVien.TabIndex = 20;
            this.chbMaNhanVien.Text = "Mã Nhân Viên";
            this.chbMaNhanVien.UseVisualStyleBackColor = true;
            // 
            // nudMaNhanVienTimKiem
            // 
            this.nudMaNhanVienTimKiem.Location = new System.Drawing.Point(134, 21);
            this.nudMaNhanVienTimKiem.Name = "nudMaNhanVienTimKiem";
            this.nudMaNhanVienTimKiem.Size = new System.Drawing.Size(209, 22);
            this.nudMaNhanVienTimKiem.TabIndex = 21;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.HeaderText = "Mã Nhân Viên";
            this.colMaNhanVien.MinimumWidth = 6;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Width = 125;
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colTenChucVu
            // 
            this.colTenChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenChucVu.DataPropertyName = "TenChucVu";
            this.colTenChucVu.HeaderText = "Chức Vụ";
            this.colTenChucVu.MinimumWidth = 6;
            this.colTenChucVu.Name = "colTenChucVu";
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenPhongBan.DataPropertyName = "TenPhongBan";
            this.colTenPhongBan.HeaderText = "Phòng Ban";
            this.colTenPhongBan.MinimumWidth = 6;
            this.colTenPhongBan.Name = "colTenPhongBan";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 726);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaNhanVienTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox tboHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tboDiaChi;
        private System.Windows.Forms.ComboBox cbbPhongBan;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbNgaySinh;
        private System.Windows.Forms.CheckBox chbHoTen;
        private System.Windows.Forms.ComboBox cbbPhongBanTimKiem;
        private System.Windows.Forms.ComboBox cbbChucVuTimKiem;
        private System.Windows.Forms.TextBox tboDiaChiTimKiem;
        private System.Windows.Forms.ComboBox cbbGioiTinhTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhTimKiem;
        private System.Windows.Forms.TextBox tboHoTenTimKiem;
        private System.Windows.Forms.CheckBox chbDiaChi;
        private System.Windows.Forms.CheckBox chbPhongBan;
        private System.Windows.Forms.CheckBox chbChucVu;
        private System.Windows.Forms.CheckBox chbGioiTinh;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.CheckBox chbMaNhanVien;
        private System.Windows.Forms.NumericUpDown nudMaNhanVienTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhongBan;
    }
}