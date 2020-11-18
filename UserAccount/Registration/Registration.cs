using System.Data.OleDb;

namespace AIS_Kinoteatr
{
    class Registration : BaseConection
    {
        public Registration(string login, string password, string fullName, string position)
            : base(login, password, fullName, position) {}

        public override void Execute()
        {
            string cmdText = $"INSERT INTO Users ([Login], [Password], [Function], [FullName]) VALUES ('" + Login + "', '" + Password + "', '"+ Position +"' , '"+ FullName +"')";
            OleDbCommand cmd = new OleDbCommand(cmdText, OleDbConnect);

            OleDbConnect.Open();
            cmd.ExecuteNonQuery();
            OleDbConnect.Close();
        }
    }
}
