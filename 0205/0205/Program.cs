using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mornig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력해주세요 : ");
            string Name = Console.ReadLine();
            Console.Write("출생년도을 입력해주세요 : ");
            string Birth = Console.ReadLine();
            Console.Write("자기소개를 입력해주세요 : ");
            string Intro = Console.ReadLine();
            int Age = 2023 - (Convert.ToInt32(Birth)) + 1;
            Console.WriteLine("당신의 이름은 {0}입니다.", Name);
            Console.WriteLine("당신의 나이는 {0}입니다.", Age);
            Console.WriteLine("\"{0}\"", Intro);
            Console.WriteLine($"당신의 이름은 {Name}이고 나이는 {Age} 입니다. \"{Intro}\"");
            Console.WriteLine(@"
    @@@@@
    @@@@@
    @@@@@
");

            string[] array = new string[3] { Name, Age.ToString(), Intro };
            Console.WriteLine("당신의 이름은 {0} 이고 나이는 {1} 입니다. \"{2}\"", array[0], array[1], array[2]);
            Console.WriteLine($"당신의 이름은 {array[0]} 이고 나이는 {array[1]} 입니다. \"{array[2]}\"");
        }
    }
}
