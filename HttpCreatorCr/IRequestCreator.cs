using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_re_q.HttpCreatorCr
{
    public interface IRequestCreator<T>
    {
        public T MakeRequest();
    }
}