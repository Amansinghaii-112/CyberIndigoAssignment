// <copyright file="BlogController.cs" company=" CyberIndigo Dot net Assignment">
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
    /// Service class for blog details.
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BlogController : ApiController
    {

        public BlogController(IBlogManager blogManager)
        {
            this._blogManager = blogManager;
        }

        #region Private fileds.

        /// <summary>
        /// Instance of blog detail repository.
        /// </summary>
        private IBlogManager _blogManager;

        #endregion Private fileds.

        [HttpPost]
        [Route("Blog/Add")]
        public bool Add(IList<BlogDTO> BlogDtoList)
        {

            bool result = false;

            try
            {

                result = _blogManager.AddManager(BlogDtoList);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

        [HttpPost]
        [Route("Blog/Update")]
        public bool Update(IList<BlogDTO> BlogDtoList)
        {

            bool result = false;

            try
            {

                result = _blogManager.UpdateManager(BlogDtoList);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

        [HttpPost]
        [Route("Blog/Delete")]
        public bool Delete(IList<int> Ids)
        {

            bool result = false;

            try
            {

                result = _blogManager.DeleteManager(Ids);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

        [HttpPost]
        [Route("Blog/GetAll")]
        public IList<BlogDTO> GetAll(IList<BlogSearchParameter> BlogSearchParameterList)
        {

            IList<BlogDTO> BlogDTOList = new List<BlogDTO>();

            try
            {
                BlogSearchParameterList.ToList().ForEach(BlogSearchParameter =>
                {
                    BlogDTOList = _blogManager.GetAllManager(BlogSearchParameter);
                });
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogDTOList;
        }

        [HttpPost]
        [Route("Blog/GetById")]
        public BlogDTO GetById(IList<int> Ids)
        {

            BlogDTO BlogDTOObj = new BlogDTO();

            try
            {

                BlogDTOObj = _blogManager.GetByIdManager(Ids);
               
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogDTOObj;
        }

    }
}