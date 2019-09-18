using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivalasztas
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] honapok = new string[] {"Jan","Feb","Marc","Apr","Maj","Jun",
                                       "Jul","Aug","Szept","Okt","Nov","Dec" };

      for (int i = 0; i < honapok.Length; i++)
      {
        Console.Write("{0}, ",honapok[i]);
      }

      Console.Write("\nKérek egy hónapot a fenti lista alapján: ");
      string honap = Console.ReadLine();

      int hely = 0;

      while (honapok[hely] != honap)
      {
        hely++;
      }

      Console.WriteLine("Ez a {0}-dik hónap.",hely + 1);

      Console.ReadLine();
    }
  }
}
