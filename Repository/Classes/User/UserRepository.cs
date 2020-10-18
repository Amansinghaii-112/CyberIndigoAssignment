// <copyright file="UserRepository.cs" company=" CyberIndigo Dot net Assignment">
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
    /// This is the class for blog tags detail.
    /// </summary>
    public class UserRepository : IUser
    {

        /// <summary>
        /// This method responsible for add the user details in database.
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        public bool AddRepository(IList<UserDTO> UserDTOList)
        {
            bool result = false;

            IList<UserRecord> UserDTODetailRecords = null;

            try
            {

                UserDTODetailRecords = UserDTOList?.Select(blogRec => new UserRecord()
                {

                   UserName = blogRec.UserName,
                   UserPassword = blogRec.UserPassword,
                   UserEmailId = blogRec.UserEmailID


                }).ToList();

                using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                {

                    context.UserRecords.InsertAllOnSubmit(UserDTODetailRecords);
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
        /// This method responsible for delete the user details in database.
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public bool DeleteRepository(IList<int> Ids)
        {
            bool result = false;

            try
            {

                Ids.ToList().ForEach(id =>
                {
                    UserRecord UserRecordObj = new UserRecord();

                    using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                    {

                        UserRecordObj = context.UserRecords.Where(item => item.Identifier.Equals(id)).FirstOrDefault();

                        context.UserRecords.DeleteOnSubmit(UserRecordObj);
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

        public IList<UserDTO> GetAllRepository()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///This method responsible for get the user details as per id from database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public UserDTO GetByIdRepository(int Id)
        {

            UserDTO UserDTOObj = new UserDTO();

            try
            {

                UserRecord UserRecordObj = new UserRecord();

                using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                {

                    UserRecordObj = context.UserRecords.Where(item => item.Identifier.Equals(Id)).FirstOrDefault();
                }

                UserDTOObj.Identifier = UserRecordObj.Identifier;
                UserDTOObj.UserName = UserRecordObj.UserName;
                UserDTOObj.UserEmailID = UserRecordObj.UserEmailId;
                UserDTOObj.UserPassword = UserRecordObj.UserPassword;
                UserDTOObj.Identifier = UserRecordObj.Identifier;

            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return UserDTOObj;

        }

        public int GetUserDetailCountRepository()
        {
            throw new NotImplementedException();
        }

        public bool UpdateRepository(IList<UserDTO> UserDTOList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is rtesponsible for check user credential from database;
        /// </summary>
        /// <param name="UserDTOList"></param>
        /// <returns></returns>
        public UserDTO CheckRepository(IList<UserDTO> UserDTOList)
        {

            UserDTO UserDTOObj = new UserDTO();

            try
            {

                UserRecord UserRecordObj = new UserRecord();


                UserDTOList.ToList().ForEach(userObj =>
                {

                    using (CyberIndigoDBDataContext context = new CyberIndigoDBDataContext())
                    {

                        UserRecordObj = context.UserRecords.Where(item => item.UserEmailId.Equals(userObj.UserEmailID)).FirstOrDefault();

                    }

                    if (UserRecordObj != null)
                    {

                        UserDTOObj.Identifier = UserRecordObj.Identifier;
                        UserDTOObj.UserName = UserRecordObj.UserName;
                        UserDTOObj.UserPassword = UserRecordObj.UserPassword;
                        UserDTOObj.UserEmailID = UserRecordObj.UserEmailId;

                    }

                });

                return UserDTOObj;
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

    }
}
