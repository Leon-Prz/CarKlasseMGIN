using System;

namespace AutoNamespace
{
        public class Car
        {
            // Eigenschaften
            public string Farbe { get; private set; } 
            public int Leistung { get; private set; } 
            public int Geschwindigkeit { get; private set; } 
            public int Hoechstgeschwindigkeit { get; private set; } 
            public double MaxTankinhalt { get; private set; } 
            public double Kraftstoffstand { get; private set; } 
    
            // Konstruktor
            public Car(string farbe, int leistung, int hoechstgeschwindigkeit, double maxtankinhalt)
            {
                Farbe = farbe;
                Leistung = leistung;
                Geschwindigkeit = 0;
                Hoechstgeschwindigkeit = hoechstgeschwindigkeit;
                MaxTankinhalt = maxtankinhalt;
                Kraftstoffstand = maxtankinhalt;
            }
    
            
            public void Beschleunigen()
            {
                if (Kraftstoffstand <= 0)
                {
                    Console.WriteLine("Tank ist leer! Das Auto bleibt stehen.");
                    return;
                }
    
                Geschwindigkeit = Math.Min(Geschwindigkeit + 10, Hoechstgeschwindigkeit);
                Kraftstoffstand -= 0.2;
    
                if (Kraftstoffstand < MaxTankinhalt * 0.1 && Kraftstoffstand > 0)
                {
                    Console.WriteLine("Warnung: Kraftstoffstand unter 10%!");
                }
    
                if (Geschwindigkeit == Hoechstgeschwindigkeit)
                {
                    Console.WriteLine("Höchstgeschwindigkeit erreicht!");
                }
            }
    
            public void Bremsen()
            {
                if (Geschwindigkeit > 0)
                {
                    Geschwindigkeit = Math.Max(Geschwindigkeit - 10, 0);
                    Kraftstoffstand = Math.Max(Kraftstoffstand - 0.05, 0);
                }
                else
                {
                    Console.WriteLine("Das Auto steht bereits.");
                }
            }
    
            public void Vollbremsung()
            {
                Geschwindigkeit = 0;
                Console.WriteLine("Das Auto hat eine Vollbremsung durchgeführt und steht nun.");
            }
    
            public void Fahren()
            {
                if (Kraftstoffstand <= 0)
                {
                    Console.WriteLine("Tank ist leer! Das Auto bleibt stehen.");
                    return;
                }
    
                Kraftstoffstand -= 0.2;
    
                if (Kraftstoffstand < MaxTankinhalt * 0.1
                    && Kraftstoffstand > 0)
                {
                    Console.WriteLine("Warnung: Kraftstoffstand unter 10%!");
                }
            }
    
            public void Tanken()
            {
                Kraftstoffstand = MaxTankinhalt;
                Console.WriteLine("Tank ist jetzt voll.");
            }
    
            public override string ToString()
            {
                return $"Farbe: {Farbe}, Leistung: {Leistung} PS, Geschwindigkeit: {Geschwindigkeit} km/h, Höchstgeschwindigkeit: {Hoechstgeschwindigkeit} km/h, Tankinhalt: {Kraftstoffstand:F2}/{MaxTankinhalt} l";
            }
        }
} 

