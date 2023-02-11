//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Введите число");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
int Sum=0;
while(N>0)
{
  Sum=Sum+N%10;
  N=N/10;
}
System.Console.WriteLine(Sum);