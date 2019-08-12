using System;

namespace Week1.Domain
{
    public class Palindrome
    {
      public bool PalindromeCheck(string s)
      {
        System.Console.WriteLine("Test");
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        string s2 = new string(arr);
        System.Console.WriteLine(s2 + " Test");
        if(Equals(s,s2))
        {
          return true;
        }
        else
        {
          return false;
        }
      }
    }
}
