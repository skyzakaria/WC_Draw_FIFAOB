using System.Configuration;
using System.Data;
using System.Windows;
using WC_Draw_FIFAOB.Data;

namespace WC_Draw_FIFAOB
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Intialize Trigger on startup
            using var context = new WorldCupDbContext();
            DbInitializer.Initialize(context);
        }
    }

}
