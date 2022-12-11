using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_re_q.HttpCreator
{
    public class DeleteMethodCreator
    {
        public void MakeRequest()
        {
            using var httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

            int todoId = 1;

            var responseMessage = httpClient.DeleteAsync($"todos/{todoId}").Result;

            if (responseMessage.IsSuccessStatusCode)
                Console.WriteLine("Delete is successful.");
            else
                Console.WriteLine($"Error: {responseMessage.StatusCode}");
        }
    }
}