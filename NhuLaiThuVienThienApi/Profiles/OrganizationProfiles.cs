using AutoMapper;
using NhuLaiThuVienThienApi.DTOs;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Profiles
{
    public class OrganizationProfiles : Profile
    {
        public OrganizationProfiles()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
            CreateMap<Chapter, ChapterDto>();
            CreateMap<ChapterDto, Chapter>();
        }
    }
}
