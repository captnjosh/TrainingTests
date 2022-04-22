using System;
using System.Text;

namespace ClassLibrary1
{
	public class Class1
	{

		public string MyReverse(string str)
		{
			StringBuilder result = new StringBuilder();
			try
			{
				int l = str.Length;
				for (int i = l-1; i >=0 ; i--)
				{
					result.Append(str[i]);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}

			return result.ToString();
		}

		public string MyReverse2(string str)
		{
			int l = str.Length;
			char[] result = new char[l];

			for (int i = l-1; i >= 0; i--)
			{
				result[i] = str[l - i - 1];
			}

			return new string(result);
		}
	}
}
