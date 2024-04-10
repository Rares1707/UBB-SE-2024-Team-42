namespace UBB_SE_2024_Team_42.Domain
{
    public class Post(long newPostID, long newUserID, string newContent, DateOnly newDate, bool newEditFlag, string newPostType, List<Vote> newVoteList)
    {
        public long PostID { get; } = newPostID;
        public long UserID { get; } = newUserID;
        public string Content { get; set; } = newContent;
        public DateOnly Date { get; } = newDate;
        public bool EditFlag { get; set; } = newEditFlag;
        public string PostType { get; } = newPostType;
        public List<Vote> VoteList { get; set; } = newVoteList;

        protected string ToStringVoteList()
        {
            string result = "";
            foreach (Vote elem in VoteList)
            {
                result += elem;
            }
            return result;
        }


        public override string ToString()
        {
            return $"{PostType}(postID: {PostID}, userID: {UserID}, date: {Date}, editFlag: {EditFlag}) \n" + $"{Content} \n" + $"votes: {ToStringVoteList()} \n";
        }

        public void AddVote(string newVote)
        {
            Console.WriteLine(1);
        }

    }
}
