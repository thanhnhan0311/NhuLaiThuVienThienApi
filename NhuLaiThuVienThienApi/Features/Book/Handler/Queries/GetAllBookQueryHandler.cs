using AutoMapper;
using MediatR;
using NhuLaiThuVienThienApi.DTOs;
using NhuLaiThuVienThienApi.Features.Book.Request.Queries;
using NhuLaiThuVienThienApi.Repositories;

namespace NhuLaiThuVienThienApi.Features.Book.Handler.Queries
{
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQuery, List<BookDto>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public GetAllBookQueryHandler(IBookRepository bookRepository,IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<List<BookDto>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetBooksIncludeChapterAsync();
            var booksDto = _mapper.Map<List<BookDto>>(books);
            return booksDto;
        }
    }
}
