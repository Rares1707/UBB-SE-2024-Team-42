using System.Drawing;
namespace UBB_SE_2024_Team_42.Domain
{
    public class Badge(long newBadgeID, long newUserID, string newBadgeName, string newBadgeDescription, Image newImage)
    {
        public long BadgeID { get; set; } = newBadgeID;
        public long UserID { get; } = newUserID; //not needed
        public string BadgeName { get; set; } = newBadgeName;
        public string BadgeDescription { get; set; } = newBadgeDescription;
        public Image Image { get; set; } = newImage;

        public override string ToString()
        {
            return $"Badge(badgeID: {BadgeID}, userID: {UserID}, badgeName: {BadgeName}, image: {Image}) \n" + $"badgeDescription: {BadgeDescription} \n";
        }
    }
}
