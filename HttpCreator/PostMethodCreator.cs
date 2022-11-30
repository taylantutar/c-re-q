using System.Text.Json;
using c_re_q.Models;

namespace c_re_q.HttpCreator
{
    public class PostMethodCreator
    {
        public PostMethodCreator()
        {

        }

        public Task<string> MakeRequest()
        {
            HttpClient client = new HttpClient();

            var baseUrl = GetBaseAddress();
            var urlPath = "todos";

            var msg = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{baseUrl}/{urlPath}")
            };

            var todo = GetBodyObject();

            if (todo != null)
            {
                msg.Content = new StringContent(JsonSerializer.Serialize(todo));
            }

            var httpResponse = client.Send(msg);

            var result = httpResponse.Content.ReadAsStringAsync();
            return result;

        }


        private string GetBaseAddress()
        {
            return "https://jsonplaceholder.typicode.com";
        }

        private Todo GetBodyObject()
        {

            return new Todo
            {
                title = "deneme1",
                completed = false,
                userId = 1
            };
        }

        public Todo PostTodo()
        {
            var content = this.MakeRequest().GetAwaiter().GetResult();
            return JsonSerializer.Deserialize<Todo>(content);
        }
    }
}
