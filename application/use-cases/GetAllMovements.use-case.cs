using Test_technical_ziur.domain.entities;
using Test_technical_ziur.domain.respositories;

namespace Test_technical_ziur.application.use_cases
{
    public class GetAllMovementsUseCase(MovementsRepository movementsRepository)
    {
        // Este archivo es para crear un caso de uso el cual nos ayude a retornar todos los movimientos de inversion, usando el repositorio, para poder inyectarlo y poder traer la data que necesitamos
        public Task<List<MovementsEntity>> executeAsync()
        {
            // Aca dentro podemos hacer orquestacion y pasar filtros de politicas del negocio que imp
            return movementsRepository.getAllMovements();
        }
    }
}
