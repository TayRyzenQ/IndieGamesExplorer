using IndieGames.Models;

namespace IndieGames.Pages;

[QueryProperty(nameof(Game), "Game")]
public partial class StardewValleyDetailPage : ContentPage
{
    public StardewValleyDetailPage()
    {
        InitializeComponent();
    }

    private Game _game;
    public Game Game
    {
        get => _game;
        set
        {
            _game = value;
            BindingContext = _game;
        }
    }
}
