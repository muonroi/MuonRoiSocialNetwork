using BaseConfig.EntityObject.Entity;
using MuonRoi.Social_Network.Users;
using System.ComponentModel.DataAnnotations;

namespace MuonRoi.Social_Network.Storys
{
    /// <summary>
    /// Table Notifications
    /// </summary>
    public class StoryNotifications : Entity
    {
        /// <summary>
        /// User guid
        /// </summary>
        public Guid UserGuid { get; set; }
        /// <summary>
        /// Story Guid
        /// </summary>
        public Guid StoryGuid { get; set; }
        /// <summary>
        /// Url''s notifition
        /// </summary>
        [Required(ErrorMessage = nameof(EnumNotificationStoryErrorCodes.NT00))]
        [MaxLength(1000, ErrorMessage = nameof(EnumNotificationStoryErrorCodes.NT01))]
        public string NotifiUrl { get; set; }
        /// <summary>
        /// Title''s notifition
        /// </summary>
        [Required(ErrorMessage = nameof(EnumNotificationStoryErrorCodes.NT02))]
        [MaxLength(200, ErrorMessage = nameof(EnumNotificationStoryErrorCodes.NT03))]
        public string Title { get; set; }
        /// <summary>
        /// Message''s notifition
        /// </summary>
        [Required(ErrorMessage = nameof(EnumNotificationStoryErrorCodes.NT04))]
        [MaxLength(350, ErrorMessage = nameof(EnumNotificationStoryErrorCodes.NT05))]
        public string Message { get; set; }
        /// <summary>
        /// State''s notifition
        /// </summary>
        public EnumStateNotification NotificationSate { get; set; }
        /// <summary>
        /// Check notifition was watched?
        /// </summary>
        public DateTime ReadNotificationDate { get; set; }
        /// <summary>
        /// Url img of story
        /// </summary>
        [Required(ErrorMessage = nameof(EnumStoryErrorCode.ST06))]
        [MaxLength(1000, ErrorMessage = nameof(EnumStoryErrorCode.ST10))]
        public string Img_Url { get; set; }

        public Story Story { get; set; }
        public AppUser UserMember { get; set; }
    }
}
