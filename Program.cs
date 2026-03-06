public class Program
{
    // Lista iniziallizata vuota (pronta ad essere popolata).
    static List<Modello> listModello = [];
    public static void Main()
    {
        
    }

    static void InizializzaLista() 
    {
        // --- INSERT DIARIO ---
        listModello.Add(new Diario(21.0f, 14.8f, 15.50m,TipoEnum.Opaca,true)); 

        listModello.Add(new Diario(15.0f, 10.0f, 9.90m, TipoEnum.Satinata,false));

        // --- INSERT QUADERNO ---
        listModello.Add(new Quaderno(29.7f, 21.0f, 2.50m, TipoEnum.Liscia, "Quadretti 5mm"));

        listModello.Add(new Quaderno(29.7f, 21.0f, 2.80m, TipoEnum.Ruvida, "Righe A"));

        // --- INSERT CALENDARIO ---
        listModello.Add(new Calendario(42.0f, 29.7f, 12.00m, TipoEnum.Vergata, true));

        listModello.Add(new Calendario(10.0f, 10.0f, 5.00m, TipoEnum.Goffrata, false));
    }
}