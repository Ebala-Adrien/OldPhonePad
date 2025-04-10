using System;

// Simple test class to test the examples given in the assignment
public static class OldPhonePadTests
{
    public static void RunTests()
    {
        Console.WriteLine("Running OldPhonePad Tests...");
        Console.WriteLine("----------------------------");

        TestDecode("33#", "E");
        TestDecode("227*#", "B");
        TestDecode("4433555 555666#", "HELLO");
        TestDecode("8 88777444666*664#", "TURING");

        Console.WriteLine("----------------------------");
        Console.WriteLine("All tests completed successfully!");
    }

    private static void TestDecode(string input, string expected)
    {
        var result = OldPhonePad.Decode(input);
        
        Console.WriteLine($"Input: '{input}'");
        Console.WriteLine($"Expected: '{expected}'");
        Console.WriteLine($"Got: '{result}'");
        
        if (result != expected)
        {
            throw new Exception($"Test failed: Input '{input}' should have returned '{expected}' but got '{result}'");
        }
        
        Console.WriteLine("Status: PASSED");
        Console.WriteLine();
    }
} 