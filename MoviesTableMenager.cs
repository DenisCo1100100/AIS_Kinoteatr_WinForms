using System.Data.OleDb;

namespace AIS_Kinoteatr
{
    class MoviesTableMenager
    {
        private string ImageIndex { get; set; }
        private string Name { get; set; }
        private string Director { get; set; }
        private string Country { get; set; }
        private int Price { get; set; }
        private string Description { get; set; }
        private OleDbConnection OleDbConnect { get; set; }

        public MoviesTableMenager(string name, string director, string country, int price, string description, string imageIndex)
        {
            Name = name;
            Director = director;
            Country = country;
            Price = price;
            Description = description;
            ImageIndex = imageIndex;
        }

        public void Add()
        {
            string StrConnection = $@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\Serious Projects\AIS_Kinoteatr\CinemaDataBase.mdb;";
            OleDbConnect = new OleDbConnection(StrConnection);
            string cmdText = $"INSERT INTO Films ([ImageIndex], [Name], [Description], [Price], [Director], [Country]) VALUES ('"+ ImageIndex +"', '"+ Name +"', '"+ Description +"', '"+ Price +"', '"+ Director +"', '"+ Country +"')";

            OleDbCommand cmd = new OleDbCommand(cmdText, OleDbConnect);

            OleDbConnect.Open();
            cmd.ExecuteNonQuery();
            OleDbConnect.Close();
        }
    }
}