using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

    [TestMethod]
    public void CorrectLetterCounts()
    {
      string path = Directory.GetCurrentDirectory();

      var result = letterOccurances.Program.LetterCount(path);

      var expected = new Dictionary<char, int>
      {
        {'a', 47255},
        {'b', 13838},
        {'c', 29028},
        {'d', 17151},
        {'e', 71155},
        {'f', 13295},
        {'g', 7100},
        {'h', 14506},
        {'i', 27393},
        {'j', 4780},
        {'k', 2952},
        {'l', 27375},
        {'m', 14404},
        {'n', 31804},
        {'o', 39815},
        {'p', 18113},
        {'q', 2024},
        {'r', 40045},
        {'s', 36355},
        {'t', 57958},
        {'u', 24065},
        {'v', 5652},
        {'w', 3615},
        {'x', 7218},
        {'y', 8758},
        {'z', 883}
      };

      CollectionAssert.AreEquivalent(expected, result);
    }
  }
}
