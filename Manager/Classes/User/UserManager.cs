// <copyright file="UserManager.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This is the interface for user detail manager lavel.
    /// </summary>
    public class UserManager : IUserManager
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public UserManager(IUser user)
        {

            this._user = user;

        }

        #region Private fields.

        /// <summary>
        /// Instance of user detail repository.
        /// </summary>
        private IUser _user;

        #endregion #region Private fields.

        #region Public methods.

        /// <summary>
        /// This method responsible for add the user details in  manager level.
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        public bool AddManager(IList<UserDTO> UserDTOList)
        {

            bool Result = false;

            try
            {

                if (this.PasswordVerification(UserDTOList))
                {

                    Result = _user.AddRepository(UserDTOList);

                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return Result;
        }

        /// <summary>
        /// This method responsible for delete the user details in  manager level.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public bool DeleteManager(IList<int> Ids)
        {

            try
            {
                return _user.DeleteRepository(Ids);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///  This method responsible for get the user details from  manager level.
        /// </summary>
        /// <returns></returns>
        public IList<UserDTO> GetAllManager()
        {
            try
            {
                return _user.GetAllRepository();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///This method responsible for get the user details as per id from  manager level.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public UserDTO GetByIdManager(IList<int> Ids)
        {
            UserDTO UserDTOObj = new UserDTO();

            try
            {
                Ids.ToList().ForEach(id =>
                {

                    UserDTOObj = _user.GetByIdRepository(id);

                });
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return UserDTOObj;
        }

        /// <summary>
        /// This method is responsible for get user count from  manager level.
        /// </summary>
        /// <returns></returns>
        public int GetUserDetailCountManager()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  This method responsible for update the user details in  manager level.
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        public bool UpdateManager(IList<UserDTO> UserDTOList)
        {
            try
            {
                return _user.UpdateRepository(UserDTOList);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// This method is responsible for user lohin data from repository.
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        public bool CheckManager(IList<UserDTO> UserDTOList)
        {

            UserDTO UserDTOObj = new UserDTO();
            bool result = false;

            try
            {

                UserDTOObj = this._user.CheckRepository(UserDTOList);

                UserDTOList.ToList().ForEach(loginObj =>
                {

                    if (UserDTOObj.UserEmailID == loginObj.UserEmailID && UserDTOObj.UserPassword == loginObj.UserPassword)
                    {
                        result = true;
                    }

                });

            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

        #endregion Public methods.


        #region Private methods.

        private bool PasswordVerification(IList<UserDTO> UserDTOList)
        {
            bool result = false;

            UserDTOList.ToList().ForEach(user => {

                if(user.UserPassword == user.ConfirmUserPassword)
                {
                    result = true; 
                }

            });

            return result;
        }

        #endregion Private methods.

    }
}
