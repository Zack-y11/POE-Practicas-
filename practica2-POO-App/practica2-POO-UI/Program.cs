using practica2_POO_UI.Encapsulamiento.Modelo;
using practica2_POO_UI.Polimorfism.Modelo;

namespace practica2_POO_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new EncapsulamientoForm());
        }
    }
}