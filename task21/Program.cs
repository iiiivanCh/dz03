// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double x1 = 0, y1 = 0, z1 = 0,
       x2 = 0, y2 = 0, z2 = 0,
       lengthSegment3D = 0;

try
{
  Console.WriteLine("Введите координаты первой точки");
  Console.Write("x1 = ");
  x1 = double.Parse(Console.ReadLine() ?? "");
  Console.Write("y1 = ");
  y1 = double.Parse(Console.ReadLine() ?? "");
  Console.Write("z1 = ");
  z1 = double.Parse(Console.ReadLine() ?? "");

  Console.WriteLine("Введите координаты второй точки");
  Console.Write("x2 = ");
  x2 = double.Parse(Console.ReadLine() ?? "");
  Console.Write("y2 = ");
  y2 = double.Parse(Console.ReadLine() ?? "");
  Console.Write("z2 = ");
  z2 = double.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
  Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
}

lengthSegment3D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine(lengthSegment3D);
