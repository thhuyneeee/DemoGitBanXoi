using DevExpress.XtraEditors;
using QuanLyChuoiBanXoi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiBanXoi
{
    public partial class frmDiemBan2 : DevExpress.XtraEditors.XtraForm
    {
        public frmDiemBan2()
        {
            InitializeComponent();
        }

        private void frmDiemBan2_Load(object sender, EventArgs e)
        {
            LoadDiemBan2();
        }

        private void LoadDiemBan2()
        {
            dgvDiem2.Rows.Clear();
            using (var dbContext = new QLBXDBcontext())
            {
                foreach (HoaDon hd in dbContext.HoaDon.Where(h => h.MaDB == "DB02"))
                {
                    int index = dgvDiem2.Rows.Add();
                    dgvDiem2.Rows[index].Cells[0].Value = hd.MaHD;
                    dgvDiem2.Rows[index].Cells[1].Value = hd.MaDB;
                    dgvDiem2.Rows[index].Cells[2].Value = hd.MaNV;
                    dgvDiem2.Rows[index].Cells[3].Value = hd.MaKH;
                    dgvDiem2.Rows[index].Cells[4].Value = hd.NgayLap;
                    dgvDiem2.Rows[index].Cells[5].Value = hd.ThanhTien;
                }
            }
        }

        private void dgvDiem2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using(var dbContext = new QLBXDBcontext())
            {
                int index = e.RowIndex;
                string MaHD = dgvDiem2.Rows[index].Cells[0].Value?.ToString();
                string MaDB = dgvDiem2.Rows[index].Cells[1].Value?.ToString();
                string MaNV = dgvDiem2.Rows[index].Cells[2].Value?.ToString();
                string MaKhachHang = dgvDiem2.Rows[index].Cells[3].Value?.ToString();
                DateTime? NgayLap = dgvDiem2.Rows[index].Cells[4].Value as DateTime?;
                string ThanhTien = dgvDiem2.Rows[index].Cells[5].Value?.ToString();
                if (!string.IsNullOrEmpty(MaHD))
                {
                    HoaDon hd = dbContext.HoaDon.FirstOrDefault(x => x.MaHD == MaHD);
                    txtMaHD.Text = MaHD;
                    txtMaDB.Text = MaDB;
                    txtMaNV.Text = MaNV;
                    txtMaKhachHang.Text = MaKhachHang;
                    dtpNgayLap.Value = NgayLap ?? DateTime.Now;
                    txtThanhTien.Text = ThanhTien;
                }
            }
        }
        private void CaiDatMacDinh()
        {
            txtMaDB.Text = txtMaHD.Text = txtMaKhachHang.Text = txtMaNV.Text = txtThanhTien.Text = string.Empty;
            dtpNgayLap.Value = DateTime.Now;
        }
        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(txtMaDB.Text) || string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(dtpNgayLap.Text) || string.IsNullOrEmpty(txtThanhTien.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin hoặc chọn hóa đơn cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDiem2.SelectedRows.Count > 0)
            {
                string maHD = dgvDiem2.SelectedRows[0].Cells[0].Value.ToString();

                using (var dbContext = new QLBXDBcontext())
                {
                    var hoaDon = dbContext.HoaDon.FirstOrDefault(h => h.MaHD == maHD && h.MaDB == "DB02");
                    DialogResult dg = MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hoaDon != null && dg == DialogResult.Yes)
                    {
                        dbContext.HoaDon.Remove(hoaDon);
                        dbContext.SaveChanges();
                        MessageBox.Show("Xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        CaiDatMacDinh();
                        LoadDiemBan2();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                using (var dbcontext = new QLBXDBcontext())
                {
                    string maHD = txtMaHD.Text.ToString();
                    var hoaDon = dbcontext.HoaDon.FirstOrDefault(hd => hd.MaHD == maHD);
                    if (hoaDon != null)
                    {
                        hoaDon.MaDB = txtMaDB.Text.ToString();
                        hoaDon.MaKH = txtMaKhachHang.Text.ToString();
                        hoaDon.NgayLap = dtpNgayLap.Value;
                        hoaDon.ThanhTien = Convert.ToDecimal(txtThanhTien.Text);
                        dbcontext.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn có mã " + maHD, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                CaiDatMacDinh();
                LoadDiemBan2();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(timKiem))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dbContext = new QLBXDBcontext())
            {
                HoaDon hd = dbContext.HoaDon.FirstOrDefault(x => x.MaHD == timKiem && x.MaDB == "DB02");

                if (hd != null)
                {
                    dgvDiem2.Rows.Clear();
                    int index = dgvDiem2.Rows.Add();
                    dgvDiem2.Rows[index].Cells[0].Value = hd.MaHD;
                    dgvDiem2.Rows[index].Cells[1].Value = hd.MaDB;
                    dgvDiem2.Rows[index].Cells[2].Value = hd.MaNV;
                    dgvDiem2.Rows[index].Cells[3].Value = hd.MaKH;
                    dgvDiem2.Rows[index].Cells[4].Value = hd.NgayLap;
                    dgvDiem2.Rows[index].Cells[5].Value = hd.ThanhTien;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy" + timKiem, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            LoadDiemBan2();
        }

    }
}