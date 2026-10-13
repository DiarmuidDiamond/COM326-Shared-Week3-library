using Library;

//Create ne lists that will be used to store books and memebers
List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

//Create and add new Book objects to the list
books.Add(new Book("C# for beginners", "Bill Gates", "1234567"));
books.Add(new Book("Ultimate C#", "Microsoft", "2233445"));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

//Display all items within the Book list
foreach(Book book in books)
{
    book.DisplayInfo();
}

//Display all members with the member list
foreach(Member member in members)
{
    member.DisplayInfo();
}

//Create a dictonary to track book inventory by ISBN
Dictionary<string, int> bookInventory = new Dictionary<string, int>();

//Add our two sample books to the inventory (ISBN, Quantity)
bookInventory.Add("1234567", 5);
bookInventory.Add("2233445", 2);

//Display the inventory of a specific book using its ISBN key
Console.WriteLine($"Copies of 'C# for beginners' in stock: " +
    $"{bookInventory["1234567"]}");

Console.WriteLine("Checking inventory for a misiing book...");

try
{
    //This ISBN does not exist, so it will throw a KeyNotFoundException
    Console.WriteLine(bookInventory["9999999"]);
}
catch (Exception ex)
{
    Console.WriteLine("Error: That ISBN was not found in the inventory" +
        "system.");
}
finally
{
    Console.WriteLine("Inventory check complete.");
}