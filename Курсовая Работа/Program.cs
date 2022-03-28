using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_Работа
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegForm());
        }

    }
    static class RegUser
    {
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string IdUser { get; set; }
        public static bool Find { get; set; }
        public static string FindStr { get; set; }
        public static bool RegFormClose { get; set; }
    }
}
