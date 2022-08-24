Console.Write("ВВедите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a-b>0) Console.WriteLine("Max="+a);
else if(b-a>0) Console.WriteLine("Max="+b);
else Console.WriteLine("Числа равны");