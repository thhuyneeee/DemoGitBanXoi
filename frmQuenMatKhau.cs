using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiBanXoi
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
            lblKetQua.Text = "";
        }
        Modify modify = new Modify();

        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            string email = txtEmailDK.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    lblKetQua.ForeColor = Color.Blue;
                    lblKetQua.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    lblKetQua.ForeColor = Color.Red;
                    lblKetQua.Text = "Email này chưa được đăng ký! ";
                }
            }
        }
    }
}
