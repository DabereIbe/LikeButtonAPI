using DataAccessLayer.Data;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LikeRepository : ILikeRepository
    {
        private readonly AppDbContext db;

        public LikeRepository(AppDbContext db)
        {
            this.db = db;
        }

        public async Task<int> GetLikeCountAsync(int articleId)
        {
            var article = await db.ArticleLike.FindAsync(articleId);
            return article?.LikeCount ?? 0;
        }

        public async Task IncrementLikeAsync(int articleId)
        {
            var article = await db.ArticleLike.FindAsync(articleId);

            if (article == null)
            {
                article = new ArticleLike { ArticleId = articleId, LikeCount = 1 };
                db.ArticleLike.Add(article);
            }
            else 
            { 
                article.LikeCount++;
                db.ArticleLike.Update(article);
            }
            await db.SaveChangesAsync();
        }
    }
}
