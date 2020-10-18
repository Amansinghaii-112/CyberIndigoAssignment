// <copyright file="IBlogTag.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References

using System.Collections.Generic;

#endregion

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This is the interface for blog tags detail.
    /// </summary>
    public interface IBlogTag
    {

        /// <summary>
        ///  This method responsible for get the Blog Tags details from database.
        /// </summary>
        /// <returns></returns>
        IList<BlogTagsDTO> GetAllRepository();

        /// <summary>
        ///This method responsible for get the  Blog Tags details as per id from database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        BlogTagsDTO GetByIdRepository(int Id);

    }
}
