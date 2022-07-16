// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

System.Console.WriteLine("введите число");
int s1 = Convert.ToInt32(Console.ReadLine());
if(s1>99)
{
    System.Console.WriteLine(Convert.ToString(s1).Substring(2 ,1));
}
else
{
    System.Console.WriteLine("incorrect");
}