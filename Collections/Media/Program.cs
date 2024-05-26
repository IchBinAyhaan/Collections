namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialMedia socialMedia = new SocialMedia();
            socialMedia.AddFriend("user1", "friend1");
            socialMedia.AddFriend("user1", "friend2");
            socialMedia.AddFriend("user2", "friend3");
            socialMedia.AddFriend("user3", "friend1");

            Console.WriteLine("User1's Friends:");
            PrintFriends(socialMedia.GetAllFriendsByUsername("user1"));
            Console.WriteLine("User2's Friends:");
            PrintFriends(socialMedia.GetAllFriendsByUsername("user2"));
            Console.WriteLine("User3's Friends:");
            PrintFriends(socialMedia.GetAllFriendsByUsername("user3"));
            socialMedia.RemoveFriend("user1", "friend1");
            Console.WriteLine("User1's Updated Friends:");
            PrintFriends(socialMedia.GetAllFriendsByUsername("user1"));
        }

        static void PrintFriends(List<string> friends)
        {
            if (friends != null)
            {
                foreach (var friend in friends)
                {
                    Console.WriteLine(friend);
                }
            }
            else
            {
                Console.WriteLine("User not found in social media.");
            }
        }
    }
}