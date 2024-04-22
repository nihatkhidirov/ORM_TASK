using ORM_TASK.DAL;
using ORM_TASK.Models;

using DataContext dataContext = new ();
var groups= dataContext.Groups.ToList();
foreach (Group group in groups)
{
    Console.WriteLine(group);
}