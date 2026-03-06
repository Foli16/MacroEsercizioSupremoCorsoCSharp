
//La classe report accetta come argomento una lista di oggetti
public class Report
{
   public List<Modello> lista;

   // ReportUI UI = new ReportUI();
   //StampaLogoReport
   //StampaLogoListaProdotti
   // StampaProdottoFormattato(Prodotto p)

   //Costruttore
   public Report (List<Modello> lista)
   {
      this.lista = lista;
   }


   //Metodo per la ricerca in base ad una caratteristica singola ||| S T R |||
   public void CercaPerTipo(string stringa)
   {
      // UI.StampaLogoListaProdotti();
      ReportUI.StampaLogoListaProdotti();

      foreach (Modello item in lista)
      {
         if (string.Equals(item.GetType(), stringa))
         {
            //chiamo metodo per la stampa
            ReportUI.StampaProdottoFormattato();
            item.ToCsv();
         }
      }


   }

   public void StampaInfo()
   {
      ReportUI.StampaProdottoFormattato();
      foreach(var item in lista)
      {
         item.ToCsv();
      }
   }

   //Metodo per la ricerca in base ad una caratteristica singola ||| I N T |||
   public void CercaPerTipo (int numero)
   {
      //UI.StampaLogoListaProdotti();
      foreach (Modello item in lista)
      {
         if (item.Prezzo == numero)
         {
            //chiamo metodo per la stampa
            //UI.StampaProdottoFormattato(Prodotto p)
         }
      }
   }


   //Metodo per mandare in stampa tutto
   public void StampaComplessiva ()
   {
      int counterProd = 0;

      //UI.StampaLogoReport();
      foreach (Modello item in lista)
      {
         Console.WriteLine(item.ToCsv());
      }
   }


   //Metodo per avere un conteggio del totale in base ad una caratteristica singola ||| S T R |||
   public void ConteggioPerTipo(string nome)
   {
      //UI.StampaLogo()
      int counter = 0;

      foreach (object item in lista)
      {
         if (item.nome == nome)
         
         {
            counter += 1;
         }
      }

      //UI.StampaConteggio (counter, nome)
   }

   //Metodo per avere un conteggio del totale in base ad una caratteristica singola ||| I N T |||
   public void ConteggioPerTipo(int num)
   {
      //UI.StampaLogo()
      int counter = 0;

      foreach (object item in lista)
      {
         if (item.num == num)
         {
            counter += 1;
         }
      }

      //UI.StampaConteggio (counter, num)
   }

   // Metodo sperimentalo Che itera tra le stringhe di un tipo
   public void ConfrontoConteggio()
   {
      //UI.StampaLogo()
      foreach (object item in lista)
      {
         ConteggioPerTipo(item.nome);
      }
   }

   // Metodo sperimentalo Che itera tra le stringhe di un tipo
   public void ConfrontoConteggio()
   {
      //UI.StampaLogo()

      foreach (object item in lista)
      {
         ConteggioPerTipo(item.num);
      }
   }
   
}
/*


*/