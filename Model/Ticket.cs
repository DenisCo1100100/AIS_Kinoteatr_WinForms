using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    class Ticket
    {
        public string ClientFIO { get; private set; }
        public int Discount { get; private set; }
        public string FilmName { get; private set; }
        public int Price { get; private set; }
        public string Director { get; private set; }
        public string Country { get; private set; }
        public int NumberTicket { get; private set; }
        public bool IsVIP { get; private set; }
        public bool IsStudy { get; private set; }
        public string Notes { get; private set; }

        public Ticket(string clientFIO, int discount, string filmName, int price, string director, string country, 
                      int numberTicket, bool isVIP, bool isStudy, string notes)
        {
            ClientFIO = clientFIO;
            Discount = discount;
            FilmName = filmName;
            Price = price;
            Director = director;
            Country = country;
            NumberTicket = numberTicket;
            IsVIP = isVIP;
            IsStudy = isStudy;
            Notes = notes;
        }

        public void Print()
        {
            Workbook xlWB = CreateAndGetWorkSheet(out Microsoft.Office.Interop.Excel.Application xlApp);
            Worksheet xlSht = xlWB.ActiveSheet;

            if (IsStudy)
            {
                Price -= 1;
            }
            if (IsVIP)
            {
                xlSht.Cells[2, "H"] = "VIP";
                Price += 10;
            }

            xlSht.Cells[2, "F"] = NumberTicket.ToString();
            xlSht.Cells[3, "D"] = FilmName.ToString();
            xlSht.Cells[6, "H"] = Price.ToString();
            xlSht.Cells[7, "H"] = Discount.ToString();
            xlSht.Cells[7, "C"] = Notes; 
            xlSht.Cells[6, "C"] = ClientFIO;
            xlSht.Cells[4, "C"] = Director;
            xlSht.Cells[5, "C"] = Country;

            xlWB.Close(true);
            xlApp.Quit();
        }

        private Workbook CreateAndGetWorkSheet(out Microsoft.Office.Interop.Excel.Application xlApp)
        {
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWB;
            Workbook xlWB2;
            Worksheet xlSht;

            xlWB = xlApp.Workbooks.Open($@"{System.Windows.Forms.Application.StartupPath}/шаблон.xlsx");
            xlWB2 = xlApp.Workbooks.Add(System.Reflection.Missing.Value);

            xlSht = xlWB.Worksheets["Лист1"];

            xlSht.Copy(After: xlWB2.Worksheets[xlWB2.Worksheets.Count]);          

            MessageBox.Show("Успех!!!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);


            FileInfo nakl = new FileInfo(@"Билет.xlsx");
            int i = 1;
            while (nakl.Exists)
            {
                nakl = new FileInfo($"Билет{i++}.xlsx");
            }
            xlWB2.SaveAs($"{Environment.CurrentDirectory}/{nakl.Name}");
            xlWB.Close();

            return xlWB2;
        }
    }
}
