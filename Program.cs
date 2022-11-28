using c_re_q.HttpCreator;
using System.Linq;

var getMethodCreator = new GetMethodCreator();

try
{
    var todos = getMethodCreator.GetTodos();

    Console.WriteLine(todos.First().title);
}
catch (HttpRequestException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
