namespace c_re_q.HttpCreatorCr
{
    public abstract class BaseRequestCreator
    {
        public HttpClient HttpClient { get; set; }
        public string BaseAddress { get; set; }
        public string UrlPath { get; set; }
        public HttpMethod HttpMethod { get; set; }
    }
}