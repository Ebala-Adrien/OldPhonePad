using System;

class Program
{
    static void Main(string[] args)
    {
        // Run tests if the --test flag is provided
        if (args.Length > 0 && args[0].ToLower() == "--test")
        {
            OldPhonePadTests.RunTests();
            return;
        }

        // Run the program if no test flag is provided. The program will prompt the user to enter a sequence and then decode it.
        Console.WriteLine("Enter the sequence (finalize with #):");
        string input = Console.ReadLine();

        string result = OldPhonePad.Decode(input);
        Console.WriteLine($"Result: {result}");
    }
}