using System;

namespace Tehtävä_5._1_Valuuttalaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esitellään muuttujat, henkilö valitsee
            int luku;
            double valuutta;
            Console.WriteLine("VALUUTTALASKURI");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.Write("Anna summa euroina? ");
            // Kysytty henkilöltä, muunettu ja tallennettu muuttujan arvoksi
            valuutta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vastaa 1 jos haluat muuntaa dollareiksi ja 2 jos haluat muuntaa punniksi? ");
            
            //Kysytty henkilöltä 1 tai 2 ja merkkijono muutetaan kokonaisluvuksi ja tallenetaan lukuun
            luku = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //perustettu oma alueen {} luku 1 on dollari. muutetaan luku -> String.Format käskyllä stringiksi ja laskukaava sekä + $
            if (luku == 1)
            {
                Console.WriteLine(String.Format("{0:0.00}",valuutta * 1.21) + " $ ");
            }
            else if (luku == 2)
            {
                Console.WriteLine(String.Format("{0:0.00}",valuutta * 0.87) + " £ ");
            }
            


        }
    }
}
