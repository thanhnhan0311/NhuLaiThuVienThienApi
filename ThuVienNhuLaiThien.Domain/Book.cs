using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienNhuLaiThien.Domain
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int book_id { get; set; }
        public string book_name { get; set; } = string.Empty;
        public string book_image { get; set; } = string.Empty;
        public string book_author { get; set; } = string.Empty;
        public string book_category { get; set; } = string.Empty;
        public string book_description { get; set; } = string.Empty;
        public DateTime create_date { get; set; } = DateTime.Now;
        public DateTime updated_date { get; set; } = DateTime.Now;
        public List<Chapter> chapters { get; set; } = new List<Chapter>();
    }
}
