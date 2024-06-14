using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestorRiego;


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



        public async Task AddTemperatura(Temperatura temperatura)
        {
            await _estadoRiegoRepo.AddTemperatura(temperatura);
        }

        public async Task AddHumedadSuelo(HumedadSuelo humedadSuelo)
        {
            await _estadoRiegoRepo.AddHumedadSuelo(humedadSuelo);
        }

        public async Task AddCultivo(Cultivo cultivo)
        {
            await _estadoRiegoRepo.AddCultivo(cultivo);
        }

        /* public async Task AddEstadoRiego(Cultivo cultivo, HumedadSuelo humedadSuelo, Temperatura temperatura)
         {
             await _estadoRiegoRepo.AddTemperatura(temperatura);
             await _estadoRiegoRepo.AddHumedadSuelo(humedadSuelo);
             await _estadoRiegoRepo.AddCultivo(cultivo);
         }

         */


        /*public async Task AddRiego(Cultivo cultivo, HumedadSuelo humedadSuelo, Temperatura temperatura)
        {
            await _estadoRiegoRepo.AddRiego(temperatura, cultivo, humedadSuelo);
 
        }
        */
    }
}