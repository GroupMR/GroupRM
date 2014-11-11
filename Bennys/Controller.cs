using System;
using System.Collections.Generic;

namespace ObjectAssignment
{
    public class Controller
    {
        List<ToDoItem> _items;

        public Controller()
        {
            Console.WriteLine("Benny");
            Console.WriteLine("GIRLS!");
            Console.WriteLine("Computer scinencesnsnfsdijgbs");
            // Consider what must be done in this constructor
            _items = new List<ToDoItem>();
        }

        public void AddNewToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            // A to do item contains 
            // a short description
            // a long description
            // a deadline
            // and one or more tasks that each contains a description

            ToDoItem newItem = new ToDoItem(shortDescription, longDescription, itemDeadline, firstTaskDescription );
            _items.Add(newItem);
        }

        /// <summary>
        /// Creates a report on Items
        /// </summary>
        /// <param name="OnlyNotfinished">True = Items that aren't finished</param>
        /// <returns>The report in one string</returns>
        public string GetAllItemReports(bool OnlyNotfinished = false)
        {
            // Do some more here
            return  "Controller.GetAllItemReports()";
        }
    }
}
