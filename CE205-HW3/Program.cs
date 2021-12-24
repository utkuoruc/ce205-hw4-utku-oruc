/**
  * @file Program.cs
  * @author Utku ORUC
  * @date 20 November 2021
  *
  *
  */
namespace CE205_HW3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}