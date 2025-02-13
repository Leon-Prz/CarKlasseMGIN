using System;

namespace AutoNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Lastkraftwagen testen
            Console.WriteLine("=== Lastkraftwagen ===");
            Lastkraftwagen lkw = new Lastkraftwagen();
            Console.WriteLine(lkw);
            lkw.Belade(5000);
            lkw.KranBelade(1000);
            lkw.KranEntlade(500);
            lkw.Entlade(3000);

            // Kleintransporter testen
            Console.WriteLine("\n=== Kleintransporter ===");
            Kleintransporter transporter = new Kleintransporter();
            Console.WriteLine(transporter);
            transporter.Belade(800);
            transporter.Entlade(200);

            // Autobus testen
            Console.WriteLine("\n=== Autobus ===");
            Autobus bus = new Autobus();
            Console.WriteLine(bus);
            bus.Öffne();
            bus.Schließe();

            // Personenkraftwagen testen
            Console.WriteLine("\n=== Personenkraftwagen ===");
            Personenkraftwagen pkw = new Personenkraftwagen();
            Console.WriteLine(pkw);
            pkw.Beschleunigen();

        }
    }
}