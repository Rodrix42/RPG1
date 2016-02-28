using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Log
    {
        public static void Update(List<Character> AllCharacters)
        {
            Console.Clear();
            Console.WriteLine("_____________");
            Console.WriteLine("Команда 1 :");
            Console.WriteLine("ХП палладина -" + AllCharacters [0].hp);
            Console.WriteLine("ХП Шамана -" + AllCharacters [4].hp);
            Console.WriteLine("ХП Жреца -" + AllCharacters[6].hp);
            Console.WriteLine("ХП Вора -" + AllCharacters[2].hp);
            Console.WriteLine("_____________");
            Console.WriteLine("Команда 2 :");
            Console.WriteLine("ХП палладина -" + AllCharacters[1].hp);
            Console.WriteLine("ХП Шамана -" + AllCharacters[5].hp);
            Console.WriteLine("ХП Жреца -" + AllCharacters[7].hp);
            Console.WriteLine("ХП Вора -" + AllCharacters[3].hp);
            Console.WriteLine("_____________");
        }
    }
}
