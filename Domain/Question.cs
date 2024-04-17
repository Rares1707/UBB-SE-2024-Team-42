namespace UBB_SE_2024_Team_42.Domain
{
    //Tags???
    public class Question(long newPostID, long newUserID, string newTitle, string newCategory, string newContent, DateOnly newDate, bool newEditFlag, string newPostType, List<Vote> newVoteList) : Post(newPostID, newUserID, newContent, newDate, newEditFlag, newPostType, newVoteList)
    {
        public string Title { get; set; } = newTitle;
        public string Category { get; } = newCategory;

        public override string ToString()
        {
            return $"Question(postID: {PostID}, userID: {UserID}, title:{Title} , category: {Category}, date: {Date}, editFlag: {EditFlag}, postType: {PostType}) \n" + $"{Content} \n" + $"votes: {ToStringVoteList()} \n";
        }
    }

}
