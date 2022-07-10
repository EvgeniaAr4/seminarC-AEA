// Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа
// Не поняла тз и сделала два варианта (в первом - наибольшее число из диапазона; во втором - наибольшие цифры в диапазоне)
int a = 10;
int b = 99;
int max = a;
if ( a < b )
{
     max = b;
System.Console.WriteLine(max);
}
else
{
System.Console.WriteLine(a);
}

/*
int a = 10;
            int b = 99;
            for (; b !=0; b/=10)
            {
                int r = b % 10;
                if (r > a) a = r;
                System.Console.WriteLine(r);
            }
/*
