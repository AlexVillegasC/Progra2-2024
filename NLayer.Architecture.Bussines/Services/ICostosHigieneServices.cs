<<<<<<< HEAD
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
=======
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
=======
﻿using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
<<<<<<< HEAD
=======
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
<<<<<<< HEAD
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> origin/development
=======
﻿using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> b5fa883 (costos higiene)
=======
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
=======
=======
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
﻿using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
>>>>>>> 3fc5f46 (costos higiene)
=======
=======
﻿using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
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
