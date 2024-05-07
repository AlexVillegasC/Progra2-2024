using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
public class HigieneServices : ICostosHigieneServices
=======
public class HigieneServices
>>>>>>> 1672b8f (costos higiene)
=======
public class HigieneServices : ICostosHigieneServices
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
public class HigieneServices
>>>>>>> 1672b8f (costos higiene)
{
    private readonly ICostosHigieneRepository _costosHigieneRepository;

    public HigieneServices(ICostosHigieneRepository costosHigieneRepository)
    {
        _costosHigieneRepository = costosHigieneRepository;
    }

    public async Task<TheSillies.CostosGenerales> GetCostosGenerales()
    {
        TheSillies.CostosGenerales reporteHigiene = new TheSillies.CostosGenerales();
        reporteHigiene.CostosHigiene = await _costosHigieneRepository.GetCostosHigiene();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        reporteHigiene.CostosAlimenticios = await _costosHigieneRepository.GetCostosAlimenticios();
=======
>>>>>>> 1672b8f (costos higiene)
=======
        reporteHigiene.CostosAlimenticios = await _costosHigieneRepository.GetCostosAlimenticios();
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
>>>>>>> 1672b8f (costos higiene)

        return reporteHigiene;
    }
}