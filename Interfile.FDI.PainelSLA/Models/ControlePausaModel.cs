using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfile.FDI.PainelSLA.Models
{
    public class ControlePausaModel
    {
        public int Online { get; set; }
        public int Offline { get; set; }
        public int Pausa { get; set; }
    }
}
