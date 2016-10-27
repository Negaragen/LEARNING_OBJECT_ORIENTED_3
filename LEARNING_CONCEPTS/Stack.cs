namespace LEARNING_CSHARP
{
	public class Stack
	{
		public int Index = -1;
		public System.Collections.ArrayList List = new System.Collections.ArrayList();

		public void Push(int data)
		{
			Index++;

			List.Add(data);
		}

		public int Pop()
		{
			if (Index >= 0)
			{
				int intData = (int)List[Index];

				List.RemoveAt(Index);

				Index--;

				return (intData);
			}
			else
			{
				return (-1);
			}
		}
	}
}
