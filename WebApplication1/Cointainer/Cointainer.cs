// <copyright file="Cointainer.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References.

using Unity;

#endregion References.

namespace CyberIndigoAssignment
{
    public class Cointainer
    {

        /// <summary>
        ///  This method use to create unity container
        /// </summary>
        /// <returns>Returns unity container object</returns>
        public static IUnityContainer GetUnityContainer(IUnityContainer unityContainer = null)
        {
            if (unityContainer == null)
            {
                unityContainer = new UnityContainer();
            }

            // Add unity configuration
            unityContainer.RegisterType<IUser, UserRepository>();
            unityContainer.RegisterType<IBlog, BlogRepository>();
            unityContainer.RegisterType<IBlogTag, BlogTagRepository>();

            unityContainer.RegisterType<IBlogTagManager, BlogTagManager>();
            unityContainer.RegisterType<IBlogManager, BlogManager>();
            unityContainer.RegisterType<IUserManager, UserManager>();

            return unityContainer;
        }

    }
}