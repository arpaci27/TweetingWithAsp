using Newtonsoft.Json;

namespace TweetingWithAsp.Model
{
	public class PostTweetRequestDto
	{
		[JsonProperty("text")]
		public string Text { get; set; } = string.Empty;

    }
}
