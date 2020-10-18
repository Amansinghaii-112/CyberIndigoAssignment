// <copyright file="BlogManager.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This is the interface for blog detail manager lavel.
    /// </summary>
    public class BlogManager : IBlogManager
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public BlogManager(IBlog blog)
        {

            this._blog = blog;

        }

        #region Private fields.

        /// <summary>
        /// Instance of blog detail repository.
        /// </summary>
        private IBlog _blog;

        #endregion #region Private fields.

        #region Public methods.

        /// <summary>
        /// This method responsible for add the blog details in manager level.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        public bool AddManager(IList<BlogDTO> blogDTOList)
        {
            try
            {
                return _blog.AddRepository(blogDTOList);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///  This method responsible for update the blog details in manager level.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        public bool UpdateManager(IList<BlogDTO> blogDTOList)
        {

            try
            {
                return _blog.UpdateRepository(blogDTOList);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// This method responsible for delete the blog details in manager level.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public bool DeleteManager(IList<int> Ids)
        {

            try
            {
                return _blog.DeleteRepository(Ids);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///  This method responsible for get the blog details from manager level.
        /// </summary>
        /// <returns></returns>
        public IList<BlogDTO> GetAllManager(BlogSearchParameter blogSearchParameter)
        {

            try
            {
                return _blog.GetAllRepository(blogSearchParameter);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///This method responsible for get the blog details as per id from manager level.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public BlogDTO GetByIdManager(IList<int> Ids)
        {
            BlogDTO BlogDTOObj = new BlogDTO();

            try
            {
                Ids.ToList().ForEach(id =>
                {

                    BlogDTOObj = _blog.GetByIdRepository(id);

                });
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogDTOObj;
        }

        #endregion Public methods.

    }
}
