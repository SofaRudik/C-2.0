Console.Clear();
Console.WriteLine("Введите число: ");
int n= int.Parse(Console.ReadLine());
if (n<0) n = n *(-1);

if (n<99) {
Console.WriteLine("Введите 3ех значное число");
int m= int.Parse(Console.ReadLine());
n=m;
} 
if (n<0) n = n *(-1);
else
 while (n>1000) 
    n/=10;
Console.WriteLine($"Третья цифра числа: {n%10}");
