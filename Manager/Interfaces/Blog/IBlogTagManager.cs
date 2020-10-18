// <copyright file="IBlogTagManager.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References

using System.Collections.Generic;

#endregion

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This is the interface for blog tag detail.
    /// </summary>
    public interface IBlogTagManager
    {


        /// <summary>
        ///  This method responsible for get the Blog Tags details in manager level..
        /// </summary>
        /// <returns></returns>
        IList<BlogTagsDTO> GetAllManager();

        /// <summary>
        ///This method responsible for get the  Blog Tags details as per id in manager level..
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        BlogTagsDTO GetByIdManager(IList<int> Ids);


    }
}
