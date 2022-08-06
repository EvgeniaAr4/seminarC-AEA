// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());

int first = 1;
Console.Write("{0} ", first);
int second = 1;
Console.Write("{0} ", second);
int sum = 0;

while (number >= sum)
            {
                sum = first + second;
                
                    Console.Write("{0} ", sum);
                    
                        first = second;
                        second = sum;                
                }