using System;
using System.Text.RegularExpressions;

public static class RemoveVowel
{
  public static string Disemvowel(string str)
  {
    return new Regex("(?i)[a|i|u|e|o]+").Replace(str, "");
  }
}