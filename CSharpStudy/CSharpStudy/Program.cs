using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Write 쓰는법
            System.Console.Write("a");
            // WriteLine 쓰는법
            System.Console.WriteLine("B");

            System.Console.WriteLine("저의 이름은 한정호 입니다.");
            System.Console.WriteLine("저는 28살 입니다.");
            System.Console.WriteLine("저는 게임을 좋아합니다.");
            System.Console.WriteLine("저는 부천시에 살고 있습니다");

            // 데이터 형 - string
            String myName;
            String myAge;
            String myHobby;
            String myAdd;

            myName = "Han";
            myAge = "28";
            myHobby = "게임";
            myAdd = "부천시";
            System.Console.WriteLine(myName);
            System.Console.WriteLine(myAge);
            System.Console.WriteLine(myHobby);
            System.Console.WriteLine(myAdd);

            // ReadLine();
            string yourName;
            string yourAge;
            string yourAdd;
            string yourSex; */

            /* System.Console.WriteLine("이름을 입력해주세요 : ");
            yourName = System.Console.ReadLine();
            System.Console.WriteLine("나이를 입력해주세요 : ");
            yourAge = System.Console.ReadLine();
            System.Console.WriteLine("주소를 입력해주세요 : ");
            yourAdd = System.Console.ReadLine();
            System.Console.WriteLine("성별을 입력해주세요 : ");
            yourSex = System.Console.ReadLine();
            System.Console.Write("당신의 이름은 ");
            System.Console.Write(yourName);
            System.Console.WriteLine(" 입니다.");
            System.Console.Write("당신의 나이는 ");
            System.Console.Write(yourAge);
            System.Console.WriteLine(" 입니다.");
            System.Console.Write("당신의 주소는 ");
            System.Console.Write(yourAdd);
            System.Console.WriteLine(" 입니다.");
            System.Console.Write("당신의 성별은 ");
            System.Console.Write(yourSex);
            System.Console.WriteLine(" 입니다."); 

            // 변수 쓰기
            System.Console.WriteLine($"당신의 이름은 {yourName} 이고, 나이는 {yourAge} 입니다.");
            System.Console.WriteLine("당신의 주소는 {0} 이고, 성별은 {1} 입니다.", yourAdd, yourSex); */
            /*
            System.Console.Write("\n");
            // 1장 끝

            // 변수
            int myNum = 3;
            string SomeName = "Han";
            float toDay = 1.29f;

            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            // 이스케이프 코드
            System.Console.WriteLine("\"안녕하세요\"");

            string SomeNum = "3";
            string NNN = SomeName + SomeNum;
            System.Console.WriteLine(NNN);


            // 캐스팅 (형식변형) - 예제(나이계산)
            /* string birthYear;
            System.Console.WriteLine("태어난 년도를 입력해주세요 : ");
            birthYear = System.Console.ReadLine();

            int birthYearNum = Convert.ToInt32(birthYear);
            string someAge = (2023 - birthYearNum + 1).ToString();

            System.Console.WriteLine(someAge); */
            /* System.Console.WriteLine(@"        **
        aa
       aaaa
      aaaaaa
     aaaaaaaa
    aaaaaaaaaa
   aaaaaaaaaaaa
  aaaaaaaaaaaaaa
 aaaaaaaaaaaaaaaa
aaaaaaaaaaaaaaaaaa"); */
            /*
            // 1. 변수형 종류 주석으로 작성 후, 각 변수형들의 최대값, 최솟값 출력하기
            System.Console.WriteLine("1번 문제");
            System.Console.WriteLine("int의 최솟값 : {0}", int.MinValue); //int
            System.Console.WriteLine("int의 최댓값 : {0}", int.MaxValue); //int
            System.Console.WriteLine("double의 최솟값 : {0}", double.MinValue); //double
            System.Console.WriteLine("double의 최댓값 : {0}", double.MaxValue); //double
            System.Console.WriteLine("float의 최솟값 : {0}", float.MinValue); //float
            System.Console.WriteLine("float의 최댓값 : {0}", float.MaxValue); //float
            System.Console.WriteLine("char의 최솟값 : {0}", char.MinValue); //char
            System.Console.WriteLine("char의 최댓값 : {0}", char.MaxValue); //char
            System.Console.WriteLine("");

            // 2. string으로 이름 나이 입력 받고, 출력하기
            // 나이는 출생년도만 입력받기
            System.Console.WriteLine("2번 문제");
            System.Console.Write("이름을 입력해주세요 : ");
            string Name = System.Console.ReadLine();
            System.Console.Write("출생년도를 입력해주세요 : ");
            string birthYear = System.Console.ReadLine();
            int birthYearNum = Convert.ToInt32(birthYear);
            string nowAge = (2023 - birthYearNum + 1).ToString();
            System.Console.WriteLine("당신의 이름은 {0} 이고, 나이는 {1} 입니다.", Name, nowAge);
            System.Console.WriteLine("");

            // 3. @사용하여 별 그리기
            System.Console.WriteLine("3번 문제");
            System.Console.WriteLine(@"
                   *
                 *****
             *************
              ***********
             *************
                 *****
                   *");
            System.Console.WriteLine("");
            // 4. int 값을 float 로 캐스팅하기
            System.Console.WriteLine("4번 문제");
            System.Console.Write("정수를 입력해주세요 : ");
            string Num = System.Console.ReadLine();
            int intNum = Convert.ToInt32(Num);
            float floatNum = (float)intNum;
            System.Console.WriteLine("당신의 숫자는 " + floatNum);
            float tempFloat = 3.12f;
            int tempInt = (int)tempFloat;
            System.Console.WriteLine("3.12 를 int 로 바꾸면 " + tempInt);
            System.Console.WriteLine("");

            System.Console.WriteLine("추가문제");
            System.Console.Write("이름을 입력해주세요 : ");
            string tempName = System.Console.ReadLine();
            int strLen = tempName.Length;
            string tempNameStr = strLen.ToString();
            System.Console.WriteLine("이름의 길이는 {0} 입니다.", tempNameStr);
            System.Console.WriteLine("");
            */
            // 2장 끝

            // var (C# 에만 있음)

            // 배열
            /*
            int[] i1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] i2 = new int[5] { 14, 44, 4, 34, 24};
            int[] i3 = new int[5] { 2, 4, 6, 8, 10};
            int[] i4 = new int[5] { 300, 300, 300, 300, 300};
            int[] i5 = new int[5] { 10, 9, 8, 7, 6};

            string[] str1 = new string[5] { "a", "b", "c", "d", "e" };
            string[] str2 = new string[5] { "cat", "dog", "cow", "wolf", "fox" };
            string[] str3 = new string[5] { "int", "char", "float", "string", "long" };
            string[] str4 = new string[5] { "C", "C#", "C++", "Java", "Python" };
            string[] str5 = new string[5] { "마", "라", "다", "나", "가" };

            int[] LaterArray;
            System.Console.Write("배열의 크기는? ");
            string ArraySize = System.Console.ReadLine();
            LaterArray = new int[Convert.ToInt32(ArraySize)];

            string[] lang = new string[3];
            lang[0] = "C";
            lang[1] = "C++";
            lang[2] = "C#";
            System.Console.WriteLine($"0번 값은 {lang[0]} 입니다.");
            lang[0] = "Python";
            System.Console.WriteLine($"0번 값은 {lang[0]} 입니다."); */

            string[] food = new string[4] { "떡볶이", "김밥", "라면", "라볶이" };
            System.Console.WriteLine($"{food[0]}, {food[1]}, {food[2]}, {food[3]}");
            System.Console.Write("숫자를 입력해주세요 (0 ~ 3) : ");
            string choice = System.Console.ReadLine();
            int choNum = Convert.ToInt32(choice);

            System.Console.WriteLine("선택하신 숫자의 메뉴는 {0} 입니다.", food[choNum]);
            food[choNum] = " ";

            System.Console.WriteLine($"{food[0]}, {food[1]}, {food[2]}, {food[3]}");
            System.Console.WriteLine("추가 하실 메뉴를 입력해주세요 : ");
            string addFood1 = System.Console.ReadLine();
            string addFood2 = System.Console.ReadLine();
            string addFood3 = System.Console.ReadLine();
            string[] newFood = new string[7] { food[0], food[1], food[2], food[3], addFood1, addFood2, addFood3 };
            System.Console.WriteLine($"{newFood[0]}, {newFood[1]}, {newFood[2]}, {newFood[3]}, {newFood[4]}, {newFood[5]}, {newFood[6]}");
        }
    }
}
