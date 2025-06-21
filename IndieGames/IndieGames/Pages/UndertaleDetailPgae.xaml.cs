using IndieGames.Models;

namespace IndieGames.Pages;

[QueryProperty(nameof(Game), "Game")]
public partial class UndertaleDetailPage : ContentPage
{
    public UndertaleDetailPage()
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
