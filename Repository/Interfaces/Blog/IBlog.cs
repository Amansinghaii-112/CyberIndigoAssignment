using System;
// <copyright file="IBlog.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References

using System.Collections.Generic;

#endregion

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This is the interface for blog detail.
    /// </summary>
    public interface IBlog
    {

        /// <summary>
        /// This method responsible for add the blog details in database.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        bool AddRepository(IList<BlogDTO> blogDTOList);

        /// <summary>
        ///  This method responsible for update the blog details in database.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        bool UpdateRepository(IList<BlogDTO> blogDTOList);

        /// <summary>
        /// This method responsible for delete the blog details in database.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        bool DeleteRepository(IList<int> Ids);

        /// <summary>
        ///  This method responsible for get the blog details from database.
        /// </summary>
        /// <returns></returns>
        IList<BlogDTO> GetAllRepository(BlogSearchParameter blogSearchParameter);

        /// <summary>
        ///This method responsible for get the blog details as per id from database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        BlogDTO GetByIdRepository(int Id);

    }
}
