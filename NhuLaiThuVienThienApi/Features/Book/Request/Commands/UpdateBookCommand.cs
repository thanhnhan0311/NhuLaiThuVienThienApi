using MediatR;
using NhuLaiThuVienThienApi.DTOs;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Features.Book.Request.Commands
{
    public class UpdateBookCommand : IRequest
    {
        public BookDto bookUpdate { get; set; }

    }
}
