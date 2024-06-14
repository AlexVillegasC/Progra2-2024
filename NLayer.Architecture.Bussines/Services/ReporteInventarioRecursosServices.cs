using NLayer.Architecture.Bussines.ReporteInventarioRecursos;
using DataAccess.Layer.FileRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Services
{
    public class ReporteInventarioRecursosServices : IReporteInventarioRecursosServices
    {
        private readonly IReporteInventarioRecursosRepository _inventarioRecursos;

        public ReporteInventarioRecursosServices(IReporteInventarioRecursosRepository inventarioRecursos)
        {
            _inventarioRecursos = inventarioRecursos;
        }

        public async Task<ReporteInventarioRecursos> GetInventario()
        {
            ReporteInventarioRecursos miInventario = new ReporteInventarioRecursos
            {
                Pesticidas = await _inventarioRecursos.GetPesticidas(),
                Fertilizantes = await _inventarioRecursos.GetFertilizantes()
            };
            return miInventario;
        }

        public async Task AddFertilizantes(Fertilizantes fertilizantes)
        {
            await _inventarioRecursos.AddFertilizantes(fertilizantes);
        }

        public async Task<bool> UpdateFertilizantes(IEnumerable<Fertilizantes> fertilizantes)
        {
            return await _inventarioRecursos.UpdateFertilizantes(fertilizantes);
        }

        public async Task<bool> DeleteFertilizantes()
        {
            return await _inventarioRecursos.DeleteFertilizantes();
        }

        public async Task AddPesticidas(Pesticidas pesticidas)
        {
            await _inventarioRecursos.AddPesticidas(pesticidas);
        }

        public async Task<bool> UpdatePesticidas(IEnumerable<Pesticidas> pesticidas)
        {
            return await _inventarioRecursos.UpdatePesticidas(pesticidas);
        }

        public async Task<bool> DeletePesticidas()
        {
            return await _inventarioRecursos.DeletePesticidas();
        }

        Task<ReporteInventarioRecursos.ReporteInventarioRecursos> IReporteInventarioRecursosServices.GetInventario()
        {
            throw new NotImplementedException();
        }
 

