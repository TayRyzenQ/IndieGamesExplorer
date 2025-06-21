using IndieGames.Pages;

namespace IndieGames
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registro de páginas de detalle
           // Routing.RegisterRoute(nameof(CelesteDetailPage), typeof(CelesteDetailPage));
           // Routing.RegisterRoute(nameof(StardewValleyDetailPage), typeof(StardewValleyDetailPage));
           // Routing.RegisterRoute(nameof(HadesDetailPage), typeof(HadesDetailPage));
           // Routing.RegisterRoute(nameof(UndertaleDetailPage), typeof(UndertaleDetailPage));
            Routing.RegisterRoute(nameof(HollowKnightPage), typeof(HollowKnightPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));


        }
    }
}
