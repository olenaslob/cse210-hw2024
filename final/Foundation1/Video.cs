public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    public List<Comment> Comments { get; set; }

    public Video() //The Comments property is initialized as a new list in the constructor
    {
        Comments = new List<Comment>();
    }

    public int GetCommentCount() //returns the number of comments
    {
        return Comments.Count; 
    }
}
