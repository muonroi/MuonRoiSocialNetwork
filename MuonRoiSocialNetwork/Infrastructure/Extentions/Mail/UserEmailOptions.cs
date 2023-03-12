namespace MuonRoiSocialNetwork.Infrastructure.Extentions.Mail
{
    /// <summary>
    /// Body when send mail
    /// </summary>
    public class UserEmailOptions
    {
        public List<string> ToEmails { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<KeyValuePair<string, string>> PlaceHolders { get; set; }
    }
}
