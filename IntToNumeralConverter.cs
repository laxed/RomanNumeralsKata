using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
  public class IntToNumeralConverter
  {
    public static string Convert(int n)
    {
      if (n > 3000) throw new ArgumentException("Number greater than supported", "n");
      if (n < 0) throw new ArgumentException("Negative numbers not supported", "n");
      StringBuilder result = new StringBuilder();
      int remainder = n;
      remainder = processNumber(result, remainder, 1000, "M", null, null);
      remainder = processNumber(result, remainder, 100, "C", "D", "M");
      remainder = processNumber(result, remainder, 10, "X", "L", "C");
      processNumber(result, remainder, 1, "I", "V", "X");
      return result.ToString();
    }

    private static int processNumber(StringBuilder result, int remainder, int devisor, string small, string middle, string big)
    {
      int count = remainder / devisor;
      result.Append(convertNumberToString(count, small, middle, big));
      remainder = remainder - count * devisor;
      return remainder;
    }

    static string convertNumberToString(int n, string small, string middle, string big)
    {
      if (n <= 3) return repeat(small, n);
      if (n == 4) return small + middle;
      if (n < 9) return middle + convertNumberToString(n-5, small, middle, big);
      if (n == 9) return small + big;
      throw new ArgumentException("Number greater than supported", "n");
    }

    static string repeat(string s, int n)
    {
      string r = "";
      for (int i = 0; i < n; i++)
        r += s;
      return r;
    }
  }
}
