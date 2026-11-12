using Test_technical_ziur.domain.entities;

namespace Test_technical_ziur.domain.respositories
{
    public abstract class Movements
    {
        // aqui podemos poner todas las operaciones que se realizaran con los movimientos, como por ejemplo crearlos o eliminarlos
        public abstract List<MovementsEntity> getAllMovements();
    }
}
