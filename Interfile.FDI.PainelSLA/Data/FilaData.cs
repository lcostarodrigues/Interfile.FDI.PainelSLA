namespace Interfile.FDI.PainelSLA.Data
{
    public class FilaData : DataBase
    {
        public object GetFilaAtual()
        {
            OpenConection();
            //var dt = new System.Data.DataTable();
            var dados = ShowDataInGridView("EXEC spu_FDI_GERENCIADOR_FilaAtual");
            CloseConnection();
            return dados;
        }
    }
}
