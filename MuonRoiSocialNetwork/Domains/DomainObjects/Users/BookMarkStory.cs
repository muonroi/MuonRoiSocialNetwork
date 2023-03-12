using BaseConfig.EntityObject.Entity;
using MuonRoi.Social_Network.Tags;
using System.ComponentModel.DataAnnotations;

namespace MuonRoi.Social_Network.Users
{
    /// <summary>
    /// Table Bookmark
    /// </summary>
    public class BookMarkStory : Entity
    {
        /// <summary>
        /// Story Guid
        /// </summary>
        [Required(ErrorMessage = nameof(EnumTagsErrorCode.TT06))]
        public Guid StoryGuid { get; set; }
        /// <summary>
        /// User Guid
        /// </summary>
        public Guid UserGuid { get; set; }
        /// <summary>
        /// BookmarkDate
        /// </summary>
        public DateTime BookmarkDate { get; set; }
        public AppUser UserMember { get; set; }
    }
}
