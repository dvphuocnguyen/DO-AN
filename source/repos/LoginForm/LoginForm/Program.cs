using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            /*Application.Run(new KhoaHoc());*/
            Application.Run(new mediaplayer("6/20/2022 9:34:43 AM"));
=======
            /*Application.Run(new Form2());*/
            Application.Run(new mediaplayer("6/19/2022 9:58:49 AM"));
>>>>>>> 7e99832b6f0c836392f06dd0e919c71330aa377b
            /* Application.Run(new Form5());*/
        }
    }
}
