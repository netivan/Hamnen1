using System;
using System.Collections.Generic;

namespace Hamnen
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Båt> HamnRegister = new List<Båt>();

            Kaj.initKaj();

            for (int day = 1; day < 6; day++)
            {
                Console.WriteLine($"Dag {day}");

                for (int i = 0; i < 5; i++)
                {
                    Båt b = new Båt(day);
                    b.kajPlats = Kaj.insertBåt(b.hamnplats);
                    
                    HamnRegister.Add(b);

                    Console.WriteLine(b.message1());

                    Kaj.stampa();

                    Console.ReadLine();
                }
                
            }

            
           
        }
    }
}
