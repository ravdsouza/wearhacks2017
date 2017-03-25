using System;

namespace AssemblyCSharp
{
	public class WearHacks
	{
		//public WearHacks (){

		class Task
		{
			private bool isDone = false;
			private string name = "NAME";
			private string description = "description";
			private bool isHighPriority = false;

			public Task() {
				
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

			//}
		}

	}
}


