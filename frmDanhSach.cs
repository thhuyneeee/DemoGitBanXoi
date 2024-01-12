using DevExpress.XtraEditors;
using QuanLyChuoiBanXoi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiBanXoi
{
    public partial class frmDanhSach : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSach()
        {
            InitializeComponent();
        }
        private void frmDanhSach_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            dgvDS.Rows.Clear();
            using (var dbContext = new QLBXDBcontext())
            {
                foreach (DSXoi ds in dbContext.DSXoi)
                {
                    int index = dgvDS.Rows.Add();
                    dgvDS.Rows[index].Cells[0].Value = ds.MaXoi;
                    dgvDS.Rows[index].Cells[1].Value = ds.TenXoi;
                    dgvDS.Rows[index].Cells[2].Value = ds.Gia;
                }
            }
        }
        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var dbContext = new QLBXDBcontext())
            {
                int index = e.RowIndex;
                string maXoi = dgvDS.Rows[index].Cells[0].Value.ToString();
                DSXoi ds = dbContext.DSXoi.FirstOrDefault(x => x.MaXoi == maXoi);
                txtMaXoi.Text = dgvDS.Rows[index].Cells[0].Value.ToString();
                txtTenXoi.Text = dgvDS.Rows[index].Cells[1].Value.ToString();
                txtGia.Text = dgvDS.Rows[index].Cells[2].Value.ToString();
            }
        }
        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtMaXoi.Text) || string.IsNullOrEmpty(txtTenXoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtGia.Text.All(char.IsDigit))
            {
                MessageBox.Show("Giá không phải là chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                using (var dbContext = new QLBXDBcontext())
                {

                    if (dbContext.DSXoi.Any(DSXoi => DSXoi.MaXoi == txtMaXoi.Text))
                    {
                        MessageBox.Show("Mã xôi đã tồn tại. Vui lòng chọn mã xôi khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DSXoi dS = new DSXoi()
                    {
                        MaXoi = txtMaXoi.Text.ToString(),
                        TenXoi = txtTenXoi.Text.ToString(),
                        Gia = decimal.Parse(txtGia.Text.ToString()),
                    };
                    dbContext.DSXoi.Add(dS);
                    dbContext.SaveChanges();
                }
                CaiDatMacDinh();
                LoadDanhSach();
            }
        }
        private void CaiDatMacDinh()
        {
            txtMaXoi.Text = txtTenXoi.Text = txtGia.Text = string.Empty;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaXoi.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int selectedrow = GetSelectedRow(txtMaXoi.Text);
                if (selectedrow == -1)
                {
                    throw new Exception("Không tìm thấy mã cần xóa");
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        using (var dbContext = new QLBXDBcontext())
                        {
                            DSXoi dS = dbContext.DSXoi.FirstOrDefault(x => x.MaXoi == txtMaXoi.Text.ToString());
                            dbContext.DSXoi.Remove(dS);
                            dbContext.SaveChanges();
                        }
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        CaiDatMacDinh();
                        LoadDanhSach();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedRow(string maXoi)
        {
            for (int i = 0; i < dgvDS.Rows.Count; i++)
            {
                if (dgvDS.Rows[i].Cells[0].Value.ToString() == maXoi)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                using (var dbcontext = new QLBXDBcontext())
                {
                    DSXoi dS = new DSXoi()
                    {
                        MaXoi = txtMaXoi.Text.ToString(),
                        TenXoi = txtTenXoi.Text.ToString(),
                        Gia = decimal.Parse(txtGia.Text.ToString()),
                    };
                    dbcontext.DSXoi.AddOrUpdate(dS);
                    dbcontext.SaveChanges();
                }
                CaiDatMacDinh();
                LoadDanhSach();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(timKiem))
            {
                MessageBox.Show("Vui lòng nhập mã xôi" + " cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var dbContext = new QLBXDBcontext())
            {
                DSXoi dS = dbContext.DSXoi.FirstOrDefault(x => x.MaXoi == timKiem);

                if (dS != null)
                {
                    dgvDS.Rows.Clear();
                    int index = dgvDS.Rows.Add();
                    dgvDS.Rows[index].Cells[0].Value = dS.MaXoi;
                    dgvDS.Rows[index].Cells[1].Value = dS.TenXoi;
                    dgvDS.Rows[index].Cells[2].Value = dS.Gia;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xôi với mã " + timKiem, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
    }
}