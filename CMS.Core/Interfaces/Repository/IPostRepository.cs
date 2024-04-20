using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Core.Domains;

namespace CMS.Core.Interfaces.Repository
{
    public interface IPostRepository
    {
        /// <summary>
        /// This method should be return all of posts
        /// </summary>
        /// <returns></returns>
        List<Post> GetAllPosts();

        /// <summary>
        /// With the given count parameter, this method gets the number of latest posts based on the count
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<Post> GetLatestPosts(int count);

        /// <summary>
        /// This method should be return a post by primary key (Id)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Post GetByID(long id);

        /// <summary>
        ///  This method add new post to database
        /// </summary>
        /// <param name="post"></param>
        void Add(Post post);

        /// <summary>
        /// This method update a post and return modified post
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        Post Update(Post post);

        /// <summary>
        /// This method delete the category from database 
        /// </summary>
        /// <param name="post"></param>
        void Delete(Post post);

    }
}
