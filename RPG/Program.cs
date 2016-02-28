using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Character p1 = new Palladin(800, 400, 80);
            Character p2 = new Palladin(800, 400, 80);
            Character r1 = new Rogue(360, 280, 100);
            Character r2 = new Rogue(360, 280, 100);
            Character sh1 = new Shaman(500, 700, 50);
            Character sh2 = new Shaman(500, 700, 50);
            Character pr1 = new Priest(400, 900, 30);
            Character pr2 = new Priest(400, 900, 30);
            List<Character> AllCharacters = new List<Character>();
            AllCharacters.Add(p1);
            AllCharacters.Add(p2);
            AllCharacters.Add(r1);
            AllCharacters.Add(r2);
            AllCharacters.Add(sh1);
            AllCharacters.Add(sh2);
            AllCharacters.Add(pr1);
            AllCharacters.Add(pr2);
            Console.WriteLine("Добро пожаловать в игру.");
            Console.WriteLine("Для продолжения напишите start.");
            string start = Console.ReadLine();
            if (start == "start")
            {
                while (p2.hp + r2.hp + sh2.hp + pr2.hp > 0)
                {
                    Log.Update(AllCharacters);
                    Console.WriteLine("Кто будет бить?");
                    Console.WriteLine("1.Палладин");
                    Console.WriteLine("2.Жрец");
                    Console.WriteLine("3.Шаман");
                    Console.WriteLine("4.Вор");
                    string answ = Console.ReadLine();
                    switch (answ)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Кого бить?");
                            Console.WriteLine("1.Палладин");
                            Console.WriteLine("2.Жрец");
                            Console.WriteLine("3.Шаман");
                            Console.WriteLine("4.Вор");
                            string answ1 = Console.ReadLine();
                            Console.Clear();
                            switch (answ1)
                            {
                                case "1":
                                    p1.target = p2;
                                    p1.attack();
                                    Console.WriteLine("У палладина осталось {0} ХП", p2.hp);
                                    Console.ReadLine();
                                    break;
                                case "2":
                                    p1.target = pr2;
                                    p1.attack();
                                    Console.WriteLine("У жреца осталось {0} ХП", pr2.hp);
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    p1.target = sh2;
                                    p1.attack();
                                    Console.WriteLine("У шамана осталось {0} ХП", sh2.hp);
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    p1.target = r2;
                                    p1.attack();
                                    Console.WriteLine("У вора осталось {0} ХП", r2.hp);
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Кого бить?");
                            Console.WriteLine("1.Палладин");
                            Console.WriteLine("2.Жрец");
                            Console.WriteLine("3.Шаман");
                            Console.WriteLine("4.Вор");
                            string answ2 = Console.ReadLine();
                            Console.Clear();
                            switch (answ2)
                            {
                                case "1":
                                    pr1.target = p2;
                                    pr1.attack();
                                    Console.WriteLine("У палладина осталось {0} ХП", p2.hp);
                                    Console.ReadLine();
                                    break;
                                case "2":
                                    pr1.target = pr2;
                                    pr1.attack();
                                    Console.WriteLine("У жреца осталось {0} ХП", pr2.hp);
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    pr1.target = sh2;
                                    pr1.attack();
                                    Console.WriteLine("У шамана осталось {0} ХП", sh2.hp);
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    pr1.target = r2;
                                    pr1.attack();
                                    Console.WriteLine("У вора осталось {0} ХП", r2.hp);
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Кого бить?");
                            Console.WriteLine("1.Палладин");
                            Console.WriteLine("2.Жрец");
                            Console.WriteLine("3.Шаман");
                            Console.WriteLine("4.Вор");
                            string answ3 = Console.ReadLine();
                            Console.Clear();
                            switch (answ3)
                            {
                                case "1":
                                    sh1.target = p2;
                                    sh1.attack();
                                    Console.WriteLine("У палладина осталось {0} ХП", p2.hp);
                                    Console.ReadLine();
                                    break;
                                case "2":
                                    sh1.target = pr2;
                                    sh1.attack();
                                    Console.WriteLine("У жреца осталось {0} ХП", pr2.hp);
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    sh1.target = sh2;
                                    sh1.attack();
                                    Console.WriteLine("У шамана осталось {0} ХП", sh2.hp);
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    sh1.target = r2;
                                    sh1.attack();
                                    Console.WriteLine("У вора осталось {0} ХП", r2.hp);
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Кого бить?");
                            Console.WriteLine("1.Палладин");
                            Console.WriteLine("2.Жрец");
                            Console.WriteLine("3.Шаман");
                            Console.WriteLine("4.Вор");
                            string answ4 = Console.ReadLine();
                            Console.Clear();
                            switch (answ4)
                            {
                                case "1":
                                    r1.target = p2;
                                    r1.attack();
                                    Console.WriteLine("У палладина осталось {0} ХП", p2.hp);
                                    Console.ReadLine();
                                    break;
                                case "2":
                                    r1.target = pr2;
                                    r1.attack();
                                    Console.WriteLine("У жреца осталось {0} ХП", pr2.hp);
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    r1.target = sh2;
                                    r1.attack();
                                    Console.WriteLine("У шамана осталось {0} ХП", sh2.hp);
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    r1.target = r2;
                                    r1.attack();
                                    Console.WriteLine("У вора осталось {0} ХП", r2.hp);
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                    }
                }
            }
        }
    }

}
