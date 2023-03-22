namespace MascotaVirtual;

public class Aburrido : IEstado
{
    public void Comer(Mascota mascota)
    {
        throw new NotImplementedException();
    }

    public void Jugar(Mascota mascota)
    {
        mascota.Estado = new Contento();
    }
}