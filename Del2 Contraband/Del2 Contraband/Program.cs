using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del2_Contraband
{
    class Program
    {
        static void Main(string[] args)

        {
            //List<int> cars = new List<int>();
            Console.WriteLine("Hur många bilar ska skapas?");

            int answer = LimitedRangeInt("Du måste skriva ett heltal", "Du måste skriva mer än 0", 1);

            Console.ReadLine();

            int i = 0;
            while (i<answer) //Körs så många gånger som svaret
            {
                Car car = new Car();
               // cars.Add();
                i++;

            }



        }
        //Tvingar användaren att skriva in ett heltal
        public static int ParseIntMethod(string message)
        {
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine().Trim(), out int result))
                    return result;

                Console.WriteLine(message);
            }
        }
        // Tvingar användaren att skriva en int med ett minsta värde, samt tar med information från parse int metoden
        public static int LimitedRangeInt(string parseIntMessage, string toLow,  int minValue)
        {
            while (true)
            {

                int answer = ParseIntMethod(parseIntMessage);

                if (answer < minValue)
                {
                    Console.WriteLine(toLow);
                }

                else
                {
                    return answer;
                }
            }
        }
    }
}
