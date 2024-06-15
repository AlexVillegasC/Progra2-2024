using NLayer.Architecture.Bussines.GestorRiego;
//using NLayer.Architecture.Bussines.ReporteClima;


namespace DataAccess.Layer.FileRepositories


{
    public interface IGestorRiegoRepository
    {
        //   - GET
        Task <List<Temperatura>> GetTemperatures();

        Task<List<Cultivo>> GetCultivo();

        Task<List<HumedadSuelo>> GetMoisture();


        //POST

        Task AddTemperatura(Temperatura temperatura);

        Task AddCultivo(Cultivo cultivo);

        Task AddHumedadSuelo(HumedadSuelo humedadSuelo);



        //   - PUT

        Task<bool> UpdateTemperatures(int id, Temperatura _temperaturaVirtualPath);

        Task<bool> UpdateMoisture(int id, HumedadSuelo _humedadadSueloVirtualPath);

        Task<bool> UpdateCultivo(int id, Cultivo _cultivo);

        //   - DELETE
        Task<bool> DeleteTemperatures();

        Task<bool> DeleteCultivo();

        Task<bool> DeleteMoisture();

    }
}
