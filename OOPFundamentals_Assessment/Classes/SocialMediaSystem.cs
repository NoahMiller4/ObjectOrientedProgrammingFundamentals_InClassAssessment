using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFundamentals_InClassAssessment.Classes
{
    static class SocialMediaSystem
    {
        private static int _idCounter = 0;
        private static HashSet<User> _users = new HashSet<User>();
        private static List<Post> _posts = new List<Post>();
        private static List<Reaction> _reactions = new List<Reaction>(); 

        public static void AddUser(User user)
        {
            _users.Add(user);
        }

        public static void AddPost(Post post)
        {
            _posts.Add(post);
        }

        public static void AddReaction(Reaction reaction)
        {
            _reactions.Add(reaction);
        }






        public static int NextID
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }
        }

        public static User CreateUser(string username, int age)
    {
        User newUser = new User(username, age);
        _users.Add(newUser);
        return newUser;
    }

        public static Post CreatePost(string body, User creator)
        {
            Post newPost = new Post(body, creator);
            creator.CreatedPosts.Add(newPost); // Add the post to the creator's list of created posts
            _posts.Add(newPost);
            return newPost;
        }

        public static Reaction CreateReaction(string type, User creator, Post post)
        {
            // Check if the creator has already reacted to the post
            Reaction existingReaction = null;

            foreach (var reaction in creator.Reactions)
            {
                if (reaction.Post == post)
                {
                    existingReaction = reaction;
                    break;
                }
            }

            if (existingReaction != null)
            {
                // If the reaction type is the same, do nothing
                if (existingReaction.Type == type)
                    return null;

                // Switch the reaction type
                existingReaction.Type = type;
                return existingReaction;
            }

            // Create a new reaction
            Reaction newReaction = new Reaction(type, creator, post);
            creator.Reactions.Add(newReaction); // Add the reaction to the creator's list of reactions
            _reactions.Add(newReaction);
            return newReaction;
        }

    }
}
