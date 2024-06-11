using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace letterOccurances
{
    public class Program
    {
    public static void Main(string[] args)
    {

      string path = Directory.GetCurrentDirectory();

      var occurrences = LetterCount(path);

      // Output the counts for each letter in descending order
      foreach (var x in occurrences.OrderByDescending(k => k.Value))
      {
        Console.WriteLine($"{x.Key} = {x.Value} occurrences");
      }
      Console.ReadLine();
    }

    public static Dictionary<char, int> LetterCount(string directoryPath)
    {
      var occurrences = new Dictionary<char, int>();

      // Initialize the dictionary with letters A-Z
      for (char c = 'a'; c <= 'z'; c++)
      {
        occurrences[c] = 0;
      }

      // Get all JavaScript/TypeScript files in the repository
      var jsTsFiles = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories).Where(f => f.EndsWith(".js") || f.EndsWith(".ts"));

      try
      {
        foreach (var file in jsTsFiles)
        {
          // Read the content of each file
          string text = File.ReadAllText(file);

          // Count the occurrences of each letter
          foreach (char c in text)
          {
            char lowerChar = char.ToLower(c);
            if (occurrences.ContainsKey(lowerChar))
            {
              occurrences[lowerChar]++;
            }
          }
        }
      }
      // If a file is not found
      catch (FileNotFoundException ex)
      {
        Console.WriteLine("Error: The file was not found.");
        Console.WriteLine("Exception Message: " + ex.Message);
      }
      
      return occurrences;
    }
  }
}
