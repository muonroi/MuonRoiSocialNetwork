using BaseConfig.EntityObject.Entity;
using System.ComponentModel.DataAnnotations;

namespace MuonRoi.Social_Network.Tags
{
    /// <summary>
    /// Table for Tag
    /// </summary>
    public class Tag : Entity
    {
        /// <summary>
        /// Tag for name
        /// </summary>
        [Required(ErrorMessage = nameof(EnumTagsErrorCode.TT00))]
        [MaxLength(50, ErrorMessage = nameof(EnumTagsErrorCode.TT01))]
        [MinLength(3, ErrorMessage = nameof(EnumTagsErrorCode.TT02))]
        public string TagName { get; set; }
        /// <summary>
        /// Details for tag
        /// </summary>
        [Required(ErrorMessage = nameof(EnumTagsErrorCode.TT03))]
        [MaxLength(500, ErrorMessage = nameof(EnumTagsErrorCode.TT04))]
        public string Details { get; set; }
        public List<TagInStory> TagInStory { get; set; }
    }
}
