using Microsoft.EntityFrameworkCore;

namespace PH34686_THICS4.Models
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext() // khai báo con trắc tơ ko tham số
        {
        }

        public AppDBContext(DbContextOptions options) :base(options) // khai báo con trắc tơ có tham số
        {   
        }
        public DbSet<Ca> Cas { get; set; } // khai báo Dbset của 2 bảng đã tạo
        public DbSet<DongVat> DongVats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-CXH2410\\SQLEXPRESS;Database=Test_02;Trusted_Connection=True;");
        }

    }
}
