// <copyright file="IUser.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References

using System.Collections.Generic;

#endregion

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This is the interface for user detail.
    /// </summary>
    public interface IUser
    {

        /// <summary>
        /// This method responsible for add the user details in database.
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        bool AddRepository(IList<UserDTO> UserDTOList);

        /// <summary>
        /// This method responsible for update the user details in database.
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        bool UpdateRepository(IList<UserDTO> UserDTOList);

        /// <summary>
        /// This method responsible for delete the user details in database.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        bool DeleteRepository(IList<int> Ids);

        /// <summary>
        ///  This method responsible for get the user details from database.
        /// </summary>
        /// <returns></returns>
        IList<UserDTO> GetAllRepository();

        /// <summary>
        ///This method responsible for get the user details as per id from database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        UserDTO GetByIdRepository(int Id);


        /// <summary>
        /// This method is responsible for get user count from database.
        /// </summary>
        /// <returns></returns>
        int GetUserDetailCountRepository();

        /// <summary>
        /// This method is rtesponsible for check user credential from database;
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        UserDTO CheckRepository(IList<UserDTO> UserDTOList);

    }
}
