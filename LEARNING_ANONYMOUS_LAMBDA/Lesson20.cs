using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_ANONYMOUS_LAMBDA
{
	/// <summary>
	/// Learning Anonymous Function - Action & Func & Predicate
	/// </summary>
	class Lesson20
    {
		public static void Main(string[] args)
		{
			// **************************************************
			System.Action myDelegate1 = delegate
			{
				System.Console.WriteLine("Hello, World!");
			};

			myDelegate1();
			// **************************************************

			// **************************************************
			System.Action<string> myDelegate2 = delegate (string text)
			{
				System.Console.WriteLine(text);
			};

			myDelegate2("Hello, World!");
			// **************************************************

			// **************************************************
			System.Func<string, string> myDelegate3 = delegate (string text)
			{
				string strReturnValue = text.ToUpper();

				System.Console.WriteLine(text);

				return (strReturnValue);
			};

			string strResult = myDelegate3("Hello, World!");

			System.Console.WriteLine("Result: {0}", strResult);
			// **************************************************

			// **************************************************
			System.Predicate<string> myDelegate4 = delegate (string text)
			{
				System.Console.WriteLine(text);

				if (string.Compare(text, "Hello, World!", ignoreCase: true) == 0)
				{
					return (true);
				}
				else
				{
					return (false);
				}
			};

			bool blnResult = myDelegate4("Hello, World!");

			System.Console.WriteLine("Result: {0}", blnResult);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
