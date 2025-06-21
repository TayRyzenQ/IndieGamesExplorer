using IndieGames.Data;
using IndieGames.Models;
using IndieGames.Pages;

namespace IndieGames.Pages;

public partial class CelestePage : ContentPage
{
    public CelestePage()
    {
        InitializeComponent();
        GamesCollection.ItemsSource = CelesteData.Games;
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Game selected)
        {
            await Shell.Current.GoToAsync(nameof(CelesteDetailPage),
                new Dictionary<string, object>
                {
                    { "Game", selected }
                });

            GamesCollection.SelectedItem = null;
        }
    }
}
