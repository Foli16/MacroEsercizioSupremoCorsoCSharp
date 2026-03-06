public abstract class Modello
{
    private float _altezzaPagina;
    private float _larghezzaPagina;
    private decimal _prezzo;
    private TipoEnum _tipoCarta;

    public float AltezzaPagina
    {
        get { return _altezzaPagina; }
        set
        {
            if (value < 0)
                throw new ArgumentException("L'altezza della pagina non può essere negativa!");
            
            _altezzaPagina = value;
        }
    }

    public float LarghezzaPagina
    {
        get { return _larghezzaPagina; }
        set
        {
            if (value < 0)
                throw new ArgumentException("La larghezza della pagina non può essere negativa!");
            
            _larghezzaPagina = value;
        }
    }

    public decimal Prezzo
    {
        get { return _prezzo; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Il prezzo non può essere negativa!");
            
            _prezzo = value;
        }
    }

    public TipoEnum TipoCarta
    {
        get { return _tipoCarta; }
        set
        {
            
            
            _tipoCarta = value;
        }
    }

    public Modello(float AltezzaPagina, float LarghezzaPagina, decimal Prezzo, TipoEnum TipoCarta)
    {
        this.AltezzaPagina = AltezzaPagina;
        this.LarghezzaPagina = LarghezzaPagina;
        this.Prezzo = Prezzo;
        this.TipoCarta = TipoCarta;
    }

    public abstract string ToCsv();
} 