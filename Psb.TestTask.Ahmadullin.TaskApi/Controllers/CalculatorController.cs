using Microsoft.AspNetCore.Mvc;

namespace Psb.TestTask.Ahmadullin.TaskApi.Controllers
{
	/// <summary>
	/// Контроллер для калькулятора.
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	public class CalculatorController : Controller
	{
		/// <summary>
		/// Запрос на получение суммы чисел.
		/// </summary>
		/// <param name="firstNumber">Первое число.</param>
		/// <param name="secondNumber">Второе число.</param>
		/// <returns>Результат запроса.</returns>
		[HttpGet("/Sum")]
		public IActionResult Sum(decimal firstNumber, decimal secondNumber)
		{
			try
			{
				return Ok(firstNumber + secondNumber);
			}
			catch (BadHttpRequestException e)
			{

				return BadRequest(e);
			}
		}

		/// <summary>
		/// Запрос на получение разности чисел.
		/// </summary>
		/// <param name="firstNumber">Первое число.</param>
		/// <param name="secondNumber">Второе число.</param>
		/// <returns>Результат запроса.</returns>
		[HttpGet("/Subtraction")]
		public IActionResult Subtraction(decimal firstNumber, decimal secondNumber)
		{
			try
			{
				return Ok(firstNumber - secondNumber);
			}
			catch (BadHttpRequestException e)
			{

				return BadRequest(e);
			}
		}

		/// <summary>
		/// Запрос на получение произведения чисел.
		/// </summary>
		/// <param name="firstNumber">Первое число.</param>
		/// <param name="secondNumber">Второе число.</param>
		/// <returns>Результат запроса.</returns>
		[HttpGet("/Multiplication")]
		public IActionResult Multiplication(decimal firstNumber, decimal secondNumber)
		{
			try
			{
				return Ok(firstNumber * secondNumber);
			}
			catch (BadHttpRequestException e)
			{

				return BadRequest(e);
			}
		}

		/// <summary>
		/// Запрос на получение частного чисел.
		/// </summary>
		/// <param name="firstNumber">Первое число.</param>
		/// <param name="secondNumber">Второе число.</param>
		/// <returns>Результат запроса.</returns>
		[HttpGet("/Division")]
		public IActionResult Division(decimal firstNumber, decimal secondNumber)
		{
			if (secondNumber == 0)
			{
				return BadRequest("Деление на 0 запрещено.");
			}

			try
			{
				return Ok(firstNumber / secondNumber);
			}
			catch (BadHttpRequestException e)
			{

				return BadRequest(e);
			}
		}
	}
}
