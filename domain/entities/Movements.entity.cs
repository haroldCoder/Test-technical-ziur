namespace Test_technical_ziur.domain.entities
{
    public class MovementsEntity
    {
        public int Code { get; private set; } // aqui tambien lo corrijo ya que es parte de la equivocacion, claro que nos podria servir mas si se queda como un string, ya que como necesitamos hacer busqueda por este necesitamos el contains; Pero para no hacerlo dificil dejemoslo tambien en number
        public string Description { get; private set; }
        public bool Active { get; private set; }

        private MovementsEntity(int code, string description, bool active = false)
        {
            Code = code;
            Description = description;
            Active = active;
        }

        public static MovementsEntity create(int code, string description, bool active)
        {
            if (code <= 0)
            {
                throw new Exception("El código es requerido y debe ser mayor a cero.");
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new Exception("La descripcion es requerida!");
            }

            return new MovementsEntity(code, description, active);
        }
    }
}
