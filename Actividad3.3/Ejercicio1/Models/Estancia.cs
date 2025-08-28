using System.Collections;

namespace Ejercicio1.Models;

public class Estancia
{
    public string Nombre { get; set; }

    public Casco casco { get; set; }

    ArrayList puestos = new ArrayList();

    ArrayList campos = new ArrayList();

    public Estancia(string nombre, string idCampo, double sup)
    {
        this.Nombre = nombre;
        this.casco = new Casco();
        this.casco.Administrador = "Sin asingar";

        Puesto puesto = new Puesto();
        puestos.Add(puesto);
        puesto.Responsable = "Sin asignar";

        Campo campo = new Campo(idCampo, sup);
        puestos.Add(campo);
    }

}
