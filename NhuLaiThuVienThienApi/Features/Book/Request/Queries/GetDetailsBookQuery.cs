using MediatR;
using NhuLaiThuVienThienApi.DTOs;

namespace NhuLaiThuVienThienApi.Features.Book.Request.Queries
{
    public class GetDetailsBookQuery : IRequest<BookDto>
    {
        public int book_id { get; set; }
    }
}
