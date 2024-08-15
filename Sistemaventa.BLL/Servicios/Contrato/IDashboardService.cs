using Sistemaventa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistemaventa.DTO;

namespace Sistemaventa.BLL.Servicios.Contrato
{
    public interface IDashboardService
    {
        Task<DashboardDTO> Resumen();
    }
}
