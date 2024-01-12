using DevExpress.XtraBars;
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
    public partial class frmGiaoDienChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        void OpenForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if(frm.GetType()==typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form) Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void btnNV_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNhanVien));
        }

        private void btnKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmKhachHang));
        }

        private void btnDiem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmDiemBan1));
        }

        private void btnDiem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmDiemBan2));
        }

        private void btnTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmThongKe));
        }

        private void btnHoTro_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmHoTro));
        }

        private void btnDSM_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmDanhSach));
        }
    }
}