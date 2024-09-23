using MediatR;
using NhuLaiThuVienThienApi.DTOs;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Features.Book.Request.Queries
{
    public class GetAllBookQuery :IRequest<List<BookDto>>
    {
    }
}
