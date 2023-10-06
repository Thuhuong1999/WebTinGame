using Microsoft.EntityFrameworkCore;

namespace TTGame.Entities
{
    public class AppDbContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G6DDPS5\\SQLEXPRESS01;Integrated Security=true;Initial Catalog=GameNets;MultipleActiveResultSets=True;encrypt=true;trustservercertificate=true");
        }
        public DbSet<KetQua> ketQuas { get; set; }
        public DbSet<Khoa> khoas { get; set; }
        public DbSet<KhoaMon> khoaMons { get; set; }
        public DbSet<Lop> lops { get; set; }
        public DbSet<MonHoc> monHocs { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>().HasOne(x => x.Lop).WithMany().HasForeignKey(x => x.MaLop).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Lop>().HasOne(x => x.khoa).WithMany().HasForeignKey(x => x.MaKhoa).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<KhoaMon>().HasOne(x => x.Khoa).WithMany().HasForeignKey(x => x.MaKhoa).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<KetQua>().HasOne(x => x.SinhVien).WithMany().HasForeignKey(x => x.MaSinhVien).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<KetQua>().HasOne(x => x.MonHoc).WithMany().HasForeignKey(x => x.MaMonHoc).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
