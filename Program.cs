using c_re_q.Models.HttpCreator;
using System;

var getMethodCreator = new GetMethodCreator();

try
{
    var res = await getMethodCreator.MakeRequest();

    Console.WriteLine(res);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
