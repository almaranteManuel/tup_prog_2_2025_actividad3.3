namespace Ejercicio1.Models;

public abstract class Actividad
{
    public int Periodo {  get; set; }

    public stiring Descripcion {  get; set; }

    public List<Parcela> lotesAsignados = new List<Parcela>();
    public Actividad(int periodo , string descripcion, Parcela p1)
    {
        this.Periodo = periodo ;
        this.Descripcion = descripcion ;
    }
    abstract public double CalcularProduccion();
    abstract public double CalcularRendimiento();

   
}
