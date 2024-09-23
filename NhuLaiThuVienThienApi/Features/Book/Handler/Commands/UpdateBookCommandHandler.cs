using AutoMapper;
using MediatR;
using NhuLaiThuVienThienApi.Features.Book.Request.Commands;
using NhuLaiThuVienThienApi.Repositories;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Features.Book.Handler.Commands
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public UpdateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.Get(request.bookUpdate.book_id);

            _mapper.Map(request.bookUpdate, book);



            foreach (var chapterUpdate in request.bookUpdate.chapters)
            {
                var existingChapter = book.chapters.FirstOrDefault(c => c.chapter_id == chapterUpdate.chapter_id);

                if (existingChapter != null)
                {
                    _mapper.Map(chapterUpdate, existingChapter);
                }
                else
                {
                    var newChapter = _mapper.Map<Chapter>(chapterUpdate);
                    book.chapters.Add(newChapter);
                }
            }

            await _bookRepository.Update(book);
            return Unit.Value;
        }
    }
}
