using System.Text.Json;

namespace c_re_q.HttpCreatorCr
{
    public class GetRequestCreator<T> : BaseRequestCreator where T : class
    {
        public  List<T> MakeRequest()
        {
            HttpClient client = new();
            client.BaseAddress = new Uri(base.BaseAddress);

            var responseMessage = client.GetAsync(base.UrlPath).Result;
            var jsonString = responseMessage.Content.ReadAsStringAsync().Result;

            var res = JsonSerializer.Deserialize<List<T>>(jsonString);

            return res;

        }
    }
}