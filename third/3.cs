void input (float[] array, int len)
{  string number;
   System.Console.WriteLine("Введите массив");

   for (int i=0; i<len; ++i)
   {
     number = Console.ReadLine();
     array[i] = Convert.ToInt32(number);
   }
}

void output (float[] array, int len)
{
    for (int i=0; i<len; ++i)
    {
        System.Console.Write(array[i]);
        System.Console.Write(" ");
    }
}
 float[] massive = new float[8];
 int a=massive.Length;
 input(massive, a);
 output(massive, a);
