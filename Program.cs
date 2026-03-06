public class Program
{
    // Lista iniziallizata vuota (pronta ad essere popolata).
    static List<Modello> listModello = [];
    public static void Main()
    {
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nScegli opzione:");
            Console.WriteLine("1 - Crea prodotti");
            Console.WriteLine("2 - Cancella prodotti");
            Console.WriteLine("3 - Modifica prodotti");
            Console.WriteLine("4 - Stampa Elenco prodotti");
            Console.WriteLine("5 - Esporta CSV prodotti");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    // CreaProdotti();
                    break;
                case 2:
                    CancellaProdotti();
                    break;
                case 3:
                    // ModificaProdotti();
                    break;
                case 4:
                    StampaElenco();
                    break;
                case 5:
                    EsportaCSV(listModello);
                    break;
                case 0:
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida!");
                    break;
            }
        }
        Console.WriteLine("Programma terminato.");
    }

    static void InizializzaLista()
    {
        // --- INSERT DIARIO ---
        listModello.Add(new Diario(21.0f, 14.8f, 15.50m, TipoEnum.Opaca, true));

        listModello.Add(new Diario(15.0f, 10.0f, 9.90m, TipoEnum.Satinata, false));

        // --- INSERT QUADERNO ---
        listModello.Add(new Quaderno(29.7f, 21.0f, 2.50m, TipoEnum.Liscia, "Quadretti 5mm"));

        listModello.Add(new Quaderno(29.7f, 21.0f, 2.80m, TipoEnum.Ruvida, "Righe A"));

        // --- INSERT CALENDARIO ---
        listModello.Add(new Calendario(42.0f, 29.7f, 12.00m, TipoEnum.Vergata, true));

        listModello.Add(new Calendario(10.0f, 10.0f, 5.00m, TipoEnum.Goffrata, false));
    }

    public static void EsportaCSV(List<Modello> listModello)
    {
        string percorso = "prodotti.csv";

        using (StreamWriter sw = new StreamWriter(percorso))
        {
            // intestazione CSV
            sw.WriteLine("Nome");
            foreach (Modello s in listModello)
            {
                sw.WriteLine(s.ToCsv());
            }
        }
        Console.WriteLine("File CSV creato con successo!");
    }

    public static void IndiceProdotti()
    {
        Console.WriteLine($"\nElenco prodotti");
        for (int i = 0; i < listModello.Count; i++)
        {
            Console.WriteLine($"{i} {listModello[i]}");
        }
    }

    public static void CancellaProdotti()
    {
        IndiceProdotti();
        Console.WriteLine($"Inserisci l'indice da eliminare");
        int idx = int.Parse(Console.ReadLine());
        if (idx >= 0 && idx < listModello.Count)
        {
            listModello.RemoveAt(idx);
            Console.WriteLine($"Prodotto rimosso.");
        }
        else
        {
            Console.WriteLine($"Prodotto non trovato.");
        }
    }

    public static void StampaElenco()
    {
        Console.WriteLine($"\nElenco: ");
        foreach (var p in listModello)
        {
            //controllare metodi per stampa info
        }
    }
}