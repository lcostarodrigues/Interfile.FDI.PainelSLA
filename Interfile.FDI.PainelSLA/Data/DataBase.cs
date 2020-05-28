using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Interfile.FDI.PainelSLA.Data
{
    public class DataBase
    {
        string ConnectionString = "Server=FDISQL11V.interfile.com.br;Database=FDI_AUTOMACAO;User Id=USER_FDI_AUTOMACAO;Password=7RMNSpJx";
        SqlConnection con;
        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }

        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
