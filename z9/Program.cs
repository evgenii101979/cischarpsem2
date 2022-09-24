// Прогр. выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

Console.Clear();


int randnum = new Random().Next(10, 100);
int a1 = randnum / 10;
int a2 = randnum % 10;
int max = a1;
if(a2 > a1)
{
    max= a2;
}
Console.WriteLine($"Рандомное число {randnum} ");
Console.WriteLine($"Максимальная цифра чила {max} ");
