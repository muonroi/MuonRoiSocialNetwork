using BaseConfig.EntityObject.Entity;
using MuonRoi.Social_Network.Tags;
using MuonRoi.Social_Network.Users;
using System.ComponentModel.DataAnnotations;

namespace MuonRoi.Social_Network.Storys
{
    /// <summary>
    /// Table StoryPublished
    /// </summary>
    public class StoryPublish : Entity
    {
        /// <summary>
        /// Guid story
        /// </summary>
        [Required(ErrorMessage = nameof(EnumTagsErrorCode.TT06))]
        public Guid StoryGuid { get; set; }
        /// <summary>
        /// Guid User
        /// </summary>
        public Guid UserGuid { get; set; }
        public AppUser UserMember { get; set; }

    }
}
