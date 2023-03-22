namespace MascotaVirtual;

public class Mascota
{
    public int Nivel { get; private set; }
    public IEstado Estado { get; internal set; }

    public Mascota(int nivel, IEstado estado)
    {
        Nivel = nivel;
        Estado = estado;
    }
    public void Jugar()
    {

    }
    public void Comer()
    {
        
    }

    public void IncrementarNivel(int unidades) => this.Nivel = this.Nivel + unidades;
}
