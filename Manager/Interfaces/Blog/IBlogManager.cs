// <copyright file="IBlogManager.cs" company=" CyberIndigo Dot net Assignment">
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
    public interface IBlogManager
    {

        /// <summary>
        /// This method responsible for add the blog details in manager level.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        bool AddManager(IList<BlogDTO> blogDTOList);

        /// <summary>
        ///  This method responsible for update the blog details in manager level.
        /// </summary>
        /// <param name="blogDTOList"></param>
        /// <returns></returns>
        bool UpdateManager(IList<BlogDTO> blogDTOList);

        /// <summary>
        /// This method responsible for delete the blog details in manager level.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        bool DeleteManager(IList<int> Ids);

        /// <summary>
        ///  This method responsible for get the blog details from manager level.
        /// </summary>
        /// <returns></returns>
        IList<BlogDTO> GetAllManager(BlogSearchParameter blogSearchParameter);

        /// <summary>
        ///This method responsible for get the blog details as per id from manager level.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        BlogDTO GetByIdManager(IList<int> Ids);

    }
}
