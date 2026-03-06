class Calendario : Modello
{
    // Calendario segnala le festività
    private bool _segnaFestivita;

    public Calendario(float AltezzaPagina, float LarghezzaPagina, decimal Prezzo, TipoEnum TipoCarta, bool SegnaFestivita) : base(AltezzaPagina, LarghezzaPagina, Prezzo, TipoCarta)
    {
        this.SegnaFestivita = SegnaFestivita;
    }

    // Proprietà pubblica per accedere al campo
    public bool SegnaFestivita
    {
        get { return _segnaFestivita; }
        set { _segnaFestivita = value; }
    }

    public override string ToCsv()
    {
        return $"Altezza Pagina Calendario: {AltezzaPagina};Larghezza Pagine Calendario: {LarghezzaPagina};Prezzo Calendario: {Prezzo};Il Calendario segna le festività: {SegnaFestivita};";
    }
} 