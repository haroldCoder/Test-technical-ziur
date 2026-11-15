namespace Test_technical_ziur.infrastructure.models
{
    public class ResponseApiMovements : IResponseApiMovements // Con esta clase se busca modelar los datos que vienen desde la api, por eso se pone en la infrastructura, que seria todo lo relacionado a lo que esta fuera del negocio
    {
        public int Codigo { get; set; } // aqui me equivoque en el anterior commit, pense que me traia este dato con formato cadena
        public string Descripcion { get; set; } = string.Empty;
        public bool VActiva { get; set; }
    }
}
