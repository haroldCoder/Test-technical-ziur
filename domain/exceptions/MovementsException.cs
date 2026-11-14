namespace Test_technical_ziur.domain.exceptions
{
    public class MovementsException(string message, Exception? inner = null) : Exception(message, inner) // Creamos esta excepcion generica en el dominio para hacer referencias a excepciones de los movimientos
    {
    }
}
