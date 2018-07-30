using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Hello[] menuList = new Hello[5];
            menuList[0] = new Hello ("1. List task");
            menuList[1] = new Hello ("2. Add task");
            menuList[2] = new Hello ("3. Delete tasks");
            menuList[3] = new Hello ("4. Mark task complete");
            menuList[4] = new Hello ("5. Quit");

            

                Console.WriteLine("1. List task");
                Console.WriteLine("2. Add task");
                Console.WriteLine("3. Delete tasks");
                Console.WriteLine("4. Mark task complete");
                Console.WriteLine("4. Mark task complete");

                Console.WriteLine("What would you like to do?");
                int choice = int.Parse (Console.ReadLine());
            if (choice == 2)
            {
                Console.WriteLine("Team Member: Grant");
                Console.WriteLine(" Task Description: Update student workbooks");
                Console.WriteLine("Due Date: 01/15/2018");
                Console.ReadLine();
            }

            Console.WriteLine("What would you like to do?");
            choice = int.Parse (Console.ReadLine());

            if (choice ==1)
            {
                Console.WriteLine("Done       Due Date      Team Member       Description");
                Console.WriteLine(" False     01/15/2018     Grant            Update student workbooks");
                Console.ReadLine();
            }

            Console.WriteLine("1. List task");
            Console.WriteLine("2. Add task");
            Console.WriteLine("3. Delete tasks");
            Console.WriteLine("4. Mark task complete");
            Console.WriteLine("4. Mark task complete");

            Console.WriteLine("What would you like to do?");
            choice = int.Parse(Console.ReadLine());


            if (choice == 5)
            {
                Console.WriteLine("Have a Great Day!");
                Console.ReadLine();
            }

        }
    }
}
