// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ex_43");
Console.WriteLine("write b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write k2");
int k2 = Convert.ToInt32(Console.ReadLine());

primer(b1, b2, k1, k2);

void primer(int a1, int a2, int c1, int c2){
int y = 0;
int x = 0;    
x = (c2 - c1)/(a1 - a2);
y = a1 * x + c1;
Console.WriteLine(y);
}