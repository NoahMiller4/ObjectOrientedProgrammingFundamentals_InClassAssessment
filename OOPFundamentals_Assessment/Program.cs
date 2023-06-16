
// In Class Assesment -> Noah Miller


using ObjectOrientedProgrammingFundamentals_InClassAssessment.Classes;

try
{
    Console.WriteLine("Please enter a username with 3-20 characters using numbers and letters.");
    string username = Console.ReadLine();

    Console.WriteLine("Please enter the user's age:");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter a post from 10-150 characters");
    string content = Console.ReadLine();

    //string type = Console.ReadLine();


    //Reaction reaction = new Reaction(type, Noseby, );
    User user = new User(username, age);
    Post post = new Post(content, user);

    Console.WriteLine();
    // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1 datetime format
    Console.WriteLine($"{user.UserName}: {post.DateOfCreation.ToString("dddd, dd MMMM yyyy HH:mm:ss")} Posted:");
    Console.WriteLine();
    Console.WriteLine($"{content}");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
