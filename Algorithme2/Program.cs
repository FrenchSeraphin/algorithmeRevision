// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inverser un nombre");
int n, reverse = 0, rem;
Console.Write("Enter a number: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Nombre= " + n);
while (n != 0)
{
    rem = n % 10;
    reverse = reverse * 10 + rem;
    n = n / 10;
}
Console.Write("Reversed Number: " + reverse);
Console.ReadKey();