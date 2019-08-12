using System;
using Week1.Domain;

namespace Week1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type word to be tested: ");
            Palindrome p = new Palindrome();
            string s = System.Console.ReadLine();
            //Palindrome p = new PalindromeCheck(s);
            //Palindrome.PalindromeCheck(s)
            //string test = Palindrome.PalindromeCheck(s);
            if(p.PalindromeCheck(s))
            {
              System.Console.WriteLine(s + " is a Palindrome.");
            }
            else
            {
              System.Console.WriteLine(s + " is not a Palindrome...");
            }

        }

        /* private static string Palindrome(string s)
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
        }*/
    }
}
