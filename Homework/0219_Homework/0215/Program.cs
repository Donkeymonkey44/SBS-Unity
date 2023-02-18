using System.ComponentModel.Design;

namespace _0215
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1.한식  2.중식  3.양식");
			Console.Write("식당의 번호를 입력해주세요 : ");
			int Num = Convert.ToInt32(Console.ReadLine());

			switch (Num)
			{
				case 1:
					Korean korean = new Korean();
					korean.Menu();
					break;
				case 2:
					Chinese chinese = new Chinese();
					chinese.Menu();
					break;
				case 3:
					Western western = new Western();
					western.Menu();
					break;
			}
		}
	}

	class Restaurant
	{
		protected string[] menus;
		protected int[] price;

		protected void TakeMoney(int money)
		{
			Console.WriteLine($"가격은 {price[money]} 원 입니다.");
		}
		protected void Order(int num)
		{
			Console.WriteLine($"받은 주문 : {menus[num]}");
			TakeMoney(num);
		}
		protected void ShowMenu()
		{
			Console.Write("메뉴 : ");
			for (int i = 0; i < menus.Length; i++)
			{
				Console.Write($"{ menus[i]}  ");
			}
			Console.WriteLine();
			Console.Write("음식의 번호를 골라주세요 : ");
			int Choice = Convert.ToInt32(Console.ReadLine()) - 1;
			Order(Choice);
		}
	}
	class Korean : Restaurant
	{
		public void Menu()
		{
			menus = new string[3] { "비빔밥", "갈비탕", "불고기" };
			price = new int[3] { 6000, 8000, 7000 };
			ShowMenu();
		}
	}
	class Chinese : Restaurant
	{
		public void Menu()
		{
			menus = new string[2] { "짜장면", "짬뽕" };
			price = new int[2] { 6000, 7000 };
			ShowMenu();
		}
	}
	class Western : Restaurant
	{
		public void Menu()
		{
			menus = new string[3] { "피자", "햄버거", "파스타" };
			price = new int[3] { 9000, 5000, 6500 };
			ShowMenu();
		}
	}
}