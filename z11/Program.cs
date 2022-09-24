// прога выводит рандомное число и удаляет вторую цифру этого числа
Console.Clear();
int a = new Random().Next(100, 1000);
//int randnum = new Random().Next(100, 1000);
//int a = randnum / 100;
//int c = randnum % 100;
//int d = c % 10;
//int f = a * 10 + d;
int b = (a / 100) * 10 + a % 10;

//Console.WriteLine($"Рандомное число {randnum} -> {f}");
Console.WriteLine($"Рандомное число {a} -> {b}");