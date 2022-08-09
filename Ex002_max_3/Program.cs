// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите три различных числа, и мы выведем максимальное среди них");
Console.Write("number1 =");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("number2 =");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("number3 =");
double number3 = Convert.ToDouble(Console.ReadLine());
double max = number1;
if (number2 > max)
    {
     max = number2;
    }
else
    {
        if (number3 > max)
        {
         max = number3;
        }
    }   
Console.Write("Максимальное из этих чисел равно  ");
Console.WriteLine(max);
