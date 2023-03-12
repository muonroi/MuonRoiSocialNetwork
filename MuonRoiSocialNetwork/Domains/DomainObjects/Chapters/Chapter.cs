using BaseConfig.EntityObject.Entity;
using MuonRoi.Social_Network.Storys;
using System.ComponentModel.DataAnnotations;

namespace MuonRoi.Social_Network.Chapters
{
    /// <summary>
    /// Table Chapter
    /// </summary>
    public class Chapter : Entity
    {
        public Chapter()
        { }
        public Chapter(int id, string chapterTitle, string body, string numberOfChapter, int numberCharacter)
        {
            Id = id;
            ChapterTitle = chapterTitle;
            Body = body;
            NumberOfChapter = numberOfChapter;
            NumberCharacter = numberCharacter;
        }
        /// <summary>
        /// Title
        /// </summary>
        [Required(ErrorMessage = nameof(EnumChapterErrorCode.CT00))]
        [MaxLength(255, ErrorMessage = nameof(EnumChapterErrorCode.CT01))]
        [MinLength(3, ErrorMessage = nameof(EnumChapterErrorCode.CT02))]
        public string ChapterTitle { get; set; }
        /// <summary>
        /// Content of story
        /// </summary>
        [Required(ErrorMessage = nameof(EnumChapterErrorCode.CT04))]
        [MaxLength(100000, ErrorMessage = nameof(EnumChapterErrorCode.CT05))]
        [MinLength(750, ErrorMessage = nameof(EnumChapterErrorCode.CT06))]
        public string Body { get; set; }

        /// <summary>
        /// Number of each the chapter
        /// </summary>
        [Required(ErrorMessage = nameof(EnumChapterErrorCode.CT07))]
        [MaxLength(200, ErrorMessage = nameof(EnumChapterErrorCode.CT08))]

        public string NumberOfChapter { get; set; }

        /// <summary>
        /// Sum character in chapter
        /// </summary>

        [Required(ErrorMessage = nameof(EnumChapterErrorCode.CT09))]
        public int NumberCharacter { get; set; }

        [Required(ErrorMessage = nameof(EnumChapterErrorCode.CT09))]
        public Guid StoryGuid { get; set; }
        /// <summary>
        /// Slug of chapter
        /// </summary>
        [Required(ErrorMessage = nameof(EnumChapterErrorCode.CT10))]
        public string Slug { get; set; }

        public Story Story { get; set; }
    }
}
