using System;

public class CaptainCrunchDecoder
{
    public static string Encode(string input, int shift)
    {
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)(((letter + shift - offset) % 26 + 26) % 26 + offset);
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }

    public static void Main()
    {
        string input = "Hello World";
        int shift = 13;
        string encoded = Encode(input, shift);
        Console.WriteLine(encoded); // Outputs: Uryyb Jbeyq

        string decoded = Encode(encoded, -shift);
        Console.WriteLine(decoded); // Outputs: Hello World
    }
}
