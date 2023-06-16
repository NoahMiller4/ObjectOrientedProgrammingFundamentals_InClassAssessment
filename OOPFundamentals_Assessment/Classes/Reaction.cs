using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFundamentals_InClassAssessment.Classes
{
    public class Reaction
    {

        public string Type { get; }
        public User Creator { get; }
        public Post Post { get; }

        public Reaction(string type, User creator, Post post)
        {
            if (string.IsNullOrEmpty(type) || (type != "Positive" && type != "Negative"))
            {
                throw new ArgumentException("Please type Positive or Negative (case sensitive).");
            }

            Type = type;
            Creator = creator;
            Post = post;
        }
    }
}
