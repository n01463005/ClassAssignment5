using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			int inputCount, resultCounter, matchCounter;
			Console.Write("\n\nCount frequency of each element of an array:\n");
			Console.Write("------------------------------------------------\n");
			Console.Write("Input the number of elements to be stored in the array :");
			if (int.TryParse(Console.ReadLine(), out inputCount))
			{
				int[] inArray = new int[inputCount];
				int[] resultArray = new int[inputCount];
				Console.Write("Input {0} elements in the array :\n", inputCount);
				for (int inCounter = 0; inCounter < inputCount; inCounter++)
				{
					Console.Write("element - {0} : ", inCounter);
					if (int.TryParse(Console.ReadLine(), out inArray[inCounter]))
					{
						resultArray[inCounter] = -1;
					}
				}

				for (int inCounter = 0; inCounter < inputCount; inCounter++)
				{
					matchCounter = 1;
					for (resultCounter = inCounter + 1; resultCounter < inputCount; resultCounter++)
					{
						if (inArray[inCounter] == inArray[resultCounter])
						{
							matchCounter++;
							resultArray[resultCounter] = 0;
						}
					}

					if (resultArray[inCounter] != 0)
					{
						resultArray[inCounter] = matchCounter;
					}
				}

				Console.Write("Frequency of all elements of array :");
				for (int i = 0; i < inputCount; i++)
				{
					if (resultArray[i] != 0)
					{
						Console.Write(" {0} occurs {1} times ", inArray[i], resultArray[i]);
					}
				}
			}
			else
			{
				Console.WriteLine("Next time, please enter a valid number :(");
			}

			Console.ReadLine();
		}
    }
}
