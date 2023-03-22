namespace MascotaVirtual;

public class Contento : IEstado
{
    public void Comer(Mascota mascota)
    {
        mascota.IncrementarNivel(1);
    }

    public void Jugar(Mascota mascota)
    {
        mascota.IncrementarNivel(2);
    }
}