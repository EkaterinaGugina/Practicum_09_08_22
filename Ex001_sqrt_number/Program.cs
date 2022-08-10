// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два целых числа, и мы выведем, какое из них больше");
Console.Write("A =");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("B =");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
    {
     Console.WriteLine($"{numberA} > {numberB}");
    }
else
    {
        if (numberA == numberB)
        {
        Console.WriteLine($"{numberA} = {numberB}");
        }
        else 
        {
        Console.WriteLine($"{numberA} < {numberB}");
        }
    }   