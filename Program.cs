// Part 1
using System;

public class CaptainCrunchDecoder
{
    public static string Encode(string input)
    {
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)(((letter + 13 - offset) % 26) + offset);
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }

    public static void Main()
    {
        string input = "Hello World";
        string encoded = Encode(input);
        Console.WriteLine(encoded); // Outputs: Uryyb Jbeyq
    }
}


