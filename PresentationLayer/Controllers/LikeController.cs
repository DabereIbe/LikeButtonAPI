using BusinessLogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeSevice likeSevice;

        public LikeController(ILikeSevice likeSevice)
        {
            this.likeSevice = likeSevice;
        }

        [HttpGet("LikeCount/{id}")]
        public async Task<IActionResult> GetLikeCount(int id)
        {
            var likeCount = await likeSevice.GetLikeCountAsync(id);
            return Ok(likeCount);
        }

        [HttpPost("LikeArticle/{id}")]
        public async Task<IActionResult> IncrementLike(int id)
        {
            await likeSevice.IncrementLikeAsync(id);

            return Ok();
        }
    }
}
