// <copyright file="UserManager.cs" company=" CyberIndigo Dot net Assignment">
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
    /// Service class for user details.
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {

        public UserController(IUserManager userManager)
        {
            this._userManager = userManager;
        }

        #region Private fileds.

        /// <summary>
        /// Instance of user detail repository.
        /// </summary>
        private IUserManager _userManager;

        #endregion Private fileds.

        [HttpPost]
        [Route("User/Check")]
        public bool Check(IList<UserDTO> UserDtoList)
        {

            bool result = false;

            try
            {

                result = _userManager.CheckManager(UserDtoList);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

        [HttpPost]
        [Route("User/Add")]
        public bool Add(IList<UserDTO> UserDtoList)
        {

            bool result = false;

            try
            {

                result = _userManager.AddManager(UserDtoList);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

    }
}