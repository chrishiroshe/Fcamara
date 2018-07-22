using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string _readSoldiers = Console.ReadLine();
            short _countSoldiers = 0;
            System.Int16.TryParse(_readSoldiers, out _countSoldiers);
            if (_countSoldiers != 0)
            {
                var _retLiveSoldier = ReturnWhoLives(_countSoldiers);
                Console.WriteLine(_retLiveSoldier.ToString());
            }
            else
                Console.WriteLine("Programa não funciona, não é um numerico");
            Console.ReadKey();
        }
        public static short ReturnWhoLives(short countSoldiers)
        {
            ArrayList arrSoldiers = new ArrayList();
            for (short i = 1; i <= countSoldiers; i++)
                arrSoldiers.Add(i);

            int counter = arrSoldiers.Count-1;

            while (arrSoldiers.Count > 1)
            {
                counter = arrSoldiers.Count;
                for (int i=0; i < counter; i++)
                {
                    if ( i == counter - 1)
                    {
                        arrSoldiers.RemoveAt(0);
                        break;
                    }
                    arrSoldiers.RemoveAt(i + 1);
                   
                   counter = arrSoldiers.Count;
                }
            }
            return (short)arrSoldiers[0];

        }
    }
}
