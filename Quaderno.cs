class Quaderno : Modello
{
    // Memorizza il tipo di rigatura
    private string _tipoRighe;

    public Quaderno(float AltezzaPagina, float LarghezzaPagina, decimal Prezzo, TipoEnum TipoCarta, string TipoRighe) : base(AltezzaPagina, LarghezzaPagina, Prezzo, TipoCarta)
    {
        this.TipoRighe = TipoRighe;
    }

    public string TipoRighe
    {
        get { return _tipoRighe; }
        set { _tipoRighe = value; }
    }

    public override string ToCsv()
    {
        return $"Altezza Pagina Quaderno: {AltezzaPagina};Larghezza Pagine Quaderno: {LarghezzaPagina};Prezzo Quaderno: {Prezzo};Tipo righe quaderno: {TipoRighe};";
    }
}

