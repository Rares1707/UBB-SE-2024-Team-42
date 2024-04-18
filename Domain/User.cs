namespace UBB_SE_2024_Team_42.Domain
{
    public class User(long newUserID, string newUserName, List<Notification> newNotificationList, List<Category> newCategoriesModeratedList, List<Vote> newVoteList, List<Badge> newBadgeList)
    {
        public long UserID { get; } = newUserID;
        public string UserName { get; set; } = newUserName;
        public List<Notification> NotificationList { get; set; } = newNotificationList;
        public List<Category> CategoriesModeratedList { get; set; } = newCategoriesModeratedList;
        public List<Vote> VoteList { get; set; } = newVoteList; //not needed
        public List<Badge> BadgeList { get; set; } = newBadgeList;

        private string ToStringNotificationList()
        {
            string result = "";
            foreach (Notification elem in NotificationList)
            {
                result += elem;
            }
            return result;
        }
        private string ToStringCategoryList()
        {
            string result = "";
            foreach (Category elem in CategoriesModeratedList)
            {
                result += elem;
            }
            return result;
        }

        private string ToStringVoteList()
        {
            string result = "";
            foreach (Vote elem in VoteList)
            {
                result += elem;
            }
            return result;
        }

        private string ToStringBadgeList()
        {
            string result = "";
            foreach (Badge elem in BadgeList)
            {
                result += elem;
            }
            return result;
        }

        public override string ToString()
        {
            return $"User(userID: {UserID}, userName: {UserName}) \n" + $"notifications: {ToStringNotificationList()} \n" + $"categoriesModerated: {ToStringCategoryList()} \n" + $"votes: {ToStringVoteList()} \n" + $"badges: {ToStringBadgeList()} \n";
        }
    }
}
