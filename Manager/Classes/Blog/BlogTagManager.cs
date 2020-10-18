// <copyright file="BlogTagManager.cs" company=" CyberIndigo Dot net Assignment">
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
    /// This is the interface for blog tag detail ata manager lavel.
    /// </summary>
    public class BlogTagManager : IBlogTagManager
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public BlogTagManager(IBlogTag blogTag)
        {

            this._blogTag = blogTag;

        }

        #region Private fields.

        /// <summary>
        /// Instance of blog tag detail repository.
        /// </summary>
        private IBlogTag _blogTag;

        #endregion #region Private fields.

        #region Public methods.

        /// <summary>
        ///  This method responsible for get the Blog Tags details in manager level..
        /// </summary>
        /// <returns></returns>
        public IList<BlogTagsDTO> GetAllManager()
        {
            try
            {
                return _blogTag.GetAllRepository();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///This method responsible for get the  Blog Tags details as per id in manager level..
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public BlogTagsDTO GetByIdManager(IList<int> Ids)
        {

            BlogTagsDTO BlogTagsDTOObj = new BlogTagsDTO();

            try
            {
                Ids.ToList().ForEach(id =>
                {

                    BlogTagsDTOObj = _blogTag.GetByIdRepository(id);

                });
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogTagsDTOObj;

        }

        #endregion Public methods.

    }
}
