// <copyright file="BlogRepository.cs" company=" CyberIndigo Dot net Assignment">
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
    /// This is the class for blog detail.
    /// </summary>
    public class BlogRepository : IBlog
    {

        /// <summary>
        /// This method responsible for add the blog details in database.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        public bool AddRepository(IList<BlogDTO> blogDTOList)
        {
            bool result = false;

            IList<BlogRecord> BlogDTODetailRecords = null;

            try
            {

                BlogDTODetailRecords = blogDTOList?.Select(blogRec => new BlogRecord()
                {

                   Title = blogRec.Title,
                   SubTitle = blogRec.SubTitle,
                   TagId = blogRec.Tags,
                   OwnerEmailID = blogRec.OwnerEmailID,
                   ArticleDescription = blogRec.ArticleDescription

                }).ToList();

                using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                {

                    context.BlogRecords.InsertAllOnSubmit(BlogDTODetailRecords);
                    context.SubmitChanges();
                    result = true;

                }

            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

        /// <summary>
        ///  This method responsible for update the blog details in database.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        public bool DeleteRepository(IList<int> Ids)
        {

            bool result = false;

            try
            {

                Ids.ToList().ForEach(id =>
                {
                    BlogRecord BlogRecordObj = new BlogRecord();

                    using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                    {

                        BlogRecordObj = context.BlogRecords.Where(item => item.Identifier.Equals(id)).FirstOrDefault();

                        context.BlogRecords.DeleteOnSubmit(BlogRecordObj);
                        context.SubmitChanges();

                    }
                });

                result = true;
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///  This method responsible for get the Blog details from database.
        /// </summary>
        /// <returns></returns>
        public IList<BlogDTO> GetAllRepository(BlogSearchParameter blogSearchParameter)
        {
            IList<BlogDTO> BlogDTODTOList = new List<BlogDTO>();

            try
            {

                CyberIndigoDBDataContext context = new CyberIndigoDBDataContext();

                if(blogSearchParameter.Tags != null || blogSearchParameter.Tags != 0)
                {

                    var query = from BlogRecord in context.BlogRecords
                                where blogSearchParameter.Tags == BlogRecord.TagId
                                select BlogRecord;

                    IList<BlogRecord> BlogRecords = query.ToList();

                    BlogDTODTOList = this.MakeDto(BlogRecords);

                }
                else
                {

                    var query = from BlogRecord in context.BlogRecords
                                select BlogRecord;

                    IList<BlogRecord> BlogRecords = query.ToList();

                    BlogDTODTOList = this.MakeDto(BlogRecords);

                }

            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return BlogDTODTOList;
        }

        /// <summary>
        ///This method responsible for get the blog details as per id from database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public BlogDTO GetByIdRepository(int Id)
        {

            BlogDTO BlogDTOObj = new BlogDTO();

            try
            {

                BlogRecord BlogRecordObj = new BlogRecord();

                using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                {

                    BlogRecordObj = context.BlogRecords.Where(item => item.Identifier.Equals(Id)).FirstOrDefault();
                }

                BlogDTOObj.Identifier = BlogRecordObj.Identifier;
                BlogDTOObj.Title = BlogRecordObj.Title;
                BlogDTOObj.SubTitle = BlogRecordObj.SubTitle;
                BlogDTOObj.Tags = BlogRecordObj.TagId;
                BlogDTOObj.ArticleDescription = BlogRecordObj.ArticleDescription;
                BlogDTOObj.OwnerEmailID = BlogRecordObj.OwnerEmailID;

            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogDTOObj;

        }

        /// <summary>
        ///  This method responsible for update the blog details in database.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        public bool UpdateRepository(IList<BlogDTO> blogDTOList)
        {
            bool result = false;

            try
            {

                using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                {

                    blogDTOList.ToList().ForEach(blogDetail =>
                    {

                        BlogRecord BlogRecordObj = context.BlogRecords.Where(val => val.Identifier == blogDetail.Identifier).FirstOrDefault();

                        BlogRecordObj.Title = blogDetail.Title;
                        BlogRecordObj.SubTitle = blogDetail.SubTitle;
                        BlogRecordObj.TagId = blogDetail.Tags;
                        BlogRecordObj.ArticleDescription = blogDetail.ArticleDescription;
                        BlogRecordObj.OwnerEmailID = blogDetail.OwnerEmailID;

                        context.SubmitChanges();

                    });

                    result = true;

                }

            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

        #region Private Methods.

        /// <summary>
        /// Make DTO method.
        /// </summary>
        /// <param name="BlogTagRecords"></param>
        /// <returns></returns>
        private IList<BlogDTO> MakeDto(IList<BlogRecord> BlogRecords)
        {

            IList<BlogDTO> BlogDTOList = new List<BlogDTO>();

            try
            {
                BlogRecords.ToList().ForEach(blogRecord =>
                {

                    BlogDTOList.Add(new BlogDTO()
                    {

                        Identifier = blogRecord.Identifier,
                        Title = blogRecord.Title,
                        SubTitle = blogRecord.SubTitle,
                        Tags = blogRecord.TagId,
                        OwnerEmailID = blogRecord.OwnerEmailID,
                        ArticleDescription = blogRecord.ArticleDescription

                    });

                });


            }
            catch (Exception exception)
            {
                throw exception;
            }

            return BlogDTOList;

        }

        #endregion Private Methods.


    }
}
