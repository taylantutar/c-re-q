using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using c_re_q.Models.Core;

namespace c_re_q.HttpCreatorCr
{
    public class RequestCreator
    {
        public BaseRequestCreator BaseRequestCreator { get; set; }
        public RequestCreator(Action<HttpClientModel> action)
        {
            HttpClientModel model = new();
            action.Invoke(model);

            BaseRequestCreator = new BaseRequestCreator
            {
                BaseAddress = model.BaseAddress,
                HttpMethod = model.HttpMethod,
                UrlPath = model.UrlPath
            };
        }

        public void Create()
        {

        }
    }
}