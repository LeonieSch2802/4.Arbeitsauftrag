using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Arbeitsauftrag
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Übung

            int zahl = 3;

            string[] namen = new string[zahl];

            zahl = zahl + 1;


            try
            {

                int sch = 0;
                int num = 0;
                while (sch < zahl)
                {
                    Console.WriteLine("Geben Sie einen Namen ein: ");
                    string name = Console.ReadLine();
                    namen[num] = name;
                    sch++;
                    num++;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //2. Übung

            int zahl1 = 10;
            int zahl2 = 0;

            try
            {
                Console.WriteLine(zahl1 / zahl2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }


            //3. Aufgabe


            try
            {
                Console.WriteLine("Geben Sie eine Zahl ein: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben Sie eine weitere Zahl ein: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 == 10 || num2 == 10)
                {
                    throw new Exception("10 ist nicht erlaubt");
                }
                else
                {
                    int ergebnis = num1 + num2;
                    Console.WriteLine("Ihr Ergebnis ist : {0}", ergebnis);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }






        }
    }
}
