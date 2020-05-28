using Interfile.FDI.PainelSLA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfile.FDI.PainelSLA.Business
{
    public class FilaBusiness : FilaData, IDisposable
    {
        object dados = null;
        public void CarregarFilaAtual()
        {
            dados = GetFilaAtual();
        }

        public void Dispose()
        {
            dados = null;
        }
    }
}
