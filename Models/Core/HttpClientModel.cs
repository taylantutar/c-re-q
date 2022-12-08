using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_re_q.Models.Core
{
    public class HttpClientModel
    {
        public string BaseAddress { get; set; }
        public string UrlPath { get; set; }
        public HttpMethod HttpMethod { get; set; }
    }
}