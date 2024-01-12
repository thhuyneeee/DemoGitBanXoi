namespace QuanLyChuoiBanXoi
{
    partial class frmGiaoDienChinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDienChinh));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNV = new DevExpress.XtraBars.BarCheckItem();
            this.btnKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoTro = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSM = new DevExpress.XtraBars.BarButtonItem();
            this.mnNV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnKhachHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnDiemBan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnHoTro = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(111);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNV,
            this.btnKH,
            this.btnDiem1,
            this.btnDiem2,
            this.btnTK,
            this.btnHoTro,
            this.btnDSM});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(12);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 1257;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mnNV,
            this.mnKhachHang,
            this.mnDiemBan,
            this.mnThongKe,
            this.ribbonPage1,
            this.mnHoTro});
            this.ribbon.Size = new System.Drawing.Size(1362, 182);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnNV
            // 
            this.btnNV.Caption = "      Nhân viên                       ";
            this.btnNV.Id = 2;
            this.btnNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.Image")));
            this.btnNV.Name = "btnNV";
            this.btnNV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNV.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_CheckedChanged);
            // 
            // btnKH
            // 
            this.btnKH.Caption = "   Khách Hàng                  ";
            this.btnKH.Id = 4;
            this.btnKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.ImageOptions.Image")));
            this.btnKH.Name = "btnKH";
            this.btnKH.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKH_ItemClick);
            // 
            // btnDiem1
            // 
            this.btnDiem1.Caption = "Điểm 1";
            this.btnDiem1.Id = 5;
            this.btnDiem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDiem1.ImageOptions.Image")));
            this.btnDiem1.Name = "btnDiem1";
            this.btnDiem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDiem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiem1_ItemClick);
            // 
            // btnDiem2
            // 
            this.btnDiem2.Caption = " Điểm 2       ";
            this.btnDiem2.Id = 7;
            this.btnDiem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDiem2.ImageOptions.Image")));
            this.btnDiem2.Name = "btnDiem2";
            this.btnDiem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDiem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiem2_ItemClick);
            // 
            // btnTK
            // 
            this.btnTK.Caption = "                                   Thống Kê        ";
            this.btnTK.Id = 8;
            this.btnTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.ImageOptions.Image")));
            this.btnTK.Name = "btnTK";
            this.btnTK.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTK_ItemClick);
            // 
            // btnHoTro
            // 
            this.btnHoTro.Caption = "        Hỗ Trợ                                ";
            this.btnHoTro.Id = 9;
            this.btnHoTro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoTro.ImageOptions.Image")));
            this.btnHoTro.Name = "btnHoTro";
            this.btnHoTro.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnHoTro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoTro_ItemClick);
            // 
            // btnDSM
            // 
            this.btnDSM.Caption = "Danh Sách Món";
            this.btnDSM.Id = 10;
            this.btnDSM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSM.ImageOptions.Image")));
            this.btnDSM.Name = "btnDSM";
            this.btnDSM.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDSM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSM_ItemClick);
            // 
            // mnNV
            // 
            this.mnNV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.mnNV.Name = "mnNV";
            this.mnNV.Text = "Nhân viên";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // mnKhachHang
            // 
            this.mnKhachHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.mnKhachHang.Name = "mnKhachHang";
            this.mnKhachHang.Text = "Khách Hàng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKH);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // mnDiemBan
            // 
            this.mnDiemBan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.mnDiemBan.Name = "mnDiemBan";
            this.mnDiemBan.Text = "Điểm Bán";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDiem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDiem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // mnThongKe
            // 
            this.mnThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.mnThongKe.Name = "mnThongKe";
            this.mnThongKe.Text = "Thống Kê";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTK);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Sách Món";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDSM);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // mnHoTro
            // 
            this.mnHoTro.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.mnHoTro.Name = "mnHoTro";
            this.mnHoTro.Text = "Hỗ Trợ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHoTro);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 698);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(12);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1362, 27);
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmGiaoDienChinh
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1362, 725);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmGiaoDienChinh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Giao Diện Chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnDiemBan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarCheckItem btnNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnKH;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnNV;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDiem1;
        private DevExpress.XtraBars.BarButtonItem btnDiem2;
        private DevExpress.XtraBars.BarButtonItem btnTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnHoTro;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnHoTro;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnDSM;
    }
}