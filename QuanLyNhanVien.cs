using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDuSQLNangCao
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            loadCbbs();
            loadDgvNhanVien();
        }
        private void loadCbbs()
        {
            cbbGioiTinh.Text = "Nam";
            cbbGioiTinhTimKiem.Text = "Nam";
            cbbChucVu.DataSource = Database.Query("SELECT * FROM ChucVu");
            cbbPhongBan.DataSource = Database.Query("SELECT * FROM PhongBan");
            cbbChucVuTimKiem.DataSource = Database.Query("SELECT * FROM ChucVu");
            cbbPhongBanTimKiem.DataSource = Database.Query("SELECT * FROM PhongBan");
        }
        private void loadDgvNhanVien()
        {
            dgvNhanVien.DataSource = Database.Query("SELECT * FROM vNhanVien");
            btnSua.Enabled = btnXoa.Enabled = dgvNhanVien.Rows.Count > 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql =
                "EXEC ThemNhanVien @HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@HoTen", tboHoTen.Text);
            tuDien.Add("@NgaySinh", dtpNgaySinh.Value);
            tuDien.Add("@GioiTinh", (cbbGioiTinh.Text == "Nam" ? 1 : 0));
            tuDien.Add("@DiaChi", tboDiaChi.Text);
            tuDien.Add("@MaChucVu", cbbChucVu.SelectedValue);
            tuDien.Add("@MaPhongBan", cbbPhongBan.SelectedValue);
            try
            {
                Database.Execute(sql, tuDien);
                loadDgvNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql =
               "EXEC SuaNhanVien @MaNhanVien,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@MaNhanVien", dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value);
            tuDien.Add("@HoTen", tboHoTen.Text);
            tuDien.Add("@NgaySinh", dtpNgaySinh.Value);
            tuDien.Add("@GioiTinh", (cbbGioiTinh.Text == "Nam" ? 1 : 0));
            tuDien.Add("@DiaChi", tboDiaChi.Text);
            tuDien.Add("@MaChucVu", cbbChucVu.SelectedValue);
            tuDien.Add("@MaPhongBan", cbbPhongBan.SelectedValue);
            try
            {
                Database.Execute(sql, tuDien);
                loadDgvNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql =
                "EXEC XoaNhanVien @MaNhanVien";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@MaNhanVien", dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value);
            try
            {
                Database.Execute(sql, tuDien);
                loadDgvNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colHoTen"].Value.ToString();
            cbbGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colGioiTinh"].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString());
            tboDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            cbbChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colTenChucVu"].Value.ToString();
            cbbPhongBan.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colTenPhongBan"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql =
                "SELECT * FROM dbo.TimKiemNhanVien(@MaNhanVien,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan)";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            if (chbMaNhanVien.Checked)
                tuDien.Add("@MaNhanVien", nudMaNhanVienTimKiem.Value);
            else
                tuDien.Add("@MaNhanVien", DBNull.Value);
            if (chbHoTen.Checked)
                tuDien.Add("@HoTen", tboHoTenTimKiem.Text);
            else
                tuDien.Add("@HoTen", "");
            if (chbNgaySinh.Checked)
                tuDien.Add("@NgaySinh", dtpNgaySinhTimKiem.Value);
            else
                tuDien.Add("@NgaySinh", DBNull.Value);
            if (chbGioiTinh.Checked)
                tuDien.Add("@GioiTinh", (cbbGioiTinhTimKiem.Text == "Nam" ? 1 : 0));
            else
                tuDien.Add("@GioiTinh", DBNull.Value);
            if (chbDiaChi.Checked)
                tuDien.Add("@DiaChi", tboDiaChiTimKiem.Text);
            else
                tuDien.Add("@DiaChi", "");
            if (chbChucVu.Checked)
                tuDien.Add("@MaChucVu", cbbChucVuTimKiem.SelectedValue);
            else
                tuDien.Add("@MaChucVu", DBNull.Value);
            if (chbPhongBan.Checked)
                tuDien.Add("@MaPhongBan", cbbPhongBanTimKiem.SelectedValue);
            else
                tuDien.Add("@MaPhongBan", DBNull.Value);
            dgvNhanVien.DataSource = Database.Query(sql, tuDien);
            btnSua.Enabled = btnXoa.Enabled = dgvNhanVien.Rows.Count > 0;
        }
    }
}
