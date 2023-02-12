// See https://aka.ms/new-console-template for more information
Console.WriteLine("2월 8일자 숙제");
Console.WriteLine("숫자 두 개를 입력해주세요 : ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a + b <= 10) Console.WriteLine("10 이하입니다");
else if (a + b <= 20) Console.WriteLine("20 이하입니다");
else if (a + b <= 30) Console.WriteLine("30 이하입니다");
else Console.WriteLine("최소 30이상입니다");

if (a % 2 == 0 && b % 2 == 0) Console.WriteLine("짝짝");
else if (a % 2 == 0 && b % 2 == 1) Console.WriteLine("짝홀");
else if (a % 2 == 1 && b % 2 == 0) Console.WriteLine("홀짝");
else Console.WriteLine("홀홀");
Console.WriteLine("");
Console.Write("숫자를 입력해주세요 : ");
int r = Convert.ToInt32(Console.ReadLine());
int R = r;
while (r > 0)
{
	Console.WriteLine("문장반복");
	r--;
}
Console.WriteLine("");
for (int i = 0; i < R; i++)
	Console.WriteLine("문장반복");