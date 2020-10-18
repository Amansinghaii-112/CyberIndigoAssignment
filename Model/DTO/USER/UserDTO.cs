// <copyright file="UserDTO.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References.

using System.ComponentModel;

#endregion References.

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This class represent DTO for user's details.
    /// </summary>
    public class UserDTO
    {

        #region Private fields.

        /// <summary>
        /// The user Id.
        /// </summary>
        private int identifier = default;

        /// <summary>
        /// The user name.
        /// </summary>
        private string userName = default;

        /// <summary>
        /// The user email id.
        /// </summary>
        private string userEmailID = default;

        /// <summary>
        /// The user password.
        /// </summary>
        private string userPassword = default;

        /// <summary>
        /// The confirm user password.
        /// </summary>
        private string confirmUserPassword = default;

        #endregion Private fields.

        #region Public Properties.

        /// <summary>
        /// The user Id.
        /// </summary>
        [Description("Identifier")]
        public int Identifier { get => identifier; set => identifier = value; }

        /// <summary>
        /// The user name.
        /// </summary>
        [Description("User Name")]
        public string UserName { get => userName; set => userName = value; }

        /// <summary>
        /// The user password.
        /// </summary>
        [Description("User Password")]
        public string UserPassword { get => userPassword; set => userPassword = value; }

        /// <summary>
        /// The confirm user password.
        /// </summary>
        [Description("Confirm User Password")]
        public string ConfirmUserPassword { get => confirmUserPassword; set => confirmUserPassword = value; }

        /// <summary>
        /// The user email id.
        /// </summary>
        [Description("User Email Id")]
        public string UserEmailID { get => userEmailID; set => userEmailID = value; }

        #endregion Public Properties.

    }
}
