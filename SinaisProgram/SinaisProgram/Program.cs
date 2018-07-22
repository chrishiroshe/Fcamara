using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinaisProgram
{
    class Program
    {
        static void Main(string[] args)
        { 
            string readSigns = Console.ReadLine();
            if (!String.IsNullOrEmpty(readSigns))
            {
                var retSigns = ReturnSigns(readSigns);
                Console.WriteLine(retSigns.ToString());
            }
            else
                Console.WriteLine("Texto nao pode ser vazio");

            Console.ReadKey();
        }
        public static bool ReturnSigns(string signs)
        {
            Dictionary<char, char> dicChar = new Dictionary<char, char>() ;
            dicChar.Add('[', ']');
            dicChar.Add('(', ')');
            dicChar.Add('{', '}');
          
            int countLength = signs.Length;
            int midCount = countLength / 2;
            var arrSigns = signs.ToCharArray();
            int actualCounter = countLength - 1;
            for (int i = 0; i < midCount-1; i++ )
            {
                for (int x = actualCounter; x > midCount; x--)
                {
                    if (!dicChar.ContainsKey(arrSigns[i]) || dicChar[arrSigns[i]] != arrSigns[x])
                    {
                        return false;
                    }
                    actualCounter = x-1;
                    break;
                }
            }
            return true;

        }
    }
}
