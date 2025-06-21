using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IndieGames.Models;

namespace IndieGames.ViewModels;

public class GameDetailViewModel : IQueryAttributable, INotifyPropertyChanged
{
	public Game Game { set; private get;  }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Game = query["Game"] as Game;
        OnPropertyChanged(nameof(Game));
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        var handler = PropertyChanged;
        if (handler != null)
            handler(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

}