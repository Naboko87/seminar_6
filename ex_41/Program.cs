// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, ex_41");
Console.WriteLine("Write number");
string input = Console.ReadLine();
string[] number = input.Split(",");
int [] mass = new int[number.Length];

for (int i = 0; i < number.Length; i++)
{
    mass[i] = Convert.ToInt32(number[i]);
}


int collichestvo = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        collichestvo = collichestvo + 1; 
    }
}
Console.WriteLine(collichestvo);
