using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_ANONYMOUS_LAMBDA
{
	public delegate string MyDelegate(string text);
	public delegate void MyDelegate1();
	public delegate void MyDelegate2(string text);
	public delegate string MyDelegate3(string text);

	/// <summary>
	/// Learning Anonymous Function/Method
	/// </summary>
	public static class Lesson10
	{
		public static void Main(string[] args)
		{
			string strResult;

			// **************************************************

			MyDelegate myDelegate = SomeFunction1;

			strResult =
				myDelegate.Invoke("Hello, World (1)!");

			System.Console.WriteLine("Result: {0}", strResult);

			// **************************************************

			MyDelegate1 myDelegate1 = delegate
			{
				System.Console.WriteLine("Hello, World!");
			};

			myDelegate1();
			// **************************************************

			// **************************************************

			MyDelegate2 myDelegate2 = delegate (string text)
			{
				System.Console.WriteLine(text);
			};

			myDelegate2("Hello, World!");
			// **************************************************

			// **************************************************
			MyDelegate3 myDelegate3 = delegate (string text)
			{
				string strReturnValue = text.ToUpper();

				System.Console.WriteLine(text);

				return (strReturnValue);
			};

			strResult = myDelegate3("Hello, World!");

			System.Console.WriteLine("Result: {0}", strResult);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}

		public static string SomeFunction1(string text)
		{
			string strResult =
				string.Format("Some Function (1): {0}", text);

			System.Console.WriteLine(strResult);

			return (strResult);
		}

	}

}
