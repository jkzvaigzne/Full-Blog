
using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public interface IBlogPostLikeRepository
    {
        Task<int> GetTotalLikes(Guid blogPostId);
        Task<IEnumerable<BlogPostsLike>>GetLikesForBlog(Guid blogPostId);
        Task<BlogPostsLike> AddLikeForBlog(BlogPostsLike blogPostLike);
    }
}
