using AutoMapper;
using MediatR;
using NhuLaiThuVienThienApi.DTOs;
using NhuLaiThuVienThienApi.Features.Book.Request.Queries;
using NhuLaiThuVienThienApi.Repositories;

namespace NhuLaiThuVienThienApi.Features.Book.Handler.Queries
{
    public class GetDetailsBookQueryHandler : IRequestHandler<GetDetailsBookQuery, BookDto>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public GetDetailsBookQueryHandler(IBookRepository bookRepository,IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<BookDto> Handle(GetDetailsBookQuery request, CancellationToken cancellationToken)
        {
            var bookDto = _mapper.Map<BookDto>(await _bookRepository.GetBookIncludeChapterAsync(request.book_id));
            return bookDto;
        }
    }
}
