// See https://aka.ms/new-console-template for more information
Console.WriteLine("2월 6일자 숙제");
Console.WriteLine("숫자 두 개를 입력해주세요(A, B) : ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A + B = {0}", a + b);
Console.WriteLine("A - B = {0}", a - b);
Console.WriteLine("A * B = {0}", a * b);
Console.WriteLine("A / B = {0}", a / b);
Console.WriteLine("A % B = {0}", a % b);

Console.WriteLine("숫자를 입력해주세요(C) : ");
int c = Convert.ToInt32(Console.ReadLine());
a += c;
Console.WriteLine("A += C 의 결과 : {0}", a);
a -= c;
Console.WriteLine("A -= C 의 결과 : {0}", a); 
a *= c;
Console.WriteLine("A *= C 의 결과 : {0}", a); 
a /= c;
Console.WriteLine("A /= C 의 결과 : {0}", a);
a %= c;
Console.WriteLine("A %= C 의 결과 : {0}", a);

Console.WriteLine("C++ 의 결과 : {0}", c++);
Console.WriteLine("C-- 의 결과 : {0}", c--);
Console.WriteLine("++C 의 결과 : {0}", ++c);
Console.WriteLine("--C 의 결과 : {0}", --c);
