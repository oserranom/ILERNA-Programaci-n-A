using System;

namespace PAC1_UF1_OSM
{
    class Program
    {
        static void Main(string[] args)
        {
            string ilernaChain = "ilerna online programacion a 1º semestre 2023";

            ilernaChain = ilernaChain.ToUpper();
            string nospaces = "";

            for (int i = 0; i < ilernaChain.Length; i++)
                if (ilernaChain[i] != ' ')
                {
                    nospaces += ilernaChain[i];
                }

            Console.WriteLine(nospaces);

            //Ejercicio 1


            int contCons = 0;

            for (int i = 0; i < nospaces.Length; i++)
            {

                if (nospaces[i] == 'L' || nospaces[i] == 'R' || nospaces[i] == 'N' || nospaces[i] == 'P' || nospaces[i] == 'G' || nospaces[i] == 'M' || nospaces[i] == 'C'
                    || nospaces[i] == 'S' || nospaces[i] == 'T')
                    contCons++;
            }
            Console.WriteLine(contCons);


            //Ejercicio 2

            int contNum = 0;

            for (int i = 0; i < nospaces.Length; i++)
            {

                if (nospaces[i] == '0' || nospaces[i] == '1' || nospaces[i] == '2' || nospaces[i] == '3')
                    contNum++;
            }
            Console.WriteLine(contNum);

            //Ejercicio 3

            string consonantes = "";

            for (int i = 0; i < nospaces.Length; i++)
            {
                if (nospaces[i] == 'L' || nospaces[i] == 'R' || nospaces[i] == 'N' || nospaces[i] == 'P' || nospaces[i] == 'G' || nospaces[i] == 'M' || nospaces[i] == 'C'
                    || nospaces[i] == 'S' || nospaces[i] == 'T')
                {
                    consonantes += nospaces[i];
                }
            }


            Console.WriteLine(consonantes.ToLower());

            //Ejercicio 4
        
        }
    }
}
