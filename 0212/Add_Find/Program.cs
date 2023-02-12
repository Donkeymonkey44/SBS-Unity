using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Find
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 1;
			int count = 0;
			Classes list = new Classes();

			while (x > 0)
			{
				list.inputData(count);
				count++;
				Console.Write("계속 할까요? (Y or N) : ");
				string Keep = Console.ReadLine();
				if (Keep == "N" || Keep == "n")
					x = 0;
				else if (Keep != "y" && Keep != "Y")
				{
					Console.WriteLine("잘못된 입력입니다.");
					x = -1;
				}
			}

			if (x != -1)
			{
				Console.Write("반을 입력해주세요 : ");
				string FindClass = Console.ReadLine();
				list.FindClass(FindClass);
			}
		}
	}
	
	class Student
	{
		public string Name;
		public string Class;
	}

	class Classes
	{
		Student[] student = new Student[99];

		public void inputData(int i)
		{
			student[i] = new Student();

			Console.Write("학생의 이름 : ");
			student[i].Name = Console.ReadLine();
			Console.Write("학생의 반 : ");
			student[i].Class = Console.ReadLine();
			Console.WriteLine("======================================");
		}

		public void FindClass(string Class)
		{
			Console.WriteLine("- 해당 반의 학생 - ");
			for (int i = 0; i < student.Count(); i++)
			{
				if (student[i] == null)
				{
					Console.WriteLine("모두 찾았습니다.");
					break;
				}
				else if (Class == student[i].Class)
					Console.WriteLine($"{student[i].Name}");
			}
		}

	}
}
