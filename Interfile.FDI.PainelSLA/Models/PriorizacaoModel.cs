using System;

namespace Interfile.FDI.PainelSLA.Models
{
    public interface IPriorizacaoModel
    {

    }
    public class PriorizacaoModel: IPriorizacaoModel, IDisposable
    {
        public string Classificacao { get; set; }
        public string Validacao { get; set; }
        public string Forma { get; set; }
        public string PreValidacao { get; set; }

        public void Dispose()
        {
            Classificacao = null;
            Validacao = null;
            Forma = null;
            PreValidacao = null;
        }
    }
}
