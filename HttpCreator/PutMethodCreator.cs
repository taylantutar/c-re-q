using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using c_re_q.Models;

namespace c_re_q.HttpCreator
{
    public class PutMethodCreator
    {
        public void MakeRequest()
        {
            using var httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

            var todo = new Todo()
            {
                userId = 1,
                id = 1,
                title = "deneme",
                completed = false
            };

            var serializeProduct = JsonSerializer.Serialize(todo);

            var stringMessage = new StringContent(serializeProduct, Encoding.UTF8, "application/json");

            var responseMessage = httpClient.PutAsync("todos/1", stringMessage).Result;

            if (responseMessage.IsSuccessStatusCode)
                Console.WriteLine("Success");
            else
                Console.WriteLine($"Error: {responseMessage.StatusCode}");
        }
    }
}