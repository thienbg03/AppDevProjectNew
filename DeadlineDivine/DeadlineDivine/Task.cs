using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlineDivine
{
    internal class Task
    {
        int id;
        string title;
        DateTime deadline;
        string description;
          
        //Use for creating a task from datbase
        public Task(int id, string title, DateTime deadline, string description)
        {
            this.id = id;
            Title = title;
            Deadline = deadline;
            Description = description;
        }

        //Use for creating a new task
        public Task(string title, DateTime deadline, string description)
        {
            Title = title;
            Deadline = deadline;
            Description = description;
        }

        public int Id { get { return id; } }

        public string Title { get { return title; }
            set {
                if(value.Length == 0)
                {
                    throw new Exception("Title Cannot Be Empty");
                }
                else
                {
                    this.title = value;
                }
            }
        }

        public string Description { get { return description; }
            set
            {
                if(value.Length > 200)
                {
                    throw new Exception("No More Than 200 Words");
                } 
                else
                {
                    this.description = value;
                }
            }        
        }
        public DateTime Deadline {
            get { return deadline; }

            set { 
                if(value < DateTime.Now) {
                    throw new Exception("Cannot Be Before Now");
                }
                else
                {
                    deadline = value;
                }
            
            }
        }
    }
}
