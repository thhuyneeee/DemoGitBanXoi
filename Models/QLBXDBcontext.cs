using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyChuoiBanXoi.Models
{
    public partial class QLBXDBcontext : DbContext
    {
        public QLBXDBcontext()
            : base("name=QLBXDBcontext4")
        {
        }

        public virtual DbSet<CTHD> CTHD { get; set; }
        public virtual DbSet<DiemBan> DiemBan { get; set; }
        public virtual DbSet<DSXoi> DSXoi { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaCT)
                .IsFixedLength();

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaXoi)
                .IsFixedLength();

            modelBuilder.Entity<CTHD>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DiemBan>()
                .Property(e => e.MaDB)
                .IsFixedLength();

            modelBuilder.Entity<DSXoi>()
                .Property(e => e.MaXoi)
                .IsFixedLength();

            modelBuilder.Entity<DSXoi>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaDB)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.KhachHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();
        }
    }
}
