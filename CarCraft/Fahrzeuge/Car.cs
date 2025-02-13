using System;

namespace AutoNamespace
{
    public enum Kraftstoffart
    {
        Benzin,
        Diesel
    }

    public class Car 

    {
    public string Farbe { get; private set; }
    public int Leistung { get; private set; }
    public int Hoechstgeschwindigkeit { get; private set; }
    public double MaxTankinhalt { get; private set; }
    public double Kraftstoffstand { get; private set; }
    public Kraftstoffart Kraftstoff { get; private set; }

    // Standardkonstruktor
    public Car() : this("Weiß", 100, 150, 50, Kraftstoffart.Benzin)
    {
    }

    // Konstruktor mit Farbe und Leistung
    public Car(string farbe, int leistung) : this(farbe, leistung, 150, 50, Kraftstoffart.Benzin)
    {
    }

    // Vollständiger Konstruktor
    public Car(string farbe, int leistung, int hoechstgeschwindigkeit, double maxTankinhalt,
        Kraftstoffart kraftstoffart)
    {
        Farbe = farbe;
        Leistung = leistung;
        Hoechstgeschwindigkeit = Math.Clamp(hoechstgeschwindigkeit, 0, 260);
        MaxTankinhalt = Math.Clamp(maxTankinhalt, 20, 100);
        Kraftstoffstand = MaxTankinhalt;
        Kraftstoff = kraftstoffart;
    }

    // Beschleunigen-Methode
    public void Beschleunigen()
    {
        if (Kraftstoffstand <= 0)
        {
            Console.WriteLine("Tank ist leer! Das Auto bleibt stehen.");
            return;
        }

        Kraftstoffstand = Math.Max(Kraftstoffstand - 0.2, 0);

        if (Kraftstoffstand < MaxTankinhalt * 0.1)
            Console.WriteLine("Warnung: Kraftstoffstand unter 10%!");
    }

    // Tanken-Methode
    public void Tanken(Kraftstoffart kraftstoffart, double menge)
    {
        if (kraftstoffart != Kraftstoff)
        {
            Console.WriteLine("Falsche Kraftstoffart! Der Tankvorgang wurde abgebrochen.");
            return;
        }

        Kraftstoffstand = Math.Min(Kraftstoffstand + menge, MaxTankinhalt);
        Console.WriteLine($"Tank erfolgreich aufgefüllt: {Kraftstoffstand:F2}/{MaxTankinhalt} l.");
    }

    public override string ToString()
    {
        return
            $"Farbe: {Farbe}, Leistung: {Leistung} PS, Höchstgeschwindigkeit: {Hoechstgeschwindigkeit} km/h, Tank: {Kraftstoffstand:F2}/{MaxTankinhalt} l, Kraftstoffart: {Kraftstoff}";
    }

    }
}

