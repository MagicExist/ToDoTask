using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTask.Classes
{
    internal class Pages
    {
        private string name;
        private string icon;
        private List<Task> tasksList;


        public string Name { get => name; set => name = value; }
        public string Icon { get => icon; set => icon = value; }

        public Pages(string name, string icon)
        {
            this.name = name;
            this.icon = icon;
        }
    }
}
