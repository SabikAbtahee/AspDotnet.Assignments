namespace AspDotnet.Assignments;

public class Magazine : LibraryItem
{
    private int IssueNumber { get; set; }

    public Magazine(int itemId, string title, bool isAvailable, int issueNumber) : base(itemId, title, isAvailable)
    {
        IssueNumber = issueNumber;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"IssueNumber is: {IssueNumber}");
    }
}