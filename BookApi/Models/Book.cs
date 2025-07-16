namespace BookApi.Models;

public class Book
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishedYear { get; set; }
    public string Language { get; set; }
    public string Genre { get; set; }
}