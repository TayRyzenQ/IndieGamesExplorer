using IndieGames.Data;
using IndieGames.Models;
using IndieGames.Pages;

namespace IndieGames.Pages;

public partial class UndertalePage : ContentPage
{
    public UndertalePage()
    {
        InitializeComponent();
        GamesCollection.ItemsSource = UndertaleData.Games;
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Game selected)
        {
            await Shell.Current.GoToAsync(nameof(UndertaleDetailPage),
                new Dictionary<string, object>
                {
                    { "Game", selected }
                });

            GamesCollection.SelectedItem = null;
        }
    }
}
