namespace Test_technical_ziur.infrastructure.models
{
    public interface IResponseApiMovements
    {
         string Codigo { get; set; }
         string Descripcion { get; set; }
         bool VActiva { get; set; }
    }
}
