namespace AspDotnet.Assignments;

public class LibraryItem
{
    private string Title { get; set; }

    private int ItemId { get; set; }

    private bool IsAvailable { get; set; }

    public LibraryItem(int itemId, string title, bool isAvailable)
    {
        Title = title;
        ItemId = itemId;
        IsAvailable = isAvailable;
    }


    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ItemId: {ItemId} with Title: {Title}");
    }

    public void BorrowItem()
    {
        if (IsAvailable)
        {
            Console.WriteLine($"ItemId: {ItemId} with Title: {Title} is borrowed");
            IsAvailable = false;
        }
        else
        {
            Console.WriteLine($"Sorry ItemId: {ItemId}  not available for borrowing");
        }
    }

    public void MakeAvailable()
    {
        if (!IsAvailable) IsAvailable = true;
    }
}