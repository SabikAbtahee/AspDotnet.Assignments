namespace AspDotnet.Assignments;

internal class Program
{
    private static void Main()
    {
        LibraryItem[] items =
        [
            new Book(1, "Red Dead Redemption", true, "Arthur Morgan"),
            new Book(2, "Arc Raiders", true, "John Marsten"),
            new Magazine(3, "Times", true, 333),
            new LibraryItem(4, "Library Internal Book", false)
        ];

        foreach (var item in items)
        {
            item.DisplayInfo();
        }

        items[0].BorrowItem(); // borrowed
        items[0].BorrowItem(); // cant borrow anymore

        items[0].MakeAvailable(); // make item available again
        items[0].BorrowItem(); // should be able to borrow again

        items[1].BorrowItem();
        items[2].BorrowItem();
        items[3].BorrowItem();

    }
}