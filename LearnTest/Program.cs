using System;
using System.Collections;
using System.Reflection.Metadata;

namespace LearnTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int[] array = { 1, 2, 3, 4, 5 };

			int i =0;
			Console.WriteLine(i);

			int max_i = int.MaxValue;
			int min_i = int.MinValue;

			float max_f = float.MaxValue;
			float min_f = float.MinValue;


			// Reference
			string str1 = "C#";
			string str2 = "C#";
			Console.WriteLine(Object.ReferenceEquals(str1,str2));  // True

			Person p = new Person();
			Console.WriteLine(p.Id);

			//var x;  //compile time error
			//x = 100;

			int j;
			j = 100;


			//var i1 = 10, j2 = 20, k3 = 15; // compile-time. var are to be declared on separate lines.
			//Console.WriteLine(k3=i1+j2);

			Console.WriteLine(Convert.ToInt32(('A')));

			IList nums = null;
			//Console.WriteLine(nums[0]);
			Console.WriteLine(nums?[0]);
			Console.WriteLine(nums?[10]);

			Person p2 = new Person() { Id = 3 };

			//Program.test();

			try
			{
				Console.Write(array[10]);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			//catch (IndexOutOfRangeException ex)  // Previous catch catches all!!! Compile	
			//{

			//}

			//try

			//{
			//		int x = 5;
			//		throw new Exception("This my exception...");
			//	}
			//	//catch  //will catch and hide all exceptions
			//	//{
			//	//}

			//	catch (Exception e)
			//	{
			//		Console.WriteLine(e);
			//		//throw; //re-throw current catch exception to parent method. And specify line # in try block where exception was thrown
			//	}
			//	finally
			//	{
			//		// throw; // can't throw current exception, there no exc.
			//		throw new Exception("This exception #2"); // this ok
			//		//return; // cant have return
			//	}

			Point p5;
			//Console.WriteLine(p5.x);  // compileerror: unassigned value


			int i10 = 3;
			//int[] array10 = new int[i10] { 1, 2, 3 }; //compile-error: constant only

			int Sixteen = 0b0001_0000;
			Console.WriteLine(Sixteen);

			Printer prt = new LaserPrinter();
			prt.Install();

			Action doSomething = () => Console.WriteLine("Hello! Action");
			doSomething ();
		}

		//void Predicate<T>(){}

		private int[,] array2 = new int[2, 5];
		private int[][,] array3 = new int[5][,];

		enum colors
		{
			Orange,
			Blue = 0,
			Green = 0
		};
		
		public class Person
		{
			public int Id;
		}

		public class EnumInsideMethode
		{
			public void insidemethod()
			{
				int i = 1;

				//enum myenum {
				//	Green, Orange, Blue
				//}
				

			}
		}

		void test()
		{
			Console.WriteLine("test()");
		}

		struct Point
		{
			public int x;
		}

		class Printer
		{
			public virtual void Install()
			{
				Console.WriteLine("Printer installed");
			}

			public virtual void Print(string text)
			{
				Console.WriteLine("Printing:" + text);
			}
		}

		class LaserPrinter:Printer
		{
			public void Install()  // to use this local implementation u must "override", else it's the Printer.Install() that will supersede.
			{
				Console.WriteLine("Laser printer installed success");
			}
		}

		class ValueProcessor
		{
		}
	}
}
