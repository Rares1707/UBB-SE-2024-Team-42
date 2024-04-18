namespace UBB_SE_2024_Team_42.Domain
{
    public class Post(long newPostID, long newUserID, string newContent, string newPostType, List<Vote> newVoteList, DateTime newDatePosted, DateTime newDateOfLastEdit)
    {
        public long PostID { get; } = newPostID;
        public long UserID { get; } = newUserID;
        public string Content { get; set; } = newContent;
        public DateTime datePosted { get; } = newDatePosted;
        public DateTime dateOfLastEdit { get; set; } = newDateOfLastEdit;
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
            return $"{PostType}(postID: {PostID}, userID: {UserID}, datePosted: {datePosted}, dateOfLastEdit: {dateOfLastEdit}) \n" + $"{Content} \n" + $"votes: {ToStringVoteList()} \n";
        }

        public void AddVote(string newVote)
        {
            Console.WriteLine(1);
        }

    }
}
