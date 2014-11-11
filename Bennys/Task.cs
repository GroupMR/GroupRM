using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectAssignment
{
    public class Task
    {

        public Task(string description)
        {
            Console.WriteLine("jabababa");
            Console.WriteLine("Terminator");
            // A task has a description and a datetime that contains null when the task isn't finished or the date of when the task is finished 
        }


        public void MarkAsFinished()
        {
            // finishedTimestamp = DateTime.Now;
        }

        public bool ItemFinished()
        {
            // Do some more here
            return false;
        }
    }
}
