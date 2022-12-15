using System;
using System.Collections.Generic;

namespace NGC3628
{
    class Program
    {
        public void listAllLakok(List<NGC> lakok)
        {
            for (int i = 0; i < lakok.Count; i++)
            {
                Console.WriteLine(lakok[i].nezet + " - " + lakok[i].kedv);
            }
        }

        static void Main(string[] args)
        {
            // 0-66 - atl
            // 67-87 - opt
            // 88-100 - pessz
            List<NGC> lakok = new List<NGC>() { };

            for (int i = 0; i < 101; i++)
            {
                Random random = new Random();
                int nezetRand = random.Next(0, 101);
                int kedvRand = 0;
                if (i >= 0 && i <= 66)
                {
                    // atl
                    kedvRand = random.Next(0, 101);
                    lakok.Add(new NGC(kedvRand, "atl"));
                }
                else if (i >= 67 && i <= 87)
                {
                    // opt
                    kedvRand = random.Next(60, 101);
                    lakok.Add(new NGC(kedvRand, "opt"));
                }
                else if (i >= 88 && i <= 100)
                {
                    // pessz
                    kedvRand = random.Next(0, 21);
                    lakok.Add(new NGC(kedvRand, "pessz"));
                }
            }

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(lakok[i].nezet + " - " + lakok[i].kedv);
                Random random = new Random();
                int rand1 = random.Next(0, 101);
                int rand2 = random.Next(0, 101);

                Console.WriteLine("------------------------------");
                Console.WriteLine("FIRST GUY BEFORE MEETING: ");
                Console.WriteLine(lakok[rand1].nezet + " - " + lakok[rand1].kedv);
                Console.WriteLine("\n\n");
                Console.WriteLine("SECOND GUY BEFORE MEETING: ");
                Console.WriteLine(lakok[rand2].nezet + " - " + lakok[rand2].kedv);
                Console.WriteLine("\n\n");
                if (lakok[rand1].nezet == "opt")
                {
                    if(lakok[rand2].nezet == "atl")
                    {
                        lakok[rand2].setKedv((lakok[rand1].kedv+lakok[rand2].kedv)/2);
                    }
                    else if (lakok[rand2].nezet == "pessz")
                    {
                        lakok[rand2].setKedv(lakok[rand2].kedv / 2);
                    }
                }
                else if(lakok[rand1].nezet == "atl")
                {
                    lakok[rand1].setKedv((lakok[rand1].kedv + lakok[rand2].kedv) / 2);
                    if(lakok[rand2].nezet == "atl")
                        lakok[rand2].setKedv((lakok[rand1].kedv + lakok[rand2].kedv) / 2);
                }
                else if(lakok[rand1].nezet == "pessz")
                {
                    if(lakok[rand2].nezet == "opt")
                        lakok[rand1].setKedv(lakok[rand1].kedv / 2);
                    if (lakok[rand2].nezet == "atl")
                        lakok[rand2].setKedv((lakok[rand1].kedv + lakok[rand2].kedv) / 2);
                }
                Console.WriteLine("Találkozás...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\n\n");
                Console.WriteLine("FIRST GUY AFTER MEETING: ");
                Console.WriteLine(lakok[rand1].nezet + " - " + lakok[rand1].kedv);
                Console.WriteLine("\n\n");
                Console.WriteLine("SECOND GUY AFTER MEETING: ");
                Console.WriteLine(lakok[rand2].nezet + " - " + lakok[rand2].kedv);
                Console.WriteLine("\n\n");
                int sumKedv = 0;
                for (int j = 0; j < lakok.Count; j++)
                {
                    sumKedv += lakok[j].kedv;
                }
                Console.WriteLine("Összes kedv összeadva: " + sumKedv);
            }

        }
    }
}
