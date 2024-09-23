using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienNhuLaiThien.Domain
{
    public class Chapter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int chapter_id { get; set; }
        public int book_id { get; set; }
        public Book book { get; set; } = new Book();
        public string chapter_name { get; set; } = string.Empty;
        public string chapter_content { get; set; } = string.Empty;

    }
}
