using System.Text;
using System.Text.Json;

namespace c_re_q.HttpCreatorCr
{
    public class PostRequestCreator<T> : BaseRequestCreator where T : class
    {
        public object Data { get; set; }

        public PostRequestCreator(object Data)
        {
            this.Data = Data;
        }

        public T MakeRequest()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(base.BaseAddress);

            var jsonData = JsonSerializer.Serialize(Data);
            var stringData = new StringContent(jsonData, encoding: Encoding.UTF8, mediaType: "application/json");

            var responseMessage = client.PostAsync(base.UrlPath, stringData).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var res = responseMessage.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<T>(res);
            }
            return null;
        }
    }
}