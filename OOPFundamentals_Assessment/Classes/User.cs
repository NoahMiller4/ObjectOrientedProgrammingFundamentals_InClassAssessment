using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace ObjectOrientedProgrammingFundamentals_InClassAssessment.Classes
{
    public class User
    {

        private string _userName;

        // set username to public, but set the value of input of username as private
        public string UserName
        {
            get { return _userName; }
            private set { _userName = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }


        public List<Post> CreatedPosts { get; } = new List<Post>();

        public List<Reaction> Reactions { get; } = new List<Reaction>();

        // regex from https://www.techiedelight.com/check-if-string-contains-only-letters-in-csharp/#:~:text=Using%20Regex.&text=You%20can%20also%20use%20regular,zA%2DZ0%2D9%5D%2B%24%20.
        // method to ensure username length is greater or equal to 3 and less than 20
        // also has regex to ensure username is ASCII characters and numbers only
        public void SetUserName(string username)
        {
            if (username.Length >= 3 && username.Length <= 20 &&
                Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                UserName = username;
            }
            else
            {
                throw new ArgumentException(String.Format("User Name must be 3 to 20 characters, containing only numbers" +
                    " and letters."));
            }
        }
        // method to ensure age is greater than 0, and not negative
        public void SetAge(int age)
        {
            if (age > 0)
            {
                Age = age;
            }
            else
            {
                throw new ArgumentException(String.Format("Age must be a value greater than 0"));
            }
        }


        


        // Constructor to initialize username and age
        public User(string _username, int _age)
        {
            SetUserName(_username);
            SetAge(_age);
        }
    }
}
