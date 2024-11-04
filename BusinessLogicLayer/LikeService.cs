using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LikeService : ILikeSevice
    {
        private readonly ILikeRepository likeRepository;

        public LikeService(ILikeRepository likeRepository)
        {
            this.likeRepository = likeRepository;
        }
        public async Task<int> GetLikeCountAsync(int articleId)
        {
            return await likeRepository.GetLikeCountAsync(articleId);
        }

        public async Task IncrementLikeAsync(int articleId)
        {
            await likeRepository.IncrementLikeAsync(articleId);
        }
    }
}
