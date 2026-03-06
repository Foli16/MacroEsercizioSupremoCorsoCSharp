public class Diario : Modello
{
    private bool _haIllustrazioni;


    public bool HaIllustrazioni
    { 
        get {return _haIllustrazioni;} 
        set{ _haIllustrazioni = value;}
    }

    public Diario(float AltezzaPagina, float LarghezzaPagina, decimal Prezzo, TipoEnum TipoCarta, bool HaIllustrazioni) : base(AltezzaPagina, LarghezzaPagina, Prezzo, TipoCarta)
    {
        this.HaIllustrazioni = HaIllustrazioni;
    }
    

    public override string ToCsv()
    {
        return $"Altezza Pagina Diario: {AltezzaPagina};Larghezza Pagine Diario: {LarghezzaPagina};Prezzo Diario: {Prezzo};Il Diario Ha delle illustrazioni: {HaIllustrazioni};";
    }
}