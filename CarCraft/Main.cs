using System;

namespace AutoNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Auto erstellen
            Car auto = new Car("Rot", 150, 200, 50);

            Console.WriteLine("\nTest 1: Beschleunigen bis zur Höchstgeschwindigkeit");
            while (auto.Geschwindigkeit < auto.Hoechstgeschwindigkeit)
            {
                auto.Beschleunigen();
                Console.WriteLine(auto);
            }
            
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n Test 2: Bremsen bis zum Stillstand");
            while (auto.Geschwindigkeit > 0)
            {
                auto.Bremsen();
                Console.WriteLine(auto);
            }
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nTest 3: Beschleunigen bis der Tank leer ist");
            do
            {
                auto.Beschleunigen();
                Console.WriteLine(auto);
            } 
            while (auto.Kraftstoffstand > 0);

            auto.Fahren(); // Nochmals fahren um die "Tank ist leer"-Warnung zu sehen

            auto.Tanken();
            Console.WriteLine(auto);
        }
    }
}
