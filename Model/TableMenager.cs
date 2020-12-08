using System.Data.OleDb;

namespace AIS_Kinoteatr
{
    class TableMenager
    {
        private OleDbConnection OleDbConnect { get; set; }

        public void Add(string cmdText)
        {
            string strConnection = $@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = CinemaDataBase.mdb;";
            OleDbConnect = new OleDbConnection(strConnection);

            OleDbCommand cmd = new OleDbCommand(cmdText, OleDbConnect);

            OleDbConnect.Open();
            cmd.ExecuteNonQuery();
            OleDbConnect.Close();
        }
    }
}