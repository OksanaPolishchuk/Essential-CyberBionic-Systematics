namespace SalonApp
{
    interface ISalon
    {
        void RegisterObserver(IСlient сlient);
        void RemoveObserver(IСlient сlient);
        void NotifyObservers();
    }
}