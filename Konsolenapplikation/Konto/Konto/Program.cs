using System;
using System.Text.Json;
using System.Collections;

namespace Konto
{
    class Program
    {
        static void Main(string[] args)
        {
            // boolean for while loop state
            bool addKonto = true;

            // arrayList kontonummer
            ArrayList kontoNrArray = new ArrayList();
            // arrayList bankleiZahl
            ArrayList blzArray = new ArrayList();
            // arrayList kontostand
            ArrayList kontostandArray = new ArrayList();


            // while loop to add kontostand data to List
            while (addKonto == true)
            {
                bool kontoNr = true;
                while (kontoNr = true) {

                    // User Input Kontonummer
                    Console.WriteLine("Kontonummer eingeben:");
                    string kontoNummerInput = Console.ReadLine();
                    int kontoNummer;
                    bool succesNumber = int.TryParse(kontoNummerInput, out kontoNummer);

                    if (kontoNummer.ToString().Length < 7)
                    {
                        Console.WriteLine(kontoNummer.ToString().Length);
                        Console.WriteLine("Kontonummer zu klein!!");
                        kontoNr = true;
                    }
                    else if (Math.Floor(Math.Log10(kontoNummer) + 1) > 9)
                    {
                        Console.WriteLine("Kontonummer zu groß!!");
                        kontoNr = true;
                    }
                    else
                    {
                        if (succesNumber == true)
                        {
                            kontoNrArray.Add(kontoNummer);
                            kontoNr = false;
                        }
                        else
                        {
                            kontoNr = true;
                        }
                    }
                }

                // User Input Bankleizahl
                bool blz = true;
                while (blz = true)
                {
                    Console.WriteLine("Bankleizahl eingeben:");

                    string bankNrInput = Console.ReadLine();
                    int bankleiZahl;

                    bool successBankNr = int.TryParse(bankNrInput, out bankleiZahl);

                    if (bankleiZahl < 0 || bankleiZahl > 9999)
                    {
                        Console.WriteLine("Bankleizahl ungültig!!");
                        blz = true;
                    }
                    if (successBankNr == true)
                    {
                        blzArray.Add(bankleiZahl);
                        blz = false;
                    }
                    else
                    {
                        blz = true;
                    }
                }
              
               

                // User Input Kontostand
                Console.WriteLine("Kontostand eingeben:");

                string kontostandInput = Console.ReadLine();
                int kontostand;

                bool successKonto = int.TryParse(kontostandInput, out kontostand);
                if (successKonto == true)
                {
                    kontostandArray.Add(kontostand);
                }
                else
                {

                }

                // sort array by Kontonummer with Bubblesort
                kontoNrArray.Sort();
                // sort array by Kontostand with Bubblesort
                kontostandArray.Sort();
                //Show list on console
                Console.WriteLine("Kontonummer");
                foreach (int i in kontoNrArray) {
                    Console.WriteLine(i);
                }
                Console.WriteLine();

                Console.WriteLine("BLZ");
                foreach (int i in blzArray)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();

                Console.WriteLine("Kontostand");
                foreach (int i in kontostandArray)
                {
                    Console.WriteLine(i);
                }
                //foreach(var i in KontoList)
                //{
                //Console.WriteLine(i);
                //}

                Console.WriteLine("Einen weiteren Namen eingeben? Y=Yes/N=No");

                string desicion = Console.ReadLine();

                if (desicion.StartsWith("y") || desicion.StartsWith("Y"))
                {
                    addKonto = true;
                }
                else if (desicion.StartsWith("n") || desicion.StartsWith("N"))
                {
                    addKonto = false;
                }
            }
        }
    }
}

