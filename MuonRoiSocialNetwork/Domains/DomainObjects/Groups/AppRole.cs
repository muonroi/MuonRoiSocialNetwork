using MuonRoi.Social_Network.Roles;
using Microsoft.AspNetCore.Identity;

namespace MuonRoiSocialNetwork.Domains.DomainObjects.Groups
{
    public class AppRole : IdentityRole<Guid>
    {
        public string? Description { get; set; }
        public List<GroupUserMember> GroupUserMember { get; set; }
    }
}
