using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    static class Init
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            StudentController studentController = new StudentController();
            studentController.CreateStudent(1, ”Markus”, ”Örebro);
            foreach (var item in studentController.GetAllStudents())
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadKey();
        }
    }
}
