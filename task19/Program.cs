// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


//Вариант 1
int n = new Random().Next(10000, 99999);
string num = n.ToString();
if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine($"{n} -> да, полиндром");
else Console.WriteLine($"{n} -> нет, не полиндром");


//Вариант 2
n = new Random().Next(10000, 99999);
if (n / 10000 == n % 10 && n / 1000 % 10 == n % 100 / 10) Console.WriteLine($"{n} -> да, полиндром");
else Console.WriteLine($"{n} -> нет, не полиндром");


//Поигрался, сколько раз получится полиндром из 1000 попыток
int i = 0;
int yes = 0;
int no = 0;
while (i < 1000)
{
  n = new Random().Next(10000, 99999);
  num = n.ToString();
  if (num[0] == num[4] && num[1] == num[3])
  {
    yes++;
  }
  else
  {
    no++;
  }
  i++;
}
Console.WriteLine($"Нет = {no}, Да = {yes}");