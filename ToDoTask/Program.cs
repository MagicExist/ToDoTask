using ToDoTask.Classes;

namespace ToDoTask
{
    internal class Program
    {
        enum iconList { AT, CAT, SAD, HAPPY }

        static void Main(string[] args)
        {
            Pages page = new Pages("Exercises",iconList.HAPPY.ToString());

            Console.WriteLine(page.Icon);
        }
    }
}