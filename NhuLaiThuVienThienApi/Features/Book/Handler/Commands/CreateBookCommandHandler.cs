using AutoMapper;
using MediatR;
using NhuLaiThuVienThienApi.Features.Book.Request.Commands;
using NhuLaiThuVienThienApi.Repositories;
using TechWizWebApp.Services;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Features.Book.Handler.Commands
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, ThuVienNhuLaiThien.Domain.Book>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
        private readonly IFileService _fileService;
        public CreateBookCommandHandler(IMapper mapper,IBookRepository bookRepository,IFileService fileService)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _fileService = fileService;
        }
        public async Task<ThuVienNhuLaiThien.Domain.Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<ThuVienNhuLaiThien.Domain.Book>(request.book);
            var imageName = await _fileService.UploadImageAsync(request.fileImage);
            book.book_image = imageName;
            return await _bookRepository.Add(book);
            
        }
    }
}
