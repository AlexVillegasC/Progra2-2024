using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 011c04a (costos higiene)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
>>>>>>> 3fc5f46 (costos higiene)
public class HigieneServices : ICostosHigieneServices
=======
public class HigieneServices
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
<<<<<<< HEAD
=======
public class HigieneServices : ICostosHigieneServices
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
<<<<<<< HEAD
public class HigieneServices : ICostosHigieneServices
>>>>>>> origin/development
=======
public class HigieneServices
>>>>>>> b5fa883 (costos higiene)
=======
public class HigieneServices : ICostosHigieneServices
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
=======
=======
public class HigieneServices : ICostosHigieneServices
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
public class HigieneServices
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 3fc5f46 (costos higiene)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
>>>>>>> 3fc5f46 (costos higiene)
        reporteHigiene.CostosAlimenticios = await _costosHigieneRepository.GetCostosAlimenticios();
=======
>>>>>>> 1672b8f (costos higiene)
=======
        reporteHigiene.CostosAlimenticios = await _costosHigieneRepository.GetCostosAlimenticios();
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
<<<<<<< HEAD
=======
        reporteHigiene.CostosAlimenticios = await _costosHigieneRepository.GetCostosAlimenticios();
>>>>>>> origin/development
=======
>>>>>>> b5fa883 (costos higiene)
=======
        reporteHigiene.CostosAlimenticios = await _costosHigieneRepository.GetCostosAlimenticios();
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
        reporteHigiene.CostosAlimenticios = await _costosHigieneRepository.GetCostosAlimenticios();
=======
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 011c04a (costos higiene)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
=======
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 3fc5f46 (costos higiene)

        return reporteHigiene;
    }
}