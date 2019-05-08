using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bukmacher
{
    public class Matches
    {

    }
    static class Program
    {
        public static object RESEED { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //LinqToSql_DB_BukmacherDataContext database = new LinqToSql_DB_BukmacherDataContext();
            // database.Matches.DeleteAllOnSubmit(database.Matches);
            //database.SubmitChanges();
           // DBCC CHECKIDENT ("Matches", RESEED, 0);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BukmacherMainMenu());
        }
    }
}
