using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0212
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Astudent = new Student();
            //Astudent.name = "한정호";
            //Astudent.age = 28;

            //Student Bstudent = new Student();
            //Bstudent.name = "누군가";
            //Bstudent.age = 24;

            //Astudent.writelineStudentInfo();
            //Bstudent.writelineStudentInfo();

            //Console.Write("이름을 입력해주세요 : ");
            //Astudent.name = Console.ReadLine();
            //Console.Write("나이를 입력해수제요 : ");
            //Astudent.age = Convert.ToInt32(Console.ReadLine());
            //Astudent.writelineStudentInfo();
            //Console.WriteLine("");

            //Bstudent.inputStudentInfodate();

            //Student[] students = new Student[3];
            //for (int i = 0; i < 3; i++)
            //{
            //      students[i] = new Student();
            //      students[i].inputStudentInfodate();
            //      Console.WriteLine("");
            //}

            //Food food = new Food();
            //food.InputFoods();
            //food.ListFoods();
            //food.AddFood();
            //food.NewListFoods();

            //Zodiac you = new Zodiac();
            //you.Cal(you.BirthYear());

            //Games NewGame = new Games();
            //NewGame.InputData();

            //public        - 외부에서 자유롭게
            //private       - 나만 쓸수있다.
            //protected     - 상속받은 자식이 쓸 수있다.

            //Classes myNewClass = new Classes();
            //myNewClass.WriteSchoolInfo("상원초등학교");

            Korean Food = new Korean();
            Food.MenuSetting();
        }
    }

    class Student
    {
        public string name;
        public int age;

        public void writelineStudentInfo()
		{
            Console.WriteLine("학생의 이름은 {0}입니다.", name);
            Console.WriteLine("학생의 나이는 {0}입니다.", age);
        }

        public void inputStudentInfodate()
		{
            Console.Write("이름을 입력해주세요 : ");
            name = Console.ReadLine();
            Console.Write("나이를 입력해수제요 : ");
            age = Convert.ToInt32(Console.ReadLine());

            writelineStudentInfo();
        }
    }
    
    class Food
	{
        public string[] Names = new string[6];
        public string New;

        public void InputFoods()
		{
            for (int i = 0; i < 5; i++)
            {
                Console.Write("음식을 입력해주세요 : ");
                Names[i] = Console.ReadLine();
            }
		}

        public void ListFoods()
		{
            for (int j = 0; j < 4; j++)
                Console.Write("{0}, ", Names[j]);
            Console.WriteLine("{0}", Names[4]);
        }

        public void AddFood()
		{
            int j = 0;
            Console.Write("음식을 추가로 입력해주세요 : ");
            New = Console.ReadLine();

            int findindex = Array.IndexOf(Names, New);
            if (findindex != -1)
                Names[findindex] = "";

   //         for (int i = 0; i < 5; i++)
			//{
   //             if (New == Names[i])
   //                 Names[i] = "";
			//}
            while (j < 5)
			{
                if (Names[j] == "")
                    break;
                j++;
			}
            if (j == 5)
                Names[5] = New;
		}
        public void NewListFoods()
        {
            for (int j = 0; j < 5; j++)
                Console.Write("{0}, ", Names[j]);
            Console.WriteLine("{0}", Names[5]);
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


            return (birthYear);
		}

        public void Cal(int birthYear)
		{
            int Znum = birthYear % 12;
            int Age = 2023 - birthYear + 1;

            Console.WriteLine($"당신은 {birthYear}년생 {Age}세 {Animal[Znum]}띠 입니다.");
        }
	}

    class Games
	{
        public string[] Titles = new string[7] { "a", "b", "c", "d", "e", "f", "g" };

        public void InputData()
		{
            Console.Write("게임명을 입력해주세요 : ");
            string InTitle = Console.ReadLine();

            int i = 0;
            while (i < 7)
			{
                if (InTitle == Titles[i])
				{
                    Console.WriteLine("{0} 은 있습니다.", Titles[i]);
                    break;
				}
                i++;
			}
            if (i == 7)
                Console.WriteLine("{0} 은 없습니다.", InTitle);
		}
	}

    class School
    {
        protected string SchoolName;

        protected void WriteSchoolName()
        {
            Console.WriteLine($"학교 이름 : {SchoolName}");
        }
    }

    class Classes : School
	{
        private string ClassName = "A반";

        public void WriteSchoolInfo(string _SchoolName)
		{
            SchoolName = _SchoolName;
            WriteSchoolName();
            Console.WriteLine($"내 반은 {ClassName}");
		}
	}

    class Restaurant
    {
        protected string[] menus;
        protected int[] menusPirce;

        private void TakeMoney(int money)
		{
            Console.WriteLine($"돈 내기 : {money}");
		}

        private void OrderMenu(int num)
		{
            Console.WriteLine($"주문 : {menus[num]}");
            TakeMoney(menusPirce[num]);
		}

        protected void ShowMenu()
		{
            Console.Write("종류 : ");
            for (int i = 0; i < menus.Count(); i++)
			{
                Console.Write($"{menus[i]}  ");
            }
            Console.WriteLine();
            Console.Write("음식의 번호를 골라주세요 : ");
            int input = Convert.ToInt32(Console.ReadLine()) - 1;
            OrderMenu(input);
		}
    }

    class Korean : Restaurant
	{
        public void MenuSetting()
		{
            menus = new string[2] { "비빔밥", "갈비" };
            menusPirce = new int[2] { 6000, 8000 };
            ShowMenu();
		}
	}

    class Chinese : Restaurant
    {
        public void MenuSetting()
        {
            menus = new string[2] { "짜장면", "짬뽕" };
            menusPirce = new int[2] { 5000, 6000 };
        }
    }

    class West : Restaurant
    {
        public void MenuSetting()
        {
            menus = new string[2] { "피자", "파스타" };
            menusPirce = new int[2] { 10000, 7000 };
        }
    }
}
