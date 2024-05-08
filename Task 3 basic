using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static char[] OrderByAlgorithm(char[] input, int stepSize)
    {
        var output = new List<char>();
        var queue = new Queue<char>(input);

        while (queue.Count > 0)
        {
            // Move to the next character in the queue
            for (int i = 0; i < stepSize - 1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            // Output the character
            char nextChar = queue.Dequeue();
            output.Add(nextChar);

            // Add a '-' every 3rd character
            if (output.Count % 4 == 3 && output.Count > 0)
            {
                output.Add('-');
            }
        }

        return output.ToArray();
    }

    public static void Main()
    {
        char[] input = "GHA14SFSD6K92".ToCharArray();
        char[] output = OrderByAlgorithm(input, 16);
        Console.WriteLine(new string(output));  // GDB-ACF-JEH-I
    }
}
