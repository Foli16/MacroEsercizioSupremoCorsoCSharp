
//La classe report accetta come argomento una lista di oggetti
public class Report
{
   public List<object> lista;

   //ReportUI UI = new ReportUI();
   //StampaLogoReport
   //StampaLogoListaProdotti
   //StampaProdottoFormattato(Prodotto p)

   //Costruttore
   public Report (List<object> lista)
   {
      this.lista = lista;
   }


   //Metodo per la ricerca in base ad una caratteristica singola ||| S T R |||
   public void CercaPerTipo(string stringa)
   {
      //UI.StampaLogoListaProdotti();
      //ReportUI.StampaLogoListaProdotti();

      foreach (object item in lista)
      {
         if (item.tipo == stringa)
         {
            //chiamo metodo per la stampa
            //ReportUI.StampaProdottoFormattato(Prodotto p)
         }
      }


   }

   public void StampaInfo()
   {
   foreach(var item in lista)
   {
      StampaProdottoFormattato(item.ToCSV());
   }
   }

   //Metodo per la ricerca in base ad una caratteristica singola ||| I N T |||
   public void CercaPerTipo (int numero)
   {
      //UI.StampaLogoListaProdotti();
      foreach (object item in lista)
      {
         if (item.numero == numero)
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
      foreach (object item in lista)
      {
         //
         //Logica di stampa
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