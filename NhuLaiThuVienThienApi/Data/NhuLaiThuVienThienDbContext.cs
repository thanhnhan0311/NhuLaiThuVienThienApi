using Microsoft.EntityFrameworkCore;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Data
{
    public class NhuLaiThuVienThienDbContext : DbContext
    {
        public NhuLaiThuVienThienDbContext(DbContextOptions<NhuLaiThuVienThienDbContext> options): base(options) 
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(b => b.chapters)
                .WithOne(c => c.book)
                .HasForeignKey(c => c.book_id);
                
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
