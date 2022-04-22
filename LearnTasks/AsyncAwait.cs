using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTasks
{
	internal static class AsyncBreakfast
	{

		public static async Task AsyncAwait()
		{
			var start = DateTime.Now;

			var cup = PourCoffee();
			$"({Thread.CurrentThread.ManagedThreadId}) coffee is ready".Dump();

			var toastTask = MakeToastWithButterAndJamAsync(2);
			$"({Thread.CurrentThread.ManagedThreadId}) >>> set makeToastWithButterAnd... ".Dump();
			var eggsTask = FryEggs(2);
			var baconTask = FryBacon(3);

			var oj = PourOJ();
			$"({Thread.CurrentThread.ManagedThreadId}) oj is ready".Dump();


			var toast = await toastTask;
			$"({Thread.CurrentThread.ManagedThreadId}) toast is ready".Dump();

			var eggs = await eggsTask;
			$"({Thread.CurrentThread.ManagedThreadId}) eggs are ready".Dump();

			var baon = await baconTask;
			$"({Thread.CurrentThread.ManagedThreadId}) bacon is ready".Dump();


			$"({Thread.CurrentThread.ManagedThreadId}) Breakfast is ready!".Dump();
			Console.WriteLine($"Time:{DateTime.Now - start}");
		}

		public static Task NoAsync()
		{
			return Task.Run(() => Console.WriteLine("no async"));
		}

		private static Juice PourOJ()
		{
			$"({Thread.CurrentThread.ManagedThreadId}) Pouring orange juice".Dump();
			return new Juice();
		}

		private static Coffee PourCoffee()
		{
			$"({Thread.CurrentThread.ManagedThreadId}) Pouring coffee".Dump();
			return new Coffee();
		}

		private static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
		{
			var toast = await ToastBread(number);
			ApplyButter(toast);
			ApplyJam(toast);

			return toast;
		}

		private static Task<Toast> ToastBread(int slices)
		{
			return Task.Run(() =>
			{
				for (var slice = 0; slice < slices; slice++)
					$"({Thread.CurrentThread.ManagedThreadId}) Putting a slice of bread in the toaster".Dump();

				$"({Thread.CurrentThread.ManagedThreadId}) Start toasting...".Dump();
				//await Task.Delay(3000);
				$"({Thread.CurrentThread.ManagedThreadId}) Remove toast from toaster".Dump();

				return new Toast();
			});
		}

		private static async Task<Toast> ToastBreadAsync(int slices)
		{
			for (var slice = 0; slice < slices; slice++)
				$"({Thread.CurrentThread.ManagedThreadId}) Putting a slice of bread in the toaster".Dump();

			$"({Thread.CurrentThread.ManagedThreadId}) Start toasting...".Dump();
			await Task.Delay(3000);
			$"({Thread.CurrentThread.ManagedThreadId}) Remove toast from toaster".Dump();

			return new Toast();
		}

		private static void ApplyButter(Toast toast)
		{
			$"({Thread.CurrentThread.ManagedThreadId}) Putting butter on the toast".Dump();
		}

		private static void ApplyJam(Toast toast)
		{
			$"({Thread.CurrentThread.ManagedThreadId}) Putting jam on the toast".Dump();
		}

		private static async Task<Egg> FryEggs(int howMany)
		{
			$"({Thread.CurrentThread.ManagedThreadId}) Warming the egg pan...".Dump();
			await Task.Delay(3000);
			$"({Thread.CurrentThread.ManagedThreadId}) cracking {howMany} eggs".Dump();
			$"({Thread.CurrentThread.ManagedThreadId}) cooking the eggs ...".Dump();
			await Task.Delay(3000);
			$"({Thread.CurrentThread.ManagedThreadId}) Put eggs on plate".Dump();

			return new Egg();
		}

		private static async Task<Bacon> FryBacon(int slices)
		{
			$"({Thread.CurrentThread.ManagedThreadId}) putting {slices} slices of bacon in the pan".Dump();
			$"({Thread.CurrentThread.ManagedThreadId}) cooking first side of bacon...".Dump();
			await Task.Delay(3000);
			for (var slice = 0; slice < slices; slice++)
				$"({Thread.CurrentThread.ManagedThreadId}) flipping a slice of bacon".Dump();

			$"({Thread.CurrentThread.ManagedThreadId}) cooking the second side of bacon...".Dump();
			await Task.Delay(3000);
			$"({Thread.CurrentThread.ManagedThreadId}) Put bacon on plate".Dump();

			return new Bacon();
		}

		internal class Juice
		{
		}

		internal class Bacon
		{
		}

		internal class Toast
		{
		}

		internal class Egg
		{
		}

		public class Coffee
		{
		}
	}
}