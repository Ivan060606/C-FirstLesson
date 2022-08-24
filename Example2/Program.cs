Console.Write("ВВедите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b)
    if (c>a) Console.WriteLine("Max="+c); 
    else Console.WriteLine("Max="+a);
else  
    if (b>a)
        if (c>b) Console.WriteLine("Max="+c);
        else Console.WriteLine("Max="+b);
else Console.WriteLine("Все числа равны "+c);