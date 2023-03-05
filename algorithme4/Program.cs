// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tableau croissant");

//Fonction 
void asc(int[] tableau1)
{
    for (int i = 0; i < tableau1.Length; i++)
    {
        for (int j = i + 1; j < tableau1.Length; j++)
        {
            if (tableau1[i] > tableau1[j])
            {
                int tmp = tableau1[i];
                tableau1[i] = tableau1[j];
                tableau1[j] = tmp;
            }
        }
    }
    Console.WriteLine("Ordre ASC:");
    for (int i = 0; i < tableau1.Length; i++)
    {
        Console.WriteLine(tableau1[i]);
    }
}

void desc(int[] tableau1)
{
    for (int i = 0; i < tableau1.Length; i++)
    {
        for (int j = i + 1; j < tableau1.Length; j++)
        {
            if (tableau1[i] < tableau1[j])
            {
                int tmp = tableau1[i];
                tableau1[i] = tableau1[j];
                tableau1[j] = tmp;
            }
        }
    }
    Console.WriteLine("Ordre DESC:");
    for (int i = 0; i < tableau1.Length; i++)
    {
        Console.WriteLine(tableau1[i]);
    }
}

//Variables
int[] tab = new int[7] { 67, 16, 11, 55, 2, 99, 1 };

//Algo
asc(tab);
Console.ReadKey();
desc(tab);
Console.ReadKey();