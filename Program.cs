using c_re_q.HttpCreator;
using System.Linq;

var getMethodCreator = new GetMethodCreator();
var todos = getMethodCreator.GetTodos();
Console.WriteLine(todos.First().title);

System.Console.WriteLine("******************************");

var postMethodCreator = new PostMethodCreator();
var newTodo = postMethodCreator.PostTodo();
System.Console.WriteLine(newTodo.id);
System.Console.WriteLine(newTodo.title);

