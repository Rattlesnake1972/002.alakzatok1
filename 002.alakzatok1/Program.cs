using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.alakzatok1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 11; i++)
            {
                Console.Write("o");
            }

            Console.ReadKey();
        }
    }
}

/*Ez a C# kód egy konzolos alkalmazás, amely két alakzatot jelenít meg a képernyőn. A program egy egyszerű for ciklust használ arra, hogy a két alakzatot a konzol ablakban jelenítse meg.

A program először egy sor csillagot rajzol ki a konzolra a for ciklus segítségével. A for ciklus 0-tól kezdve 11-ig számol, és minden egyes lépésben kiír egy * karaktert a konzolra. Ezután egy új sort kezd a Console.WriteLine("\n") metódus segítségével.

A következő for ciklus hasonlóan működik, de ezúttal a o karaktereket írja ki a konzolra, szintén 0-tól kezdve 11-ig.

Végül a Console.ReadKey() metódus segítségével várakoztatja a programot, amíg a felhasználó meg nem nyomja a billentyűzet valamelyik gombját. Ezután a program befejeződik, és a konzol ablak bezárul.*/
