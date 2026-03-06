using System.Runtime.CompilerServices;

class ReportUI
{
    private ReportUI(){}

    public static void StampaLogoListaProdotti()
    {
        
        Console.WriteLine("********************************************************");
        Console.WriteLine("                    ELENCO PRODOTTI                     ");
        Console.WriteLine("********************************************************");
    }

    private static void StampaLogoReport()
    {   
        Console.WriteLine("********************************************************");
        Console.WriteLine("               REPORT GENERALE FABBRICA                 ");
        Console.WriteLine("********************************************************");
    }

    public static void StampaProdottoFormattato() //Modello m
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("m.toCsv.Trim(';')                                       ");    //metodo di Prodotto p, da capire se il toString() o il MostraInfo() è su una linea
        Console.WriteLine("--------------------------------------------------------");    //
    }

    public static void StampaReportFormattato(int n_prodotti, int n_carta,string tipo_piu_usato) //Prodotto p
    {
        StampaLogoReport();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Numero totale prodotti:   {n_prodotti}                  ");    
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Tipo carta più usato:   {tipo_piu_usato}                ");    
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Prodotto piu' presente: {p.Nome}                        ");    
        Console.WriteLine("--------------------------------------------------------");

    }





}