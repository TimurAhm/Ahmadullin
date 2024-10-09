using static Psb.TestTask.Ahmadullin.TaskConsoleApp.Calculator;

namespace Psb.TestTask.Ahmadullin.TaskConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ShowTaskResult();
		}

		/// <summary>
		/// Вывод результата.
		/// </summary>
		private static void ShowTaskResult()
		{
			// Для отображения плавающей запятой(В US точки).
			Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

			Console.WriteLine(
				$"\nСложение - {GetStringResponse(CalculatorUriMaker(12.4m, 10.2m, Operation.Sum))}" +
				$"\nВычитание - {GetStringResponse(CalculatorUriMaker(12.4m, 10.2m, Operation.Subtraction))}" +
				$"\nУмножение - {GetStringResponse(CalculatorUriMaker(12.4m, 10.2m, Operation.Multiplication))}" +
				$"\nДеление - {GetStringResponse(CalculatorUriMaker(12.4m, 10.2m, Operation.Division))}"
				);
		}
	}
}
