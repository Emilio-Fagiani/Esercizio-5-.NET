using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("enter the file path ");
        string percorsoFile = Console.ReadLine();
        string contenutoFile = File.ReadAllText(percorsoFile);
        Console.WriteLine("File: ");
        Console.WriteLine(contenutoFile);
    }
}
