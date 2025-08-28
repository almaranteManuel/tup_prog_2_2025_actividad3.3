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

    public Campo AgregarCampos(string identificador, double superficie)
    {
        Campo campo = new Campo(identificador, superficie);
        campos.Add(campo);
        return campo;
    }

    public Campo VerCampo(int idx)
    {
        if (idx >= 0 && idx < campos.Count && campos!=null)
        {
            return campos[idx] as Campo;
        }
        return null;
    }

    public int VerCantidadCampos()
    {
        if( campos !=null )
        {
            return campos.Count;
        }
        return 0;
    }
}
