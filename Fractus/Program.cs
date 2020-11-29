using System;

using System.Windows.Forms;



namespace Fractus
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
                try
                {

                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Form1 fr = new Form1();
                    Application.Run(fr);
                    

                }
                catch
                {
                    Application.Run(new Form2());
                

                    
                    
                    


                }
            Application.Exit();



        }

    }
}
