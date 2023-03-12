using BaseConfig.EntityObject.Entity;
using MuonRoi.Social_Network.Storys;
using System.ComponentModel.DataAnnotations;

namespace MuonRoi.Social_Network.Categories
{
    /// <summary>
    /// Category Table
    /// </summary>
    public class Category : Entity
    {
        /// <summary>
        /// Name of category
        /// </summary>
        [Required(ErrorMessage = nameof(EnumCategoriesErrorCode.CTS01))]
        public string? NameCategory { get; set; }
        /// <summary>
        /// Status category
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Storys of category
        /// </summary>
        public List<Story>? Storys { get; set; }
    }
}
