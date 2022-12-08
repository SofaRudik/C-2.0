Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n= int.Parse(Console.ReadLine());
int n2=n/10;
Console.WriteLine($"вторая цифра числа это {n2%10}");
