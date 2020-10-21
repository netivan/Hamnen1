using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen
{
    class Kaj
    {

        public static string kaj;
         public static void initKaj()
        {
            for (int i = 0; i < 64; i++)
                kaj += ".";  
        } 

        public static void stampa()
        {
            Console.WriteLine(kaj);
        }

        public static int insertBåt(string HP)
        {
            string freePlats = ".....".Substring(1, HP.Length);

            if (HP == "H" )

            {
                int postoH = kaj.IndexOf("H");

                if (postoH >= 0)
                {
                    string x = kaj.Remove(postoH, 1);

                    kaj = x.Insert(postoH, "F");

                    return postoH;
                }
            }
            int posto = kaj.IndexOf(freePlats);
            if (posto >= 0)
            {

                string x = kaj.Remove(posto, HP.Length);

                kaj = x.Insert(posto, HP);
            }
            Console.WriteLine(posto);

            return posto ;







        }
    }
    
}
