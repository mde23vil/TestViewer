using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestViewer
{
  class Program
  {
    static void Main(string[] args)
    {
      if (!File.Exists("database.db"))
      {
        SQLiteConnection.CreateFile("database.db");
      }
      var repository = new TestInfoRepository();
      var test = new TestInfo();
      test.Name = "ReportingIncoming";
      test.Author = "Lena";
      test.Division = "Reporter";
      test.Created = DateTime.Now;
      test.Updated = DateTime.Now.AddSeconds(1);
      repository.Add(test);
    }
  }
}
