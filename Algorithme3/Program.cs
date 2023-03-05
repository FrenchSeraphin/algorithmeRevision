// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fibonacci");
static void fibonacci(int nb)
{
    int Upp = 0;
    int Up = 1;
    int tampon;

    Console.WriteLine(Upp);
    Console.WriteLine(Up);
    for (int i = 0; i < nb - 1; i++)
    {
        Console.WriteLine(Up + Upp);
        tampon = Upp;
        Upp = Up;
        Up +=b tampon;
    }
    Console.ReadKey();
}


int nb = 0;

while (nb < 2)
{
    Console.WriteLine("Entrez un chiffre/nombre supérieur ou égal à 2: ");
    nb = int.Parse(Console.ReadLine());
}

fibonacci(nb);