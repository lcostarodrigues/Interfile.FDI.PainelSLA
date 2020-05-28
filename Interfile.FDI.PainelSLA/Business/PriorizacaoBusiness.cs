using Interfile.FDI.PainelSLA.Models;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfile.FDI.PainelSLA.Businnes
{
    //public interface IPriorizacaoBusiness
    //{

    //}
    public class PriorizacaoBusiness : PriorizacaoModel, IDisposable
    {
        
        private string valorValidacao = string.Empty;
        private string valorPreValidacao = string.Empty;
        private string valorClassificacao = string.Empty;
        private string valorFormalizacao = string.Empty;
        double classificacao = 0;
        double preValidacao = 0;
        double validacao = 0;
        double forma = 0;
        PriorizacaoModel pModel = new PriorizacaoModel();
        
        public PriorizacaoModel GetContadoresFila()
        {
            Form1 frm = new Form1();
            double contdgv = frm.dgvFilaAtual.RowCount - 1;

            for (int i = 0; i <= contdgv; i++)
            {
                if (frm.dgvFilaAtual.Rows[frm.dgvFilaAtual.Rows[i].Index].Cells["Atividade"].Value.ToString() == "CLASSIFICAÇÃO") classificacao = classificacao + 1;
                if (frm.dgvFilaAtual.Rows[frm.dgvFilaAtual.Rows[i].Index].Cells["Atividade"].Value.ToString() == "PRÉ-VALIDAÇÃO") preValidacao = preValidacao + 1;
                if (frm.dgvFilaAtual.Rows[frm.dgvFilaAtual.Rows[i].Index].Cells["Atividade"].Value.ToString() == "VALIDAÇÃO") validacao = validacao + 1;
                if (frm.dgvFilaAtual.Rows[frm.dgvFilaAtual.Rows[i].Index].Cells["Atividade"].Value.ToString() == "FORMALIZAÇÃO") forma = forma + 1;
            }
            pModel.Classificacao = classificacao.ToString("00");
            pModel.PreValidacao = preValidacao.ToString("00");
            pModel.Validacao = validacao.ToString("00");
            pModel.Forma = forma.ToString("00");
            frm.Dispose();
            return pModel;
        }       

        public void Dispose()
        {
            pModel.Validacao = null;
            pModel.PreValidacao = null;
            pModel.Validacao = null;
            pModel.Forma = null;
            classificacao = 0;
            preValidacao = 0;
            validacao = 0;
            forma = 0;
        }
    }
}
