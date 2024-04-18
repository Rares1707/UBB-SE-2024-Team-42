using System.Dynamic;

namespace UBB_SE_2024_Team_42.Domain
{
    public class Notification(long newNotficationID, string newText, long newPostID, long BadgeID)
    {
        public long NotificationId { get; } = newNotficationID;
        public string Text { get; set; } = newText;
        public long PostID { get; } = newPostID;
        public long BadgeID {  get; } = BadgeID;

        public override string ToString()
        {
            return $"Notification(notificationID: {NotificationId}, postID: {PostID}, badgeID: {BadgeID}) \n" + $"notificationText: {Text} \n";
        }

    }
}
