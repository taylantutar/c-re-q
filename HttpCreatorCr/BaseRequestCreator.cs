namespace c_re_q.HttpCreatorCr
{
    public abstract class BaseRequestCreator<T> where T : class
    {
        public HttpClient HttpClient { get; set; }
        public string BaseAddress { get; set; }
        public string UrlPath { get; set; }

        public abstract T MakeRequest();
    }
}