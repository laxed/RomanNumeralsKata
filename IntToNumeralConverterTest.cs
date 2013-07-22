using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace RomanNumeralsKata
{
  public class IntToNumeralConverterTest
  {
    [Fact]
    public void Convert_Negative_Throws()
    {
      Assert.Throws<ArgumentException>(() => IntToNumeralConverter.Convert(-1));
    }
    
    [Fact]
    public void Convert_TooBig_Throws()
    {
      Assert.Throws<ArgumentException>(() => IntToNumeralConverter.Convert(3001));
    }

    [Theory]
    [PropertyData("TestCases")]
    public void Convert_SomeInt_CorrectNumeralString(int n, string expected)
    {
      var result = IntToNumeralConverter.Convert(n);
      Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> TestCases
    {
      get
      {
        return new[]
        {
          new object[] {1, "I"},
          new object[] {2, "II"},
          new object[] {4, "IV"},
          new object[] {5, "V"},
          new object[] {7, "VII"},
          new object[] {9, "IX"},
          new object[] {38, "XXXVIII"},
          new object[] {52, "LII"},
          new object[] {83, "LXXXIII"},
          new object[] {142, "CXLII"},
          new object[] {262, "CCLXII"},
          new object[] {890, "DCCCXC"},
          new object[] {1000, "M"},
          new object[] {1001, "MI"},
          new object[] {1954, "MCMLIV"},
          new object[] {1984, "MCMLXXXIV"},
          new object[] {1990, "MCMXC"},
          new object[] {2008, "MMVIII"},
          new object[] {2013, "MMXIII"},
        };
      }
    }
  }
}
