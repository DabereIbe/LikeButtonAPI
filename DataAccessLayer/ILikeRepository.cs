using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ILikeRepository
    {
        public Task<int> GetLikeCountAsync(int articleId);
        public Task IncrementLikeAsync(int articleId);
    }
}
