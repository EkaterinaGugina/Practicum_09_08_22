// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите целое число, и мы выведем четное ли оно");
Console.Write("number =");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
    {
     Console.Write($"Число {number} чётное");
    }
else
    {
    Console.Write($"Число {number} нечётное"); 
    }   
