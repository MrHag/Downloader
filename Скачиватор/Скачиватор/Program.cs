using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Скачиватор
{

    

    class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();

            

            //watcher.Changed += (s, em) => MessageBox.Show("Changed: " + em.FullPath);


            
            Application.Run(mainForm);
            


        }




        

        


    }
}
