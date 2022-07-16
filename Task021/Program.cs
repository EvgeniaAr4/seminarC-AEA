// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("введите число");
int quarterNum  = Convert.ToInt32(Console.ReadLine());
string range = "";

if (quarterNum == 1) range = "x > 0, y > 0";
else if (quarterNum == 2) range = "x < 0, y > 0 ";
else if (quarterNum == 3) range = "x < 0, y < 0";
else range = "x > 0, y < 0";

System.Console.WriteLine($"Для {quarterNum}-й четверти координаты точки должны быть заданы в диапазоне ( {range} )");
System.Console.WriteLine();
