using Test_technical_ziur.domain.entities;

namespace Test_technical_ziur.domain.respositories
{
    public abstract class MovementsRepository // aqui en este commit, decidi cambiar el nombre, para que la clase quede mas representativa a lo que hace, el cual es un contrato
    {
        // aqui podemos poner todas las operaciones que se realizaran con los movimientos, como por ejemplo crearlos o eliminarlos
        public abstract Task<List<MovementsEntity>> getAllMovements();
    }
}
