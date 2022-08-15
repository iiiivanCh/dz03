// Задачa 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
int N = 0;
int i = 1;
int t = 3;

try
{
  Console.Write("Введите число: ");
  N = int.Parse(Console.ReadLine() ?? "");

}
catch (Exception exc)
{
  Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
}

Console.Write($"{N} -> ");
while (i <= N)
{
  Console.Write($"{Math.Pow(i, t)}, ");
  i++;
}
