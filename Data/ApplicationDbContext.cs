using Microsoft.EntityFrameworkCore;

namespace yaz_okul.Data  // Projenizin namespace ismi neyse onu kullanın
{
    public class ApplicationDbContext : DbContext  // DbContext sınıfından miras alıyoruz
    {
        // Constructor (Veritabanı bağlantısını alacak)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Veritabanındaki tablolar için DbSet tanımlamaları
        public DbSet<TBLOGRNCI> Students { get; set; }  // Örneğin, Student tablosu
        // Diğer tablolarınız varsa onları da buraya ekleyebilirsiniz:
        // public DbSet<Course> Courses { get; set; }
    }
}
