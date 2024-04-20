using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Infrastructure.Data.Entities.Infrastructure.Data.Entity.Core.Domains;

namespace CMS.Infrastructure.Data.Entities.Infrastructure.Data.Entity.Core.Interfaces.Repository
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// This method should be return a category by primary key (Id)
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        Category GetByID(long categoryId);

        /// <summary>
        /// This method should be return all of categories
        /// </summary>
        /// <returns></returns>
        List<Category> GetAll();

        /// <summary>
        /// This method add new category to database
        /// </summary>
        /// <param name="category"></param>
        void Add(Category category);

        /// <summary>
        /// This method update a category and return modified category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Category Update(Category category);

        /// <summary>
        /// This method delete the category from database 
        /// </summary>
        /// <param name="categoryId"></param>
        void Delete(long categoryId);
    }
}
