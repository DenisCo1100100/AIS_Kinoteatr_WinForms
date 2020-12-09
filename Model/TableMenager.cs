using System.Data.OleDb;

namespace AIS_Kinoteatr
{
    class TableMenager
    {
        private OleDbConnection OleDbConnect { get; set; }

        public void ExecuteRequest(string request)
        {
            string strConnection = $@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = CinemaDataBase.mdb;";
            OleDbConnect = new OleDbConnection(strConnection);

            OleDbCommand cmd = new OleDbCommand(request, OleDbConnect);

            OleDbConnect.Open();
            cmd.ExecuteNonQuery();
            OleDbConnect.Close();
        }
    }
}