using System;
using System.Collections.Generic;

namespace SalonApp
{
    class Administrator : ISalon
    {
        Notification _notification; 

        List<IСlient> _сlients;

        public Administrator()
        {
            _сlients = new List<IСlient>();
            _notification = new Notification();
        }

        public void RegisterObserver(IСlient сlient)
        {
            _сlients.Add(сlient);
        }

        public void RemoveObserver(IСlient сlient)
        {
            _сlients.Remove(сlient);
        }

        public void NotifyObservers()
        {
            foreach (IСlient сlient in _сlients)
            {
                сlient.Update(_notification);
            }
        }

        public void Services()
        {
            Random rnd = new Random();
            _notification.Manicure = rnd.Next(9, 20);
            _notification.Haircut = rnd.Next(9, 20);
            NotifyObservers();
        }
    }
}
