namespace Test_technical_ziur.domain.entities
{
    public class MovementsEntity
    {
        public string Code { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }

        private MovementsEntity(string code, string description, bool active = false)
        {
            Code = code;
            Description = description;
            Active = active;
        }

        public static MovementsEntity create(string code, string description, bool active)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new Exception("El codigo es requerido!");
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new Exception("La descripcion es requerida!");
            }

            return new MovementsEntity(code, description, active);
        }
    }
}
