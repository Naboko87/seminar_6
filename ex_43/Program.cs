// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ex_43");
Console.WriteLine("write b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
} else if (k1 == k2)
{
   Console.WriteLine("Прямые параллельны"); 
} else
{
    primer(b1, b2, k1, k2);
}


void primer(double bb1, double bb2, double kk1, double kk2){
double y = 0;
double x = 0;    
Console.WriteLine("x:" +x);
Console.WriteLine("y:" +y);
Console.WriteLine("b1:" +bb1);
Console.WriteLine("b2:" +bb2);
Console.WriteLine("k1:" +kk1);
Console.WriteLine("k2:" +kk2);

x = (bb2 - bb1)/(kk1 - kk2);
Console.WriteLine("x:" +x);

y=(kk1*(bb2-bb1))/(kk1-kk2)+bb1;

Console.WriteLine("y:" +y);
}