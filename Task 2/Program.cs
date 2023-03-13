// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int num_X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_Y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num_Z = int.Parse(Console.ReadLine());

int max = num_X; 
if (num_Y > max)
{
    max = num_Y;
}
if (num_Z > max)
{
    max = num_Z;
}
Console.WriteLine("Наибольшее из введённых чисел -> " + max);
