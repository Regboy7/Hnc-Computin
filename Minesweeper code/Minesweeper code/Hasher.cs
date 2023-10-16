using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_code
{
    class Hasher
    {
        public static string Hash(string plainText, int hashLength)
        {
            int? seed = 0;
            char[] charArr = plainText.ToCharArray();

            int i = 1;
            foreach (char c in charArr)
            {
                seed = seed * charArr.Length + Convert.ToInt32(c) % 7919; // CALCULATION: seed = seed * size_of_list + ASCII_Value MOD any_large_prime
                i++;
            }

            Random rnd = new Random(Convert.ToInt32(seed));
            string hash = "";

            for (i = 0; i < hashLength; i++)
            {
                hash = hash + Convert.ToChar(rnd.Next(42, 122));
            }
            //Console.WriteLine("Hash: " + hash); //Writes Hash
            return hash;
        }
    }
}
