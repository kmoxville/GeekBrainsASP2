
using Newtonsoft.Json;

namespace Lesson1
{
    public class Lesson2
    {
        public static async Task Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            using StreamWriter sw = new StreamWriter("result.txt", false);

            var downloadTasksQuery = Enumerable
                .Range(1, 10)
                .Select((index) => GetPostAsync(httpClient, $"https://jsonplaceholder.typicode.com/posts/{index}"));

            var downloadTasks = downloadTasksQuery.ToList();

            while (downloadTasks.Count > 0)
            {
                var downloadTask = await Task.WhenAny(downloadTasks);
                downloadTasks.Remove(downloadTask);

                Post? post = await downloadTask;

                if (post == null)
                    continue;

                sw.WriteLine(post.UserId);
                sw.WriteLine(post.Id);
                sw.WriteLine(post.Title);
                sw.WriteLine(post.Body);
                sw.WriteLine();
            }
        }

        private static async Task<Post?> GetPostAsync(HttpClient httpClient, string uri)
        {
            string content = await httpClient.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<Post>(content);
        }
    }

    class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public int UserId { get; set; }
    }
}