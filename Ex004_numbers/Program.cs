// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число, большее 1, и мы выведем все чётные числа от 1 до него");
Console.Write("number =");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= number)
{
    Console.Write($"{current}  ");  
    current+=2;
}
if (number <= 1)
{
    Console.Write("Исправьте введенное число согласно условию задачи!"); 
}