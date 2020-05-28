using Interfile.FDI.PainelSLA.Data;
using System;

namespace Interfile.FDI.PainelSLA.Business
{
    public class ControlePausaBusiness : ControlePausaData, IDisposable
    {
        private string valor = string.Empty;
        public string GetOnline()
        {
            valor = string.Empty;
            var totPausa = CarregarPausa();
            var totOnline = CarregarOnLine();
            var count = totOnline - totPausa;
            if (totOnline > 0) valor = count.ToString("00");
            else valor = "00";
            return valor;
        }

        //public string GetOffLine()
        //{
        //    valor = string.Empty;
        //    valor = Convert.ToString(CarregarOffline());
        //    return valor;
        //}

        public string GetPausa()
        {
            valor = string.Empty;
            int v = CarregarPausa();
            valor = v.ToString("00");
            return valor;
        }

        public void Dispose()
        {
            valor = null;
        }
    }
}
