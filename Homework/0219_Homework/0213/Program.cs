namespace _0213
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Zodiac zodiac = new Zodiac();
			zodiac.Return(zodiac.BirthYear());
			Console.WriteLine();
			Calculator calculator = new Calculator();
			calculator.cal();
		}
	}

	class Zodiac
	{
		public string[] Animal = new string[12]
			{"원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양"};

		public int BirthYear()
		{
			Console.Write("출생년도를 입력해주세요 : ");
			int birthYear = Convert.ToInt32(Console.ReadLine());

			return birthYear;
		}

		public void Return(int birthYear)
		{
			int animal = birthYear % 12;
			int age = 2023 - birthYear + 1;
			Console.WriteLine($"당신은 {birthYear}년생 {age}세 {Animal[animal]}띠 입니다.");
		}
	}
	class Calculator
	{
		public void cal()
		{
			Console.WriteLine("숫자 두 개를 입력해주세요 : ");
			int A = Convert.ToInt32(Console.ReadLine());
			int B = Convert.ToInt32(Console.ReadLine());
			Console.Write("연산기호를 입력해주세요 : ");
			string oper = Console.ReadLine();
			int Re;

			switch (oper)
			{
				case "+":
					Re = A + B;
					Console.WriteLine($"두 수의 합은 {Re}");
					break;
				case "-":
					Re = A - B;
					Console.WriteLine($"두 수의 차는 {Re}");
					break;
				case "*":
					Re = A * B;
					Console.WriteLine($"두 수의 곱은 {Re}");
					break;
				case "/":
					Re = A / B;
					Console.WriteLine($"두 수의 나누기는 {Re}");
					break;
				case "%":
					Re = A % B;
					Console.WriteLine($"두 수의 나머지는 {Re}");
					break;
			}
		}
	}

}