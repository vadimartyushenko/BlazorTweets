namespace BlazorServerApp.Data;

public class Store
{
    public IList<Tweet> Tweets { get; set; } = new List<Tweet>
    {
        new Tweet
        {
            Content = "One from backend"
        }
    };

    public void Add(Tweet tweet) => Tweets.Add(tweet);
    public class Tweet
    {
        public string Content { get; set; }
    }
}