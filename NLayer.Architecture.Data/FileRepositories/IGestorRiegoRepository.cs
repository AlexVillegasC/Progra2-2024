using NLayer.Architecture.Bussines.GestorRiego;
//using NLayer.Architecture.Bussines.ReporteClima;


namespace DataAccess.Layer.FileRepositories


{
    public interface IGestorRiegoRepository
    {

        Task<Temperatura> GetTemperatures();

        Task<Cultivo> GetCultivo();

        Task<HumedadSuelo> GetMoisture();
    }
}
