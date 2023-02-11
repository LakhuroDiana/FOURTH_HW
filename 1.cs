// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

System.Console.WriteLine("Введите число A");
string number1 = Console.ReadLine();
float A = Convert.ToInt32(number1);

System.Console.WriteLine("Введите число B");
string number2 = Console.ReadLine();
int B = Convert.ToInt32(number2);

int i = 0;
float result = 1;
if (B > 0)
{
    while (i < B)
    {
        result = result * A;
        i++;
    }
}
if (B == 0)
{
    if (A > 0)
    {
        result = 1;
    }
    if (A < 0)
    {
        result = -1;
    }
    if (A == 0)
    {
        System.Console.WriteLine("uncertainty");
        result = 0;
    }
}
if (B < 0)
{
    float a = 1;
    int j = 0;
    while (j < -B)
    {
        a = a * A;
        j++;
    }
    System.Console.WriteLine(a);
    result = 1 / a;
}

System.Console.WriteLine(result);