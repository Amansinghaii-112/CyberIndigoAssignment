// <copyright file="BlogTagController.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------


#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;

#endregion

namespace CyberIndigoAssignment
{

    /// <summary>
    /// Service class for blog tag details.
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BlogTagController : ApiController
    {

        public BlogTagController(IBlogTagManager blogTagManager)
        {
            this._blogTagManager = blogTagManager;
        }

        #region Private fileds.

        /// <summary>
        /// Instance of blog tag detail repository.
        /// </summary>
        private IBlogTagManager _blogTagManager;

        #endregion Private fileds.

        [HttpPost]
        [Route("BlogTag/GetById")]
        public BlogTagsDTO GetById(IList<int> Ids)
        {

            BlogTagsDTO BlogTagDTOObj = new BlogTagsDTO();

            try
            {

                BlogTagDTOObj = _blogTagManager.GetByIdManager(Ids);

            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogTagDTOObj;
        }

        [HttpPost]
        [Route("BlogTag/GetAll")]
        public IList<BlogTagsDTO> GetAll()
        {

            IList<BlogTagsDTO> BlogTagDTOList = new List<BlogTagsDTO>();

            try
            {

                BlogTagDTOList = _blogTagManager.GetAllManager();

            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogTagDTOList;
        }

    }
}