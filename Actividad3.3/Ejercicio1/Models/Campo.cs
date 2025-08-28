namespace Ejercicio1.Models;

internal class Campo : IComparable
{
    public string Identificador { get; set; }
    public double Superficie { get; set; }

    public Campo(string id, double superficie)
    {
        this.Identificador = id;
        this.Superficie = superficie;
    }

    public int CompareTo(object? otro)
    {
        Campo otroCampo = otro as Campo;
        if (otroCampo != null)
        {
            return Identificador.CompareTo(otroCampo.Identificador);
        }
        return 1;
    }
}
