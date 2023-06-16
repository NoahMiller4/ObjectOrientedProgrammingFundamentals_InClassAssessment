using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFundamentals_InClassAssessment.Classes
{
    public class Post
    {
        // Properties
        public string Body { get; }

        public DateTime DateOfCreation { get; private set; }
        public User Creator { get; }
        public List<Reaction> Reactions { get; } = new List<Reaction>();

        // Methods
        public void AddReaction(Reaction reaction)
        {
            Reactions.Add(reaction);
        }
        // Constructor to initialize body and creator of post
        public Post(string body, User creator)
        {
            // check if string is null or empty, or if length is greater than 10 or less than 250
            if (string.IsNullOrEmpty(body) || body.Length < 10 || body.Length > 250)
            {
                throw new ArgumentException("Post body must be between 10 and 250 characters.");
            }

            //https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-7.0
            Body = body;
            DateOfCreation = DateTime.Now;
            Creator = creator;
        }
    }
}
