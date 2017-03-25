using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AssemblyCSharp
{
	public class WearHacks
	{
		class Task
		{
			private bool isDone;
			private string name;
			private string description;
			private bool isHighPriority;

			Task() {
                isDone = false;
                name = "NAME";
                description = "description";
                isHighPriority = false;
            }
            ~Task() {
                 // class destructor  
            }
			public void changeName(string newName) {
				name = newName;
			}
			public void changeDescription(string newDescription) {
				description = newDescription;
			}
			public bool togglePriority() {
				if (isHighPriority)
					isHighPriority = false;
				else 
					isHighPriority = true;
				return true;
			}
			public bool deleteTask() {
				return true;
			}
			public bool markDone() {
				isDone = true;
				return true;
			}
            public bool markUndone() {
                isDone = false;
                return true;
            }
		}

        class ToDoList
        {
            private Task[] tasks;
            private Task[] imcompleteTasks;
            private Task[] completeTasks;
            private int size;
            private int cap;
            
            ToDoList() {
                cap = 10;
                tasks = new AssemblyCSharp.WearHacks.Task[cap];
                size = 0;
                imcompleteTasks = new Task[cap];
                completeTasks = new Task[cap];
            }
            ToDoList(int capacity)
            {
                cap = capacity;
                tasks = new AssemblyCSharp.WearHacks.Task[cap];
                size = 0;
                imcompleteTasks = new Task[cap];
                completeTasks = new Task[cap];
            }
            ~ToDoList() {
                // delete []tasks;
                tasks = null;
                /// delete []imcompleteTasks;
                imcompleteTasks = null;
                //// delete []completeTasks;
                completeTasks = null;
            }
            public bool moveAllInComplete() {
                if (size == 0) return false;
                for (int i = 0; i < size; i++)
                {
                    tasks[i].markDone();
		    imcompleteTasks[i] = tasks[i];
                }
                return true;
            }
            public bool moveAllComplete() {
                if (size == 0) return false;
                for (int x = 0; x < size; x++)
                {
                    tasks[x].markUndone();
		    completeTasks[x] = tasks[x];
                }
                return true;
            }

        }

	}
}





