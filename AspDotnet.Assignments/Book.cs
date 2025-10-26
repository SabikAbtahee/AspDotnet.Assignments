namespace AspDotnet.Assignments;

public class Book : LibraryItem
{
    private string Author { get; set; }


    public Book(int itemId, string title, bool isAvailable, string author)
        : base(itemId, title, isAvailable)
    {
        Author = author;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author is: {Author}");
    }
}