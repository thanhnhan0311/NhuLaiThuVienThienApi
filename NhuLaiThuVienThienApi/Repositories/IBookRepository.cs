
using Microsoft.EntityFrameworkCore;
using NhuLaiThuVienThienApi.Data;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Repositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<List<Book>> GetBooksIncludeChapterAsync();
        Task<Book> GetBookIncludeChapterAsync(int id);
    }
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly NhuLaiThuVienThienDbContext _context;
        public BookRepository(NhuLaiThuVienThienDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBooksIncludeChapterAsync()
        {
            return await _context.Books.Include(b => b.chapters).ToListAsync();
        }

        public async Task<Book> GetBookIncludeChapterAsync(int id)
        {
            var book = await _context.Books.Include(b => b.chapters)
                .Where(b => b.book_id == id).SingleOrDefaultAsync();
            return book;
        }
    }
}
