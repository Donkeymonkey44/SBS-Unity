﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("0130 숙제");
Console.WriteLine("제 이름은 한정호 입니다.");
Console.WriteLine("나이는 28 입니다.");
Console.Write("저는 남성이고 ");
Console.WriteLine("현재 부천시에 거주중입니다.");
Console.WriteLine("저는 게임을 좋아합니다.");
Console.WriteLine("블루아카이브, 원신을 하고 있습니다.");
Console.WriteLine("지금 SBS 게임아카데미에서 Unity를 배우고 있습니다.");
Console.WriteLine("예전에 C언어와 파이선을 공부한적이 있습니다.");
Console.WriteLine("제 소개는 여기까지 입니다.");
Console.WriteLine("잘 부탁드립니다.");
Console.WriteLine(" ");

Console.WriteLine("0201 숙제");
Console.Write("당신의 이름은? : ");
string Name = Console.ReadLine();
Console.Write("당신의 출생년도는? : ");
string birthYear = Console.ReadLine();
Console.Write("당신의 주소는? : ");
string Add = Console.ReadLine();
Console.Write("당신의 성별은? : ");
string Sex = Console.ReadLine();
Console.Write("자기소개를 입력해주세요. : ");
string Intro = Console.ReadLine();

int birth = Convert.ToInt32(birthYear);
int Old = 2023 - birth + 1;

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine($"이름 : {Name}");
Console.WriteLine($"나이 : {Old}");
Console.WriteLine($"주소 : {Add}");
Console.WriteLine($"성별 : {Sex}");
Console.WriteLine($"자기소개 : {Intro}");