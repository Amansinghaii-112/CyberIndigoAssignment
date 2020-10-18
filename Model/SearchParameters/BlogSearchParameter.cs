// <copyright file="BlogSearchParameter.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References.

using System.ComponentModel;

#endregion References.

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This class represent SearchParameter for blog details.
    /// </summary>
    public class BlogSearchParameter
    {


        #region Private fields.

        /// <summary>
        /// The blog Id.
        /// </summary>
        private int identifier = default;

        /// <summary>
        /// The blog title.
        /// </summary>
        private string title = default;

        /// <summary>
        /// The blog sub title.
        /// </summary>
        private string subTitle = default;

        /// <summary>
        /// The blog tags.
        /// </summary>
        private int? tags = default;

        /// <summary>
        /// The blog's owner email Id.
        /// </summary>
        private string ownerEmailID = default;

        #endregion Private fields.

        #region Public Properties.

        /// <summary>
        /// The blog Id.
        /// </summary>
        [Description("Identifier")]
        public int Identifier { get => identifier; set => identifier = value; }

        /// <summary>
        /// The blog title.
        /// </summary>
        [Description("Title")]
        public string Title { get => title; set => title = value; }

        /// <summary>
        /// The blog sub title.
        /// </summary>
        [Description("Sub Title")]
        public string SubTitle { get => subTitle; set => subTitle = value; }

        /// <summary>
        /// The blog tags.
        /// </summary>
        [Description("Tags")]
        public int? Tags { get => tags; set => tags = value; }

        /// <summary>
        /// The blog's owner email Id.
        /// </summary>
        public string OwnerEmailID { get => ownerEmailID; set => ownerEmailID = value; }

        #endregion Public Properties.

    }
}
