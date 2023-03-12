using BaseConfig.EntityObject.Entity;
using MuonRoi.Social_Network.Users;
using MuonRoiSocialNetwork.Domains.DomainObjects.Groups;

namespace MuonRoi.Social_Network.Roles
{
    /// <summary>
    /// Table of group user
    /// </summary>
    public class GroupUserMember : Entity
    {
        /// <summary>
        /// Admin
        /// </summary>
        public EnumManage Manage { get; set; }
        /// <summary>
        /// Staff
        /// </summary>
        public EnumStaff Staff { get; set; }
        /// <summary>
        /// Viewer (Have owned account)
        /// </summary>
        public EnumViewer Viewer { get; set; }
        /// <summary>
        /// Guest (haven't account)
        /// </summary>
        public EnumGuest Guest { get; set; }
        public Guid AppUserKey { get; set; }
        public Guid AppRoleKey { get; set; }

        public AppUser UserMember { get; set; }
        public AppRole AppRole { get; set; }
    }
}
