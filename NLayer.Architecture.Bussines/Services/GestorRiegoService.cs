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

        //   - GET
       public async Task <List<Temperatura>> GetTemperatures()
        {
            return await _estadoRiegoRepo.GetTemperatures();
        }

        public async Task<List<Cultivo>> GetCultivos()
        {
            return await _estadoRiegoRepo.GetCultivo();
        }

        public async Task<List<HumedadSuelo>> GetMoistures()
        {
            return await _estadoRiegoRepo.GetMoisture();
        }

        //POST

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



        //   - PUT
        public async Task<bool> UpdateTemperatures(int id, Temperatura _tempetaruraVirtualPath)
        {
            return await _estadoRiegoRepo.UpdateTemperatures(id, _tempetaruraVirtualPath);
        }


        public async Task<bool> UpdateMoisture(int id, HumedadSuelo _humedadadSueloVirtualPath)
        {
            return await _estadoRiegoRepo.UpdateMoisture(id, _humedadadSueloVirtualPath);
        }

        public async Task<bool> UpdateCultivo(int id, Cultivo _cultivo)
        {
            return await _estadoRiegoRepo.UpdateCultivo(id, _cultivo);
        }



        //   - DELETE
        public async Task<bool> DeleteTemperatura()
        {
            return await _estadoRiegoRepo.DeleteTemperatures();
        }

        public async Task<bool> DeleteMoisture()
        {
            return await _estadoRiegoRepo.DeleteMoisture();

        }

        public async Task<bool> DeleteCultivo()
        {
            return await _estadoRiegoRepo.DeleteCultivo();
        }


    }
}