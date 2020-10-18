// <copyright file="BlogTagRepository.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------


#region References.

using Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;

#endregion References.

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This is the class for blog tags detail.
    /// </summary>
    public class BlogTagRepository : IBlogTag
    {

        #region Public methods.

        /// <summary>
        ///  This method responsible for get the Blog Tags details from database.
        /// </summary>
        /// <returns></returns>
        public IList<BlogTagsDTO> GetAllRepository()
        {
            IList<BlogTagsDTO> BlogTagsDTOList = new List<BlogTagsDTO>();

            try
            {

                CyberIndigoDBDataContext context = new CyberIndigoDBDataContext();

                var query = from BlogTagRecord in context.BlogTagRecords
                            select BlogTagRecord;

                IList<BlogTagRecord> BlogTagRecords = query.ToList();

                BlogTagsDTOList = this.MakeDto(BlogTagRecords);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return BlogTagsDTOList;
        }


        /// <summary>
        ///This method responsible for get the  Blog Tags details as per id from database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public BlogTagsDTO GetByIdRepository(int Id)
        {

            BlogTagsDTO BlogTagsDTOObj = new BlogTagsDTO();

            try
            {

                BlogTagRecord BlogTagRecordObj = new BlogTagRecord();

                using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                {

                    BlogTagRecordObj = context.BlogTagRecords.Where(item => item.Identifier.Equals(Id)).FirstOrDefault();
                }

                BlogTagsDTOObj.Identifier = BlogTagRecordObj.Identifier;
                BlogTagsDTOObj.TagName = BlogTagRecordObj.TagName;

            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogTagsDTOObj;

        }

        #endregion Public methods.

        #region Private Methods.

        /// <summary>
        /// Make DTO method.
        /// </summary>
        /// <param name="BlogTagRecords"></param>
        /// <returns></returns>
        private IList<BlogTagsDTO> MakeDto(IList<BlogTagRecord> BlogTagRecords)
        {

            IList<BlogTagsDTO> BlogTagsDTOList = new List<BlogTagsDTO>();

            try
            {
                BlogTagRecords.ToList().ForEach(blogTagRecord =>
                {

                    BlogTagsDTOList.Add(new BlogTagsDTO()
                    {

                        Identifier = blogTagRecord.Identifier,
                        TagName = blogTagRecord.TagName
                    });

                });

               
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogTagsDTOList;

        }

        #endregion Private Methods.

    }
}
