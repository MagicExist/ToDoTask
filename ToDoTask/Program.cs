using ToDoTask.Classes;

namespace ToDoTask
{
    internal class Program
    {
        enum iconList { AT, CAT, SAD, HAPPY }

        static void Menu(List<string> options) 
        {
            for (int i = 0; i < options.Count; i++) 
            {
                Console.WriteLine($"{i + 1}.{options[i]}");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}