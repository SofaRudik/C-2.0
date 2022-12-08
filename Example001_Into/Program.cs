Console.Clear();
Console.WriteLine("Введите число");

int n;
int max1=0, max2=0;
do
{    
     n= int.Parse(Console.ReadLine());
    if(n>max1)
     { max2=max1; 
     max1=n; }
}while (n!=0);
 Console.WriteLine(max2);
