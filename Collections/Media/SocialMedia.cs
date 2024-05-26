
namespace Media
{
    internal class SocialMedia
    {
        public Dictionary<string, List<string>> Friends { get; set; }

        public SocialMedia()
        {
            Friends = new Dictionary<string, List<string>>();
        }

        public void AddFriend(string username, string friend)
        {
            if (Friends.ContainsKey(username))
            {
                Friends[username].Add(friend);
            }
            else
            {
                Friends.Add(username, new List<string> { friend });
            }
        }
        public void RemoveFriend(string username, string friend)
        {
            if (Friends.ContainsKey(username))
            {
                Friends[username].Remove(friend);
            }
            else
            {
                Console.WriteLine("User not found in social media.");
            }
        }
        public List<string> GetAllFriendsByUsername(string username)
        {
            if (Friends.ContainsKey(username))
            {
                return Friends[username];
            }
            else
            {
                Console.WriteLine("User not found in social media.");
                return null;
            }
        }
    }
}
