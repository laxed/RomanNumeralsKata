using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.Write("Write a number ('quit' to quit): ");
        var s = Console.ReadLine();
        if (s == "quit") return;
        int n;
        var validInt = Int32.TryParse(s, out n);
        if (validInt && n < 3001 && n > 0)
        {
          var roman = IntToNumeralConverter.Convert(n);
          Console.WriteLine("Converted: {0}", roman);
        }
        else
          Console.WriteLine("Not a valid number. Numbers from 1 to 3000 are supported. Try again.");
      }
    }
  }
}
