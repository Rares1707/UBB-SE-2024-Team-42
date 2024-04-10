namespace UBB_SE_2024_Team_42.Domain
{
    public class Notification(long newNotficationID, long newUserID, string newText, long newPostID, string newPostType)
    {
        public long NotificationId { get; } = newNotficationID;
        public long UserID { get; } = newUserID;
        public string Text { get; set; } = newText;
        public long PostID { get; } = newPostID;
        public string PostType { get; } = newPostType;

        public override string ToString()
        {
            return $"Notification(notificationID: {NotificationId}, userID: {UserID}, postID: {PostID}, postType: {PostType}) \n" + $"notificationText: {Text} \n";
        }

    }
}
