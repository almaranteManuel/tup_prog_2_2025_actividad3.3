namespace Ejercicio1.Models;

internal class Campo
{
    public string Identificador { get; set; }
    public double Superficie { get; set; }

    public Campo(string id, double superficie)
    {
        this.Identificador = id;
        this.Superficie = superficie;
    }
}
