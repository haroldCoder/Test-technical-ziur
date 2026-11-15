using System.Text.Json;
using Test_technical_ziur.core.utils;
using Test_technical_ziur.domain.entities;
using Test_technical_ziur.domain.exceptions;
using Test_technical_ziur.domain.respositories;
using Test_technical_ziur.infrastructure.models;

namespace Test_technical_ziur.infrastructure.gateways
{
    public class MovementsImplGateway(HttpRequestApi requestApi) : MovementsRepository
    {
        public override async Task<List<MovementsEntity>> getAllMovements()
        {
            try
            {
                var movements = await requestApi.Get<List<ResponseApiMovements>>("DocumentosFillsCombos"); // usamos el objeto de la clase para hacer peticiones, con el metodo get, pasandole como generico el ResponseApiMovements, que sera lo que nos devuelve la api

                if (movements is null || movements.Count == 0) return []; // si la api no devuelve nada, entonces devolvemos el array vacio

                return movements.Select(m => MovementsEntity.create(m.Codigo, m.Descripcion, m.VActiva)).ToList(); // en caso de que la api devuelva correctamente los datos, lo que haremos sera mapear los datos a como la entidad los necesita.

                // Nota importante: en la entidad, se puso los nombres en ingles, para que quede demostrado que el dia de mañana, si el objeto de la api cambian los nombres, es decir si codigo, se llamara coder o Kodigo, entonces solo cambiaria en el modelo de la infrastructura, sin dañar el dominio como tal
            }
            catch (HttpRequestException ex)
            {
                throw new MovementsException("No se pudo conectar con la API de movimientos.", ex);
            }
            catch (JsonException ex) // Esta excepcion es en caso de que la api no devuelva los datos en formato json
            {
                Console.WriteLine(ex.Message);
                throw new MovementsException("La API devolvió datos con un formato inesperado.", ex);
            }
        }
    }
}
