using OvningGarage.Initiate;
using OvningGarage.Interfaces;

namespace OvningGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            IUI ui = new ConsoleUI();
            var startup = new Startup(ui);
            startup.Run();

        }
    }
}
