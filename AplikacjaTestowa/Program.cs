// import przestrzeni nazw
using System;                   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  przestrzeń nazw w której się poruszamy
namespace AplikacjaTestowa
{
    // deklaracja klasy
    class Program
    {
        // deklaracja metody
        static void Main(string[] args)
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);
            Console.WriteLine(feetToInchesConverter.Convert(30)); // 360
            Console.WriteLine(feetToInchesConverter.Convert(100)); // 1200
            Console.WriteLine(feetToInchesConverter.Convert(
            milesToFeetConverter.Convert(1))); // 63360

            // UseUmbrella
            Console.WriteLine(Test.UseUmbrella(true, true, true));

            //sekwencje specjalne(ang.escape sequences)
            Console.WriteLine("abec\nadlo");    //abec
                                                //adlo

           
            Test.Wypisanie();
            Test.Odwrocenie();

            Console.ReadKey();
        }
    }
    public class UnitConverter
    {
        int ratio; // pole
        public UnitConverter(int unitRatio) { ratio = unitRatio; } // konstruktor
        public int Convert(int unit) { return unit * ratio; } // metoda
    }
    //klasa testowa
    public class Test
    {
        public static bool UseUmbrella(bool rainy, bool sunny, bool windy)
        {
            return !windy && (rainy || sunny);
        }

        //operatorem trójargumentowym — ang. ternary operator (if(a>b){a}else{b})
        public static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // Metoda 1234 123 12 1
        public static void Wypisanie()
        { 

            for (int i = 1; i < 5; i++)
            {
                
                for (int j = 4; j > 0; j--)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }


        }

        // Metoda odwracająca napis
        public static void Odwrocenie()
        {
            Console.WriteLine("Podaj słowo do odwrócenia:");
           string slowo= Console.ReadLine();
            char[] c = slowo.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine(c);
        } 
    }
}
