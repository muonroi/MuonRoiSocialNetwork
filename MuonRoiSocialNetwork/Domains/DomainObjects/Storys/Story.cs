using BaseConfig.EntityObject.Entity;
using MuonRoi.Social_Network.Categories;
using MuonRoi.Social_Network.Chapters;
using MuonRoi.Social_Network.Tags;
using System.ComponentModel.DataAnnotations;

namespace MuonRoi.Social_Network.Storys
{
    /// <summary>
    /// Table Story
    /// </summary>
    public class Story : Entity
    {
        public Story()
        { }
        public Story(Guid storyGuid, string story_Title, string story_Synopsis,
                        string img_Url,
                        bool isShow)
        {
            Guid = storyGuid;
            Story_Title = story_Title;
            Story_Synopsis = story_Synopsis;
            Img_Url = img_Url;
            IsShow = isShow;
        }
        /// <summary>
        /// Title of story
        /// </summary>
        [Required(ErrorMessage = nameof(EnumStoryErrorCode.ST00))]
        [MaxLength(255, ErrorMessage = nameof(EnumStoryErrorCode.ST01))]
        [MinLength(3, ErrorMessage = nameof(EnumStoryErrorCode.ST02))]
        public string Story_Title { get; set; }
        /// <summary> 
        /// Description of story
        /// </summary>
        [Required(ErrorMessage = nameof(EnumStoryErrorCode.ST03))]
        [MaxLength(5000, ErrorMessage = nameof(EnumStoryErrorCode.ST04))]
        [MinLength(100, ErrorMessage = nameof(EnumStoryErrorCode.ST05))]
        public string Story_Synopsis { get; set; }
        /// <summary>
        /// Url img of story
        /// </summary>
        [Required(ErrorMessage = nameof(EnumStoryErrorCode.ST06))]
        [MaxLength(1000, ErrorMessage = nameof(EnumNotificationStoryErrorCodes.NT01))]
        public string Img_Url { get; set; }
        /// <summary>
        /// Is show ? tru : false
        /// </summary>
        [Required(ErrorMessage = nameof(EnumStoryErrorCode.ST08))]
        public bool IsShow { get; set; }
        /// <summary>
        /// Total view of story
        /// </summary>
        public int TotalView { get; set; }
        /// <summary>
        /// Total like of story
        /// </summary>
        public int TotalFavorite { get; set; }
        /// <summary>
        /// Rating of story
        /// </summary>
        public double Rating { get; set; }
        /// <summary>
        /// Slug of story
        /// </summary>
        [Required(ErrorMessage = nameof(EnumStoryErrorCode.ST00))]
        [MaxLength(255, ErrorMessage = nameof(EnumStoryErrorCode.ST01))]
        [MinLength(3, ErrorMessage = nameof(EnumStoryErrorCode.ST02))]
        public string Slug { get; set; }
        /// <summary>
        /// Foreign key category
        /// </summary>
        public int CategoryId { get; set; }
        public List<Chapter> Chapters { get; set; }
        public Category Category { get; set; }
        public List<StoryNotifications> StoryNotifications { get; set; }
        public List<TagInStory> TagInStory { get; set; }
    }
}
