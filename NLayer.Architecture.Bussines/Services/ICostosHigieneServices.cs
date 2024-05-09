<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
=======
﻿using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
=======
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
﻿using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
=======
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Services;

public interface ICostosHigieneServices
{
    Task<TheSillies.CostosGenerales> GetCostosGenerales();
}
