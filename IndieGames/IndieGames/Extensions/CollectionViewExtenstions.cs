namespace IndieGames.Extensions;

public static class CollectionViewExtensions
{
    public static bool ClearSelection(this CollectionView cv)
    {
        if (cv.SelectedItem == null)
            return true;

        cv.SelectedItem = null;
        return false;
    }
}