namespace c_re_q.Models.HttpCreator
{
    public class GetMethodCreator
    {
        public async Task<string> MakeRequest()
        {
            HttpClient client = new HttpClient();

            var baseUrl = GetBaseAddress();
            var urlPath = "todos";

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{baseUrl}/{urlPath}")
            };

            var httpResponse = client.Send(httpRequestMessage);
            httpResponse.EnsureSuccessStatusCode();

            return await httpResponse.Content.ReadAsStringAsync();
        }

        private string GetBaseAddress()
        {
            return "https://jsonplaceholder.typicode.com";
        }
    }
}
