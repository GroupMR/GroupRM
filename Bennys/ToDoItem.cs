using System;
using System.Collections.Generic;

// Description on this class => look at Controller for inspiration

namespace ObjectAssignment
{
    public class ToDoItem
    {
        List<Task> tasks;

        public ToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            tasks = new List<Task>();
            //this.shortDecription = shortDescription;
            //this.longDescription = longDescription;
            //this.itemDeadline = itemDeadline;
            AddTask(firstTaskDescription);

        }

        public void AddTask(string TaskDescription)
        {
            //TaskDescription = shortDescription + longDescription; 
        }

        public bool ItemFinished()
        {
            // Do some more here
            return false;
        }

        public bool DeadlineExceeded()
        {
            // Do some more here
            return false;
        }

        public string GetItemReport()
        {
            return "ToDoItem.GetItemReport()";
        }
    }
}
