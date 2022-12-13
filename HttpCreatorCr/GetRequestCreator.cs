using System.Text.Json;
using c_re_q.Models;

namespace c_re_q.HttpCreatorCr
{
    public class GetRequestCreator<T> : IRequestCreator<T>
    {
        public T MakeRequest()
        {
            HttpClient client = new();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

            var responseMessage = client.GetAsync("todos").Result;
            var jsonString = responseMessage.Content.ReadAsStringAsync().Result;

            var res = JsonSerializer.Deserialize<T>(jsonString);

            return res;
        }
    }
}