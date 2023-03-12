using BaseConfig.EntityObject.Entity;
using MuonRoi.Social_Network.Tags;
using System.ComponentModel.DataAnnotations;

namespace MuonRoi.Social_Network.Users
{
    /// <summary>
    /// Table follow
    /// </summary>
    public class FollowingAuthor : Entity
    {
        /// <summary>
        /// UserGuid
        /// </summary>
        public Guid UserGuid { get; set; }
        /// <summary>
        /// StoryGuid
        /// </summary>
        [Required(ErrorMessage = nameof(EnumTagsErrorCode.TT05))]
        public Guid StoryGuid { get; set; }
        public AppUser UserMember { get; set; }
    }
}
