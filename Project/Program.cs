// See https://aka.ms/new-console-template for more information

using Project;

static void Search()
{
    var search = new Searching(new MockDbContext());

    Console.WriteLine("Search for products");
    Console.Write("Input: ");
    var searchFor = Console.ReadLine();
    Console.WriteLine();

    var results = search.GetStudents(searchFor);

    foreach (var product in results)
    {
        Console.WriteLine(product + "\n");
    }
    Console.WriteLine($"Total amount of product results: {results.Count()}\n");
}

string? input;
do
{
    Search();
    Console.Write("Search again? Type yes or no: ");
    input = Console.ReadLine();
} while (input is "yes" or "y" or "ye" or "yeah");

