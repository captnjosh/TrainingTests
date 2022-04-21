using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTasks
{
	internal class Program
	{
		public static Task NoAsync()
		{
			return Task.Run(() => Console.WriteLine("no async"));
		}

		private static async Task Main(string[] args)
		{
			Console.WriteLine(test.one);

			await AsycBreakfast.AsycAwait();

			await NoAsync();
			return;

			//Solution1 test = new Solution1();
			//Console.WriteLine(test.solution1(1041));
			//Console.WriteLine(test.solution1(15));
			//Console.WriteLine(test.solution1(32));
			//Console.WriteLine(test.solution1(2147483647));
			//Console.WriteLine(test.solution1(20));

			//Solution2 test = new Solution2();
			//Console.WriteLine(test.solution2(1073741727, 1073741631, 1073741679));

			//Solution test = new Solution();
			//Console.WriteLine(test.solution(2, new int[] { 3, 5 }));
			//Console.WriteLine(test.solution(2, new int[] { 3,5,7,6,3 }));


			//Solution test = new Solution();
			//Console.WriteLine(test.solution("10:00", "10:21"));
			//Console.WriteLine(test.solution("10:00", "13:21"));
			//Console.WriteLine(test.solution("09:42", "11:42"));

			//Solution test = new Solution();
			//Console.WriteLine(test.solution(24));
			//Console.WriteLine(test.solution(25));

			//Solution test = new Solution();
			//Console.WriteLine(test.solution(5, 3));
			//Console.WriteLine(test.solution(3, 3));
			//Console.WriteLine(test.solution(1, 4));
			//Console.WriteLine(test.solution(1, 5));
			//Console.WriteLine(test.solution(2, 7));

			//Solution test = new Solution();
			//Console.WriteLine("'" + test.solution("Codility We Test coders", 14) + "'");
			//Console.WriteLine("'" + test.solution("Why Not", 100) + "'");
			//Console.WriteLine("'" + test.solution("The quick brown fox.", 20) + "'");
			//Console.WriteLine("'" + test.solution("To crop or not to crop", 21) + "'");

			//Solution test = new Solution();
			//Console.WriteLine(test.solution( new int[] {1,4,1}, new int[]{1,5,1}));
			//Console.WriteLine(test.solution( new int[] {4,4,2,4}, new int[]{5,5,2,5}));
			//Console.WriteLine(test.solution( new int[] {2,3,4,2}, new int[]{2,5,7,2}));


			//Solution test = new Solution();
			//Console.WriteLine(test.solution( new int[] {5,19,8,1}));
			//Console.WriteLine(test.solution( new int[] {10,10}));
			//Console.WriteLine(test.solution( new int[] {3,0,5}));

			//Solution test = new Solution();
			//int a = 100;
			//int b = 55;
			//test.SwapTwoNumbers(ref a, ref b);
			//Console.WriteLine(a);
			//Console.WriteLine(b);

			//Console.WriteLine(test.IfYearIsLeap(2022));

			//Console.WriteLine("IfNumberContains3");
			//Console.WriteLine(test.IfNumberContains3(2022));
			//Console.WriteLine(test.IfNumberContains3(2093));
			//Console.WriteLine(test.IfNumberContains3(2032));
			//Console.WriteLine(test.IfNumberContains3(2392));
			//Console.WriteLine(test.IfNumberContains3(3092));

			//Console.WriteLine("CheckBracketsSequence");
			//Console.WriteLine(test.CheckBracketsSequence("((()))"));
			//Console.WriteLine(test.CheckBracketsSequence("(()))"));
			//Console.WriteLine(test.CheckBracketsSequence("()(())("));
			//Console.WriteLine(test.CheckBracketsSequence(")"));


			//DecksOfCard t = new DecksOfCard();
			//string[] data = new string[]
			//	{ "9C", "KS", "AC", "AH", "8D", "4C", "KD", "JC", "7D", "9D", "2H", "7C", "3C", "7S", "5C", "6H", "TH" };
			//t.decksOfCards(data);

			// Wait on a single task with a timeout specified.
			Task taskA = Task.Run( () => Thread.Sleep(2000));
			try {
				taskA.Wait(1000);       // Wait for 1 second.
				bool completed = taskA.IsCompleted;
				Console.WriteLine("Task A completed: {0}, Status: {1}",
					completed, taskA.Status);
				if (! completed)
					Console.WriteLine("Timed out before task A completed.");                 
			}
			catch (AggregateException) {
				Console.WriteLine("Exception in taskA.");
			}

		}


		enum color: int
		{ 
			red,
			green, 
			blue = 5, 
			cyan,  // has value 6
			magenta = 10, 
			yellow // has value 11
		}
	
		
		private enum test
		{
			one
		}
	}


	internal abstract class employee
	{
		private employee(string department, string name)
		{
		}
	}

	internal class Employee
	{
		private readonly string department;
		private readonly string location;
		private readonly string name;
		private bool isOnVacation;

		public Employee(string department, string name, string location)
		{
			this.department = department;
			this.name = name;
			this.location = location;
		}

		public string GetDepartment()
		{
			return department;
		}

		public string GetName()
		{
			return name;
		}

		public string GetLocation()
		{
			return location;
		}

		public bool GetStatus()
		{
			return isOnVacation;
		}

		public bool SwitchStatus()
		{
			isOnVacation = !isOnVacation;
			return isOnVacation;
		}
	}

	internal class DecksOfCard
	{
		private readonly char[] ranks = { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };
		private readonly bool[] results = { true, true, true, true };
		private readonly char[] suits = { 'S', 'C', 'H', 'D' };

		public int decksOfCards(string[] cards)
		{
			foreach (var s in suits)
			{
				var result = true;
				foreach (var r in ranks) result = result && Array.IndexOf(cards, r + s) >= 0;

				results[s] = result;
			}

			return results.Count(x => x);
		}
	}


	//// 
	//// https://www.c-sharpcorner.com/UploadFile/c210df/explore-interface-vs-abstract-class/
	////

	//// - INTERFACE: Is a contract, template of what must exist;
	//// - Can be multiply inherited;
	//// - Only signatures to: methods, properties, indexers and events;
	//// - No fields, no variables nor constants, no constructor;
	//// - No access modifiers: all public;
	//// - Declarations only, no implementation;
	//// - Has abstract methods only (declaration) 
	//// - Supports inheritance and polymorphism
	//public interface ISolution : IAsyncResult
	//{
	//	public int X { get; set; }
	//	public bool CheckBracketsSequence(string sequence);
	//	public bool IfNumberContains3(int number);
	//}

	//// - ABSTRACT: Used as a base class
	//// - Can't be instantiated;
	//// - Inherited with its derived class, max 1, ordered first before Interfaces;
	//// - Can inherit another base class and base interfaces;
	//// - Can have a constructor;
	//// - Can have access modifiers;
	//// - Can have implemented and abstract methods, minimum is 1 abstract method;
	//// - All abstract methods must be implemented in derived class.
	//abstract class ASolution
	//{
	//	public abstract bool IsAbstractGood(string sequence);
	//	public abstract bool IfSolutionGood(int number);
	//}

	//// - GENERICS: A class that receives a types as a parameter
	//// - 1 or more types
	//// - Common use: create collection classes;
	//// - Can Interface, classes, methods, events and delegates;
	//// - Can exclude access to methods on particular types;
	//// - Type info of generic data type at run-time with reflection.
	//public class GenericList<T>
	//{
	//	public void Add(T input) { }
	//}

	//class SolutionA : ASolution, ISolution
	//{
	//	public SolutionA()
	//	{
	//	}

	//	public int X { get; set; }

	//	public bool CheckBracketsSequence(string sequence)
	//	{
	//		throw new NotImplementedException();
	//	}

	//	public bool IfNumberContains3(int number)
	//	{
	//		throw new NotImplementedException();
	//	}

	//	public override bool IsAbstractGood(string sequence)
	//	{
	//		throw new NotImplementedException();
	//	}

	//	public override bool IfSolutionGood(int number)
	//	{
	//		throw new NotImplementedException();
	//	}
	//}


	//class Solution : ISolution
	//{

	//	public int X { get; set; }

	//	public bool CheckBracketsSequence(string sequence)
	//	{
	//		int open = sequence.Count(o => o == '(');

	//		return open == sequence.Count(c => c == ')');
	//	}

	//	public bool IfNumberContains3(int number)
	//	{
	//		int temp = number;
	//		while (temp > 0)
	//		{
	//			if ((temp - (temp / 10) * 10) == 3)
	//				return true;

	//			temp = (int)temp / 10;
	//		}

	//		return false;
	//	}

	//	public bool IfYearIsLeap(int year)
	//	{
	//		return DateTime.IsLeapYear(year);
	//	}

	//	public void SwapTwoNumbers(ref int number1, ref int number2)
	//	{
	//		int temp = number1;
	//		number1 = number2;
	//		number2 = temp;
	//	}
	//}

	internal class Solution12
	{
		public int solution(int[] A)
		{
			// write your code in C# 6.0 with .NET 4.5 (Mono)
			var result = 0;

			var fumeEmissions = A.Select(d => (float)d).ToArray();
			var pollutionTot = (int)fumeEmissions.Sum();
			var pollutionGoal = pollutionTot / 2;

			var mostPolluter = fumeEmissions.Length - 1;
			while (fumeEmissions.Sum() > pollutionGoal)
			{
				Array.Sort(fumeEmissions);

				fumeEmissions[mostPolluter] /= 2;

				result++;
			}

			return result;
		}
	}

	internal class Solution11
	{
		public int solution(int[] P, int[] S)
		{
			var result = 0;

			var pTot = P.Sum();

			Array.Sort(S);
			Array.Reverse(S);
			var pPlaced = 0;
			while (result < S.Length && pPlaced < pTot)
			{
				pPlaced += S[result];
				result++;
			}

			return result;
		}
	}


	internal class Solution10
	{
		public string solution(string message, int K)
		{
			var l = message.Length;

			if (l <= K) return message;

			var result = message.Substring(0, Math.Min(K, l));

			if (message[K] == ' ' && !message.EndsWith(" ")) return result;

			while (!result.EndsWith(" "))
				result = result.Remove(result.Length - 1, 1);

			while (result.EndsWith(" "))
				result = result.Remove(result.Length - 1, 1);

			return result;
		}
	}


	// Binary Gap
	// Write a function:
	//
	// class Solution { public int solution(int N); }
	//
	// that, given a positive integer N, returns the length of its longest binary gap. The function
	// should return 0 if N doesn't contain a binary gap.
	//
	// For example, given N = 1041 the function should return 5, because N has binary representation
	// 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should
	// return 0, because N has binary representation '100000' and thus no binary gaps.
	//
	// Write an efficient algorithm for the following assumptions:
	//
	// N is an integer within the range [1..2,147,483,647].

	internal class Solution1
	{
		public int solution1(int N)

		{
			if (!(N >= 1 && N <= int.MaxValue))
				return -1;

			var binary = Convert.ToString(N, 2);

			var l = binary.Length;
			var g = 0;
			var result = 0;
			for (var i = 0; i < l; i++)
				if (binary[i] == '1')
				{
					if (g > 0)
					{
						result = Math.Max(result, g);
						g = 0;
					}
				}
				else
				{
					if (binary[i] == '0')
						g++;
				}

			return result;
		}
	}

	internal class Solution2
	{
		public int solution2(int A, int B, int C)
		{
			if (!(A >= 0) && A <= 1073741823 ||
			    !(B >= 0) && B <= 1073741823 ||
			    !(C >= 0) && C <= 1073741823)
				return -1;

			var a_binary = Convert.ToString(A, 2).PadLeft(30, '0'); //.Remove(0,2);
			var b_binary = Convert.ToString(B, 2).PadLeft(30, '0');
			var c_binary = Convert.ToString(C, 2).PadLeft(30, '0');
			var conform = new StringBuilder("".PadLeft(30, '0'));

			Console.WriteLine(a_binary + " " + a_binary.Length);
			Console.WriteLine(b_binary + " " + b_binary.Length);
			Console.WriteLine(c_binary + " " + c_binary.Length);
			Console.WriteLine(conform + " " + conform.Length);

			for (var i = 0; i < 30; i++)
				if ('1' == a_binary[i] && '1' == b_binary[i] && '1' == c_binary[i])
					conform[i] = '1';

			var count = conform.ToString().Count(f => f == '0');
			Console.WriteLine(conform + " " + conform.Length + " " + count);

			return 2 * count;
		}
	}

	//the following list is constructed:

	//the first node (the head) is located at index 0 and has a value of 1;
	//the second node is located at index 1 and has a value of 4;
	//the third node is located at index 4 and has a value of 2;
	//the fourth node is located at index 2 and has a value of −1.

	// Write a function:

	// class Solution { public int solution(int[] A); }

	// that, given a non-empty array A consisting of N integers, returns the length of the list constructed from A in the above manner.

	// For example, given array A such that:

	//A[0] =  1
	//A[1] =  4
	//A[2] = -1
	//A[3] =  3
	//A[4] =  2
	//	the function should return 4, as explained in the example above.

	//	Assume that:
	//N is an integer within the range [1..200,000];
	//each element of array A is an integer within the range [−1..N−1];
	//it will always be possible to construct the list and its length will be finite.

	internal class Solution3
	{
		public int solution(int[] A)
		{
			var l = 1;
			var k = 0;
			while (A[k] != -1)
			{
				l++;
				k = A[k];
			}

			return l;
		}
	}

	//Write an efficient algorithm for the following assumptions:
	//	N is an integer within the range [1..100,000];
	//	K is an integer within the range [0..1,000,000,000];
	//	each element of array A is an integer within the range [−1,000,000,000..1,000,000,000].

	internal class Solution4
	{
		public int solution(int K, int[] A)
		{
			if (!(K >= 0 && K <= 1000000000)) return -1;
			var N = A.Length;
			if (!(N >= 1 && N <= 100000)) return -1;

			var s = 0;
			for (var p = 0; p < N; p++)
			{
				var max = int.MinValue;
				var min = int.MaxValue;
				for (var q = p; q < N; q++)
				{
					var newminmax = false;
					if (A[q] > max)
					{
						newminmax = true;
						max = A[q];
					}

					if (A[q] < min)
					{
						newminmax = true;
						min = A[q];
					}

					if (newminmax && max - min <= K)
					{
						Console.WriteLine($">>>({p}, {q})");
						s++;
					}
				}
			}

			return s > 1000000000 ? 1000000000 : s;
		}
	}

	internal class Solution5
	{
		public int solution(string E, string L)
		{
			var result = 2;

			var enter = DateTime.ParseExact(E, "HH:mm",
				CultureInfo.InvariantCulture);
			var left = DateTime.ParseExact(L, "HH:mm",
				CultureInfo.InvariantCulture);

			var ts = left - enter;
			Console.WriteLine(ts);

			if (ts != TimeSpan.Zero)
			{
				result += 3;
				Console.WriteLine(ts.Minutes);
				var hours = ts.Hours;
				if (hours > 0)
					hours -= ts.Minutes > 0 ? 0 : 1;
				result += 4 * hours;
			}

			return result;
		}
	}

	//A positive integer N is given. The goal is to find the highest power of 2 that divides N.
	//In other words, we have to find the maximum K for which N modulo 2^K is 0.
	//	For example, given integer N = 24 the answer is 3,
	//	because 2^3 = 8 is the highest power of 2 that divides N.

	//	Write a function:
	//		class Solution { public int solution(int N); }

	// that, given a positive integer N, returns the highest power of 2 that divides N.

	// For example, given integer N = 24, the function should return 3, as explained above.

	// Assume that:
	// N is an integer within the range [1..1,000,000,000].
	// In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.

	internal class Solution6
	{
		public int solution(int N)
		{
			if (N < 1 || N > 1000000000) return -1;

			var k = (int)Math.Sqrt(N);
			while (N % Math.Pow(2, k) != 0 && k > 0)
				k--;

			return k;
		}
	}

//	Write a function solution that, given two integers A and B, returns a string containing exactly A
//	letters 'a' and exactly B letters 'b' with no three consecutive letters being the same (in other words,
//	neither "aaa" nor "bbb" may occur in the returned string).

//	Examples:

//	1. Given A = 5 and B = 3, your function may return "aabaabab". Note that "abaabbaa" would also be a
//		correct answer. Your function may return any correct answer.
//	2. Given A = 3 and B = 3, your function should return "ababab", "aababb", "abaabb" or any of several other strings.
//	3. Given A = 1 and B = 4, your function should return "bbabb", which is the only correct answer in this case.

//	Assume that:
//	A and B are integers within the range [0..100];
//	at least one solution exists for the given A and B.
//		In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.
//}

	internal class Solution7
	{
		public string solution(int A, int B)
		{
			if (A < 0 || A > 100) return "";
			if (B < 0 || B > 100) return "";

			var l1 = 'a';
			var l2 = 'b';
			if (A < B)
			{
				l1 = 'b';
				l2 = 'a';

				var swap = A;
				A = B;
				B = swap;
			}

			var max1 = A / 2;
			var another1 = A % 2;
			var max2 = B / 2;
			var another2 = B % 2;

			var result = "";

			for (var i = 0; i < max1; i++)
			{
				result += l1 + l1.ToString();

				if (max2 > 0)
				{
					result += l2 + l2.ToString();
					max2--;
				}
			}

			if (result.EndsWith(l1))
			{
				if (another2 == 1) result += l2;
				if (another1 == 1) result += l1;
			}
			else
			{
				if (another1 == 1) result += l1;
				if (another2 == 1) result += l2;
			}

			return result;
		}
	}

	internal class Solution8
	{
		public string solution(int A, int B)
		{
			var ans = new StringBuilder();

			while (A > 0 || B > 0)
			{
				var writeA = false;
				var L = ans.Length;
				if (L >= 2 && ans[L - 1] == ans[L - 2])
				{
					if (ans[L - 1] == 'b')
						writeA = true;
				}
				else
				{
					if (A >= B)
						writeA = true;
				}

				if (writeA)
				{
					A--;
					ans.Append('a');
				}
				else
				{
					B--;
					ans.Append('b');
				}
			}

			return ans.ToString();
		}
	}

	internal class Solution9
	{
		// Function to generate and
		// print the required string
		public string solution(int A, int B)
		{
			var rt = "";
			while (0 < A || 0 < B)
				// More 'b', append "bba"
				if (A < B)
				{
					if (0 < B--) rt += 'b';
					if (0 < B--) rt += 'b';
					if (0 < A--) rt += 'a';
				}

				// More 'a', append "aab"
				else if (B < A)
				{
					if (0 < A--) rt += 'a';
					if (0 < A--) rt += 'a';
					if (0 < B--) rt += 'b';
				}

				// Equal number of 'a' and 'b'
				// append "ab"
				else
				{
					if (0 < A--) rt += 'a';
					if (0 < B--) rt += 'b';
				}

			return rt;
		}
	}
}