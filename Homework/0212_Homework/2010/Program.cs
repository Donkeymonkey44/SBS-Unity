namespace _2010
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("2월 10일자 숙제");
			Console.WriteLine("숫자 두 개를 입력해주세요 : ");
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("두 숫자의 합은 {0} 입니다.", Plus(a, b));

			Console.WriteLine("");
			Console.WriteLine("숫자를 입력해주세요 : ");
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++) 
					Console.Write("*");
				Console.WriteLine("");
			}
			Console.WriteLine("");
			for (int i = 0; i < n; i++)
			{
				for (int j = n - 1; j > i; j--)
					Console.Write(" ");
				for (int k = 0; k < 2 * i + 1; k++)
					Console.Write("*");
				Console.WriteLine("");
			}
		}
		
		private static int Plus(int a, int b)
		{
			return a + b;
		}
	}
}