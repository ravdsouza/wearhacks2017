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
            public string getName() {
                return name;
            }
			public void changeName(string newName) {
				name = newName;
			}
			public void changeDescription(string newDescription) {
				description = newDescription;
			}
            public bool setPriority(bool isHigh) {
				isHighPriority = isHigh;
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
            public bool checkDone() { 
                return isDone;
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
            public int numCompleted() {
                int counter = 0;
                for (int i = 0; i < size; i++)
                {
                    if (tasks[i].checkDone())
                        counter++;
                    return counter;
                }
                return 0;
            }
            public int numIncomplete() {
                return (size - numCompleted());
            }
            public bool addTask(string tName, string tDes, bool highPri) {
                if (size >= cap)
                    return false;
                tasks[size].changeDescription(tDes);
                tasks[size].changeName(tName);
                tasks[size].setPriority(highPri);
                imcompleteTasks[numIncomplete()] = tasks[size];
                size++;
                return true;
            }
            public bool deleteTask(string name1) {
                if (size == 0) return false;
                int index = 0;
                for (int w = 0; w < size; w++)
                {
                    if (tasks[w].getName().Equals(name1))
                        index = w;
                }
                if (index == (size - 1))
                    size--;
                if (index < size - 1)
                {
                    for (int q = 0; q < size-1; q++)
                    {
                        tasks[index] = tasks[index + 1];
                        size--;
                    }
                }
                return true;
            }

        }

	}
}