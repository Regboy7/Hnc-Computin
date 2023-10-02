using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the secret word");
            string SecretWord = Console.ReadLine();
            char[] charlist = SecretWord.ToCharArray();
            foreach (char s in charlist)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }

}
