using System.Data.OleDb;
using System.Collections.Generic;

namespace AIS_Kinoteatr
{
    class TableMenager
    {
        private OleDbConnection OleDbConnect { get; set; }

        public TableMenager()
        {
            string strConnection = $@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = CinemaDataBase.mdb;";
            OleDbConnect = new OleDbConnection(strConnection);
        }

        public void ExecuteRequest(string request)
        {
            OleDbCommand cmd = new OleDbCommand(request, OleDbConnect);

            OleDbConnect.Open();
            cmd.ExecuteNonQuery();
            OleDbConnect.Close();
        }

        public string[] SelectInDB(string request)
        {
            OleDbCommand cmd = new OleDbCommand(request, OleDbConnect);
            OleDbDataReader reader = cmd.ExecuteReader();

            string[] getsStrings = new string[reader.FieldCount];
            
            OleDbConnect.Open();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                getsStrings[i] = reader.GetString(i);
            }
            OleDbConnect.Close();

            return getsStrings;
        }
    }
}