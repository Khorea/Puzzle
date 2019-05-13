using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_Frinco_Horea
{
    class Services
    {
        private static string dbPath = Environment.CurrentDirectory.Replace(@"\bin\Debug", @"\Clasament.mdf");

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPath + ";Integrated Security=True";
    }
}
