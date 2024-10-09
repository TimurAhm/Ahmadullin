using System.Net;
using System.Configuration;

namespace Psb.TestTask.Ahmadullin.TaskConsoleApp
{
	/// <summary>
	/// Работа с API калькулятором.
	/// </summary>
	public class Calculator
	{
		/// <summary>
		/// Создает строку запроса с API.
		/// </summary>
		/// <param name="firstNumber">Первое число.</param>
		/// <param name="secondNumber">Второе число.</param>
		/// <param name="operation">Математическая операция.</param>
		/// <returns>Строка запроса.</returns>
		internal static string CalculatorUriMaker(decimal firstNumber, decimal secondNumber, Operation operation)
		{
			return ConfigurationManager.AppSettings["url"] + operation +
				$"?firstNumber={firstNumber}&secondNumber={secondNumber}";
		}

		/// <summary>
		/// Отправляет запрос к API.
		/// </summary>
		/// <param name="url">Строка запроса.</param>
		/// <returns>Число в формате <see cref="string"/>.</returns>
		public static string GetStringResponse(string url)
		{
			using (var calculator = new WebClient { UseDefaultCredentials = true })
			{
				calculator.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8");
				var response = calculator.DownloadString(url);

				return response;
			}
		}

		/// <summary>
		/// Возможные операции.
		/// </summary>
		public enum Operation
		{
			Sum,
			Subtraction,
			Multiplication,
			Division
		}
	}
}
