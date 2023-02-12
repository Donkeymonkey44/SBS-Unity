using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 1;
			int count = 0;
			Library newbook = new Library();

			while (i == 1)
			{
				newbook.InputData(count);
				count++;
				Console.Write("계속 할까요? (Y or N) : ");
				string Keep = Console.ReadLine();
				if (Keep == "N" || Keep == "n")
					i = 0;
				else if (Keep != "y" && Keep != "Y")
				{
					Console.WriteLine("잘못된 입력입니다.");
					i = 2;
				}
			}
			if (i != 2)
			{
				Console.WriteLine();
				Console.Write("찾으시는 책의 제목을 입력해주세요 : ");
				string FindBook = Console.ReadLine();
				newbook.SearchData(FindBook);
			}
		}
	}

	class Book
	{
		public string Title;
		public string Author;
		public string Publisher;
	}

	class Library
	{
		Book[] books = new Book[99];

		public void InputData(int count)
		{
			books[count] = new Book();

			Console.Write("제목을 입력해주세요 : ");
			books[count].Title = Console.ReadLine();
			Console.Write("지은이를 입력해주세요 : ");
			books[count].Author = Console.ReadLine();
			Console.Write("출판사를 입력해주세요 : ");
			books[count].Publisher = Console.ReadLine();
			Console.WriteLine("======================================");
		}

		public void SearchData(string FindTitle)
		{
			for (int i = 0; i < books.Count(); i++)
			{
				if (books[i] == null)
				{
					Console.WriteLine("찾으시는 책은 없습니다.");
					break;
				}
				else if (FindTitle == books[i].Title)
				{
					Console.WriteLine($"찾으시는 책은 {books[i].Publisher}의 {books[i].Author} 작가의 {books[i].Title} 입니다.");
					break;
				}
			}
		}
	}
}
