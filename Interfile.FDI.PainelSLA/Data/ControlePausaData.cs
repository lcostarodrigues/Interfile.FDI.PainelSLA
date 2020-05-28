using System;
using System.Data.SqlClient;

namespace Interfile.FDI.PainelSLA.Data
{
    public class ControlePausaData : DataBase
    {
        public int CarregarPausa()
        {
            int retorno = 0;
            try
            {
                //var query = "SELECT * FROM FDI_PAUSAS where Fim is null and inicio >= Convert(char(10),GETDATE(),120) + ' 00:00:00'";
                var query = @"SELECT COUNT (distinct Usuario) as Quantidade FROM FDI_PAUSAS AS P
                              INNER JOIN FDI_Cadastro_e_Permissao as C ON P.Usuario = C.Usuario_Rede
                              WHERE Fim is null and inicio >= Convert(char(10),GETDATE(),120) + ' 00:00:00' and C.Acesso = 'Operacional'";
                OpenConection();
                SqlDataReader dr = DataReader(query);
                dr.Read();
                var qtdPausa = dr["Quantidade"];
                retorno = Convert.ToInt32(qtdPausa);
                CloseConnection();
                return retorno;
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw ex;
            }
        }

        public int CarregarOnLine()
        {
            int retorno = 0;
            try
            {
                var query = @"SELECT Count (distinct Usuario) as Quantidade FROM fdi_jornadas as J
                            INNER JOIN FDI_Cadastro_e_Permissao as P ON J.Usuario = P.Usuario_Rede
                            WHERE Fim is null and inicio >= Convert(char(10), GETDATE(), 120) + ' 00:00:00' and P.Acesso = 'Operacional'";
                OpenConection();
                var dr = DataReader(query);
                dr.Read();
                var qtdPausa = dr["Quantidade"];
                retorno = Convert.ToInt32(qtdPausa);
                CloseConnection();
                return retorno;
            }

            catch (SqlException ex)
            {
                CloseConnection();
                throw ex;
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw ex;
            }
        }

        //public int CarregarOffline()
        //{
        //    int retorno = 0;
        //    try
        //    {
        //        var query = $@"select Count(1) from FDI_Cadastro_e_Permissao where Usuario_Rede not in (
        //                       SELECT distinct jo.usuario
        //                       FROM fdi_pausas as ps ,fdi_jornadas as jo
        //                       where ps.usuario = jo.usuario
        //                       and ps.Fim is null or jo.Fim is null)
    			 //  AND Celula != 'INATIVO'";
        //        OpenConection();
        //        SqlDataReader dr = DataReader(query);
        //        var qtdPausa = dr.GetValue(0);
        //        retorno = Convert.ToInt32(qtdPausa);
        //        CloseConnection();
        //        return retorno;
        //    }
        //    catch (Exception)
        //    {
        //        CloseConnection();
        //        throw;
        //    }
        //}
    }
}
