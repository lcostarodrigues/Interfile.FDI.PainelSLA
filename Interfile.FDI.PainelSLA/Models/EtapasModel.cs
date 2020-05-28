using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfile.FDI.PainelSLA.Models
{
    public class EtapasModel
    {
        public int Classificacao { get; set; }
        public int PreValidacao { get; set; }
        public int Validacao { get; set; }
        public int Formalizacao { get; set; }
        public int CargaPj { get; set; }
        public int FinalizacaoFDI { get; set; }
    }
}
