// <copyright file="IUserManager.cs" company=" CyberIndigo Dot net Assignment">
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
    public interface IUserManager
    {

        /// <summary>
        /// This method responsible for add the user details in  manager level.
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        bool AddManager(IList<UserDTO> UserDTOList);

        /// <summary>
        ///  This method responsible for update the user details in  manager level.
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        bool UpdateManager(IList<UserDTO> UserDTOList);

        /// <summary>
        /// This method responsible for delete the user details in  manager level.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        bool DeleteManager(IList<int> Ids);

        /// <summary>
        ///  This method responsible for get the user details from  manager level.
        /// </summary>
        /// <returns></returns>
        IList<UserDTO> GetAllManager();

        /// <summary>
        ///This method responsible for get the user details as per id from  manager level.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        UserDTO GetByIdManager(IList<int> Ids);

        /// <summary>
        /// This method is responsible for get user count from  manager level.
        /// </summary>
        /// <returns></returns>
        int GetUserDetailCountManager();

        /// <summary>
        /// This method is rtesponsible for check user credential from database;
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        bool CheckManager(IList<UserDTO> UserDTOList);

    }
}
