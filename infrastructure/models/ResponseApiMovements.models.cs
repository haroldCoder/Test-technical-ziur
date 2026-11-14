namespace Test_technical_ziur.infrastructure.models
{
    public class ResponseApiMovements : IResponseApiMovements // Con esta clase se busca modelar los datos que vienen desde la api, por eso se pone en la infrastructura, que seria todo lo relacionado a lo que esta fuera del negocio
    {
        public string Codigo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool VActiva { get; set; }
    }
}
