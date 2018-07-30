using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Task
    {
        private string name;
        private string description;
        private string dueDate;

        public Task(string name, string description, string dueDate)
        {
            this.name = name;
            this.description = description;
            this.dueDate = dueDate;
        }
        public void Print()
        {
            Console.WriteLine("Team Member: Grant");
            Console.WriteLine(" Task Description: Update student workbooks");
            Console.WriteLine("Due Date: 01/15/2018");
            Console.ReadLine();
        }

        /*public string GetName()
        {
            return name;
        }*/

    }
    class AddTask
    {
        private string name;
        private string description;
        private string dueDate;

        public AddTask(string name, string description, string dueDate)
        {
            this.name = name;
            this.description = description;
            this.dueDate = dueDate;
        }

    }
    class Hello
    {
        

        public string menu1 { get; private set; }
        public string menu2 { get; private set; }
        public string menu3 { get; private set; }
        public string menu4 { get; private set; }
        public string menu5 { get; private set; }

        public Hello(string menu1)
        {
            this.menu1 = menu1;
            this.menu2 = menu2;
            this.menu3 = menu3;
            this.menu4 = menu4;
            this.menu5 = menu5;

        }

        public Hello()
        {
           
        }
    }

}