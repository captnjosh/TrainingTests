using System;
using Newtonsoft.Json;

namespace LearnTasks
{

	public static class Dumper
	{
		public static string ToPrettyString(this object value)
		{
			return JsonConvert.SerializeObject(value);
		}

		public static T Dump<T>(this T value)
		{
			Console.WriteLine(value.ToPrettyString());
			return value;
		}
	}

}
