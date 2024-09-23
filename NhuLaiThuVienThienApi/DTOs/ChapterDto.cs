

namespace NhuLaiThuVienThienApi.DTOs
{
    public class ChapterDto
    {
        public int chapter_id { get; set; }
        //public int book_id { get; set; }
        //public BookDto book { get; set; } = new BookDto();
        public string chapter_name { get; set; } = string.Empty;
        public string chapter_content { get; set; } = string.Empty;
    }
}
