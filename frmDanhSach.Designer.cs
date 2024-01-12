namespace QuanLyChuoiBanXoi
{
    partial class frmDanhSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSach));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDB1 = new System.Windows.Forms.GroupBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenXoi = new System.Windows.Forms.TextBox();
            this.lblTenXoi = new System.Windows.Forms.Label();
            this.txtMaXoi = new System.Windows.Forms.TextBox();
            this.lblMaXoi = new System.Windows.Forms.Label();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.colMaXoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(88, 414);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 43);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "  Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(373, 414);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 46);
            this.btnSua.TabIndex = 75;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(233, 416);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 43);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1179, 578);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tìm kiếm theo mã xôi";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(1361, 570);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(190, 37);
            this.txtTimKiem.TabIndex = 72;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1579, 570);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 37);
            this.btnTimKiem.TabIndex = 71;
            this.btnTimKiem.Text = "   Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grpDB1
            // 
            this.grpDB1.BackColor = System.Drawing.Color.White;
            this.grpDB1.Controls.Add(this.label4);
            this.grpDB1.Controls.Add(this.label2);
            this.grpDB1.Controls.Add(this.label1);
            this.grpDB1.Controls.Add(this.lblGia);
            this.grpDB1.Controls.Add(this.txtGia);
            this.grpDB1.Controls.Add(this.txtTenXoi);
            this.grpDB1.Controls.Add(this.lblTenXoi);
            this.grpDB1.Controls.Add(this.txtMaXoi);
            this.grpDB1.Controls.Add(this.lblMaXoi);
            this.grpDB1.Location = new System.Drawing.Point(60, 96);
            this.grpDB1.Name = "grpDB1";
            this.grpDB1.Size = new System.Drawing.Size(451, 300);
            this.grpDB1.TabIndex = 70;
            this.grpDB1.TabStop = false;
            this.grpDB1.Text = "Thông tin món ăn";
          
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(76, 230);
            this.lblGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(34, 16);
            this.lblGia.TabIndex = 44;
            this.lblGia.Text = "Giá :";
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGia.Location = new System.Drawing.Point(199, 223);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(188, 16);
            this.txtGia.TabIndex = 41;
            // 
            // txtTenXoi
            // 
            this.txtTenXoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenXoi.Location = new System.Drawing.Point(199, 147);
            this.txtTenXoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenXoi.Name = "txtTenXoi";
            this.txtTenXoi.Size = new System.Drawing.Size(188, 16);
            this.txtTenXoi.TabIndex = 37;
            // 
            // lblTenXoi
            // 
            this.lblTenXoi.AutoSize = true;
            this.lblTenXoi.Location = new System.Drawing.Point(76, 154);
            this.lblTenXoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenXoi.Name = "lblTenXoi";
            this.lblTenXoi.Size = new System.Drawing.Size(60, 16);
            this.lblTenXoi.TabIndex = 32;
            this.lblTenXoi.Text = "Tên Xôi :";
            // 
            // txtMaXoi
            // 
            this.txtMaXoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaXoi.Location = new System.Drawing.Point(199, 73);
            this.txtMaXoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaXoi.Name = "txtMaXoi";
            this.txtMaXoi.Size = new System.Drawing.Size(188, 16);
            this.txtMaXoi.TabIndex = 31;
            // 
            // lblMaXoi
            // 
            this.lblMaXoi.AutoSize = true;
            this.lblMaXoi.Location = new System.Drawing.Point(76, 80);
            this.lblMaXoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaXoi.Name = "lblMaXoi";
            this.lblMaXoi.Size = new System.Drawing.Size(55, 16);
            this.lblMaXoi.TabIndex = 30;
            this.lblMaXoi.Text = "Mã Xôi :";
            // 
            // dgvDS
            // 
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaXoi,
            this.colTenXoi,
            this.colGia});
            this.dgvDS.Location = new System.Drawing.Point(542, 70);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.RowTemplate.Height = 24;
            this.dgvDS.Size = new System.Drawing.Size(1153, 459);
            this.dgvDS.TabIndex = 69;
            this.dgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellClick);
            // 
            // colMaXoi
            // 
            this.colMaXoi.HeaderText = "Mã Xôi";
            this.colMaXoi.MinimumWidth = 6;
            this.colMaXoi.Name = "colMaXoi";
            // 
            // colTenXoi
            // 
            this.colTenXoi.HeaderText = "Tên Xôi";
            this.colTenXoi.MinimumWidth = 6;
            this.colTenXoi.Name = "colTenXoi";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            // 
            // btnQL
            // 
            this.btnQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQL.ForeColor = System.Drawing.Color.Black;
            this.btnQL.Image = ((System.Drawing.Image)(resources.GetObject("btnQL.Image")));
            this.btnQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQL.Location = new System.Drawing.Point(43, 27);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(116, 37);
            this.btnQL.TabIndex = 77;
            this.btnQL.Text = "   Quay lại";
            this.btnQL.UseVisualStyleBackColor = false;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(196, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 1);
            this.label1.TabIndex = 49;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(196, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 1);
            this.label2.TabIndex = 50;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(196, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 1);
            this.label4.TabIndex = 51;
            this.label4.Text = "label4";
            // 
            // frmDanhSach
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 649);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpDB1);
            this.Controls.Add(this.dgvDS);
            this.Name = "frmDanhSach";
            this.Text = "Danh Sách Món";
            this.Load += new System.EventHandler(this.frmDanhSach_Load);
            this.grpDB1.ResumeLayout(false);
            this.grpDB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grpDB1;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenXoi;
        private System.Windows.Forms.Label lblTenXoi;
        private System.Windows.Forms.TextBox txtMaXoi;
        private System.Windows.Forms.Label lblMaXoi;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaXoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenXoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.Button btnQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}