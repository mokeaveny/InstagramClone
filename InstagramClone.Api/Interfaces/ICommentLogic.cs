using InstagramClone.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone.Api.Interfaces
{
    public interface ICommentLogic
    {
        Task<Comment> GetComment(int commentId);
        Task<IEnumerable<Comment>> GetUserComments(int userId);
        Task CreateComment(int postId, int authorId, string message);
        Task DeleteComment(int commentId);
    }
}
