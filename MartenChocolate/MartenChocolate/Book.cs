namespace MartenChocolate;

public class Book
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public bool IsPopular { get; set; }
    public int Rating { get; set; }
}