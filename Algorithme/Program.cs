// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
int[] tableau1 = new int[5] { 12, 16, 32, 55, 2 };

for(int i = 0; i< tableau1.Length; i++)
{
    Console.WriteLine(tableau1[i]);
}
Console.ReadKey();

int[] tableau2 = new int[5];

Console.WriteLine("SOLUTION 1: /n");
int index = tableau1.Length - 1;
for (int i = 0; i < tableau1.Length; i++)
{
    tableau2[i] = tableau1[index];
    Console.WriteLine(tableau2[i]);
    index--;
}

Console.WriteLine("/n SOLUTION 2: /n");
Array.Reverse(tableau1);
for (int i = 0; i < tableau1.Length; i++)
{
    Console.WriteLine(tableau1[i]);
}
Console.ReadKey();
Console.WriteLine("/n SOLUTION sort sur tableau2 ASC: /n");
Array.Sort(tableau2);
for (int i = 0; i < tableau2.Length; i++)
{
    Console.WriteLine(tableau2[i]);
}
Console.ReadKey();
Console.WriteLine("/n SOLUTION sort sur tableau2 DESC: /n");
Array.Reverse(tableau2);
for (int i = 0; i < tableau2.Length; i++)
{
    Console.WriteLine(tableau2[i]);
}
Console.ReadKey();
int n, reverse = 0, rem;
Console.Write("Enter a number: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Nombre= "+n);
while (n != 0)
{
    rem = n % 10;
    reverse = reverse * 10 + rem;
    n /= 10;
}
Console.Write("Reversed Number: " + reverse);
Console.ReadKey();