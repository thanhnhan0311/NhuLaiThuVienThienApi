using MediatR;
using NhuLaiThuVienThienApi.DTOs;
using System.ComponentModel.DataAnnotations.Schema;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Features.Book.Request.Commands
{
    public class CreateBookCommand :  IRequest<ThuVienNhuLaiThien.Domain.Book>
    {
        public BookDto book { get; set; }
        [NotMapped]
        public IFormFile fileImage { get; set; }
    }
}
