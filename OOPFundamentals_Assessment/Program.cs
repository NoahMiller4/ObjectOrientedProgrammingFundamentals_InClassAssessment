
// In Class Assesment -> Noah Miller


using ObjectOrientedProgrammingFundamentals_InClassAssessment.Classes;


try
{
    Console.WriteLine("Please enter a username with 3-20 characters using numbers and letters.");
    string username = Console.ReadLine();
    string username2 = "Bill";
    int age2 = 33;

    Console.WriteLine("Please enter the user's age:");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter a post from 10-150 characters");
    string content = Console.ReadLine();

    User user = new User(username, age);
    User user2 = new User(username2, age2);
    Post post = new Post(content, user);
   
    Console.WriteLine();
    // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1 datetime format

    Console.WriteLine($"{user.UserName}: {post.DateOfCreation.ToString("dddd, dd MMMM yyyy HH:mm:ss")} Posted:");
    Console.WriteLine();

    Console.WriteLine($"{content}");
    Console.WriteLine();

    Console.WriteLine("How did you like this post? Please type Positive or Negative (case sensitive).");
    Console.WriteLine();

    string type = Console.ReadLine();
    Console.WriteLine();

    // Create a reaction to the post by the second user
    Reaction reaction = new Reaction(type, user, post);
    

    if (reaction != null)
    {
        Console.WriteLine($"You reacted {reaction.Type}ly to this post.");

        // Change the reaction from negative to positive or vice versa
        if (reaction.Type == "Negative")
            reaction.Type = "Positive";
        else if (reaction.Type == "Positive")
            reaction.Type = "Negative";

        Console.WriteLine($"Well, Bill had the opposite Reaction!\n" +
            $"The reaction has been changed to {reaction.Type}.");
    }
    else
    {
        Console.WriteLine("You have already reacted to this post with the same type.");
    }
}

catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
