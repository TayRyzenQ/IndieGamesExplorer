using IndieGames.Data;
using IndieGames.Models;

namespace IndieGames.Pages;

public partial class StardewValleyPage : ContentPage
{
    public StardewValleyPage()
    {
        InitializeComponent();
        GamesCollection.ItemsSource = StardewValley.Games;
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Game selected)
        {
            await Shell.Current.GoToAsync(nameof(StardewValleyDetailPage),
                new Dictionary<string, object>
                {
                    { "Game", selected }
                });

            GamesCollection.SelectedItem = null;
        }
    }
}
