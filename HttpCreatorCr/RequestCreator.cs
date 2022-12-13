using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using c_re_q.Models.Core;

namespace c_re_q.HttpCreatorCr
{
    public class RequestCreator
    {
        public HttpClientModel HttpClientModel { get; set; } = new();

        public RequestCreator Configure(Action<HttpClientModel> action)
        {
            HttpClientModel model = new();
            action.Invoke(model);

            return this;
        }
    }
}