namespace MascotaVirtual;

public class Hambriento : IEstado
{
    public void Comer(Mascota mascota)
    {
        mascota.Estado = new Contento();
    }

    public void Jugar(Mascota mascota)
    {

    }
}
