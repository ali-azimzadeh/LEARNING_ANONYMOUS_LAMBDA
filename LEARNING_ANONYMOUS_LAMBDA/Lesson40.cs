using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_ANONYMOUS_LAMBDA
{
	/// <summary>
	/// Learning Lambda Expression
	/// </summary>
	class Lesson40
    {
		public static void Main(string[] args)
		{
			// **************************************************
			System.Func<int, int> myDelegate1 = (int x) => { int y = x + 5; return (y); };

			int intResult1 = myDelegate1(10);

			System.Console.WriteLine("Result: {0}", intResult1);
			// **************************************************

			// **************************************************
			System.Func<int, int> myDelegate2 = (int x) => x + 5;

			int intResult2 = myDelegate2(10);

			System.Console.WriteLine("Result: {0}", intResult2);
			// **************************************************

			// **************************************************
			// Note: It's better you remove input data type!
			// Note: You can remove (), if you have just one variable!
			System.Func<int, int> myDelegate3 = x => x + 5;

			int intResult3 = myDelegate3(10);

			System.Console.WriteLine("Result: {0}", intResult3);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
