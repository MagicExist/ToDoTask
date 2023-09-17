using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTask.Classes
{
    internal class Task
    {
        private string name;
        private string description;
        private string creationDate;
        private string endDate;

        protected string Name { get => name; set => name = value; }
        protected string Description { get => description; set => description = value; }
        protected string CreationDate { get => creationDate; set => creationDate = value; }
        protected string EndDate { get => endDate; set => endDate = value; }

        public Task(string name, string description, string creationDate, string endDate)
        {
            this.name = name;
            this.description = description;
            this.creationDate = creationDate;
            this.endDate = endDate;
        }
    }
}
