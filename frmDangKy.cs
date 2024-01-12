using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiBanXoi
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)// check ten tai khoan va mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em) // check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();


        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            string tentk = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string xacnhanmk = txtXacNhan.Text;
            string email = txtEmail.Text;

            if (!checkAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số , chữ hoa và chữ thường! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkAccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số , chữ hoa và chữ thường! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (xacnhanmk != matkhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "' ").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void pHien_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                pAn.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void pAn_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pHien.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void pHien2_Click(object sender, EventArgs e)
        {
            if (txtXacNhan.PasswordChar == '\0')
            {
                pAn2.BringToFront();
                txtXacNhan.PasswordChar = '*';
            }
        }

        private void pAn2_Click(object sender, EventArgs e)
        {
            if (txtXacNhan.PasswordChar == '*')
            {
                pHien2.BringToFront();
                txtXacNhan.PasswordChar = '\0';
            }
        }
    }
}
