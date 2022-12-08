Console.Clear();
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

if (n==6 || n==7)
Console.Write("Выходной");
else if (n<=5 && n>0) Console.Write("Будни");
else Console.Write("Введите цифру,обозначающую день недели");
