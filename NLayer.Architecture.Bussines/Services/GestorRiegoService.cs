using DataAccess.Layer.FileRepositories;


namespace NLayer.Architecture.Bussines.Services
{

    public class GestorRiegoService : IGestorRiegoService
    {
        /// </summary>
        private readonly IGestorRiegoRepository _estadoRiegoRepo;

        public GestorRiegoService(IGestorRiegoRepository estadoRiegoRepo)
        {
            _estadoRiegoRepo = estadoRiegoRepo;
        }

        public async Task<GestorRiego.GestorRiego> GetEstadoRiego()
        {
            GestorRiego.GestorRiego miEstadoRiego = new GestorRiego.GestorRiego();
            miEstadoRiego._Temperatura = await _estadoRiegoRepo.GetTemperatures();
            miEstadoRiego._HumedadSuelo = await _estadoRiegoRepo.GetMoisture();
            miEstadoRiego._Cultivo = await _estadoRiegoRepo.GetCultivo();

            return miEstadoRiego;
        }
    }
}