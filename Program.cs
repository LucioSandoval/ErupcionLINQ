
class Program
{
    static void Main()
    {
        // Crear instancias de la clase Human
        List<Eruption> eruptions = new List<Eruption>()
    {
        new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
        new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
        new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
        new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
        new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
        new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
        new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
        new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
        new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
        new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
        new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
        new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
        new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
    };
        // Example Query - Prints all Stratovolcano eruptions
        IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
        PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
        // Execute Assignment Tasks here!

        // Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
        static void PrintEach(IEnumerable<dynamic> items, string msg = "")
        {
            Console.WriteLine("\n" + msg);
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        Eruption chileEruption = eruptions.FirstOrDefault(e => e.Location == "Chile");
    if (chileEruption != null)
    {
        Console.WriteLine("Primera erupción en Chile:");
        Console.WriteLine(chileEruption);
    }
    else
    {
        Console.WriteLine("No se encontraron erupciones en Chile.");
    }

    Eruption hawaiianIsEruption = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is");
if (hawaiianIsEruption != null)
{
    Console.WriteLine("Primera erupción en Hawaiian Is:");
    Console.WriteLine(hawaiianIsEruption);
}
else
{
    Console.WriteLine("No se encontraron erupciones en Hawaiian Is.");
}

Eruption nzEruption = eruptions.FirstOrDefault(e => e.Year > 1900 && e.Location == "New Zealand");
if (nzEruption != null)
{
    Console.WriteLine("Primera erupción después de 1900 en New Zealand:");
    Console.WriteLine(nzEruption);
}
else
{
    Console.WriteLine("No se encontraron erupciones en New Zealand después de 1900.");
}

IEnumerable<Eruption> highElevationEruptions = eruptions.Where(e => e.ElevationInMeters > 2000);
Console.WriteLine("Erupciones con elevación superior a 2000 m:");
PrintEach(highElevationEruptions);

IEnumerable<Eruption> startsWithLEruptions = eruptions.Where(e => e.Volcano.StartsWith("L"));
Console.WriteLine("Erupciones cuyo nombre de volcán comienza con 'L':");
PrintEach(startsWithLEruptions);
int count = startsWithLEruptions.Count();
Console.WriteLine($"Número de erupciones encontradas: {count}");

int maxElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine($"La elevación más alta es: {maxElevation} metros");

string volcanoWithMaxElevation = eruptions.FirstOrDefault(e => e.ElevationInMeters == maxElevation)?.Volcano;
if (!string.IsNullOrEmpty(volcanoWithMaxElevation))
{
    Console.WriteLine($"Volcán con la elevación más alta: {volcanoWithMaxElevation}");
}
else
{
    Console.WriteLine("No se encontró un volcán con la elevación más alta.");
}

IEnumerable<string> volcanoNames = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano);
Console.WriteLine("Nombres de los volcanes en orden alfabético:");
foreach (string name in volcanoNames)
{
    Console.WriteLine(name);
}


IEnumerable<Eruption> eruptionsBefore1000CE = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
Console.WriteLine("Erupciones antes del año 1000 CE en orden alfabético:");
PrintEach(eruptionsBefore1000CE);


IEnumerable<string> volcanoNamesBefore1000CE = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano);
Console.WriteLine("Nombres de los volcanes antes del año 1000 CE en orden alfabético:");
foreach (string name in volcanoNamesBefore1000CE)
{
    Console.WriteLine(name);
}


    }
}
