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
	class Lesson30
    {
		public static void Main(string[] args)
		{
			// **************************************************
			System.Action myDelegate11 = delegate
			{
				System.Console.WriteLine("Hello, World!");
			};

			myDelegate11();

			System.Action myDelegate12 = () => { System.Console.WriteLine("Hello, World!"); };

			myDelegate12();

			System.Action myDelegate13 = () => System.Console.WriteLine("Hello, World!");

			myDelegate13();
			// **************************************************

			// **************************************************
			System.Action<string> myDelegate21 = delegate (string text)
			{
				System.Console.WriteLine(text);
			};

			myDelegate21("Hello, World!");

			System.Action<string> myDelegate22 = (text) => { System.Console.WriteLine(text); };

			myDelegate22("Hello, World!");

			System.Action<string> myDelegate23 = (text) => System.Console.WriteLine(text);

			myDelegate23("Hello, World!");
			// **************************************************

			// **************************************************
			System.Func<string, string> myDelegate31 = delegate (string text)
			{
				string strReturnValue = text.ToUpper();

				System.Console.WriteLine(text);

				return (strReturnValue);
			};

			string strResult31 = myDelegate31("Hello, World!");

			System.Console.WriteLine("Result: {0}", strResult31);

			System.Func<string, string> myDelegate32 = (text) =>
			{
				string strReturnValue = text.ToUpper();

				System.Console.WriteLine(text);

				return (strReturnValue);
			};

			string strResult32 = myDelegate31("Hello, World!");

			System.Console.WriteLine("Result: {0}", strResult32);
			// **************************************************

			// **************************************************
			System.Predicate<string> myDelegate41 = delegate (string text)
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

			bool blnResult41 = myDelegate41("Hello, World!");

			System.Console.WriteLine("Result: {0}", blnResult41);

			System.Predicate<string> myDelegate42 = (text) =>
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

			bool blnResult42 = myDelegate42("Hello, World!");

			System.Console.WriteLine("Result: {0}", blnResult42);
			// **************************************************

			System.Action s = () =>
			{
				int x = 0;
				x++;
			};

			s();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
