using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

					
public class Program
{
	public static void Main()
	{
  
             string[] zipCodes = { "3342", "2324", "2334", "3444", "5667", "5565", "5677", "7777", "8765", "5645" };

            Console.Write("Enter zip code - ");
            string code = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < zipCodes.Length; i++)
            {
                if (code == zipCodes[i])
                {
                    found = true;
                    break;
                }
            }
            if (found == true)
            {
                Console.WriteLine("This zip code is valid, ship to this zip code.");
            }
            else
            {
                Console.WriteLine("This zip code is invalid, do not ship to this zip code.");
            }

    }
}
	
