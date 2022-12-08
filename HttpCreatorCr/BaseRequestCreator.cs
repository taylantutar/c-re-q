namespace c_re_q.HttpCreatorCr
{
    public class BaseRequestCreator
    {
        public string BaseAddress { get; set; }
        public string UrlPath { get; set; }
        public HttpMethod HttpMethod { get; set; } = HttpMethod.Get;
    }
}