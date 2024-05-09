<<<<<<< HEAD
<<<<<<< HEAD
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
=======
﻿using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
=======
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)

namespace DataAccess.Layer.FileRepositories;

public interface ICostosHigieneRepository
{
    Task<CostosHigiene> GetCostosHigiene();
<<<<<<< HEAD
<<<<<<< HEAD
    Task<CostosAlimenticios> GetCostosAlimenticios();
=======
>>>>>>> 1672b8f (costos higiene)
=======
    Task<CostosAlimenticios> GetCostosAlimenticios();
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
}