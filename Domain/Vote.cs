namespace UBB_SE_2024_Team_42.Domain
{
    public class Vote(long newVoteID, int newVoteValue, long newUserIDWhoVoted)
    {
        public long VoteID { get; } = newVoteID;
        public int VoteValue { get; set; } = newVoteValue;
        public long UserIDWhoVoted { get; } = newUserIDWhoVoted;

        public override string ToString()
        {
            return $"Vote(voteID: {VoteID}, voteValue: {VoteValue}, userID: {UserIDWhoVoted}) \n";
        }
    }
}
