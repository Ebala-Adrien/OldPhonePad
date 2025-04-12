using System;
using OldPhonePad;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the sequence (finalize with #):");
        string input = Console.ReadLine();

        string result = OldPhonePad.OldPhonePad.Decode(input);
        Console.WriteLine($"Result: {result}");
    }
}