using System.ComponentModel.DataAnnotations.Schema;

namespace NhuLaiThuVienThienApi.DTOs
{
    public class BookDto
    {
        public int book_id { get; set; }
        public string book_name { get; set; } = string.Empty;
        public string book_image { get; set; } = string.Empty;
        public string book_author { get; set; } = string.Empty;
        public string book_category { get; set; } = string.Empty;
        public string book_description { get; set; } = string.Empty;
        [NotMapped]
        public int chapters_total => chapters.Count;

        //public DateTime create_date { get; set; } = DateTime.Now;
        //public DateTime updated_date { get; set; } = DateTime.Now;
        public List<ChapterDto> chapters { get; set; } = new List<ChapterDto>();
       
    }
}
