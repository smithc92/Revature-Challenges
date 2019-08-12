using System;

namespace Week1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type word to be tested: ");
            String s = System.Console.ReadLine();
            if(Equals(Palindrome(s),"true"))
            {
              System.Console.WriteLine(s + " is a Palindrome.");
            }
            else
            {
              System.Console.WriteLine(s + " is not a Palindrome...");
            }

        }

        private static string Palindrome(string s)
        {
          System.Console.WriteLine("Test");
          char[] arr = s.ToCharArray();
          Array.Reverse(arr);
          String s2 = new string(arr);
          System.Console.WriteLine(s2 + " Test");
          if(Equals(s,s2))
          {
            return "true";
          }
          else
          {
            return "false";
          }
        }
    }
}
