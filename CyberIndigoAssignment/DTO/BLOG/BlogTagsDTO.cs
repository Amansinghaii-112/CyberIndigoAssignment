// <copyright file="BlogTags.cs" company=" CyberIndigo Dot net Assignment">
//<Author> Aman Singhai </Author>
// </copyright>
//-----------------------------------------------------------------------

#region References.

using System.ComponentModel;

#endregion References.

namespace CyberIndigoAssignment
{

    /// <summary>
    /// This class represent DTO for blog tags details.
    /// </summary>
    public class BlogTagsDTO
    {

        #region Private fields.

        /// <summary>
        /// The tag Id.
        /// </summary>
        private int identifier = default;

        /// <summary>
        /// The tag name.
        /// </summary>
        private string tagName = default;

        #endregion Private fields.

        #region Public Properties.

        /// <summary>
        /// The tag Id.
        /// </summary>
        [Description("Identifier")]
        public int Identifier { get => identifier; set => identifier = value; }

        /// <summary>
        /// The tag name.
        /// </summary>
        [Description("Tag Name")]
        public string TagName { get => tagName; set => tagName = value; }

        #endregion Public Properties.

    }
}
