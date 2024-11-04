using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ArticleLike
    {
        [Key]
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int LikeCount { get; set; }
    }
}
