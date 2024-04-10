namespace UBB_SE_2024_Team_42.Domain
{
    public class Tag(long newTagId, long newQuestionID, string newTagName)
    {
        public long TagID { get; } = newTagId;
        public long QuestionID { get; } = newQuestionID;
        public string TagName { get; set; } = newTagName;

        public override string ToString()
        {
            return $"Tag(tagID: {TagID}, postID: {QuestionID}, tagName: {TagName}) \n";
        }
    }
}
